using System.Windows.Forms;
﻿using System.Data;
using System.Data.SqlClient;

namespace BT_23_10_2024
{
    public partial class Form1 : Form
    {
        private List<SanPham> danhSachSanPham = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void tbMaSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // dataGridView1.DataSource = laySanPham().Tables[0];
            dataGridView1.DataSource = danhSachSanPham;
        }

        private void tbTenSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDonGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbHinhAnh_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMoTaNgan_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMoTaChiTiet_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ các TextBox và ComboBox
                string maSP = tbMaSP.Text; // Lấy mã sản phẩm từ TextBox
                string tenSP = tbTenSP.Text;
                decimal donGia;
                if (!decimal.TryParse(tbDonGia.Text, out donGia))
                {
                    MessageBox.Show("Đơn giá không hợp lệ.");
                    return;
                }
                string hinhAnh = tbHinhAnh.Text;
                string moTaNgan = tbMoTaNgan.Text;
                string moTaChiTiet = tbMoTaChiTiet.Text;
                string? loaiSP = cbLoaiSP.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(loaiSP))
                {
                    MessageBox.Show("Vui lòng chọn loại sản phẩm.");
                    return;
                }

                // Tạo đối tượng SanPham và thêm vào danh sách
                SanPham sanPham = new()
                {
                    MaSP = maSP,
                    TenSP = tenSP,
                    DonGia = donGia,
                    HinhAnh = hinhAnh,
                    MoTaNgan = moTaNgan,
                    MoTaChiTiet = moTaChiTiet,
                    LoaiSP = loaiSP
                };

                danhSachSanPham.Add(sanPham); // Thêm sản phẩm vào danh sách

                // Insert db

                // Cập nhật lại DataGridView
                dataGridView1.DataSource = null; // Đặt lại nguồn dữ liệu để làm mới
                dataGridView1.DataSource = danhSachSanPham; // Cập nhật nguồn dữ liệu

                // query db => set datasource

                // Xóa các TextBox và ComboBox
                tbMaSP.Clear();
                tbTenSP.Clear();
                tbDonGia.Clear();
                tbHinhAnh.Clear();
                tbMoTaNgan.Clear();
                tbMoTaChiTiet.Clear();
                cbLoaiSP.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy vị trí dòng được chọn
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                // Xóa sản phẩm khỏi danh sách
                danhSachSanPham.RemoveAt(selectedIndex);

                // Cập nhật lại DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = danhSachSanPham;

                MessageBox.Show("Xóa sản phẩm thành công.");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy vị trí dòng được chọn
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                // Cập nhật thông tin sản phẩm từ các TextBox
                danhSachSanPham[selectedIndex].MaSP = tbMaSP.Text;
                danhSachSanPham[selectedIndex].TenSP = tbTenSP.Text;

                decimal donGia;
                if (decimal.TryParse(tbDonGia.Text, out donGia))
                {
                    danhSachSanPham[selectedIndex].DonGia = donGia;
                }
                else
                {
                    MessageBox.Show("Đơn giá không hợp lệ.");
                    return;
                }

                danhSachSanPham[selectedIndex].HinhAnh = tbHinhAnh.Text;
                danhSachSanPham[selectedIndex].MoTaNgan = tbMoTaNgan.Text;
                danhSachSanPham[selectedIndex].MoTaChiTiet = tbMoTaChiTiet.Text;
                danhSachSanPham[selectedIndex].LoaiSP = cbLoaiSP.SelectedItem?.ToString();

                // Cập nhật lại DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = danhSachSanPham;

                MessageBox.Show("Sửa sản phẩm thành công.");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để sửa.");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            // Xóa các trường TextBox và ComboBox
            tbMaSP.Clear();
            tbTenSP.Clear();
            tbDonGia.Clear();
            tbHinhAnh.Clear();
            tbMoTaNgan.Clear();
            tbMoTaChiTiet.Clear();
            cbLoaiSP.SelectedIndex = -1;

            // Làm mới DataGridView
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = danhSachSanPham;

            MessageBox.Show("Làm mới thành công.");
        }
    }
}