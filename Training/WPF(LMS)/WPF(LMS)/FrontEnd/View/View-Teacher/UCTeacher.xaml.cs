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

        public void set_info()
        {
            MainWindow win = (MainWindow)Window.GetWindow(this);

            ucinfoteacher.name.Text = sign_in.Tchsign(Convert.ToInt32(win.ucsign.usernametxt.Text), win.ucsign.passwordtxt.Password).Name;
            ucinfoteacher.familyname.Text = sign_in.Tchsign(Convert.ToInt32(win.ucsign.usernametxt.Text), win.ucsign.passwordtxt.Password).LastName;
            ucinfoteacher.melli.Text = Convert.ToString(sign_in.Tchsign(Convert.ToInt32(win.ucsign.usernametxt.Text), win.ucsign.passwordtxt.Password).MeliCode);
            ucinfoteacher.birth.Text = Convert.ToString(sign_in.Tchsign(Convert.ToInt32(win.ucsign.usernametxt.Text), win.ucsign.passwordtxt.Password).BirthDate);
            ucinfoteacher.phone.Text = Convert.ToString(sign_in.Tchsign(Convert.ToInt32(win.ucsign.usernametxt.Text), win.ucsign.passwordtxt.Password).Phone);
            ucinfoteacher.email.Text = sign_in.Tchsign(Convert.ToInt32(win.ucsign.usernametxt.Text), win.ucsign.passwordtxt.Password).Email;
            ucinfoteacher.code.Text = Convert.ToString(sign_in.Tchsign(Convert.ToInt32(win.ucsign.usernametxt.Text), win.ucsign.passwordtxt.Password).OrgCode);
        }



        private void info_teacher_Click(object sender, RoutedEventArgs e)
        {
            delet_prev();
            set_info();

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
