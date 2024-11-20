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
    public partial class DanhMucSanPham : UserControl
    {

        private SqlConnection conn = new SqlConnection("Data Source=localhost,1433;Initial Catalog=MobileShop;Integrated Security=True");
        public DanhMucSanPham()
        {
            InitializeComponent();
            LoadSanPham();
        }

        // Hàm để tải dữ liệu từ bảng SanPham lên DataGridView
        private void LoadSanPham()
        {
            try
            {
                conn.Open(); // Mở kết nối
                string query = "SELECT ID_SanPham AS [Mã Sản Phẩm], TenSanPham AS [Tên Sản Phẩm], Gia AS [Giá], HangSX AS [Hãng Sản Xuất] " +
                               "FROM SanPham, NguoiDung " +
                               "WHERE SanPham.ID_NguoiDung = NguoiDung.ID_NguoiDung";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt); // Lấy dữ liệu từ CSDL và đổ vào DataTable

                dGV_DanhMucSanPham.DataSource = dt; // Hiển thị DataTable lên DataGridView
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
