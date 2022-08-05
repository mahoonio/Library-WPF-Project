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
        public ObservableCollection<Member> members { get; set; }
        public MyBooksView()
        {
            members = new ObservableCollection<Member>();
            for(int i = 0; i < Collections.LateReturnersMembers.Count; i++)
            {
                members.Add(Collections.LateReturnersMembers[i]);
            }
            InitializeComponent();
            DataContext = this;
        }
        private void AllMembersBox_Click()
        {
        }
        private void AllMembersBox_Click_1(object sender, RoutedEventArgs e)
        {
            members.Clear();
            for (int i = 0; i < Collections.AllMembers.Count; i++)
            {
                members.Add(Collections.AllMembers[i]);
            }
        }
        private void LateReturnersBox_Click(object sender, RoutedEventArgs e)
        {
            members.Clear();
            for (int i = 0; i < Collections.LateReturnersMembers.Count; i++)
            {
                members.Add(Collections.LateReturnersMembers[i]);
            }
        }
        private void LatePayersBox_Click(object sender, RoutedEventArgs e)
        {
            members.Clear();
            for (int i = 0; i < Collections.LatePayerMembers.Count; i++)
            {
                members.Add(Collections.LatePayerMembers[i]);
            }
        }
    }
}
