namespace QuanLy_BanHang
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            btnAddProduct = new Button();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            lbValue = new Label();
            lbCout = new Label();
            txtValue = new TextBox();
            txtCount = new TextBox();
            btnPay = new Button();
            btnRemoveProduct = new Button();
            dataGridView2 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddProduct);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(641, 439);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách sản phẩm";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(476, 377);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(160, 54);
            btnAddProduct.TabIndex = 1;
            btnAddProduct.Text = "Thêm vào giỏ hàng";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(630, 342);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbValue);
            groupBox2.Controls.Add(lbCout);
            groupBox2.Controls.Add(txtValue);
            groupBox2.Controls.Add(txtCount);
            groupBox2.Controls.Add(btnPay);
            groupBox2.Controls.Add(btnRemoveProduct);
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Location = new Point(654, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(641, 439);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Giỏ hàng";
            // 
            // lbValue
            // 
            lbValue.AutoSize = true;
            lbValue.Location = new Point(230, 411);
            lbValue.Name = "lbValue";
            lbValue.Size = new Size(89, 20);
            lbValue.TabIndex = 7;
            lbValue.Text = "Tổng giá trị:";
            // 
            // lbCout
            // 
            lbCout.AutoSize = true;
            lbCout.Location = new Point(230, 384);
            lbCout.Name = "lbCout";
            lbCout.Size = new Size(108, 20);
            lbCout.TabIndex = 6;
            lbCout.Text = "Tổng số lượng:";
            // 
            // txtValue
            // 
            txtValue.Location = new Point(344, 404);
            txtValue.Name = "txtValue";
            txtValue.ReadOnly = true;
            txtValue.Size = new Size(125, 27);
            txtValue.TabIndex = 5;
            // 
            // txtCount
            // 
            txtCount.Location = new Point(344, 377);
            txtCount.Name = "txtCount";
            txtCount.ReadOnly = true;
            txtCount.Size = new Size(125, 27);
            txtCount.TabIndex = 4;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(475, 377);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(160, 54);
            btnPay.TabIndex = 3;
            btnPay.Text = "Thanh toán";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // btnRemoveProduct
            // 
            btnRemoveProduct.Location = new Point(6, 377);
            btnRemoveProduct.Name = "btnRemoveProduct";
            btnRemoveProduct.Size = new Size(160, 56);
            btnRemoveProduct.TabIndex = 2;
            btnRemoveProduct.Text = "Xóa khỏi giỏ hàng";
            btnRemoveProduct.UseVisualStyleBackColor = true;
            btnRemoveProduct.Click += btnRemoveProduct_Click;
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 23);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(630, 342);
            dataGridView2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1307, 468);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private DataGridView dataGridView2;
        private Button btnAddProduct;
        private Button btnRemoveProduct;
        private Button btnPay;
        private TextBox txtCount;
        private Label lbValue;
        private Label lbCout;
        private TextBox txtValue;
    }
}
