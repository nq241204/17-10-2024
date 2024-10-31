using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesApp
{
    
    
    public partial class Form1 : Form
    {
        private List<Product> productList;
        private ShoppingCart shoppingCart;
        
        public Form1()
        {
            InitializeComponent();
            InitializeProductList();
            shoppingCart = new ShoppingCart();
            LoadProductsToGrid();
        }
        private void InitializeProductList()
        {
            // Tạo một số sản phẩm mẫu
            productList = new List<Product>
        {
            new Product("Sản phẩm A", 100000, 10),
            new Product("Sản phẩm B", 150000, 5),
            new Product("Sản phẩm C", 200000, 8)
        };
        }

        private void LoadProductsToGrid()
        {
            dataGridViewProducts.DataSource = null;
            dataGridViewProducts.DataSource = productList;
        }

        private void LoadCartToGrid()
        {
            dataGridViewCart.DataSource = null;
            dataGridViewCart.DataSource = shoppingCart.CartItems;
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            decimal totalPrice = shoppingCart.GetTotalPrice();
            lblTotalPrice.Text = $"Tổng giá trị: {totalPrice:C}";
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selectedCartItem = GetSelectedCartItem();
            if (selectedCartItem != null)
            {
                shoppingCart.RemoveFromCart(selectedCartItem);
                LoadCartToGrid();
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            var selectedProduct = GetSelectedProduct();
            if (selectedProduct != null)
            {
                shoppingCart.AddToCart(selectedProduct);
                LoadCartToGrid();
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (shoppingCart.CartItems.Count > 0)
            {
                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                shoppingCart.ClearCart();
                LoadCartToGrid();
            }
            else
            {
                MessageBox.Show("Giỏ hàng trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private Product GetSelectedProduct()
        {
            if (dataGridViewProducts.CurrentRow != null)
            {
                int selectedIndex = dataGridViewProducts.CurrentRow.Index;
                return productList[selectedIndex];
            }
            return null;
        }
        private Product GetSelectedCartItem()
        {
            if (dataGridViewCart.CurrentRow != null)
            {
                int selectedIndex = dataGridViewCart.CurrentRow.Index;
                return shoppingCart.CartItems[selectedIndex];
            }
            return null;
        }
    }
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;

        }
    }
    public class ShoppingCart
    {
        public List<Product> CartItems { get; private set; }

        public ShoppingCart()
        {
            CartItems = new List<Product>();
        }

        public void AddToCart(Product product)
        {
            var existingProduct = CartItems.FirstOrDefault(p => p.Name == product.Name);
            if (existingProduct != null)
                existingProduct.Quantity += product.Quantity;
            else
                CartItems.Add(new Product(product.Name, product.Price, product.Quantity));
        }

        public void RemoveFromCart(Product product)
        {
            CartItems.Remove(product);
        }

        public decimal GetTotalPrice()
        {
            return CartItems.Sum(item => item.Price * item.Quantity);
        }

        public void ClearCart()
        {
            CartItems.Clear();
        }
    }
}
