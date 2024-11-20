namespace MobileShop
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlShow = new Panel();
            panel1 = new Panel();
            pnlController = new Panel();
            btnDanhMucKhachHang = new Button();
            btnDanhMucSanPham = new Button();
            btnDonHang = new Button();
            btnThongKeDoanhThu = new Button();
            pnlController.SuspendLayout();
            SuspendLayout();
            // 
            // pnlShow
            // 
            pnlShow.Location = new Point(208, 12);
            pnlShow.Name = "pnlShow";
            pnlShow.Size = new Size(800, 500);
            pnlShow.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 120);
            panel1.TabIndex = 1;
            // 
            // pnlController
            // 
            pnlController.BackColor = SystemColors.ActiveCaption;
            pnlController.Controls.Add(btnThongKeDoanhThu);
            pnlController.Controls.Add(btnDonHang);
            pnlController.Controls.Add(btnDanhMucKhachHang);
            pnlController.Controls.Add(btnDanhMucSanPham);
            pnlController.Location = new Point(12, 138);
            pnlController.Name = "pnlController";
            pnlController.Size = new Size(190, 374);
            pnlController.TabIndex = 2;
            // 
            // btnDanhMucKhachHang
            // 
            btnDanhMucKhachHang.Location = new Point(3, 97);
            btnDanhMucKhachHang.Name = "btnDanhMucKhachHang";
            btnDanhMucKhachHang.Size = new Size(184, 87);
            btnDanhMucKhachHang.TabIndex = 1;
            btnDanhMucKhachHang.Text = "Danh Mục Khách Hàng";
            btnDanhMucKhachHang.UseVisualStyleBackColor = true;
            btnDanhMucKhachHang.Click += btnDanhMucKhachHang_Click;
            // 
            // btnDanhMucSanPham
            // 
            btnDanhMucSanPham.Location = new Point(3, 3);
            btnDanhMucSanPham.Name = "btnDanhMucSanPham";
            btnDanhMucSanPham.Size = new Size(184, 88);
            btnDanhMucSanPham.TabIndex = 0;
            btnDanhMucSanPham.Text = "Danh Mục Sản Phẩm";
            btnDanhMucSanPham.UseVisualStyleBackColor = true;
            btnDanhMucSanPham.Click += btnDanhMucSanPham_Click;
            // 
            // btnDonHang
            // 
            btnDonHang.Location = new Point(3, 190);
            btnDonHang.Name = "btnDonHang";
            btnDonHang.Size = new Size(184, 88);
            btnDonHang.TabIndex = 3;
            btnDonHang.Text = "Đơn Hàng";
            btnDonHang.UseVisualStyleBackColor = true;
            btnDonHang.Click += btnDonHang_Click;
            // 
            // btnThongKeDoanhThu
            // 
            btnThongKeDoanhThu.Location = new Point(3, 284);
            btnThongKeDoanhThu.Name = "btnThongKeDoanhThu";
            btnThongKeDoanhThu.Size = new Size(184, 87);
            btnThongKeDoanhThu.TabIndex = 4;
            btnThongKeDoanhThu.Text = "Thống Kê Doanh Thu";
            btnThongKeDoanhThu.UseVisualStyleBackColor = true;
            btnThongKeDoanhThu.Click += btnThongKeDoanhThu_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 524);
            Controls.Add(pnlController);
            Controls.Add(panel1);
            Controls.Add(pnlShow);
            Name = "Main";
            Text = "Trang chủ";
            pnlController.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlShow;
        private Panel panel1;
        private Panel pnlController;
        private Button btnDanhMucKhachHang;
        private Button btnDanhMucSanPham;
        private Button btnDonHang;
        private Button btnThongKeDoanhThu;
    }
}