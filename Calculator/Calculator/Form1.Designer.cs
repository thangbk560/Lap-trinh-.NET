namespace Calculator
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
            textBox1 = new TextBox();
            btnSo1 = new Button();
            btnSo2 = new Button();
            btnSo3 = new Button();
            btnSo4 = new Button();
            btnSo5 = new Button();
            btnSo6 = new Button();
            btnSo7 = new Button();
            btnSo8 = new Button();
            btnSo9 = new Button();
            btnSo0 = new Button();
            btnClear = new Button();
            btnBang = new Button();
            btnCong = new Button();
            btnTru = new Button();
            btnNhan = new Button();
            btnChia = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(436, 27);
            textBox1.TabIndex = 0;
            // 
            // btnSo1
            // 
            btnSo1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSo1.Location = new Point(20, 116);
            btnSo1.Name = "btnSo1";
            btnSo1.Size = new Size(94, 66);
            btnSo1.TabIndex = 1;
            btnSo1.Text = "1";
            btnSo1.UseVisualStyleBackColor = true;
            btnSo1.Click += btnSo_Click;
            // 
            // btnSo2
            // 
            btnSo2.Font = new Font("Segoe UI", 12F);
            btnSo2.Location = new Point(131, 116);
            btnSo2.Name = "btnSo2";
            btnSo2.Size = new Size(94, 66);
            btnSo2.TabIndex = 2;
            btnSo2.Text = "2";
            btnSo2.UseVisualStyleBackColor = true;
            btnSo2.Click += btnSo_Click;
            // 
            // btnSo3
            // 
            btnSo3.Font = new Font("Segoe UI", 12F);
            btnSo3.Location = new Point(241, 116);
            btnSo3.Name = "btnSo3";
            btnSo3.Size = new Size(94, 66);
            btnSo3.TabIndex = 3;
            btnSo3.Text = "3";
            btnSo3.UseVisualStyleBackColor = true;
            btnSo3.Click += btnSo_Click;
            // 
            // btnSo4
            // 
            btnSo4.Font = new Font("Segoe UI", 12F);
            btnSo4.Location = new Point(20, 188);
            btnSo4.Name = "btnSo4";
            btnSo4.Size = new Size(94, 66);
            btnSo4.TabIndex = 4;
            btnSo4.Text = "4";
            btnSo4.UseVisualStyleBackColor = true;
            btnSo4.Click += btnSo_Click;
            // 
            // btnSo5
            // 
            btnSo5.Font = new Font("Segoe UI", 12F);
            btnSo5.Location = new Point(131, 188);
            btnSo5.Name = "btnSo5";
            btnSo5.Size = new Size(94, 66);
            btnSo5.TabIndex = 5;
            btnSo5.Text = "5";
            btnSo5.UseVisualStyleBackColor = true;
            btnSo5.Click += btnSo_Click;
            // 
            // btnSo6
            // 
            btnSo6.Font = new Font("Segoe UI", 12F);
            btnSo6.Location = new Point(241, 188);
            btnSo6.Name = "btnSo6";
            btnSo6.Size = new Size(94, 66);
            btnSo6.TabIndex = 6;
            btnSo6.Text = "6";
            btnSo6.UseVisualStyleBackColor = true;
            btnSo6.Click += btnSo_Click;
            // 
            // btnSo7
            // 
            btnSo7.Font = new Font("Segoe UI", 12F);
            btnSo7.Location = new Point(20, 260);
            btnSo7.Name = "btnSo7";
            btnSo7.Size = new Size(94, 66);
            btnSo7.TabIndex = 7;
            btnSo7.Text = "7";
            btnSo7.UseVisualStyleBackColor = true;
            btnSo7.Click += btnSo_Click;
            // 
            // btnSo8
            // 
            btnSo8.Font = new Font("Segoe UI", 12F);
            btnSo8.Location = new Point(131, 260);
            btnSo8.Name = "btnSo8";
            btnSo8.Size = new Size(94, 66);
            btnSo8.TabIndex = 8;
            btnSo8.Text = "8";
            btnSo8.UseVisualStyleBackColor = true;
            btnSo8.Click += btnSo_Click;
            // 
            // btnSo9
            // 
            btnSo9.Font = new Font("Segoe UI", 12F);
            btnSo9.Location = new Point(241, 260);
            btnSo9.Name = "btnSo9";
            btnSo9.Size = new Size(94, 66);
            btnSo9.TabIndex = 9;
            btnSo9.Text = "9";
            btnSo9.UseVisualStyleBackColor = true;
            btnSo9.Click += btnSo_Click;
            // 
            // btnSo0
            // 
            btnSo0.Font = new Font("Segoe UI", 12F);
            btnSo0.Location = new Point(131, 333);
            btnSo0.Name = "btnSo0";
            btnSo0.Size = new Size(94, 66);
            btnSo0.TabIndex = 10;
            btnSo0.Text = "0";
            btnSo0.UseVisualStyleBackColor = true;
            btnSo0.Click += btnSo_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(20, 333);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 66);
            btnClear.TabIndex = 11;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnCancel_Click;
            // 
            // btnBang
            // 
            btnBang.Font = new Font("Segoe UI", 12F);
            btnBang.Location = new Point(241, 333);
            btnBang.Name = "btnBang";
            btnBang.Size = new Size(94, 66);
            btnBang.TabIndex = 12;
            btnBang.Text = "=";
            btnBang.UseVisualStyleBackColor = true;
            btnBang.Click += btnBang_Click;
            // 
            // btnCong
            // 
            btnCong.Font = new Font("Segoe UI", 12F);
            btnCong.Location = new Point(362, 116);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(94, 66);
            btnCong.TabIndex = 13;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = true;
            btnCong.Click += btnCong_Click;
            // 
            // btnTru
            // 
            btnTru.Font = new Font("Segoe UI", 12F);
            btnTru.Location = new Point(362, 188);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(94, 66);
            btnTru.TabIndex = 14;
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = true;
            btnTru.Click += btnTru_Click;
            // 
            // btnNhan
            // 
            btnNhan.Font = new Font("Segoe UI", 12F);
            btnNhan.Location = new Point(362, 260);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(94, 66);
            btnNhan.TabIndex = 15;
            btnNhan.Text = "*";
            btnNhan.UseVisualStyleBackColor = true;
            btnNhan.Click += btnNhan_Click;
            // 
            // btnChia
            // 
            btnChia.Font = new Font("Segoe UI", 12F);
            btnChia.Location = new Point(362, 333);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(94, 66);
            btnChia.TabIndex = 16;
            btnChia.Text = "/";
            btnChia.UseVisualStyleBackColor = true;
            btnChia.Click += btnChia_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 421);
            Controls.Add(btnChia);
            Controls.Add(btnNhan);
            Controls.Add(btnTru);
            Controls.Add(btnCong);
            Controls.Add(btnBang);
            Controls.Add(btnClear);
            Controls.Add(btnSo0);
            Controls.Add(btnSo9);
            Controls.Add(btnSo8);
            Controls.Add(btnSo7);
            Controls.Add(btnSo6);
            Controls.Add(btnSo5);
            Controls.Add(btnSo4);
            Controls.Add(btnSo3);
            Controls.Add(btnSo2);
            Controls.Add(btnSo1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnSo1;
        private Button btnSo2;
        private Button btnSo3;
        private Button btnSo4;
        private Button btnSo5;
        private Button btnSo6;
        private Button btnSo7;
        private Button btnSo8;
        private Button btnSo9;
        private Button btnSo0;
        private Button btnClear;
        private Button btnBang;
        private Button btnCong;
        private Button btnTru;
        private Button btnNhan;
        private Button btnChia;
    }
}
