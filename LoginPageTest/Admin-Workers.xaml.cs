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
    /// Interaction logic for Admin_Workers.xaml
    /// </summary>
    public partial class Admin_Workers : Window
    {
        public Admin_Workers()
        {
            InitializeComponent();
        }

        private void AddWorkerBtn_Click(object sender, RoutedEventArgs e)
        {
            Admin_Workers_AddWorker AWorkerAdd = new Admin_Workers_AddWorker();
            AWorkerAdd.Show();
        }

        private void PayWorkersBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        
    }
}
