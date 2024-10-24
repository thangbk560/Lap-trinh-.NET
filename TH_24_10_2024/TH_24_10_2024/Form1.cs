namespace TH_24_10_2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();
            tk.TenDangNhap = "admin";
            tk.MatKhau = "1234";
            if(txtDangNhap.Text == tk.TenDangNhap && txtMatKhau.Text == tk.MatKhau)
            {
                MessageBox.Show("Đăng nhập thành công!");
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
