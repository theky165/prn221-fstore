using BusinessObject;
using DataAccess.Repository;
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
    /// Interaction logic for WindowLogin.xaml
    /// </summary>
    public partial class WindowLogin : Window
    {
        private IMemberRepository member;
        private FstoreContext db = new FstoreContext();
        public WindowLogin()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            string email = tbEmail.Text;
            string password = tbPassword.Password;

            if (email != null && password != null)
            {
                Member member = db.Members.FirstOrDefault(m => m.Email == email && m.Password == password);
                if (member == null)
                {
                    MessageBox.Show("Incorrect email or password!");
                }
                else
                {
                    MessageBox.Show("Login Success!");
                    WindowOrders windowOrders = new WindowOrders();
                    windowOrders.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Incorrect email or password!");
            }
        }
    }
}
