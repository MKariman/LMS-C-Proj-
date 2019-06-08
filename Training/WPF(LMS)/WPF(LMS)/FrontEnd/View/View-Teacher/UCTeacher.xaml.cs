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

namespace WPF_LMS_.FrontEnd.View.View_Teacher
{
    /// <summary>
    /// Interaction logic for UCTeacher.xaml
    /// </summary>
    public partial class UCTeacher : UserControl
    {
        UCinfoteacher ucinfoteacher = new UCinfoteacher();

        public UCTeacher()
        {
            InitializeComponent();
        }

        public void delet_prev()
        {
            teacher_stack.Children.Clear();
        }

        private void info_teacher_Click(object sender, RoutedEventArgs e)
        {
            delet_prev();
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
