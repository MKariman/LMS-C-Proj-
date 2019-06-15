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
using WPF_LMS_;
using WPF_LMS_.BackEnd;
using System.Threading;


namespace WPF_LMS_.FrontEnd.View
{
    
    /// <summary>
    /// Interaction logic for UCSign.xaml
    /// </summary>
    public partial class UCSign : UserControl
    {

        Sign_In sign_in = new Sign_In();
       

        public UCSign()
        {
            InitializeComponent();
        }


        private void Sign_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = (MainWindow)Window.GetWindow(this);

            if (RBuser.IsChecked == true)
            {
                try
                {
                    if (sign_in.STsign(Convert.ToInt32(usernametxt.Text), passwordtxt.Password) != null)
                    {
                        MessageBox.Show("شما با موفقیت وارد شدید", "Sign in", MessageBoxButton.OK, MessageBoxImage.Information);
                        win.main_stack.Children.Remove(win.ucsign);
                        win.main_stack.Children.Add(win.ucstudent);
                    }
                    if (sign_in.STsign(Convert.ToInt32(usernametxt.Text), passwordtxt.Password) == null)
                    {
                        if (sign_in.Tchsign(Convert.ToInt32(usernametxt.Text), passwordtxt.Password) != null)
                        {
                            MessageBox.Show("شما با موفقیت وارد شدید", "Sign in", MessageBoxButton.OK, MessageBoxImage.Information);
                            win.main_stack.Children.Remove(win.ucsign);
                            win.main_stack.Children.Add(win.ucteacher);
                        }
                        if (sign_in.Tchsign(Convert.ToInt32(usernametxt.Text), passwordtxt.Password) == null)
                        {
                            MessageBox.Show("نام کاربری یا رمز عبور اشتباه است", "خطا", MessageBoxButton.OK, MessageBoxImage.Error);
                            usernametxt.Text = "";
                            passwordtxt.Password = "";
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("نام کاربری یا رمز عبور اشتباه است", "خطا", MessageBoxButton.OK, MessageBoxImage.Error);
                    usernametxt.Text = "";
                    passwordtxt.Password = "";
                }

            }
            else if (RBManager.IsChecked == true)
            {
                try
                {
                    if (sign_in.Mgsign(Convert.ToInt32(usernametxt.Text), passwordtxt.Password) != null)
                    {
                        MessageBox.Show("شما با موفقیت وارد شدید", "Sign in", MessageBoxButton.OK, MessageBoxImage.Information);
                        win.main_stack.Children.Remove(win.ucsign);
                        win.main_stack.Children.Add(win.ucmanager);
                    }
                    else
                    {
                        MessageBox.Show("نام کاربری یا رمز عبور اشتباه است", "خطا", MessageBoxButton.OK, MessageBoxImage.Error);
                        usernametxt.Text = "";
                        passwordtxt.Password = "";
                    }
                }
                catch
                {

                    MessageBox.Show("نام کاربری یا رمز عبور اشتباه است", "خطا", MessageBoxButton.OK, MessageBoxImage.Error);
                    usernametxt.Text = "";
                    passwordtxt.Password = "";
                }
            }
        }


        public void Creat_Users()
        {
            sign_in.AddUser();
            MessageBox.Show("Created Users", "Data base", MessageBoxButton.OK, MessageBoxImage.Information);
        }



        private void user_click(object sender, RoutedEventArgs e)
        {
            Thread thread = new Thread(Creat_Users);
            thread.Start();
        }

        

    }
}
