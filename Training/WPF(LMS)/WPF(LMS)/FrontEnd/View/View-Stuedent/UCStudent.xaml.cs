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
        Search search = new Search();
        UCreport ucreport = new UCreport();
        UCchart ucchart = new UCchart();


        public UCStudent()
        {
            InitializeComponent();
        }

        public void delet_prev ()
        {
            student_stack.Children.Clear();
        }

      


        private void info_student_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = (MainWindow)Window.GetWindow(this);

            delet_prev();
            ucinfostudent.set_info(Convert.ToInt32(win.ucsign.usernametxt.Text), win.ucsign.passwordtxt.Password , ucinfostudent );

            ucinfostudent.MaxHeight = 315;
            ucinfostudent.MaxWidth = 800;
            student_stack.Children.Add(ucinfostudent);
        }


        private void report_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = (MainWindow)Window.GetWindow(this);

            delet_prev();

            ucreport.show_Reprt(Convert.ToInt32(win.ucsign.usernametxt.Text), win.ucsign.passwordtxt.Password );
            ucreport.MaxHeight = 315;
            ucreport.MaxWidth = 800;
            student_stack.Children.Add(ucreport);
        }

        private void table_term_Click(object sender, RoutedEventArgs e)
        {
            delet_prev();
        }

        private void chart_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = (MainWindow)Window.GetWindow(this);
            delet_prev();

            ucchart.MaxHeight = 315;
            ucchart.MaxWidth = 800;
            ucchart.chart(Convert.ToInt32(win.ucsign.usernametxt.Text), win.ucsign.passwordtxt.Password);
            student_stack.Children.Add(ucchart);

            

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
