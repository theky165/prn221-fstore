using BusinessObject;
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
    /// Interaction logic for WindowMembers.xaml
    /// </summary>
    public partial class WindowMembers : Window
    {
        public FstoreContext db;
        public WindowMembers()
        {
            InitializeComponent();
            db = new FstoreContext();
        }

        private void LoadData()
        {
            var members = db.Members.Select(m => new
                {
                    id = m.MemberId,
                    email = m.Email,
                    companyName = m.CompanyName,
                    city = m.City,
                    country = m.Country,
                }).ToList();

            lvMember.ItemsSource = members;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Member member = new Member();
            member.Email = txtEmail.Text;
            member.CompanyName = txtCompanyName.Text;
            member.City = txtCity.Text;
            member.Country = txtCountry.Text;
            member.Password = txtPassword.Text;
            db.Add<Member>(member);
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Add successfully!");
                LoadData();
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Member member = new Member
            {
                MemberId = int.Parse(txtMemId.Text),
                Email = txtEmail.Text,
                CompanyName = txtCompanyName.Text,
                City = txtCity.Text,
                Country = txtCountry.Text,
                Password = txtPassword.Text,
            };
            db.Update<Member>(member);
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
            Member member = db.Members.FirstOrDefault(x => x.MemberId == int.Parse(txtMemId.Text));
            db.Remove<Member>(member);
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Record removed successfully");
                LoadData();
            }
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            txtMemId.Text = "";
            txtEmail.Text = "";
            txtCompanyName.Text = "";
            txtCity.Text = "";
            txtCountry.Text = "";
            txtPassword.Text = "";
        }
    }
}
