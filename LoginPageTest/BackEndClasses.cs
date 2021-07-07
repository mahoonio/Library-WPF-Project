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
    public class User
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        
    }
    public class Worker : User
    {
        
    }
    public class Admin : User
    {

    }
    class Member : User
    {

    }
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string EditonNumber { get; set; }

    }
    

}