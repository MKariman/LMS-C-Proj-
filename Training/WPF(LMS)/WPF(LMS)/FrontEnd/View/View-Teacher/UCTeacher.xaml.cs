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
    /// Interaction logic for UCTeacher.xaml
    /// </summary>
    public partial class UCTeacher : UserControl
    {
        UCinfoteacher ucinfoteacher = new UCinfoteacher();
        Sign_In sign_in = new Sign_In();


        public UCTeacher()
        {
            InitializeComponent();
        }

        public void delet_prev()
        {
            teacher_stack.Children.Clear();
        }

        public void set_info(int username, string password)
        {

            ucinfoteacher.name.Text = sign_in.Tchsign(username,password).Name;
            ucinfoteacher.familyname.Text = sign_in.Tchsign(username,password).LastName;
            ucinfoteacher.melli.Text = Convert.ToString(sign_in.Tchsign(username,password).MeliCode);
            ucinfoteacher.birth.Text = Convert.ToString(sign_in.Tchsign(username,password).BirthDate);
            ucinfoteacher.phone.Text = Convert.ToString(sign_in.Tchsign(username,password).Phone);
            ucinfoteacher.email.Text = sign_in.Tchsign(username,password).Email;
            ucinfoteacher.code.Text = Convert.ToString(sign_in.Tchsign(username,password).OrgCode);
        }



        private void info_teacher_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = (MainWindow)Window.GetWindow(this);

            delet_prev();
            set_info(Convert.ToInt32(win.ucsign.usernametxt.Text), win.ucsign.passwordtxt.Password);

            ucinfoteacher.MaxHeight = 313;
            ucinfoteacher.MaxWidth = 800;
            teacher_stack.Children.Add(ucinfoteacher);
        }

        private void table_classes_Click(object sender, RoutedEventArgs e)
        {
            delet_prev();
        }

        private void marks_list_student_Click(object sender, RoutedEventArgs e)
        {
            delet_prev();
        }

        private void change_mark_Click(object sender, RoutedEventArgs e)
        {
            delet_prev();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win_prev = (MainWindow)Window.GetWindow(this);
            MainWindow win_nex = new MainWindow();
            win_prev.Close();
            win_nex.ShowDialog();

        }
    }
}
