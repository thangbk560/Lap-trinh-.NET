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
    public partial class DonHang : UserControl
    {
        private SqlConnection conn = new SqlConnection("Data Source=localhost,1433;Initial Catalog=MobileShop;Integrated Security=True");

        public DonHang()
        {
            InitializeComponent();
            LoadData();
            LoadComboBoxes();
        }

        // Load dữ liệu từ bảng DonHang lên DataGridView
        private void LoadData()
        {
            try
            {
                conn.Open();
                string query = "SELECT ID_DonHang AS [Mã Đơn Hàng], DonHang.ID_KhachHang AS [Mã Khách Hàng], DonHang.ID_SanPham AS [Mã Sản Phẩm], SoLuong AS [Số Lượng], NgayMua AS [Ngày Mua]" +
                               "FROM DonHang, NguoiDung " +
                               "WHERE DonHang.ID_NguoiDung = NguoiDung.ID_NguoiDung";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dGV_DonHang.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void LoadComboBoxes()
        {
            try
            {
                conn.Open();

                // Load Khách hàng
                SqlDataAdapter khAdapter = new SqlDataAdapter("SELECT ID_KhachHang FROM KhachHang", conn);
                DataTable khTable = new DataTable();
                khAdapter.Fill(khTable);
                cbBKhachHang.DataSource = khTable;
                cbBKhachHang.DisplayMember = "ID_KhachHang";
                cbBKhachHang.ValueMember = "ID_KhachHang";

                // Load Sản phẩm
                SqlDataAdapter spAdapter = new SqlDataAdapter("SELECT ID_SanPham FROM SanPham", conn);
                DataTable spTable = new DataTable();
                spAdapter.Fill(spTable);
                cbBSanPham.DataSource = spTable;
                cbBSanPham.DisplayMember = "ID_SanPham";
                cbBSanPham.ValueMember = "ID_SanPham";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu ComboBox: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO DonHang (ID_DonHang, ID_KhachHang, ID_SanPham, SoLuong, NgayMua) " +
                               "VALUES (@id, @kh, @sp, @sl, @ngay)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", txtDonHang.Text);
                cmd.Parameters.AddWithValue("@kh", cbBKhachHang.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@sp", cbBSanPham.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@sl", int.Parse(txtSoLuong.Text));
                cmd.Parameters.AddWithValue("@ngay", dtpNgayMua.Value);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm đơn hàng thành công.");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dGV_DonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu không click vào tiêu đề cột
            if (e.RowIndex >= 0)
            {
                // Lấy dòng được chọn trong DataGridView
                DataGridViewRow row = dGV_DonHang.SelectedRows[0];

                // Điền dữ liệu từ dòng vào các điều khiển
                txtDonHang.Text = row.Cells["Mã Đơn Hàng"].Value.ToString();
                cbBKhachHang.SelectedValue = row.Cells["Mã Khách Hàng"].Value.ToString();
                cbBSanPham.SelectedValue = row.Cells["Mã Sản Phẩm"].Value.ToString();
                txtSoLuong.Text = row.Cells["Số Lượng"].Value.ToString();
                dtpNgayMua.Value = Convert.ToDateTime(row.Cells["Ngày Mua"].Value.ToString());
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "UPDATE DonHang SET ID_KhachHang = @kh, ID_SanPham = @sp, SoLuong = @sl, NgayMua = @ngay " +
                               "WHERE ID_DonHang = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", txtDonHang.Text);
                cmd.Parameters.AddWithValue("@kh", cbBKhachHang.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@sp", cbBSanPham.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@sl", int.Parse(txtSoLuong.Text));
                cmd.Parameters.AddWithValue("@ngay", dtpNgayMua.Value);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa đơn hàng thành công.");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM DonHang WHERE ID_DonHang = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", txtDonHang.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa đơn hàng thành công.");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void cbBTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "SELECT dh.ID_DonHang, kh.TenKhachHang, sp.TenSanPham, dh.SoLuong, dh.NgayMua " +
                               "FROM DonHang dh " +
                               "JOIN KhachHang kh ON dh.ID_KhachHang = kh.ID_KhachHang " +
                               "JOIN SanPham sp ON dh.ID_SanPham = sp.ID_SanPham " +
                               "WHERE kh.TenKhachHang LIKE @search";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@search", "%" + cbBTimKiem.Text + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dGV_DonHang.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}