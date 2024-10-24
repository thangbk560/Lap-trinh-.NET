namespace BT_23_10_2024
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            cbLoaiSP = new ComboBox();
            label7 = new Label();
            tbMoTaChiTiet = new TextBox();
            label6 = new Label();
            tbMoTaNgan = new TextBox();
            label5 = new Label();
            tbHinhAnh = new TextBox();
            label4 = new Label();
            tbDonGia = new TextBox();
            label3 = new Label();
            tbTenSP = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tbMaSP = new TextBox();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            btnTimKiem = new Button();
            tbTimKiem = new TextBox();
            label8 = new Label();
            groupBox3 = new GroupBox();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            btnLamMoi = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbLoaiSP);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(tbMoTaChiTiet);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tbMoTaNgan);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbHinhAnh);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tbDonGia);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbTenSP);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbMaSP);
            groupBox1.Location = new Point(0, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(288, 327);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // cbLoaiSP
            // 
            cbLoaiSP.FormattingEnabled = true;
            cbLoaiSP.Items.AddRange(new object[] { "ao ", "quan", "do an " });
            cbLoaiSP.Location = new Point(108, 265);
            cbLoaiSP.Name = "cbLoaiSP";
            cbLoaiSP.Size = new Size(151, 28);
            cbLoaiSP.TabIndex = 13;
            cbLoaiSP.SelectedIndexChanged += cbLoaiSP_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 268);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 12;
            label7.Text = "Loại Sp:";
            // 
            // tbMoTaChiTiet
            // 
            tbMoTaChiTiet.Location = new Point(108, 224);
            tbMoTaChiTiet.Name = "tbMoTaChiTiet";
            tbMoTaChiTiet.Size = new Size(143, 27);
            tbMoTaChiTiet.TabIndex = 11;
            tbMoTaChiTiet.TextChanged += tbMoTaChiTiet_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 227);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 10;
            label6.Text = "Mô tả chi tiết:";
            // 
            // tbMoTaNgan
            // 
            tbMoTaNgan.Location = new Point(108, 190);
            tbMoTaNgan.Name = "tbMoTaNgan";
            tbMoTaNgan.Size = new Size(143, 27);
            tbMoTaNgan.TabIndex = 9;
            tbMoTaNgan.TextChanged += tbMoTaNgan_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 193);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 8;
            label5.Text = "Mô tả ngắn:";
            // 
            // tbHinhAnh
            // 
            tbHinhAnh.Location = new Point(108, 153);
            tbHinhAnh.Name = "tbHinhAnh";
            tbHinhAnh.Size = new Size(143, 27);
            tbHinhAnh.TabIndex = 7;
            tbHinhAnh.TextChanged += tbHinhAnh_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 156);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 6;
            label4.Text = "Hình ảnh:";
            // 
            // tbDonGia
            // 
            tbDonGia.Location = new Point(108, 112);
            tbDonGia.Name = "tbDonGia";
            tbDonGia.Size = new Size(143, 27);
            tbDonGia.TabIndex = 5;
            tbDonGia.TextChanged += tbDonGia_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 115);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 4;
            label3.Text = "Đơn giá:";
            // 
            // tbTenSP
            // 
            tbTenSP.Location = new Point(108, 72);
            tbTenSP.Name = "tbTenSP";
            tbTenSP.Size = new Size(143, 27);
            tbTenSP.TabIndex = 3;
            tbTenSP.TextChanged += tbTenSP_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 72);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên SP:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 29);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã SP:";
            // 
            // tbMaSP
            // 
            tbMaSP.Location = new Point(108, 26);
            tbMaSP.Name = "tbMaSP";
            tbMaSP.Size = new Size(111, 27);
            tbMaSP.TabIndex = 0;
            tbMaSP.TextChanged += tbMaSP_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(tbTimKiem);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(294, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(512, 439);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dữ liệu";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(486, 356);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(429, 13);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(65, 53);
            btnTimKiem.TabIndex = 4;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // tbTimKiem
            // 
            tbTimKiem.Location = new Point(102, 26);
            tbTimKiem.Name = "tbTimKiem";
            tbTimKiem.Size = new Size(306, 27);
            tbTimKiem.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 29);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 14;
            label8.Text = "Tìm kiếm:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnSua);
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(btnThem);
            groupBox3.Controls.Add(btnLamMoi);
            groupBox3.Location = new Point(0, 345);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(288, 106);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // btnSua
            // 
            btnSua.Location = new Point(219, 40);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(65, 53);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(150, 40);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(65, 53);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(77, 40);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(65, 53);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(6, 40);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(69, 53);
            btnLamMoi.TabIndex = 0;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "FrmSanPham";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbTenSP;
        private Label label2;
        private Label label1;
        private TextBox tbMaSP;
        private TextBox tbMoTaChiTiet;
        private Label label6;
        private TextBox tbMoTaNgan;
        private Label label5;
        private TextBox tbHinhAnh;
        private Label label4;
        private TextBox tbDonGia;
        private Label label3;
        private ComboBox cbLoaiSP;
        private Label label7;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Button btnLamMoi;
        private DataGridView dataGridView1;
        private Button btnTimKiem;
        private TextBox tbTimKiem;
        private Label label8;
    }
}
