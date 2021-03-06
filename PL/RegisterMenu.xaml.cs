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
using BL;
using Backend;

namespace PL
{
    /// <summary>
    /// Interaction logic for SignInMenu.xaml
    /// </summary>
    public partial class RegisterMenu : Window
    {
        BL_Manager BL_manager;
        public RegisterMenu(BL_Manager BL_manager)
        {
            this.BL_manager = BL_manager;
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            String userName=userNametxt.Text;
            String pass=passtxt.Text;
            String fname = firstNametxt.Text;
            String lname = lastNametxt.Text;
            String IDnumber = IDtxt.Text;
            String gender = (gendertxt.SelectedValue as ComboBoxItem).Content.ToString();
            String dateOfBirth=dateOdBirthtxt.Text;

            Boolean goodInput = false;
            Club_Member customer=new Club_Member(IDnumber,fname,lname,gender,IDnumber,dateOfBirth);
            
            if (MainWindow.isWord(fname) && MainWindow.isWord(lname) && MainWindow.isNumber(IDnumber))
            
                goodInput = true;
            if (goodInput && BL_manager.BL_clubMember.Add(customer) && !BL_manager.BL_user.isUserNameTaken(userName))
            {
                MessageBox.Show("Welcome to Emart !");
                User addedNow = new User(userName, pass,IDnumber);
                BL_manager.BL_user.Add(addedNow);
                MessageBox.Show("User name : " + userName + "\nPassword : "+pass, "User name and Password", MessageBoxButton.OK, MessageBoxImage.Information);
                MainWindow mw = new MainWindow(BL_manager);
                mw.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("There where a problem.\n One or more from the fields is incorrect, please try again", "Problem", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            

        }

        private void closeClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void maximaizeB_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
                this.WindowState = WindowState.Normal;
            else
            {
                this.WindowState = WindowState.Maximized;
            }
        }

        private void minimaizeClick(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        
    }
}
