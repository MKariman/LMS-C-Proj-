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

namespace WPF_LMS_.FrontEnd.View.View_Stuedent
{
    /// <summary>
    /// Interaction logic for UCStudent.xaml
    /// </summary>
    public partial class UCStudent : UserControl
    {
        UCinfostudent ucinfostudent = new UCinfostudent();

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
            delet_prev();
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
    }
}
