namespace MobileShop
{
    partial class DanhMucSanPham
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
            dGV_DanhMucSanPham = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dGV_DanhMucSanPham).BeginInit();
            SuspendLayout();
            // 
            // dGV_DanhMucSanPham
            // 
            dGV_DanhMucSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGV_DanhMucSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGV_DanhMucSanPham.Location = new Point(3, 3);
            dGV_DanhMucSanPham.Name = "dGV_DanhMucSanPham";
            dGV_DanhMucSanPham.RowHeadersWidth = 51;
            dGV_DanhMucSanPham.Size = new Size(794, 494);
            dGV_DanhMucSanPham.TabIndex = 0;
            // 
            // DanhMucSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dGV_DanhMucSanPham);
            Name = "DanhMucSanPham";
            Size = new Size(800, 500);
            ((System.ComponentModel.ISupportInitialize)dGV_DanhMucSanPham).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dGV_DanhMucSanPham;
    }
}
