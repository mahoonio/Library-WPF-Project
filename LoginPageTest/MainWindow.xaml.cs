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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoginPageTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            Data data = new Data();
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void Registerbtn_Click(object sender, RoutedEventArgs e)
        {
            Register RPage = new Register();
            RPage.Show();
            //this.Close();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            MemberPannel mpage;
            AdminPannel APage;
            UserP Upage;

            //inja bayad thisworkero befrestam baraye view haye wallet va editview befrestam

            //inja 3 ta shartha check mishe

            //if (Extentions.FindTheWorker(Collections.Workers, UserNameBox.Text, PassBox.Password) != null)
            //{
            //    Worker ThisWorker = (Extentions.FindTheWorker(Collections.Workers, UserNameBox.Text, PassBox.Password));
            //    mpage = new MemberPannel();
            //    mpage.Show();
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("there is no worker with these informations");
            //}

            if (UserNameBox.Text == "worker")
            {
                mpage = new MemberPannel();
                mpage.Show();
                
            }
            else if(UserNameBox.Text =="AdminLib123" && PassBox.Password.Equals("admin"))
            {
                APage = new AdminPannel();
                APage.Show();
            }
            else if(methods.FindeMember(UserNameBox.Text)!=null)
            {
                Member member = methods.FindeMember((UserNameBox.Text));
                Upage = new UserP(member);
                Upage.Show();
            }
            else
            {
                MessageBox.Show("wrong information");
            }
        }

        private void AppClose_Click(object sender, RoutedEventArgs e)
        {
            Data.data.SaveInfo();
            System.Windows.Application.Current.Shutdown();
        }
    }
}
