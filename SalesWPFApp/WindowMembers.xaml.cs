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

            // Binding to : lv Employee, cb Dept
            lvMember.ItemsSource = members;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }
    }
}
