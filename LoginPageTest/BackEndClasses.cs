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
using System.Data.SqlClient;
namespace LoginPageTest
{

    public class User//point : chizi ke be shekle uniqe dar nazar gerefte shode email mibashad pas search ham bar asase email has
                     // // SQL => primery : email (first field)
    {

        //fields
        
        public string Email { get; set; }
        public string UserName { get; set; }
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
        public int Pay { get; set; } = 100000;
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
        public int CashWallet { get; set; }
        public bool LateReturn { get; set; }
        public bool LatePay { get; set; }
        public ObservableCollection<Book> MyBooks;
        public int NumbersOfBook { get; set; } 
        public int SubscriptionTimeDay { get; set; }
        public Member(string username, string email, string password, string phonenumber) : base(username, email, password, phonenumber) 
        {
            LateReturn = false;
            LatePay = false;
            NumbersOfBook = 0;
            SubscriptionTimeDay = 10;//masalan avalesh ke ozv mishan 10 hafte sharzh mishe hesabeshoon va har 10 hafte ham 20000 toman pooleshe
            CashWallet = 0;
            MyBooks = new ObservableCollection<Book>();
        }

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
            Regex regex = new Regex(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
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
            Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*)[a-zA-Z\d]{8,32}$", RegexOptions.IgnoreCase);
            return regex.IsMatch(pass);

        }

        //// Page MainWindow.xaml => username and password as the same as in the (Register.xaml)Page
        ///

        //peyda kardane member
        public static Member FindeMember(string User)
        {
            foreach(Member member in Collections.AllMembers)
            {
                if(member.UserName.Equals(User))
                {
                    return member;
                }            
            }
            return null;
        }

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
        internal static double LibMoneyBank { get; set; } = 0;
    }

    public class Data
    {
        public static Data data = new Data();
        public Data()
        {
            Collections.AllBooks = new ObservableCollection<Book>();
            Collections.BorrowedBooks = new ObservableCollection<Book>();
            Collections.AvailableBooks = new ObservableCollection<Book>();
            Collections.Workers = new ObservableCollection<Worker>();
            Collections.AllMembers = new ObservableCollection<Member>();

            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\AP-projects\WpfProjectDb.mdf;Integrated Security=True;Connect Timeout=30");
            string sql = "select * from Members";
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand(sql, sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                var email = dr["Email"].ToString();
                var username = dr["Username"].ToString();
                var phonenum = dr["PhoneNum"].ToString();
                var password = dr["Password"].ToString();
                Member Amember = new Member(username, email, password,phonenum);
                Amember.CashWallet = Convert.ToInt32(dr["CashWallet"]);
                Amember.LatePay = Convert.ToBoolean(dr["LatePayer"]);
                Amember.LateReturn = Convert.ToBoolean(dr["LateReturner"]);
                Amember.NumbersOfBook = Convert.ToInt32(dr["NumbersOfBooks"]);
                Amember.SubscriptionTimeDay = Convert.ToInt32(dr["SubTimeDay"]);
                Collections.AllMembers.Add(Amember);
            }
            sql = "select * from Books";
            dr.Close();
            cmd = new SqlCommand(sql, sqlcon);
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                var Name = dr["Name"].ToString();
                var Author = dr["Author"].ToString();
                var EditionNumber = dr["EditionNumber"].ToString();
                var Number = Convert.ToInt32(dr["Numbers"]);
                Book book = new Book(Name, Author, EditionNumber, Number);
                book.AvailableNumbers = Convert.ToInt32(dr["AvailableNumbers"]);
                book.BorrowedNumbers = Convert.ToInt32(dr["BorrowedNumbers"]);
                Collections.AllBooks.Add(book);
            }
            var Available = Collections.AllBooks.Where(x => x.AvailableNumbers > 0);
            var Borrowed = Collections.AllBooks.Where(x => x.AvailableNumbers == 0);
            Collections.AvailableBooks = new ObservableCollection<Book>(Available);
            Collections.BorrowedBooks = new ObservableCollection<Book>(Borrowed);

            sql =  "select * from Workers";
            dr.Close();
            cmd = new SqlCommand(sql, sqlcon);
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                var email = dr["Email"].ToString();
                var username = dr["Username"].ToString();
                var phonenum = dr["PhoneNum"].ToString();
                var password = dr["Password"].ToString();
                Worker Aworker = new Worker(username, email, password, phonenum);
                Aworker.Pay = Convert.ToInt32(dr["Pay"]);
            }




            
            
            sqlcon.Close();
        }

        public void SaveInfo()
        {
            try
            {


                using (SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\AP-projects\WpfProjectDb.mdf;Integrated Security=True;Connect Timeout=30"))
                using (SqlCommand cmd = new SqlCommand("TRUNCATE TABLE Books", cnn))
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }

                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\AP-projects\WpfProjectDb.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    conn.Open();




                    foreach ( var book in Collections.AllBooks)
                    {
                        SqlCommand cmd =
                        new SqlCommand(
                            "INSERT INTO Books (Name, Author, EditionNumber, AvailableNumbers, BorrowedNumbers, Numbers) " +
                            " VALUES (@Name, @Author, @EditionNumber, @AvailableNumbers, @BorrowedNumbers, @Numbers)");
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Connection = conn;
                        cmd.Parameters.AddWithValue("@Name", book.Name);
                        cmd.Parameters.AddWithValue("@Author", book.Author);
                        cmd.Parameters.AddWithValue("@EditionNumber", book.EditonNumber);
                        cmd.Parameters.AddWithValue("@AvailableNumbers", book.AvailableNumbers);
                        cmd.Parameters.AddWithValue("@BorrowedNumbers", book.BorrowedNumbers);
                        cmd.Parameters.AddWithValue("@Numbers", book.Numbers);
                        


                        cmd.ExecuteNonQuery();
                    }

                    conn.Close();
                }
                using (SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\AP-projects\WpfProjectDb.mdf;Integrated Security=True;Connect Timeout=30"))
                using (SqlCommand cmd = new SqlCommand("TRUNCATE TABLE Workers", cnn))
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\AP-projects\WpfProjectDb.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    conn.Open();




                    foreach (var member in Collections.Workers)
                    {
                        SqlCommand cmd =
                        new SqlCommand(
                            "INSERT INTO Workers (Email, Username, PhoneNum, Password, Pay) " +
                            " VALUES (@Email, @Username, @PhoneNum, @Password, @pay)");
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Connection = conn;

                        cmd.Parameters.AddWithValue("@Email", member.Email);
                        cmd.Parameters.AddWithValue("@Username", member.UserName);
                        cmd.Parameters.AddWithValue("@PhoneNum", member.PhoneNumber);
                        cmd.Parameters.AddWithValue("@Password" , member.Password );
                        cmd.Parameters.AddWithValue("@Pay" , member.Pay);
                        

                        cmd.ExecuteNonQuery();
                    }

                    conn.Close();

                }

                using (SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\AP-projects\WpfProjectDb.mdf;Integrated Security=True;Connect Timeout=30"))
                using (SqlCommand cmd = new SqlCommand("TRUNCATE TABLE Members", cnn))
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\AP-projects\WpfProjectDb.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    conn.Open();




                    foreach (var member in Collections.AllMembers)
                    {
                        SqlCommand cmd =
                       new SqlCommand(
                           "INSERT INTO Members (Email, Username, PhoneNum, Password, CashWallet, LatePayer, LateReturner, NumbersOfBooks, SubTimeDay) " +
                           " VALUES (@Email, @Username, @PhoneNum, @Password, @CashWallet, @LatePayer, @LateReturner, @NumbersOfBooks, @SubTimeDay)");
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Connection = conn;
                        cmd.Parameters.AddWithValue("@Email", member.Email);
                        cmd.Parameters.AddWithValue("@Username", member.UserName);
                        cmd.Parameters.AddWithValue("@PhoneNum", member.PhoneNumber);
                        cmd.Parameters.AddWithValue("@Password", member.Password);
                        cmd.Parameters.AddWithValue("@CashWallet", member.CashWallet );
                        cmd.Parameters.AddWithValue("@LatePayer", member.LatePay);
                        cmd.Parameters.AddWithValue("@LateReturner", member.LateReturn);
                        cmd.Parameters.AddWithValue("@NumbersOfBooks", member.NumbersOfBook);
                        cmd.Parameters.AddWithValue("@SubTimeDay", member.SubscriptionTimeDay);





                        cmd.ExecuteNonQuery();
                    }

                    conn.Close();
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}