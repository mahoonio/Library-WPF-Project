
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
    public class User
    {
        public static List<User> users = new List<User>();
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
        public static ObservableCollection<Worker> workers { get; set; } = new ObservableCollection<Worker>();
        public Worker(string username, string email, string password, string phonenumber) : base(username, email, password, phonenumber)
        {
            workers.Add(this);
        }
    }
    public class Admin : User//point : chizi ke be shekle uniqe dar nazar gerefte shode email mibashad pas search ham bar asase email has
                             // // SQL => primery : email (first field)
    {
        public Admin(string username, string email, string password, string phonenumber) : base(username, email, password, phonenumber) { }
        public void AddWorker(string name, string mail, string pass, string phone)
        {
            Worker worker = new Worker(name, mail, pass, phone);// dar constructor Worker , Add mishe 
        }
        public void RemoveWorker(string mail)
        {
            foreach (Worker worker in Worker.workers)
            {
                if (mail.Equals(worker.Email)) Worker.workers.Remove(worker);
            }
        }

    }
    class Member : User
    {
        public ObservableCollection<Member> members { get; set; }

        public Member(string username, string email, string password, string phonenumber) : base(username, email, password, phonenumber) { }

    }
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string EditonNumber { get; set; }

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

}