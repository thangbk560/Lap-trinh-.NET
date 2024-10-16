using System.Data;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string input = ""; // Lưu chuỗi nhập vào
        public Form1()
        {
            InitializeComponent();
        }

        // Sự kiện khi nhấn các nút số
        private void btnSo_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text; // Thêm số vào chuỗi input
            textBox1.Text = input; // Hiển thị chuỗi input lên textBox
        }


       // Sự kiện khi nhấn các nút phép toán (+, -, *, /)
        private void btnCong_Click(object sender, EventArgs e)
        {
            input += "+"; // Thêm phép cộng vào chuỗi input
            textBox1.Text = input; // Hiển thị chuỗi input lên textBox
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            input += "-";
            textBox1.Text = input;
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            input += "*";
            textBox1.Text = input;
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            input += "/";
            textBox1.Text = input;
        }

        // Sự kiện khi nhấn nút bằng (=)
        private void btnBang_Click(object sender, EventArgs e)
        {
            try
            {
                // Sử dụng DataTable để tính toán chuỗi
                var result = new DataTable().Compute(input, null);
                textBox1.Text = result.ToString(); // Hiển thị kết quả
                input = result.ToString(); // Lưu kết quả cho các phép toán tiếp theo
            }
            catch (Exception ex)
            {
                // Nếu có lỗi (ví dụ như chia cho 0)
                textBox1.Text = "Error";
                input = "";
            }
        }

        // Sự kiện nút hủy (C)
        private void btnCancel_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); // Xóa textBox
            input = ""; // Xóa chuỗi input
        }
    }
}
