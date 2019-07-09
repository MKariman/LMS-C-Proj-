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

namespace WPF_LMS_.FrontEnd.View.View_Manager
{
    /// <summary>
    /// Interaction logic for UCinfomanager.xaml
    /// </summary>
    public partial class UCinfomanager : UserControl
    {
        Edit edit_mg = new Edit();
        Sign_In sign_in = new Sign_In();


        public UCinfomanager()
        {
            InitializeComponent();
       
        }


        public void set_info(int username, string password, UCinfomanager ucm)
        {

            ucm.name.Text = sign_in.Mgsign(username, password).Name;
            ucm.familyname.Text = sign_in.Mgsign(username, password).LastName;
            ucm.melli.Text = Convert.ToString(sign_in.Mgsign(username, password).MeliCode);
            ucm.birth.Text = Convert.ToString(sign_in.Mgsign(username, password).BirthDate);
            ucm.phone.Text = Convert.ToString(sign_in.Mgsign(username, password).Phone);
            ucm.email.Text = sign_in.Mgsign(username, password).Email;
            ucm.code.Text = Convert.ToString(sign_in.Mgsign(username, password).OrgCode);
            ucm.teach.Text = sign_in.Mgsign(username, password).Education;
            ucm.semat.Text = sign_in.Mgsign(username, password).Post;
        }

        public void Edit_Click(object sender, RoutedEventArgs e)
        {
            name.IsEnabled = true;
            familyname.IsEnabled = true;
            birth.IsEnabled = true;
            melli.IsEnabled = true;
            semat.IsEnabled = true;
            phone.IsEnabled = true;
            email.IsEnabled = true;
            teach.IsEnabled = true;
            code.IsEnabled = true;

            name.BorderBrush = Brushes.Black;
            familyname.BorderBrush = Brushes.Black;
            birth.BorderBrush = Brushes.Black;
            melli.BorderBrush = Brushes.Black;
            semat.BorderBrush = Brushes.Black;
            phone.BorderBrush = Brushes.Black;
            email.BorderBrush = Brushes.Black;
            teach.BorderBrush = Brushes.Black;
            code.BorderBrush = Brushes.Black;


            ok.Visibility = Visibility.Visible;
            change_pass.Visibility = Visibility.Hidden;
            edit.Visibility = Visibility.Hidden;




        }

        public void Ok_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = (MainWindow)Window.GetWindow(this);

            name.IsEnabled = false;
            familyname.IsEnabled = false;
            birth.IsEnabled = false;
            melli.IsEnabled = false;
            semat.IsEnabled = false;
            phone.IsEnabled = false;
            email.IsEnabled = false;
            teach.IsEnabled = false;
            code.IsEnabled = false;

            name.BorderBrush = null;
            familyname.BorderBrush = null;
            birth.BorderBrush = null;
            melli.BorderBrush = null;
            semat.BorderBrush = null;
            phone.BorderBrush = null;
            email.BorderBrush = null;
            teach.BorderBrush = null;
            code.BorderBrush = null;

            ok.Visibility = Visibility.Hidden;
            change_pass.Visibility = Visibility.Visible;
            edit.Visibility = Visibility.Visible;

            List<Mg_Models> mg = new List<Mg_Models>();
            mg.Add(new Mg_Models
            {
                Name = name.Text ,
                LastName = familyname.Text ,
                Phone = Int32.Parse(phone.Text),
                OrgCode = Int32.Parse(code.Text) ,
                BirthDate = Int32.Parse(birth.Text),
                Email = email.Text ,
                MeliCode = Int32.Parse(melli.Text) ,
                Password = win.ucsign.passwordtxt.Password

            });

            edit_mg.InfMg(mg, Int32.Parse(win.ucsign.usernametxt.Text));


            MessageBox.Show("اطلاعات با موفقیت ذخیره شد", "Information", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        public void change_pass_Click(object sender, RoutedEventArgs e)
        {
            information.Visibility = Visibility.Hidden;
            pass_change.Visibility = Visibility.Visible;


        }

        public void ok_pass_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = (MainWindow)Window.GetWindow(this);
            if (prevpass.Password== win.ucsign.passwordtxt.Password)
            {
                if(pass1.Password == pass2.Password &&  pass1.Password != "" )
                {

                    edit_mg.ChangePass(Int32.Parse(code.Text), prevpass.Password , pass1.Password , "Manager");


                    MessageBox.Show("رمز جدید با موفقیت ذخیره شد", "Information", MessageBoxButton.OK, MessageBoxImage.Information);

                    name.IsEnabled = false;
                    familyname.IsEnabled = false;
                    birth.IsEnabled = false;
                    melli.IsEnabled = false;
                    semat.IsEnabled = false;
                    phone.IsEnabled = false;
                    email.IsEnabled = false;
                    teach.IsEnabled = false;
                    code.IsEnabled = false;

                    name.BorderBrush = null;
                    familyname.BorderBrush = null;
                    birth.BorderBrush = null;
                    melli.BorderBrush = null;
                    semat.BorderBrush = null;
                    phone.BorderBrush = null;
                    email.BorderBrush = null;
                    teach.BorderBrush = null;
                    code.BorderBrush = null;

                    information.Visibility = Visibility.Visible;
                    pass_change.Visibility = Visibility.Hidden;


                    ok.Visibility = Visibility.Hidden;
                    change_pass.Visibility = Visibility.Visible;
                    edit.IsEnabled = true;

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

        public void cancel_pass_Click(object sender, RoutedEventArgs e)
        {
           
            information.Visibility = Visibility.Visible;
            pass_change.Visibility = Visibility.Hidden;

            change_pass.Visibility = Visibility.Visible;
            edit.Visibility = Visibility.Visible;

            prevpass.Password = "";
            pass1.Password = "";
            pass2.Password = "";
        }
    }
}
