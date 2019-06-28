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



        private void AllMarks_Click(object sender, RoutedEventArgs e)
        {

           
        }


    

        private void Shimi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Mem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Mech_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Barq_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Omran_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Comp_Click(object sender, RoutedEventArgs e)
        {
            var T = search.AuChart("Computer");

            foreach ( var view in T )
            {

                list_lesson.Add(new Lesson()
                {
                    Name = view.Lesson,
                    Unit = view.Unit,
                    type = view.Type,
                    Teacher = "?"
                });

                list_lessons_view.ItemsSource = list_lesson;
                
            }
        }
    }
}
