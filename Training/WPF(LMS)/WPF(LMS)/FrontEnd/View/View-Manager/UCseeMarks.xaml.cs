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
    /// Interaction logic for UCseeMarks.xaml
    /// </summary>
    public partial class UCseeMarks : UserControl
    {
        Search search = new Search();
        List<marks> mark_show = new List<marks>();


        public UCseeMarks()
        {
            InitializeComponent();
        }

        public class marks
        {
            public string Lesson { get; set; }
            public int? Mark { get; set; }            
        }

        private void search_Click(object sender, RoutedEventArgs e)
        {
            list_students.ItemsSource = null;

            list_students.ItemsSource = search.STFilter(search_studenttxt.Text);


            //CollectionView student_listshow_sort = (CollectionView)CollectionViewSource.GetDefaultView(list_students.ItemsSource);
            //student_listshow_sort.SortDescriptions.Add(new SortDescription("UniCode", ListSortDirection.Ascending));

        }

        private void show_Click(object sender, RoutedEventArgs e)
        {
            list_mark.ItemsSource = null;
            mark_show.Clear();
            float? mid = 0;

            if (list_students.SelectedItem != null)
            {


                if (search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].Major == "Mechanic")
                {
                    mark_show.Add(new marks() { Lesson = "فیزیک", Mark = search.MechMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].MFizik });
                    mark_show.Add(new marks() { Lesson = "کنترل", Mark = search.MechMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].MControl });
                    mark_show.Add(new marks() { Lesson = "ماشین", Mark = search.MechMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].MMashin });
                    mark_show.Add(new marks() { Lesson = "سیالات", Mark = search.MechMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].MSayalat });
                    mark_show.Add(new marks() { Lesson = "ترمو", Mark = search.MechMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].MTermo });
                    mark_show.Add(new marks() { Lesson = "اندیشه", Mark = search.MechMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Andishe });
                    mark_show.Add(new marks() { Lesson = "ریاضی 1", Mark = search.MechMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Riazi1 });
                    mark_show.Add(new marks() { Lesson = "ادبیات", Mark = search.MechMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Adabiat });
                    mark_show.Add(new marks() { Lesson = "معادلات", Mark = search.MechMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Moadelat });

                    int u = 0;

                    for (int i = 0; i < 9; i++)
                    {
                        if (mark_show[i].Mark != null)
                        {
                            u += search.AuChart("Mechanic")[i].Unit;
                            mid += (mark_show[i].Mark) * (search.AuChart("Mechanic")[i].Unit);
                        }
                    }



                    list_mark.ItemsSource = mark_show;
                    Mid.Text = Convert.ToString(mid / u);
                    major.Text = "مهندسی مکانیک";

                }

                if (search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].Major == "Computer")
                {


                    mark_show.Add(new marks() { Lesson = "دیتابیس", Mark = search.CompMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].CDatabase });
                    mark_show.Add(new marks() { Lesson = "مدار منطقی", Mark = search.CompMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].CManteqi });
                    mark_show.Add(new marks() { Lesson = "گسسته", Mark = search.CompMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].CGosaste });
                    mark_show.Add(new marks() { Lesson = "هوش مصنوعی", Mark = search.CompMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].CInteligence });
                    mark_show.Add(new marks() { Lesson = "برنامه نویسی", Mark = search.CompMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].CProgramming });
                    mark_show.Add(new marks() { Lesson = "اندیشه", Mark = search.CompMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Andishe });
                    mark_show.Add(new marks() { Lesson = "ریاضی 1", Mark = search.CompMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Riazi1 });
                    mark_show.Add(new marks() { Lesson = "ادبیات", Mark = search.CompMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Adabiat });
                    mark_show.Add(new marks() { Lesson = "معادلات", Mark = search.CompMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Moadelat });


                    int u = 0;

                    for (int i = 0; i < 9; i++)
                    {
                        if (mark_show[i].Mark != null)
                        {
                            u += search.AuChart("Computer")[i].Unit;
                            mid += (mark_show[i].Mark) * (search.AuChart("Computer")[i].Unit);
                        }
                    }


                    list_mark.ItemsSource = mark_show;

                    Mid.Text = Convert.ToString(mid / u);
                    major.Text = "مهندسی کامپیوتر";

                }

                if (search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].Major == "Barq")
                {
                    mark_show.Add(new marks() { Lesson = "الکترونیک", Mark = search.BarqMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].BElectro });
                    mark_show.Add(new marks() { Lesson = "مدار الکتریکی", Mark = search.BarqMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].BMadar });
                    mark_show.Add(new marks() { Lesson = "قدرت", Mark = search.BarqMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].BQodrat });
                    mark_show.Add(new marks() { Lesson = "مخابرات", Mark = search.BarqMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].BVLSI });
                    mark_show.Add(new marks() { Lesson = "سیستم دیجیتال", Mark = search.BarqMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].BCmos });
                    mark_show.Add(new marks() { Lesson = "اندیشه", Mark = search.BarqMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Andishe });
                    mark_show.Add(new marks() { Lesson = "ریاضی 1", Mark = search.BarqMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Riazi1 });
                    mark_show.Add(new marks() { Lesson = "ادبیات", Mark = search.BarqMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Adabiat });
                    mark_show.Add(new marks() { Lesson = "معادلات", Mark = search.BarqMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Moadelat });

                    int u = 0;

                    for (int i = 0; i < 9; i++)
                    {
                        if (mark_show[i].Mark != null)
                        {
                            u += search.AuChart("Barq")[i].Unit;
                            mid += (mark_show[i].Mark) * (search.AuChart("Barq")[i].Unit);
                        }
                    }



                    list_mark.ItemsSource = mark_show;
                    Mid.Text = Convert.ToString(mid / u);
                    major.Text = "مهندسی برق";


                }


                if (search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].Major == "Omran")
                {
                    mark_show.Add(new marks() { Lesson = "استاتیک", Mark = search.OmrMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].OStatik });
                    mark_show.Add(new marks() { Lesson = "نقشه برداری", Mark = search.OmrMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].ONaqshe });
                    mark_show.Add(new marks() { Lesson = "مصالح ساختمانی", Mark = search.OmrMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].OMasaleh });
                    mark_show.Add(new marks() { Lesson = "بتن", Mark = search.OmrMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].OBotons });
                    mark_show.Add(new marks() { Lesson = "دینامیک", Mark = search.OmrMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].ODinamik });
                    mark_show.Add(new marks() { Lesson = "اندیشه", Mark = search.OmrMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Andishe });
                    mark_show.Add(new marks() { Lesson = "ریاضی 1", Mark = search.OmrMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Riazi1 });
                    mark_show.Add(new marks() { Lesson = "ادبیات", Mark = search.OmrMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Adabiat });
                    mark_show.Add(new marks() { Lesson = "معادلات", Mark = search.OmrMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Moadelat });

                    int u = 0;

                    for (int i = 0; i < 9; i++)
                    {
                        if (mark_show[i].Mark != null)
                        {
                            u += search.AuChart("Omran")[i].Unit;
                            mid += (mark_show[i].Mark) * (search.AuChart("Omran")[i].Unit);
                        }
                    }



                    list_mark.ItemsSource = mark_show;
                    Mid.Text = Convert.ToString(mid / u);
                    major.Text = "مهندسی عمران";


                }


                if (search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].Major == "Memari")
                {
                    mark_show.Add(new marks() { Lesson = "دکور", Mark = search.MeMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].MeDekor });
                    mark_show.Add(new marks() { Lesson = "فضاسازی", Mark = search.MeMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].MeFazas });
                    mark_show.Add(new marks() { Lesson = "نماسازی", Mark = search.MeMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].MeNama });
                    mark_show.Add(new marks() { Lesson = "نقشه برداری ", Mark = search.MeMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].MeNaqshe });
                    mark_show.Add(new marks() { Lesson = "طراحی", Mark = search.MeMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].MeTarahi });
                    mark_show.Add(new marks() { Lesson = "اندیشه ", Mark = search.MeMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Andishe });
                    mark_show.Add(new marks() { Lesson = "ادبیات", Mark = search.MeMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Adabiat });
                    mark_show.Add(new marks() { Lesson = "ریاضی 1", Mark = search.MeMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Riazi1 });
                    mark_show.Add(new marks() { Lesson = "معادلات", Mark = search.MeMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Moadelat });

                    int u = 0;

                    for (int i = 0; i < 7; i++)
                    {
                        if (mark_show[i].Mark != null)
                        {
                            u += search.AuChart("Memari")[i].Unit;
                            mid += (mark_show[i].Mark) * (search.AuChart("Memari")[i].Unit);
                        }
                    }




                    list_mark.ItemsSource = mark_show;
                    Mid.Text = Convert.ToString(mid / u);
                    major.Text = "مهندسی معماری";

                }


                if (search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].Major == "Shimi")
                {
                    mark_show.Add(new marks() { Lesson = "گاز", Mark = search.ShiMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].SHGaz });
                    mark_show.Add(new marks() { Lesson = "حرارت", Mark = search.ShiMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].SHHararat });
                    mark_show.Add(new marks() { Lesson = "جرم", Mark = search.ShiMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].SHJerm });
                    mark_show.Add(new marks() { Lesson = "مواد", Mark = search.ShiMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].SHMavad });
                    mark_show.Add(new marks() { Lesson = "ریاضی 1", Mark = search.ShiMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Riazi1 });
                    mark_show.Add(new marks() { Lesson = "معادلات", Mark = search.ShiMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Moadelat });
                    mark_show.Add(new marks() { Lesson = "ادبیات", Mark = search.ShiMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Adabiat });
                    mark_show.Add(new marks() { Lesson = "اندیشه", Mark = search.ShiMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Andishe });
                    mark_show.Add(new marks() { Lesson = "سینماتیک", Mark = search.ShiMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].SHSinema });


                    int u = 0;

                    for (int i = 0; i < 9; i++)
                    {
                        if (mark_show[i].Mark != null)
                        {
                            u += search.AuChart("Shimi")[i].Unit;
                            mid += (mark_show[i].Mark) * (search.AuChart("Shimi")[i].Unit);
                        }
                    }




                    list_mark.ItemsSource = mark_show;
                    Mid.Text = Convert.ToString(mid / u);
                    major.Text = "شیمی";


                }


            }
            else
            {
                MessageBox.Show("لطفا روی  یکی از دانشجویان کلیک کنید", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);


            }
        }


    }
}
