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
using WPF_LMS_.BackEnd;

namespace WPF_LMS_.FrontEnd.View.View_Teacher
{
    /// <summary>
    /// Interaction logic for UCinfoteacher.xaml
    /// </summary>
    public partial class UCinfoteacher : UserControl
    {
        Sign_In sign_in = new Sign_In();
        Edit edit_tch = new Edit();

        public UCinfoteacher()
        {
            InitializeComponent();
        }

        public void set_info(int username, string password, UCinfoteacher uct)
        {

            uct.name.Text = sign_in.Tchsign(username, password).Name;
            uct.familyname.Text = sign_in.Tchsign(username, password).LastName;
            uct.melli.Text = Convert.ToString(sign_in.Tchsign(username, password).MeliCode);
            uct.birth.Text = Convert.ToString(sign_in.Tchsign(username, password).BirthDate);
            uct.phone.Text = Convert.ToString(sign_in.Tchsign(username, password).Phone);
            uct.email.Text = sign_in.Tchsign(username, password).Email;
            uct.code.Text = Convert.ToString(sign_in.Tchsign(username, password).OrgCode);
            uct.reshteh.Text = sign_in.Tchsign(username, password).TeachingLesson;
            uct.teach.Text = sign_in.Tchsign(username, password).Education;


        }

        private void change_pass_Click(object sender, RoutedEventArgs e)
        {
            change_pass_btn.Visibility = Visibility.Hidden;
            information_stack.Visibility = Visibility.Hidden;
            pass_change.Visibility = Visibility.Visible;

        }

        private void ok_pass_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = (MainWindow)Window.GetWindow(this);
            if (prevpass.Password == win.ucsign.passwordtxt.Password)
            {
                if (pass1.Password == pass2.Password && pass1.Password != "")
                {

                    edit_tch.ChangePass(Int32.Parse(code.Text), prevpass.Password, pass1.Password, "Teacher");


                    MessageBox.Show("رمز جدید با موفقیت ذخیره شد", "Information", MessageBoxButton.OK, MessageBoxImage.Information);

                    name.IsEnabled = false;
                    familyname.IsEnabled = false;
                    melli.IsEnabled = false;
                    birth.IsEnabled = false;
                    reshteh.IsEnabled = false;
                    email.IsEnabled = false;
                    darajeh.IsEnabled = false;
                    code.IsEnabled = false;
                    phone.IsEnabled = false;
                    teach.IsEnabled = false;

                    name.BorderBrush = null;
                    familyname.BorderBrush = null;
                    melli.BorderBrush = null;
                    birth.BorderBrush = null;
                    reshteh.BorderBrush = null;
                    email.BorderBrush = null;
                    darajeh.BorderBrush = null;
                    code.BorderBrush = null;
                    phone.BorderBrush = null;
                    teach.BorderBrush = null;

                    change_pass_btn.Visibility = Visibility.Visible;
                    information_stack.Visibility = Visibility.Visible;
                    pass_change.Visibility = Visibility.Hidden;

                }
                else
                {
                    MessageBox.Show("رمز جدید خود را صحیح وارد نمایید", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                    prevpass.Password = "";
                    pass1.Password = "";
                    pass2.Password = "";

                }
            }
            else
            {
                MessageBox.Show("رمز خود را صحیح وارد نمایید", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                prevpass.Password = "";
                pass1.Password = "";
                pass2.Password = "";

            }
        }

        private void cancel_pass_Click(object sender, RoutedEventArgs e)
        {
            change_pass_btn.Visibility = Visibility.Visible;
            information_stack.Visibility = Visibility.Visible;
            pass_change.Visibility = Visibility.Hidden;
            prevpass.Password = "";
            pass1.Password = "";
            pass2.Password = "";
        }
    }
}
