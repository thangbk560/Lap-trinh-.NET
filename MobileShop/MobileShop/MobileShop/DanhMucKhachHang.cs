using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShop
{
    public partial class DanhMucKhachHang : UserControl
    {

        private SqlConnection conn = new SqlConnection("Data Source=localhost,1433;Initial Catalog=MobileShop;Integrated Security=True");
        public DanhMucKhachHang()
        {
            InitializeComponent();
            LoadKhachHang();
        }

        // Hàm để tải dữ liệu từ bảng KhachHang lên DataGridView
        private void LoadKhachHang()
        {
            try
            {
                conn.Open(); // Mở kết nối
                string query = @"
                    SELECT 
                        ID_KhachHang AS [Mã Khách Hàng],
                        TenKhachHang AS [Tên Khách Hàng],
                        DiaChi AS [Địa Chỉ],
                        SoDienThoai AS [Số Điện Thoại]
                    FROM KhachHang
                    INNER JOIN NguoiDung ON KhachHang.ID_NguoiDung = NguoiDung.ID_NguoiDung";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt); // Lấy dữ liệu từ CSDL và đổ vào DataTable

                dGV_DanhMucKhachHang.DataSource = dt; // Hiển thị DataTable lên DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close(); // Đóng kết nối
            }
        }
    }
}
