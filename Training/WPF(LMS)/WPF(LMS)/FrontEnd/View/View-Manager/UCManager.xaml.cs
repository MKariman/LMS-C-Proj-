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
using WPF_LMS_.FrontEnd.View.View_Manager;


namespace WPF_LMS_.FrontEnd.View
{
    /// <summary>
    /// Interaction logic for UCManager.xaml
    /// </summary>
    public partial class UCManager : UserControl
    {
        UCinfomanager ucinfomanager = new UCinfomanager();

        public UCManager()
        {
            InitializeComponent();
        }



        public void delet_prev()
        {
            manager_stack.Children.Remove(ucinfomanager);
        }

        

        private void info_manager(object sender, RoutedEventArgs e)
        {
            delet_prev();
            ucinfomanager.MaxHeight = 315;
            ucinfomanager.MaxWidth = 800
;            manager_stack.Children.Add(ucinfomanager);
        }

        private void info_student(object sender, RoutedEventArgs e)
        {
            delet_prev();
        }

        private void list_major(object sender, RoutedEventArgs e)
        {
            delet_prev();
        }

        ///////////////////////////////////////

        private void see_marks(object sender, RoutedEventArgs e)
        {
            delet_prev();
        }

        private void chamge_marks(object sender, RoutedEventArgs e)
        {
            delet_prev();
        }

        private void list_marks_student(object sender, RoutedEventArgs e)
        {
            delet_prev();

        }

        private void units(object sender, RoutedEventArgs e)
        {
            delet_prev();
        }

        private void add_remove(object sender, RoutedEventArgs e)
        {
            delet_prev();
        }

        private void add_user(object sender, RoutedEventArgs e)
        {
            delet_prev();
        }
    }
}
