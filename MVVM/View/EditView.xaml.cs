
using System;
using Microsoft.Win32;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace LoginPageTest.MVM.View
{
    /// <summary>
    /// Interaction logic for EditView.xaml
    /// </summary>
    public partial class EditView : UserControl
    {
        public EditView()
        {
            InitializeComponent();
        }
        


        private void SetPhotoBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "jpg files (*.jpg))|(*.jpg)|png files (*.png)|(*.png)";

            if (fileDialog.ShowDialog() == true)
            {
                var UriSource = new Uri(System.IO.Path.GetFullPath(fileDialog.FileName));
                ProfilePhoto.Source = new BitmapImage(UriSource);

            }

        }
        /// <summary>

        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        ///////////////////////////////////////inja kolan bayad avaz she vaghti toonestam etelaat ro ersal konam
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (methods.IsValidEmail(emailbox.Text)
            && methods.IsValidPhoneNumber(phonebox.Text)
            && methods.IsValidUserName(usernamebox1.Text)
            && methods.IsValidPassword(passbox.Password))
            {
                //Collections.AllMembers.Add(new Member(usernamebox1.Text, emailbox.Text, passbox.Password, phonebox.Text));
            }
            else
            {
                MessageBox.Show("Wrong information");
            }
        }
    }
}
