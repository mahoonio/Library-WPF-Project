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
using System.Text.RegularExpressions;
using System.Globalization;
using System.Collections.ObjectModel;
namespace LoginPageTest
{

    public class User//point : chizi ke be shekle uniqe dar nazar gerefte shode email mibashad pas search ham bar asase email has
                     // // SQL => primery : email (first field)
    {

        //fields
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        //methods
        public User(string username, string email, string pass, string phone)
        {
            UserName = username;
            Email = email;
            Password = pass;
            PhoneNumber = phone;
        }
        public void print()// : just for test sth (removable)
        {
            Console.WriteLine($"username:{UserName}\nemail:{Email};\nPass:{Password}\nphone:{PhoneNumber}");
        }

    }
    public class Worker : User
    {
        public int Pay { get; } = 100000;
        public Worker(string username, string email, string password, string phonenumber) : base(username, email, password, phonenumber)
        {
            Collections.Workers.Add(this);
        }
    }
    public class Admin 
    {
        public string UserName = "AdminLib123";
        public string PassWord = "admin";
        public void AddWorker(string name, string mail, string pass, string phone)
        {
            Worker worker = new Worker(name, mail, pass, phone);// dar constructor Worker , Add mishe 
        }

    }
    public class Member : User
    {
        public bool LateReturn { get; set; }
        public bool LatePay { get; set; }
        public ObservableCollection<Book> MyBooks { get; set; }
        public int NumbersOfBook { get; set; } = 0;
        public int SubscriptionTimeDay = 0;
        public Member(string username, string email, string password, string phonenumber) : base(username, email, password, phonenumber) { }

    }
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string EditonNumber { get; set; }
        public int AvailableNumbers { get; set; } // tedad ketab hayi ke available hast ro neshoon mide(ba bool naneveshtam chon tedadesh moheme)
        public int BorrowedNumbers{get;set;}
        public int Numbers { get; set; }
        public Book (string name, string author , string editionnumber ,int number=1)
        {
            Name = name;
            Author = author;
            EditonNumber = editionnumber;
            Numbers = number;
            AvailableNumbers = number;
            BorrowedNumbers = 0;
            Collections.AllBooks.Add(this);
            Collections.AvailableBooks.Add(this);
        }//dar allBook va availablebook add mishe inja

    }
    public static class methods
    {

        //// Page : payment.xaml

        //field : shomare kart
        public static bool IsValidCartNumber(string number)
        {
            //checking if number contains any char => return false
            long a;
            try
            {
                a = long.Parse(number);
            }
            catch
            {
                return false;
            }


            if (number.Length != 16) return false;
            int[] num1 = new int[16];
            int[] num2 = new int[8];
            for (int i = 0; i < 16; i++)
            {
                num1[i] = number[i] - '0';
            }
            int j = 0;//counter for num2
            for (int i = 0; i < 16; i += 2, j++)
            {
                if (2 * num1[i] >= 10) num2[j] = 1 + 2 * num1[i] % 10;
                else num2[j] = 2 * num1[i];
            }
            int sum = 0;
            for (int i = 1; i < 16; i += 2)
            {
                sum += num1[i];
            }
            foreach (int i in num2)
            {
                sum += i;
            }
            if (sum % 10 == 0) return true;
            else return false;
        }
        //field : CVV
        public static bool IsValidCVV(string cvv)
        {
            Regex regex = new Regex("^[0-9]{3,4}$", RegexOptions.IgnoreCase);
            return regex.IsMatch(cvv);
        }//checked
        //field : Year and Month ( hardo bayad vared she dar voroodi tabe)
        public static bool IsValidYearAndMonth(string year, string month)
        {
            PersianCalendar pc = new PersianCalendar();
            DateTime thisDate = DateTime.Now;
            int SystemMonth = pc.GetMonth(thisDate);
            int Systemyear = pc.GetYear(thisDate);
            Regex regexMonth = new Regex("^[0-9]{2}$", RegexOptions.IgnoreCase);
            Regex regexYear = new Regex("^[0-9]{4}$", RegexOptions.IgnoreCase);

            if (regexYear.IsMatch(year) && regexMonth.IsMatch(month))
            {
                if (int.Parse(month) > 12 || int.Parse(month) < 1) return false;
                if (Systemyear > int.Parse(year)) return true;
                if (Systemyear < int.Parse(year)) return false;
                if (Systemyear == int.Parse(year) && SystemMonth >= int.Parse(month)) return true;
                else return false;
            }
            else return false;
        }//checked

        //// Page : Register.xaml

        //field : Username 
        public static bool IsValidUserName(string name)
        {
            Regex regex = new Regex("^([A-z]|[a-z]){3,32}$", RegexOptions.IgnoreCase);
            return regex.IsMatch(name);

        }//checked
        //field : Email
        public static bool IsValidEmail(string mail)
        {
            Regex regex = new Regex("^\\w{1,32}@(\\d|\\D){1,8}\\.\\D{1,3}$", RegexOptions.IgnoreCase);
            return regex.IsMatch(mail);

        }//checked
        //field : PhoneNumber
        public static bool IsValidPhoneNumber(string num)//checked
        {
            Regex regex = new Regex("^(09)\\d{9}$", RegexOptions.IgnoreCase);
            return regex.IsMatch(num);

        }
        //field: Password
        public static bool IsValidPassword(string pass)//checked
        {
            Regex regex = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*)[a-zA-Z]{8,32}$", RegexOptions.IgnoreCase);
            return regex.IsMatch(pass);

        }

        //// Page MainWindow.xaml => username and password as the same as in the (Register.xaml)Page

    }
    public static class Extentions
    {
        //base codes
        public static Nullable<int> ParseIntOrNull(this string str)
        => !string.IsNullOrEmpty(str) ? int.Parse(str) as Nullable<int> : null;
        public static string ParseStringOrNull(this string str)
            => !string.IsNullOrEmpty(str) ? str : null;

        // methods for query 

        //public static Worker FindTheWorker(this IEnumerable<Worker> workers2, string InputMail)
        //=> workers2.Where(x => x.Email.Equals(InputMail)).First();

        //find the workers in login by their username and password
        //public static Worker FindTheWorker(this IEnumerable<Worker> workers2, string InputUsernName, string InputPass)
        //{
        //    Worker worker = Collections.Workers.Where(x => x.UserName.Equals(InputUsernName)).First();
        //    if (worker.Password.Equals(InputPass)) return worker;
        //    else return null;
        //}

    }
    public static class Collections
    {
        public static ObservableCollection<Book> AllBooks = new ObservableCollection<Book>();
        public static ObservableCollection<Book> BorrowedBooks = new ObservableCollection<Book>();
        public static ObservableCollection<Book> AvailableBooks = new ObservableCollection<Book>();

        public static ObservableCollection<Worker> Workers = new ObservableCollection<Worker>();

        internal static ObservableCollection<Member> AllMembers = new ObservableCollection<Member>();
        internal static ObservableCollection<Member> LatePayerMembers = new ObservableCollection<Member>();
        internal static ObservableCollection<Member> LateReturnersMembers = new ObservableCollection<Member>();
    }
    public static class Fields
    {
        internal static double LibMoneyBank = 0;
    }


}