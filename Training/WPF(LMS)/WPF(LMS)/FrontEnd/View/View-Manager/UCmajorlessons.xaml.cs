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
    /// Interaction logic for UCmajorlessons.xaml
    /// </summary>
    public partial class UCmajorlessons : UserControl
    {
        Search search = new Search();
       static List<Lesson> list_lesson = new List<Lesson>();

        public UCmajorlessons()
        {
            InitializeComponent();
        }

        public class Lesson
        {
            public string Name { get; set; }

            public int Unit { get; set; }

            public string type { get; set; }

            public string Teacher { get; set; }
        }

        public void  Enabled()
        {
            Shimi.IsEnabled = true;
            Mem.IsEnabled = true;
            Mech.IsEnabled = true;
            Barq.IsEnabled = true;
            Omran.IsEnabled = true;
            Comp.IsEnabled = true;

        }

        private void Shimi_Click(object sender, RoutedEventArgs e)
        {
            Enabled();
            list_lessons_view.ItemsSource = search.AuChart("Shimi");
            list_lessons_view.IsEnabled = false;
            Shimi.IsEnabled = false;
        }

        private void Mem_Click(object sender, RoutedEventArgs e)
        {
            Enabled();

            list_lessons_view.ItemsSource = search.AuChart("Memari");
            list_lessons_view.IsEnabled = false;
            Mem.IsEnabled = false;
        }

        private void Mech_Click(object sender, RoutedEventArgs e)
        {
            Enabled();

            list_lessons_view.ItemsSource = search.AuChart("Mechanic");
            list_lessons_view.IsEnabled = false;
            Mech.IsEnabled = false;
        }

        private void Barq_Click(object sender, RoutedEventArgs e)
        {
            Enabled();

            list_lessons_view.ItemsSource = search.AuChart("Barq");
            list_lessons_view.IsEnabled = false;
            Barq.IsEnabled = false;
        }

        private void Omran_Click(object sender, RoutedEventArgs e)
        {
            Enabled();

            list_lessons_view.ItemsSource = search.AuChart("Omran");
            list_lessons_view.IsEnabled = false;
            Omran.IsEnabled = false;
        }

        private void Comp_Click(object sender, RoutedEventArgs e)
        {
            Enabled();

            list_lessons_view.ItemsSource=search.AuChart("Computer");
            list_lessons_view.IsEnabled =false;
            Comp.IsEnabled = false;
        }
    }
}
