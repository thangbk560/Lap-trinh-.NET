using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShop
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void LoadUserControl(UserControl userControl)
        {
            pnlShow.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            pnlShow.Controls.Add(userControl);
        }

        private void btnDanhMucSanPham_Click(object sender, EventArgs e)
        {
            DanhMucSanPham sanPhamControl = new DanhMucSanPham();
            LoadUserControl(sanPhamControl);
        }

        private void btnDanhMucKhachHang_Click(object sender, EventArgs e)
        {
            DanhMucKhachHang khachHangControl = new DanhMucKhachHang();
            LoadUserControl(khachHangControl);
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            DonHang donHangControl = new DonHang();
            LoadUserControl(donHangControl);
        }

        private void btnThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            ThongKe thongKeControl = new ThongKe();
            LoadUserControl(thongKeControl);
        }
    }
}
