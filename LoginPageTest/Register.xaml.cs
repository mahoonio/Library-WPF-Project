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
using Microsoft.Win32;
using System.IO;

namespace LoginPageTest
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
       
        public Register()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        

        private void SetPhotoBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "jpg files (*.jpg))|(*.jpg)|png files (*.png)|(*.png)";

            if(fileDialog.ShowDialog() == true)
            {
                var UriSource = new Uri(System.IO.Path.GetFullPath(fileDialog.FileName));
                ProfilePhoto.Source = new BitmapImage(UriSource);
                
            }

        }
    }
}
