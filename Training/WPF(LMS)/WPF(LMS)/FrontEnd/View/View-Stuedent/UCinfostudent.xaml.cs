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

namespace WPF_LMS_.FrontEnd.View.View_Stuedent
{
    /// <summary>
    /// Interaction logic for UCinfostudent.xaml
    /// </summary>
    public partial class UCinfostudent : UserControl
    {
        Sign_In sign_in = new Sign_In();
        Edit edit_st = new Edit();

        public UCinfostudent()
        {
            InitializeComponent();
        }
        public void set_info(int username, string password, UCinfostudent ucs)
        {

            ucs.name.Text = sign_in.STsign(username, password).Name;
            ucs.familyname.Text = sign_in.STsign(username, password).LastName;
            ucs.melli.Text = Convert.ToString(sign_in.STsign(username, password).MeliCode);
            ucs.birth.Text = Convert.ToString(sign_in.STsign(username, password).Birthdate);
            ucs.phone.Text = Convert.ToString(sign_in.STsign(username, password).Phone);
            ucs.email.Text = sign_in.STsign(username, password).Email;
            ucs.code.Text = Convert.ToString(sign_in.STsign(username, password).UniCode);
            ucs.year.Text = Convert.ToString(sign_in.STsign(username, password).UniLog);
            ucs.unit.Text = Convert.ToString(sign_in.STsign(username, password).Vahedha);
            ucs.reshteh.Text = sign_in.STsign(username, password).Major;
        }

        private void change_pass_Click(object sender, RoutedEventArgs e)
        {
            change_pass.Visibility = Visibility.Hidden;
            information_stack.Visibility = Visibility.Hidden;
            pass_change.Visibility = Visibility.Visible;


        }

        public void ok_pass_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = (MainWindow)Window.GetWindow(this);
            if (prevpass.Password == win.ucsign.passwordtxt.Password)
            {
                if (pass1.Password == pass2.Password && pass1.Password != "")
                {

                    edit_st.ChangePass(Int32.Parse(code.Text), prevpass.Password, pass1.Password, "Student");


                    MessageBox.Show("رمز جدید با موفقیت ذخیره شد", "Information", MessageBoxButton.OK, MessageBoxImage.Information);

                    name.IsEnabled = false;
                    familyname.IsEnabled = false;
                    melli.IsEnabled = false;
                    birth.IsEnabled = false;
                    reshteh.IsEnabled = false;
                    email.IsEnabled = false;
                    unit.IsEnabled = false;
                    code.IsEnabled = false;
                    phone.IsEnabled = false;
                    year.IsEnabled = false;

                    name.BorderBrush = null;
                    familyname.BorderBrush = null;
                    melli.BorderBrush = null;
                    birth.BorderBrush = null;
                    reshteh.BorderBrush = null;
                    email.BorderBrush = null;
                    unit.BorderBrush = null;
                    code.BorderBrush = null;
                    phone.BorderBrush = null;
                    year.BorderBrush = null;

                    change_pass.Visibility = Visibility.Visible;
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
            change_pass.Visibility = Visibility.Visible;
            information_stack.Visibility = Visibility.Visible;
            pass_change.Visibility = Visibility.Hidden;

            prevpass.Password = "";
            pass1.Password = "";
            pass2.Password = "";
        }
    }
}
