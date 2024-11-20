namespace MobileShop
{
    partial class DanhMucKhachHang
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
            dGV_DanhMucKhachHang = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dGV_DanhMucKhachHang).BeginInit();
            SuspendLayout();
            // 
            // dGV_DanhMucKhachHang
            // 
            dGV_DanhMucKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGV_DanhMucKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGV_DanhMucKhachHang.Location = new Point(3, 3);
            dGV_DanhMucKhachHang.Name = "dGV_DanhMucKhachHang";
            dGV_DanhMucKhachHang.RowHeadersWidth = 51;
            dGV_DanhMucKhachHang.Size = new Size(794, 494);
            dGV_DanhMucKhachHang.TabIndex = 0;
            // 
            // DanhMucKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dGV_DanhMucKhachHang);
            Name = "DanhMucKhachHang";
            Size = new Size(800, 500);
            ((System.ComponentModel.ISupportInitialize)dGV_DanhMucKhachHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dGV_DanhMucKhachHang;
    }
}
