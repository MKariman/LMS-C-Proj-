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
    /// Interaction logic for UCStudent.xaml
    /// </summary>
    public partial class UCStudent : UserControl
    {
        UCinfostudent ucinfostudent = new UCinfostudent();
        Sign_In sign_in = new Sign_In();


        public UCStudent()
        {
            InitializeComponent();
        }

        public void delet_prev ()
        {
            student_stack.Children.Clear();
        }

        public void set_info()
        {
            MainWindow win = (MainWindow)Window.GetWindow(this);

            ucinfostudent.name.Text = sign_in.STsign(Convert.ToInt32(win.ucsign.usernametxt.Text), win.ucsign.passwordtxt.Password).Name;
            ucinfostudent.familyname.Text = sign_in.STsign(Convert.ToInt32(win.ucsign.usernametxt.Text), win.ucsign.passwordtxt.Password).LastName;
            ucinfostudent.melli.Text = Convert.ToString(sign_in.STsign(Convert.ToInt32(win.ucsign.usernametxt.Text), win.ucsign.passwordtxt.Password).MeliCode);
            ucinfostudent.birth.Text = Convert.ToString(sign_in.STsign(Convert.ToInt32(win.ucsign.usernametxt.Text), win.ucsign.passwordtxt.Password).Birthdate);
            ucinfostudent.phone.Text = Convert.ToString(sign_in.STsign(Convert.ToInt32(win.ucsign.usernametxt.Text), win.ucsign.passwordtxt.Password).Phone);
            ucinfostudent.email.Text = sign_in.STsign(Convert.ToInt32(win.ucsign.usernametxt.Text), win.ucsign.passwordtxt.Password).Email;
            ucinfostudent.code.Text = Convert.ToString(sign_in.STsign(Convert.ToInt32(win.ucsign.usernametxt.Text), win.ucsign.passwordtxt.Password).UniCode);
            ucinfostudent.year.Text = Convert.ToString(sign_in.STsign(Convert.ToInt32(win.ucsign.usernametxt.Text), win.ucsign.passwordtxt.Password).UniLog);
            ucinfostudent.unit.Text = Convert.ToString(sign_in.STsign(Convert.ToInt32(win.ucsign.usernametxt.Text), win.ucsign.passwordtxt.Password).Vahedha);
            ucinfostudent.reshteh.Text = sign_in.STsign(Convert.ToInt32(win.ucsign.usernametxt.Text), win.ucsign.passwordtxt.Password).Major;
        }


        private void info_student_Click(object sender, RoutedEventArgs e)
        {
            delet_prev();
            set_info();
            ucinfostudent.MaxHeight = 315;
            ucinfostudent.MaxWidth = 800;
            student_stack.Children.Add(ucinfostudent);
        }


        private void report_Click(object sender, RoutedEventArgs e)
        {
            delet_prev();
        }

        private void table_term_Click(object sender, RoutedEventArgs e)
        {
            delet_prev();
        }

        private void chart_Click(object sender, RoutedEventArgs e)
        {
            delet_prev();
        }

        private void select_unit_Click(object sender, RoutedEventArgs e)
        {
            delet_prev();
        }

        private void add_remove_Click(object sender, RoutedEventArgs e)
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
