﻿using System;
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
    /// Interaction logic for Admin_Bank_AddMoney.xaml
    /// </summary>
    public partial class Admin_Bank_AddMoney : Window
    {
        public Admin_Bank_AddMoney()
        {
            InitializeComponent();
        }

        private void AddMoneyBtn_Click(object sender, RoutedEventArgs e)
        {
            // code e back end marboot be ezafe kardane pool
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}