namespace TH_24_10_2024
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
            txtDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            lbTenDangNhap = new Label();
            lbMatKhau = new Label();
            btnDangNhap = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // txtDangNhap
            // 
            txtDangNhap.Location = new Point(155, 47);
            txtDangNhap.Name = "txtDangNhap";
            txtDangNhap.Size = new Size(254, 27);
            txtDangNhap.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(155, 90);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(254, 27);
            txtMatKhau.TabIndex = 1;
            // 
            // lbTenDangNhap
            // 
            lbTenDangNhap.AutoSize = true;
            lbTenDangNhap.Font = new Font("Segoe UI", 10F);
            lbTenDangNhap.Location = new Point(21, 47);
            lbTenDangNhap.Name = "lbTenDangNhap";
            lbTenDangNhap.Size = new Size(128, 23);
            lbTenDangNhap.TabIndex = 2;
            lbTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // lbMatKhau
            // 
            lbMatKhau.AutoSize = true;
            lbMatKhau.Font = new Font("Segoe UI", 10F);
            lbMatKhau.Location = new Point(21, 90);
            lbMatKhau.Name = "lbMatKhau";
            lbMatKhau.Size = new Size(86, 23);
            lbMatKhau.TabIndex = 3;
            lbMatKhau.Text = "Mật khẩu:";
            // 
            // btnDangNhap
            // 
            btnDangNhap.Font = new Font("Segoe UI", 10F);
            btnDangNhap.Location = new Point(58, 156);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(143, 47);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10F);
            btnThoat.Location = new Point(229, 156);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(143, 47);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 245);
            Controls.Add(btnThoat);
            Controls.Add(btnDangNhap);
            Controls.Add(lbMatKhau);
            Controls.Add(lbTenDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtDangNhap);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDangNhap;
        private TextBox txtMatKhau;
        private Label lbTenDangNhap;
        private Label lbMatKhau;
        private Button btnDangNhap;
        private Button btnThoat;
    }
}
