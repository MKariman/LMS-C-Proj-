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
    /// Interaction logic for UClist_marks_student.xaml
    /// </summary>
    public partial class UClist_marks_student : UserControl
    {
        Search search = new Search();
        string major;
        string lesson;


        public UClist_marks_student()
        {
            InitializeComponent();
        }
        public void Enabled()
        {
            Shimi.IsEnabled = true;
            Mem.IsEnabled = true;
            Mech.IsEnabled = true;
            Barq.IsEnabled = true;
            Omran.IsEnabled = true;
            Comp.IsEnabled = true;

        }


        private void Comp_Click(object sender, RoutedEventArgs e)
        {
            Enabled();

            list_lesson.ItemsSource = search.AuChart("Computer");
            Comp.IsEnabled = false;
            major = "Computer";
        }

        private void Omran_Click(object sender, RoutedEventArgs e)
        {
            Enabled();

            list_lesson.ItemsSource = search.AuChart("Omran");
            Omran.IsEnabled = false;
            major = "Omran";

        }

        private void Barq_Click(object sender, RoutedEventArgs e)
        {
            Enabled();

            list_lesson.ItemsSource = search.AuChart("Barq");
            Barq.IsEnabled = false;
            major = "Barq";

        }

        private void Mech_Click(object sender, RoutedEventArgs e)
        {
            Enabled();

            list_lesson.ItemsSource = search.AuChart("Mechanic");
            Mech.IsEnabled = false;
            major = "Mechanic";

        }

        private void Mem_Click(object sender, RoutedEventArgs e)
        {
            Enabled();

            list_lesson.ItemsSource = search.AuChart("Memari");
            Mem.IsEnabled = false;
            major = "Memari";

        }

        private void Shimi_Click(object sender, RoutedEventArgs e)
        {
            Enabled();
            list_lesson.ItemsSource = search.AuChart("Shimi");
            Shimi.IsEnabled = false;
            major = "Shimi";

        }

        private void Show_btn_Click(object sender, RoutedEventArgs e)
        {
            if (list_lesson.SelectedItem != null)
            {

                if (major == "Barq")
                {
                    if (search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Unit == 3)
                    {
                        if (search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Lesson == "Electronic")
                        {
                            list_mark_student_view.ItemsSource = search.Ent("BElectro", major);
                            lesson = "BElectro";
                        }
                        else
                        {
                            list_mark_student_view.ItemsSource = search.Ent("B" + search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Lesson, major);
                            lesson = "B" + search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Lesson;
                        }

                    }
                    else
                    {
                        if (search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Lesson == "Riazi")
                        {
                            list_mark_student_view.ItemsSource = search.Ent("Riazi1", major);
                            lesson = "Riazi1";

                        }
                        else
                        {
                            list_mark_student_view.ItemsSource = search.Ent(search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Lesson, major);
                            lesson = search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Lesson;

                        }
                    }

                }

                if (major == "Shimi")
                {
                    if (search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Unit == 3)
                    {

                        if (search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Lesson == "Sinematik")
                        {
                            list_mark_student_view.ItemsSource = search.Ent("SHSinema", major);
                            lesson = "SHSinema";


                        }
                        else
                        {
                            list_mark_student_view.ItemsSource = search.Ent("SH" + search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Lesson, major);
                            lesson = "SH" + search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Lesson;

                        }
                    }
                    else
                    {
                        if (search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Lesson == "Riazi")
                        {
                            list_mark_student_view.ItemsSource = search.Ent("Riazi1", major);
                            lesson = "Riazi1";

                        }
                        else
                        {
                            list_mark_student_view.ItemsSource = search.Ent(search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Lesson, major);
                            lesson = search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Lesson;

                        }
                    }

                }


                if (major == "Memari")
                {
                    if (search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Unit == 3)
                    {
                        if (search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Lesson == "Fazasazi")
                        {
                            list_mark_student_view.ItemsSource = search.Ent("MeFazas", major);
                            lesson = "MeFazas";

                        }
                        else
                        {
                            list_mark_student_view.ItemsSource = search.Ent("Me" + search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Lesson, major);
                            lesson = "Me" + search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Lesson;

                        }

                    }
                    else
                    {
                        if (search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Lesson == "Riazi")
                        {
                            list_mark_student_view.ItemsSource = search.Ent("Riazi1", major);
                            lesson = "Riazi1";

                        }
                        else
                        {
                            list_mark_student_view.ItemsSource = search.Ent(search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Lesson, major);
                            lesson = search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Lesson;

                        }
                    }

                }


                if (major == "Mechanic")
                {
                    if (search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Unit == 3)
                    {

                        list_mark_student_view.ItemsSource = search.Ent("M" + search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Lesson, major);
                        lesson = "M" + search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Lesson;
                    }
                    else
                    {
                        if (search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Lesson == "Riazi")
                        {
                            list_mark_student_view.ItemsSource = search.Ent("Riazi1", major);
                            lesson = "Riazi1";

                        }
                        else
                        {
                            list_mark_student_view.ItemsSource = search.Ent(search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Lesson, major);
                            lesson = search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Lesson;

                        }
                    }

                }


                if (major == "Omran")
                {
                    if (search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Unit == 3)
                    {
                        if (search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Lesson == "NaqsheBardari")
                        {
                            list_mark_student_view.ItemsSource = search.Ent("ONaqshe", major);
                            lesson = "ONaqshe";

                        }
                        if (search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Lesson == "BotonSazi")
                        {
                            list_mark_student_view.ItemsSource = search.Ent("OBotons", major);
                            lesson = "OBotons";

                        }
                        if (search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Lesson != "BotonSazi" && search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Lesson != "NaqsheBardari")
                        {
                            list_mark_student_view.ItemsSource = search.Ent("O" + search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Lesson, major);
                            lesson = "O" + search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Lesson;

                        }

                    }
                    else
                    {
                        if (search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Lesson == "Riazi")
                        {
                            list_mark_student_view.ItemsSource = search.Ent("Riazi1", major);
                            lesson = "Riazi1";

                        }
                        else
                        {
                            list_mark_student_view.ItemsSource = search.Ent(search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Lesson, major);
                            lesson = search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Lesson;

                        }
                    }

                }

                if (major == "Computer")
                {
                    if (search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Unit == 3)
                    {

                        list_mark_student_view.ItemsSource = search.Ent("C" + search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Lesson, major);
                        lesson = "C" + search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Lesson;


                    }
                    else
                    {
                        if (search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Lesson == "Riazi")
                        {
                            list_mark_student_view.ItemsSource = search.Ent("Riazi1", major);
                            lesson = "Riazi1";

                        }
                        else
                        {
                            list_mark_student_view.ItemsSource = search.Ent(search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Lesson, major);
                            lesson = search.AuChart(major)[list_lesson.Items.IndexOf(list_lesson.SelectedItem)].Lesson;

                        }
                    }

                }


            }
            else
            {
                MessageBox.Show("لطفا روی  یکی از دروس کلیک کنید", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void cancel_mark_Click(object sender, RoutedEventArgs e)
        {

            list_mark_student_view.Visibility = Visibility.Visible;
            change_mark_stack.Visibility = Visibility.Hidden;
            list_lesson.IsEnabled = true;
            show_btn.IsEnabled = true;
        }

        private void ok_mark_Click(object sender, RoutedEventArgs e)
        {
            list_mark_student_view.Visibility = Visibility.Visible;
            change_mark_stack.Visibility = Visibility.Hidden;
            list_lesson.IsEnabled = true;
            show_btn.IsEnabled = true;
        }

        private void change_mark_Click(object sender, RoutedEventArgs e)
        {


            if (list_mark_student_view.SelectedItem != null)
            {

                list_mark_student_view.Visibility = Visibility.Hidden;
                change_mark_stack.Visibility = Visibility.Visible;
                list_lesson.IsEnabled = false;
                show_btn.IsEnabled = false;
                new_mark_txt.Text = "";
                lastname_txt.Text = search.Ent(lesson, major)[list_mark_student_view.Items.IndexOf(list_mark_student_view.SelectedItem)].LastName;
                mark_prev_txt.Text = Convert.ToString(search.Ent(lesson, major)[list_mark_student_view.Items.IndexOf(list_mark_student_view.SelectedItem)].Mark);

            }
            else
            {
                MessageBox.Show("لطفا روی  یکی از دروس  کلیک کنید", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
