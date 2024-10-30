using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QuanLy_BanHang
{
    public partial class Form1 : Form
    {
        private List<Product> Products = new();
        private ShoppingCart cart = new();
        public Form1()
        {
            InitializeComponent();
            loadProducts();
            txtCount.Text = "0";
            txtValue.Text = "0.00";
        }
        private void loadProducts()
        {
            // Khởi tạo danh sách sản phẩm
            Products.Add(new Product { Image = 1, Name = "Product A", Price = 10.5m, Quantity = 1 });
            Products.Add(new Product { Image = 2, Name = "Product B", Price = 20.0m, Quantity = 1 });

            // Gán danh sách sản phẩm vào DataGridView
            dataGridView1.DataSource = Products;
        }
        private void UpdateDataGridView2()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = cart.Products;
        }
        private void UpdateTotalAmountAndQuantity()
        {
            int totalQuantity = (int)cart.Products.Sum(p => p.Quantity); // Tính tổng số lượng sản phẩm
            decimal totalAmount = cart.calculateTotalAmount(); // Tính tổng giá trị

            txtCount.Text = totalQuantity.ToString(); // Cập nhật vào txtCount
            txtValue.Text = totalAmount.ToString("F2"); // Cập nhật vào txtValue (2 chữ số thập phân)
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Product selectedProduct = (Product)dataGridView1.SelectedRows[0].DataBoundItem;

                var existingProduct = cart.Products.FirstOrDefault(p => p.Name == selectedProduct.Name);
                if (existingProduct != null)
                {
                    existingProduct.Quantity += 1;
                }
                else
                {
                    cart.addProduct(new Product
                    {
                        Image = selectedProduct.Image,
                        Name = selectedProduct.Name,
                        Price = selectedProduct.Price,
                        Quantity = 1
                    });
                }

                UpdateDataGridView2();
                UpdateTotalAmountAndQuantity();
            }
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                Product selectedProduct = (Product)dataGridView2.SelectedRows[0].DataBoundItem;

                var existingProduct = cart.Products.FirstOrDefault(p => p.Name == selectedProduct.Name);
                if (existingProduct != null)
                {
                    // Giảm số lượng xuống 1
                    existingProduct.Quantity -= 1;

                    // Nếu số lượng bằng 0, xóa sản phẩm khỏi giỏ hàng
                    if (existingProduct.Quantity <= 0)
                    {
                        cart.removeProduct(existingProduct);
                    }
                }

                UpdateDataGridView2();
                UpdateTotalAmountAndQuantity();
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (cart.Products.Count == 0)
            {
                MessageBox.Show("Giỏ hàng trống. Hãy thêm sản phẩm trước khi thanh toán.");
                return;
            }

            // Thực hiện thanh toán(có thể lưu hóa đơn vào cơ sở dữ liệu, v.v.)

            // Xóa giỏ hàng sau khi thanh toán
            cart.clearCart();
            UpdateDataGridView2();
            UpdateTotalAmountAndQuantity();
            MessageBox.Show("Thanh toán thành công!");
        }
    }
}
