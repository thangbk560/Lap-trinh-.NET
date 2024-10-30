using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLy_BanHang
{
    internal class ShoppingCart
    {
        private List<Product> products = new();

        public IReadOnlyList<Product> Products => products.AsReadOnly();

        public void addProduct(Product product)
        {
            products.Add(product);
        }

        public void removeProduct(Product product)
        {
            products.Remove(product);
        }

        public void clearCart()
        {
            products.Clear();
        }

        public decimal calculateTotalAmount()
        {
            return products.Sum(p => p.Price * p.Quantity);
        }
    }
}