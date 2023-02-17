using BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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
using System.Windows.Shapes;

namespace SalesWPFApp
{
    /// <summary>
    /// Interaction logic for WindowOrders.xaml
    /// </summary>
    public partial class WindowOrders : Window
    {
        FstoreContext db;
        public WindowOrders()
        {
            InitializeComponent();
            db = new FstoreContext();
        }

        public void LoadData()
        {
            var orders = db.Orders.Include(o => o.Member)
                .Select(o => new
                {
                    id = o.OrderId,
                    member = o.Member.Email,
                    orderDate = o.OrderDate,
                    requiredDate = o.RequiredDate,
                    shippedDate = o.ShippedDate,
                    freight = o.Freight,
                }).ToList();

            var members = db.Members.Select(m => new
            {
                id = m.MemberId,
                email = m.Email
            }).ToList();

            // Binding to : lv Employee, cb Dept
            lvOrder.ItemsSource = orders;
            cbMember.ItemsSource = members;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            txtOrderId.Text = "";
            cbMember.Text = "";
            dpOrderDate.Text = "";
            dpRequiredDate.Text = "";
            dpShippedDate.Text = "";
            txtFreight.Text = "";
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Order o = new Order();
            o.MemberId = int.Parse(cbMember.SelectedValue.ToString());
            o.OrderDate = (DateTime)dpOrderDate.SelectedDate;
            o.RequiredDate = (DateTime)dpRequiredDate.SelectedDate;
            o.ShippedDate = (DateTime)dpShippedDate.SelectedDate;
            o.Freight = decimal.Parse(txtFreight.Text);
            db.Add<Order>(o);
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Add successfully!");
                LoadData();
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Order o = new Order
            {
                OrderId = int.Parse(txtOrderId.Text),
                MemberId = int.Parse(cbMember.SelectedValue.ToString()),
                OrderDate = dpOrderDate.DisplayDate,
                RequiredDate = dpRequiredDate.DisplayDate,
                ShippedDate = dpShippedDate.DisplayDate,
                Freight = decimal.Parse(txtFreight.Text)
            };
            db.Update<Order>(o);
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
            Order o = db.Orders.FirstOrDefault(x => x.OrderId == int.Parse(txtOrderId.Text));
            db.Remove<Order>(o);
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Record removed successfully");
                LoadData();
            }
        }
    }
}
