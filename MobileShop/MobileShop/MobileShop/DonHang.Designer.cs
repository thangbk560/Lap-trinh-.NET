namespace MobileShop
{
    partial class DonHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dGV_DonHang = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbBKhachHang = new ComboBox();
            cbBSanPham = new ComboBox();
            txtSoLuong = new TextBox();
            dtpNgayMua = new DateTimePicker();
            txtDonHang = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            label6 = new Label();
            cbBTimKiem = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dGV_DonHang).BeginInit();
            SuspendLayout();
            // 
            // dGV_DonHang
            // 
            dGV_DonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGV_DonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGV_DonHang.Location = new Point(3, 67);
            dGV_DonHang.Name = "dGV_DonHang";
            dGV_DonHang.RowHeadersWidth = 51;
            dGV_DonHang.Size = new Size(510, 430);
            dGV_DonHang.TabIndex = 0;
            dGV_DonHang.CellClick += dGV_DonHang_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(539, 70);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 1;
            label1.Text = "ID Đơn hàng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(539, 103);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 2;
            label2.Text = "ID Khách hàng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(539, 139);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 3;
            label3.Text = "ID Sản phẩm:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(539, 173);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 4;
            label4.Text = "Số lượng:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(539, 208);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 5;
            label5.Text = "Ngày mua:";
            // 
            // cbBKhachHang
            // 
            cbBKhachHang.FormattingEnabled = true;
            cbBKhachHang.Location = new Point(653, 100);
            cbBKhachHang.Name = "cbBKhachHang";
            cbBKhachHang.Size = new Size(124, 28);
            cbBKhachHang.TabIndex = 6;
            // 
            // cbBSanPham
            // 
            cbBSanPham.FormattingEnabled = true;
            cbBSanPham.Location = new Point(653, 136);
            cbBSanPham.Name = "cbBSanPham";
            cbBSanPham.Size = new Size(124, 28);
            cbBSanPham.TabIndex = 7;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(653, 170);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(124, 27);
            txtSoLuong.TabIndex = 8;
            // 
            // dtpNgayMua
            // 
            dtpNgayMua.Format = DateTimePickerFormat.Custom;
            dtpNgayMua.Location = new Point(653, 203);
            dtpNgayMua.Name = "dtpNgayMua";
            dtpNgayMua.Size = new Size(124, 27);
            dtpNgayMua.TabIndex = 9;
            // 
            // txtDonHang
            // 
            txtDonHang.Location = new Point(653, 67);
            txtDonHang.Name = "txtDonHang";
            txtDonHang.Size = new Size(125, 27);
            txtDonHang.TabIndex = 10;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(581, 275);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 35);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(581, 337);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 35);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(581, 399);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 35);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 25);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 14;
            label6.Text = "Tìm kiếm:";
            // 
            // cbBTimKiem
            // 
            cbBTimKiem.FormattingEnabled = true;
            cbBTimKiem.Location = new Point(93, 22);
            cbBTimKiem.Name = "cbBTimKiem";
            cbBTimKiem.Size = new Size(420, 28);
            cbBTimKiem.TabIndex = 15;
            // 
            // DonHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbBTimKiem);
            Controls.Add(label6);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtDonHang);
            Controls.Add(dtpNgayMua);
            Controls.Add(txtSoLuong);
            Controls.Add(cbBSanPham);
            Controls.Add(cbBKhachHang);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dGV_DonHang);
            Name = "DonHang";
            Size = new Size(800, 500);
            ((System.ComponentModel.ISupportInitialize)dGV_DonHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dGV_DonHang;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbBKhachHang;
        private ComboBox cbBSanPham;
        private TextBox txtSoLuong;
        private DateTimePicker dtpNgayMua;
        private TextBox txtDonHang;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Label label6;
        private ComboBox cbBTimKiem;
    }
}
