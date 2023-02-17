using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace SalesWPFApp
{
    /// <summary>
    /// Interaction logic for WindowProducts.xaml
    /// </summary>
    public partial class WindowProducts : Window
    {
        FstoreContext db;
        public WindowProducts()
        {
            InitializeComponent();
            db = new FstoreContext();
        }

        public void LoadData()
        {
            var products = db.Products.Select(p => new
            {
                id = p.ProductId,
                categoryId = p.CategoryId,
                productName = p.ProductName,
                weight = p.Weight,
                unitPrice = p.UnitPrice,
                unitsInStock = p.UnitslnStock,
            }).ToList();

            lvProduct.ItemsSource = products;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            txtProductId.Text = "";
            txtCategoryId.Text = "";
            txtProductName.Text = "";
            txtWeight.Text = "";
            txtUnitPrice.Text = "";
            txtUnitInStock.Text = "";
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Product p = new Product();
            p.CategoryId = int.Parse(txtCategoryId.Text);
            p.ProductName = txtProductName.Text;
            p.Weight = txtWeight.Text;
            p.UnitPrice = decimal.Parse(txtUnitPrice.Text);
            p.UnitslnStock = int.Parse(txtUnitInStock.Text);
            db.Add<Product>(p);
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Add successfully!");
                LoadData();
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Product p = new Product
            {
                ProductId = int.Parse(txtProductId.Text),
                CategoryId = int.Parse(txtCategoryId.Text),
                ProductName = txtProductName.Text,
                Weight = txtWeight.Text,
                UnitPrice = decimal.Parse(txtUnitPrice.Text),
                UnitslnStock = int.Parse(txtUnitInStock.Text),
            };
            db.Update<Product>(p);
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Edit success.");
                LoadData();
            }
            else
            {
                MessageBox.Show("Edit failed.");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Product product = db.Products.FirstOrDefault(x => x.ProductId == int.Parse(txtProductId.Text));
            db.Remove<Product>(product);
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Record removed successfully");
                LoadData();
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string searchValue = txtSearch.Text.ToLower();
            var productList = db.Products.Select(p => new
            {
                id = p.ProductId,
                categoryId = p.CategoryId,
                productName = p.ProductName,
                weight = p.Weight,
                unitPrice = p.UnitPrice,
                unitsInStock = p.UnitslnStock,
            }).Where(p =>
            p.productName.ToLower().Contains(searchValue)).ToList();
            
            lvProduct.ItemsSource = productList;
        }
    }
}
