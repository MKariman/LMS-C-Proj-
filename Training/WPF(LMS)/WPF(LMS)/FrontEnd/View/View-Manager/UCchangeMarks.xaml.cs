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
using WPF_LMS_.BackEnd.Marks;


namespace WPF_LMS_.FrontEnd.View.View_Manager
{
    /// <summary>
    /// Interaction logic for UCchangeMarks.xaml
    /// </summary>
    public partial class UCchangeMarks : UserControl
    {
        Search search = new Search();
        List<marks> mark_show = new List<marks>();
        Edit edit_class = new Edit();


        public UCchangeMarks()
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

        private void change_mark_Click(object sender, RoutedEventArgs e)
        {

            if (list_mark.SelectedItem != null)
            {
                search_studenttxt.IsEnabled = false;
                students.IsEnabled = false;
                show_btn.IsEnabled = false;
                new_mark_txt.Text = "";
                name_lesson_txt.Text = mark_show[list_mark.Items.IndexOf(list_mark.SelectedItem)].Lesson;
                mark_prev_txt.Text = Convert.ToString(mark_show[list_mark.Items.IndexOf(list_mark.SelectedItem)].Mark);
                list_mark.Visibility = Visibility.Hidden;
                change_mark_stack.Visibility = Visibility.Visible;
            }
            else
            {
                MessageBox.Show("لطفا روی  یکی از دروس  کلیک کنید", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ok_mark_Click(object sender, RoutedEventArgs e)
        {
            int NMark;
            NMark = Int32.Parse(new_mark_txt.Text);

            if (major.Text == "مهندسی مکانیک"  && NMark >= 0 && NMark <= 20)
            {
                
               
                    mark_show[list_mark.Items.IndexOf(list_mark.SelectedItem)].Mark = NMark;


                    List<BackEnd.Marks.MechM> MarkList = new List<BackEnd.Marks.MechM>();
                    MarkList.Add(new BackEnd.Marks.MechM
                    {

                        MFizik = mark_show[0].Mark,
                        MControl = mark_show[1].Mark,
                        MMashin = mark_show[2].Mark,
                        MSayalat = mark_show[3].Mark,
                        MTermo = mark_show[4].Mark,
                        Andishe = mark_show[5].Mark,
                        Riazi1 = mark_show[6].Mark ,
                        Adabiat = mark_show[7].Mark,
                        Moadelat = mark_show[8].Mark,

                    });

                    edit_class.CMMech(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode, MarkList);
                
                


                
            }
            if (major.Text == "مهندسی کامپیوتر" && NMark >= 0 && NMark <= 20)
            {
                mark_show[list_mark.Items.IndexOf(list_mark.SelectedItem)].Mark = Int32.Parse(new_mark_txt.Text);


                List<CompM> MarkList = new List<CompM>() ;
                MarkList.Add(new CompM
                {

                    CDatabase = mark_show[0].Mark,
                    CManteqi = mark_show[1].Mark,
                    CGosaste = mark_show[2].Mark,
                    CInteligence = mark_show[3].Mark,
                    CProgramming = mark_show[4].Mark,
                    Andishe = mark_show[5].Mark,
                    Riazi1 = mark_show[6].Mark,
                    Adabiat = mark_show[7].Mark,
                    Moadelat = mark_show[8].Mark,


            });


                edit_class.CMComp(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode, MarkList);

            }
            if (major.Text == "مهندسی برق" && NMark >= 0 && NMark <= 20)
            {
                mark_show[list_mark.Items.IndexOf(list_mark.SelectedItem)].Mark = Int32.Parse(new_mark_txt.Text);


                List<BarqM> MarkList = new List<BarqM>();
                MarkList.Add(new BarqM
                {

                    BElectro = mark_show[0].Mark,
                    BMadar = mark_show[1].Mark,
                    BQodrat = mark_show[2].Mark,
                    BVLSI = mark_show[3].Mark,
                    BCmos = mark_show[4].Mark,
                    Andishe = mark_show[5].Mark,
                    Riazi1 = mark_show[6].Mark ,
                    Adabiat = mark_show[7].Mark,
                    Moadelat = mark_show[8].Mark

            });


                edit_class.CMBarq(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode, MarkList);
            }
            if (major.Text == "مهندسی عمران" && NMark >= 0 && NMark <= 20)
            {
                mark_show[list_mark.Items.IndexOf(list_mark.SelectedItem)].Mark = Int32.Parse(new_mark_txt.Text);


                List<OmranM> MarkList = new List<OmranM>();
                MarkList.Add(new OmranM
                {

                    OStatik = mark_show[0].Mark,
                    ONaqshe = mark_show[1].Mark,
                    OMasaleh = mark_show[2].Mark,
                    OBotons = mark_show[3].Mark,
                    ODinamik = mark_show[4].Mark,
                    Andishe = mark_show[5].Mark,
                    Riazi1 = mark_show[5].Mark,
                    Adabiat = mark_show[7].Mark,
                    Moadelat = mark_show[8].Mark


            });


                edit_class.CMOmran(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode, MarkList);
            }
            if (major.Text == "مهندسی معماری" && NMark >= 0 && NMark <= 20)
            {
                mark_show[list_mark.Items.IndexOf(list_mark.SelectedItem)].Mark = Int32.Parse(new_mark_txt.Text);


                List<MemM> MarkList = new List<MemM>();
                MarkList.Add(new MemM
                {

                    MeDekor = mark_show[0].Mark,
                    MeFazas = mark_show[1].Mark,
                    MeNama = mark_show[2].Mark,
                    MeNaqshe = mark_show[3].Mark,
                    MeTarahi = mark_show[4].Mark,
                    Andishe = mark_show[5].Mark,
                    Adabiat = mark_show[6].Mark,
                    Riazi1 = mark_show[7].Mark,
                    Moadelat = mark_show[8].Mark,



            });


                edit_class.CMMemari(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode, MarkList);
            }
            if (major.Text == "شیمی" && NMark >= 0 && NMark <= 20)
            {
                mark_show[list_mark.Items.IndexOf(list_mark.SelectedItem)].Mark = Int32.Parse(new_mark_txt.Text);


                List<ShimiM> MarkList = new List<ShimiM>();
                MarkList.Add(new ShimiM
                {

                    SHGaz = mark_show[0].Mark,
                    SHHararat = mark_show[1].Mark,
                    SHJerm = mark_show[2].Mark,
                    SHSinema = mark_show[3].Mark,
                    SHMavad = mark_show[4].Mark,
                    Andishe = mark_show[5].Mark,
                    Riazi1 = mark_show[6].Mark,
                    Adabiat = mark_show[7].Mark,
                    Moadelat = mark_show[8].Mark,
                    
            });


                edit_class.CMShimi(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode, MarkList);
            }

            if(NMark >= 0 && NMark <= 20)
            {
                MessageBox.Show("نمره تغییر یافت", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                search_studenttxt.IsEnabled = true;
                students.IsEnabled = true;
                show_btn.IsEnabled = true;
                show_Click(true, e);
                list_mark.Visibility = Visibility.Visible;
                change_mark_stack.Visibility = Visibility.Hidden;
            }
            else
            {
                MessageBox.Show("لطفا نمره را تصحیح کنید", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void cancel_mark_Click(object sender, RoutedEventArgs e)
        {
            list_mark.Visibility = Visibility.Visible;
            change_mark_stack.Visibility = Visibility.Hidden;
        }
    }
}
