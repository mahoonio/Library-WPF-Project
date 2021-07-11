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

namespace LoginPageTest
{
    /// <summary>
    /// Interaction logic for Admin_Workers_AddWorker.xaml
    /// </summary>
    public partial class Admin_Workers_AddWorker : Window
    {
        public Admin_Workers_AddWorker()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddBtnW_Click(object sender, RoutedEventArgs e)
        {
            // inja worker be data base add mishe ba backend
            Worker worker = new Worker(UserNameBox.Text, EmailBox.Text, PasswordBox.Text, PhoneNumberBox.Text);
            MessageBox.Show($"{UserNameBox.Text} Added");
        }
    }
}
