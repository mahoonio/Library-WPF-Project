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
using System.Collections.ObjectModel;
namespace LoginPageTest.MVM.View
{
    /// <summary>
    /// Interaction logic for MyBooksView.xaml
    /// </summary>
    public partial class MyBooksView : UserControl
    {
        public ObservableCollection<User> users { get; set; }
        public List<User> AllMembers { get; set; }
        public List<User> LateReturners { get; set; }
        public List<User> LatePayers { get; set; }
        public MyBooksView()
        {
            AllMembers = new List<User>();
            LateReturners = new List<User>();
            LatePayers = new List<User>();
            users = new ObservableCollection<User>();
            // inja be jaye in ke khodam meghdar bedam bayad maghadir az data base por shan
            
        AllMembers.Add(new User("LateReturners1", "mail1", "e1", "12345678909"));
            AllMembers.Add(new User("LateReturners2", "mail2", "e2", "12345678909"
           ));
            AllMembers.Add(new User("LateReturners3", "mail3", "e3", "12345678909"));
            AllMembers.Add(new User("LatePayers", "mail4", "e4", "12345678909"));
            AllMembers.Add(new User("LatePayers", "mail5", "e5", "12345678909"));
            LateReturners.Add(new User("LateReturners1", "mail1", "e1", "12345678909"
           ));
            LateReturners.Add(new User("LateReturners2", "mail2", "e2", "12345678909"
           ));
            LateReturners.Add(new User("LateReturners3", "mail3", "e3", "12345678909"
           ));
            LatePayers.Add(new User("LatePayers", "mail4", "e4", "12345678909"));
            LatePayers.Add(new User("LatePayers", "mail5", "e5", "12345678909"));
            users.Add(new User("LateReturners1", "mail1", "e1", "12345678909"));
            users.Add(new User("LateReturners2", "mail2", "e2", "12345678909")); users.Add(new User("LateReturners3", "mail3", "e3", "12345678909"));
            InitializeComponent();
            DataContext = this;
        }
        private void AllMembersBox_Click()
        {
        }
        private void AllMembersBox_Click_1(object sender, RoutedEventArgs e)
        {
            users.Clear();
            for (int i = 0; i < AllMembers.Count; i++)
            {
                users.Add(AllMembers[i]);
            }
        }
        private void LateReturnersBox_Click(object sender, RoutedEventArgs e)
        {
            users.Clear();
            for (int i = 0; i < LateReturners.Count; i++)
            {
                users.Add(LateReturners[i]);
            }
        }
        private void LatePayersBox_Click(object sender, RoutedEventArgs e)
        {
            users.Clear();
            for (int i = 0; i < LatePayers.Count; i++)
            {
                users.Add(LatePayers[i]);
            }
        }
    }
}
