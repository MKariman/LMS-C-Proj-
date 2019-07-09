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
    /// Interaction logic for UClistchangestudent.xaml
    /// </summary>
    public partial class UClistchangestudent : UserControl
    {
        Search search = new Search();
        string lesson_OM;

        public UClistchangestudent()
        {
            InitializeComponent();
        }

        public void list_show(int orgcode)
        {
            string lesson = search.TchFilter(Convert.ToString(orgcode))[0].TeachingLesson;

            if (lesson == "Database" || lesson == "Gosaste" || lesson == "Inteligence" || lesson == "Manteqi" || lesson == "Programming")
            {
                list_mark_student_view.ItemsSource = search.Ent("C" + lesson, "Computer");
            }


            if (lesson == "Madar" || lesson == "VLSI" || lesson == "Cmos" || lesson == "Electronic" || lesson == "Qodrat")
            {
                if (lesson == "Electronic")
                {
                    list_mark_student_view.ItemsSource = search.Ent("BElectro", "Barq");

                }
                else
                {
                    list_mark_student_view.ItemsSource = search.Ent("B" + lesson, "Barq");
                }
            }


            if (lesson == "BotonSazi" || lesson == "Dinamik" || lesson == "Masaleh" || lesson == "Statik" || lesson == "NaqsheBardari")
            {
                if (lesson == "NaqsheBardari")
                {
                    list_mark_student_view.ItemsSource = search.Ent("ONaqshe", "Omran");

                }
                if (lesson == "BotonSazi")
                {
                    list_mark_student_view.ItemsSource = search.Ent("OBotons", "Omran");
                }
                if (lesson != "BotonSazi" && lesson != "NaqsheBardari")
                {
                    list_mark_student_view.ItemsSource = search.Ent("O" + lesson, "Omran");
                }
            }


            if (lesson == "Fizik" || lesson == "Control" || lesson == "Mashin" || lesson == "Sayalat" || lesson == "Termo")
            {
                list_mark_student_view.ItemsSource = search.Ent("M" + lesson, "Mechanic");
            }

            if (lesson == "Gaz" || lesson == "Jerm" || lesson == "Mavad" || lesson == "Sinematik" || lesson == "Hararat")
            {
                if (lesson == "Sinematik")
                {
                    list_mark_student_view.ItemsSource = search.Ent("SHSinema", "Shimi");

                }
                else
                {
                    list_mark_student_view.ItemsSource = search.Ent("SH" + lesson, "Shimi");
                }
            }
            if (lesson == "Dekor" || lesson == "Fazasazi" || lesson == "Tarahi" || lesson == "Nama" || lesson == "Naqshe")
            {
                if (lesson == "Fazasazi")
                {
                    list_mark_student_view.ItemsSource = search.Ent("MeFazas", "Memari");

                }
                else
                {
                    list_mark_student_view.ItemsSource = search.Ent("Me" + lesson, "Memari");
                }
            }
            if (lesson == "Andishe" || lesson == "Adabiat" || lesson == "Riazi" || lesson == "Moadelat")
            {
                major_txt.Visibility = Visibility.Visible;
                major_btn.Visibility = Visibility.Visible;
                lesson_OM = lesson;
            }

        }
        private void change_mark_Click(object sender, RoutedEventArgs e)
        {
            list_mark_student_view.Visibility = Visibility.Hidden;
            change_mark_stack.Visibility = Visibility.Visible;
               new_mark_txt.Text = "";
               
        }

        private void ok_mark_Click(object sender, RoutedEventArgs e)
        {

            list_mark_student_view.Visibility = Visibility.Visible;
            change_mark_stack.Visibility = Visibility.Hidden;
    
        }

        private void cancel_mark_Click(object sender, RoutedEventArgs e)
        {

            list_mark_student_view.Visibility = Visibility.Visible;
            change_mark_stack.Visibility = Visibility.Hidden;
            
        }

        private void Major_btn_Click(object sender, RoutedEventArgs e)
        {
            if (lesson_OM == "Riazi")
            {
                list_mark_student_view.ItemsSource = search.Ent("Riazi1", major_txt.Text);
            }
            else
            {
                list_mark_student_view.ItemsSource = search.Ent(lesson_OM, major_txt.Text);
            }
        }
    }
}
