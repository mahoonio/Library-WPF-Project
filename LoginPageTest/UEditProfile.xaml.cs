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
    /// Interaction logic for UEditProfile.xaml
    /// </summary>
    public partial class UEditProfile : Window
    {
        public Member member1;
        public UEditProfile(Member member)
        {
            member1 = member;
            InitializeComponent();
            DataContext = member;
        }

        

        private void SetPhotoBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            // ehtemalan email ro nabayad betoone taghir bede khodet check kon bebin az nazare sql chejooriye 
            if (methods.IsValidEmail(emailbox.Text)) member1.Email = emailbox.Text;
            else MessageBox.Show("invalid email");
            if (methods.IsValidPassword(passbox.Password)) member1.Password = passbox.Password;
            else MessageBox.Show("invalid PassWord");
            if (methods.IsValidPhoneNumber(phonebox.Text)) member1.PhoneNumber = phonebox.Text;
            else MessageBox.Show("invalid Phone number");
            MessageBox.Show("information successFully changed");

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
