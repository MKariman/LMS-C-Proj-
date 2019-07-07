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

            if (list_students.SelectedItem != null)
            {


                if (search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].Major == "Mechanic")
                {
                    mark_show.Add(new marks() { Lesson = "کنترل", Mark = search.MechMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].MControl });
                    mark_show.Add(new marks() { Lesson = "ماشین", Mark = search.MechMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].MMashin });
                    mark_show.Add(new marks() { Lesson = "سیالات", Mark = search.MechMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].MSayalat });
                    mark_show.Add(new marks() { Lesson = "ترمو", Mark = search.MechMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].MTermo });
                    mark_show.Add(new marks() { Lesson = "ریاضی 1", Mark = search.MechMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Riazi1 });
                    mark_show.Add(new marks() { Lesson = "معادلات", Mark = search.MechMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Moadelat });
                    mark_show.Add(new marks() { Lesson = "ادبیات", Mark = search.MechMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Adabiat });
                    mark_show.Add(new marks() { Lesson = "اندیشه", Mark = search.MechMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Andishe });
                    mark_show.Add(new marks() { Lesson = "فیزیک", Mark = search.MechMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].MFizik });


                    list_mark.ItemsSource = mark_show;
                    Mid.Text = Convert.ToString(search.MechMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].MechMId);
                    major.Text = "مهندسی مکانیک";

                }

                if (search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].Major == "Computer")
                {
                    mark_show.Add(new marks() { Lesson = "دیتابیس", Mark = search.CompMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].CDatabase });
                    mark_show.Add(new marks() { Lesson = "گسسته", Mark = search.CompMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].CGosaste });
                    mark_show.Add(new marks() { Lesson = "هوش مصنوعی", Mark = search.CompMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].CInteligence });
                    mark_show.Add(new marks() { Lesson = "برنامه نویسی", Mark = search.CompMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].CProgramming });
                    mark_show.Add(new marks() { Lesson = "ریاضی 1", Mark = search.CompMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Riazi1 });
                    mark_show.Add(new marks() { Lesson = "معادلات", Mark = search.CompMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Moadelat });
                    mark_show.Add(new marks() { Lesson = "ادبیات", Mark = search.CompMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Adabiat });
                    mark_show.Add(new marks() { Lesson = "اندیشه", Mark = search.CompMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Andishe });
                    mark_show.Add(new marks() { Lesson = "مدار منطقی", Mark = search.CompMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].CManteqi });


                    list_mark.ItemsSource = mark_show;

                    Mid.Text = Convert.ToString(search.CompMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].CompMId);
                    major.Text = "مهندسی کامپیوتر";

                }

                if (search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].Major == "Barq")
                {
                    mark_show.Add(new marks() { Lesson = "الکترونیک", Mark = search.BarqMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].BElectro });
                    mark_show.Add(new marks() { Lesson = "مدار الکتریکی", Mark = search.BarqMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].BMadar });
                    mark_show.Add(new marks() { Lesson = "قدرت", Mark = search.BarqMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].BQodrat });
                    mark_show.Add(new marks() { Lesson = "مخابرات", Mark = search.BarqMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].BVLSI });
                    mark_show.Add(new marks() { Lesson = "سیستم دیجیتال", Mark = search.BarqMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].BCmos });
                    mark_show.Add(new marks() { Lesson = "ریاضی 1", Mark = search.BarqMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Riazi1 });
                    mark_show.Add(new marks() { Lesson = "معادلات", Mark = search.BarqMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Moadelat });
                    mark_show.Add(new marks() { Lesson = "ادبیات", Mark = search.BarqMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Adabiat });
                    mark_show.Add(new marks() { Lesson = "اندیشه", Mark = search.BarqMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Andishe });


                    list_mark.ItemsSource = mark_show;
                    Mid.Text = Convert.ToString(search.BarqMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].BarqMId);
                    major.Text = "مهندسی برق";


                }


                if (search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].Major == "Omran")
                {
                    mark_show.Add(new marks() { Lesson = "استاتیک", Mark = search.OmrMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].OStatik });
                    mark_show.Add(new marks() { Lesson = "نقشه برداری", Mark = search.OmrMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].ONaqshe });
                    mark_show.Add(new marks() { Lesson = "مصالح ساختمانی", Mark = search.OmrMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].OMasaleh });
                    mark_show.Add(new marks() { Lesson = "دینامیک", Mark = search.OmrMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].ODinamik });
                    mark_show.Add(new marks() { Lesson = "ریاضی 1", Mark = search.OmrMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Riazi1 });
                    mark_show.Add(new marks() { Lesson = "معادلات", Mark = search.OmrMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Moadelat });
                    mark_show.Add(new marks() { Lesson = "ادبیات", Mark = search.OmrMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Adabiat });
                    mark_show.Add(new marks() { Lesson = "اندیشه", Mark = search.OmrMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Andishe });
                    mark_show.Add(new marks() { Lesson = "بتن", Mark = search.OmrMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].OBotons });


                    list_mark.ItemsSource = mark_show;
                    Mid.Text = Convert.ToString(search.OmrMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].OmranMId);
                    major.Text = "مهندسی عمران";


                }


                if (search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].Major == "Memari")
                {
                    mark_show.Add(new marks() { Lesson = "کنترل", Mark = search.MeMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].MeDekor });
                    mark_show.Add(new marks() { Lesson = "ماشین", Mark = search.MeMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].MeFazas });
                    mark_show.Add(new marks() { Lesson = "سیالات", Mark = search.MeMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].MeNama });
                    mark_show.Add(new marks() { Lesson = "ترمو", Mark = search.MeMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].MeTarahi });
                    mark_show.Add(new marks() { Lesson = "ریاضی 1", Mark = search.MeMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Riazi1 });
                    mark_show.Add(new marks() { Lesson = "معادلات", Mark = search.MeMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Moadelat });
                    mark_show.Add(new marks() { Lesson = "ادبیات", Mark = search.MeMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Adabiat });
                    mark_show.Add(new marks() { Lesson = "اندیشه", Mark = search.MeMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].Andishe });


                    list_mark.ItemsSource = mark_show;
                    Mid.Text = Convert.ToString(search.MeMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].MemMId);
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


                    list_mark.ItemsSource = mark_show;
                    Mid.Text = Convert.ToString(search.ShiMark(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode)[0].ShimiMId);
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
            if(major.Text == "مهندسی مکانیک")
            {
                mark_show[list_mark.Items.IndexOf(list_mark.SelectedItem)].Mark = Int32.Parse(new_mark_txt.Text);


                List<BackEnd.Marks.MechM> MarkList = new List<BackEnd.Marks.MechM>();
                MarkList.Add(new BackEnd.Marks.MechM {

                    Adabiat = mark_show[6].Mark ,
                    Andishe = mark_show[7].Mark,
                    MControl = mark_show[0].Mark,
                    MFizik = mark_show[8].Mark, 
                    MMashin = mark_show[1].Mark,
                    Moadelat = mark_show[5].Mark,
                    MSayalat = mark_show[2].Mark,
                    MTermo  = mark_show[3].Mark,
                    Riazi1 = mark_show[4].Mark
            });
                     

                edit_class.CMMech(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode , MarkList);
            }
            if (major.Text == "مهندسی کامپیوتر")
            {
                mark_show[list_mark.Items.IndexOf(list_mark.SelectedItem)].Mark = Int32.Parse(new_mark_txt.Text);


                List<CompM> MarkList = new List<CompM>() ;
                MarkList.Add(new CompM
                {

                    Adabiat = mark_show[6].Mark,
                    Andishe = mark_show[7].Mark,
                    CDatabase = mark_show[0].Mark,
                    CGosaste = mark_show[8].Mark,
                    CInteligence = mark_show[1].Mark,
                    Moadelat = mark_show[5].Mark,
                    CManteqi = mark_show[2].Mark,
                    CProgramming = mark_show[3].Mark,
                    Riazi1 = mark_show[4].Mark
                });


                edit_class.CMComp(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode, MarkList);

            }
            if (major.Text == "مهندسی برق")
            {
                mark_show[list_mark.Items.IndexOf(list_mark.SelectedItem)].Mark = Int32.Parse(new_mark_txt.Text);


                List<BarqM> MarkList = new List<BarqM>();
                MarkList.Add(new BarqM
                {

                    Adabiat = mark_show[6].Mark,
                    Andishe = mark_show[7].Mark,
                    BCmos = mark_show[0].Mark,
                    BMadar = mark_show[8].Mark,
                    BVLSI = mark_show[1].Mark,
                    Moadelat = mark_show[5].Mark,
                    BElectro = mark_show[2].Mark,
                    BQodrat = mark_show[3].Mark,
                    Riazi1 = mark_show[4].Mark
                });


                edit_class.CMBarq(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode, MarkList);
            }
            if (major.Text == "مهندسی عمران")
            {
                mark_show[list_mark.Items.IndexOf(list_mark.SelectedItem)].Mark = Int32.Parse(new_mark_txt.Text);


                List<BackEnd.Marks.MechM> MarkList = new List<BackEnd.Marks.MechM>();
                MarkList.Add(new BackEnd.Marks.MechM
                {

                    Adabiat = mark_show[6].Mark,
                    Andishe = mark_show[7].Mark,
                    MControl = mark_show[0].Mark,
                    MFizik = mark_show[8].Mark,
                    MMashin = mark_show[1].Mark,
                    Moadelat = mark_show[5].Mark,
                    MSayalat = mark_show[2].Mark,
                    MTermo = mark_show[3].Mark,
                    Riazi1 = mark_show[4].Mark
                });


                edit_class.CMMech(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode, MarkList);
            }
            if (major.Text == "مهندسی معماری")
            {
                mark_show[list_mark.Items.IndexOf(list_mark.SelectedItem)].Mark = Int32.Parse(new_mark_txt.Text);


                List<MemM> MarkList = new List<MemM>();
                MarkList.Add(new MemM
                {

                    Adabiat = mark_show[6].Mark,
                    Andishe = mark_show[7].Mark,
                    MeDekor = mark_show[0].Mark,
                    MeNama = mark_show[8].Mark,
                    MeFazas = mark_show[1].Mark,
                    Moadelat = mark_show[5].Mark,
                    MeNaqshe = mark_show[2].Mark,
                    MeTarahi = mark_show[3].Mark,
                    Riazi1 = mark_show[4].Mark
                });


                edit_class.CMMemari(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode, MarkList);
            }
            if (major.Text == "شیمی")
            {
                mark_show[list_mark.Items.IndexOf(list_mark.SelectedItem)].Mark = Int32.Parse(new_mark_txt.Text);


                List<ShimiM> MarkList = new List<ShimiM>();
                MarkList.Add(new ShimiM
                {

                    Adabiat = mark_show[6].Mark,
                    Andishe = mark_show[7].Mark,
                    SHGaz = mark_show[0].Mark,
                    SHHararat = mark_show[8].Mark,
                    SHJerm = mark_show[1].Mark,
                    Moadelat = mark_show[5].Mark,
                    SHMavad = mark_show[2].Mark,
                    SHSinema = mark_show[3].Mark,
                    Riazi1 = mark_show[4].Mark
                });


                edit_class.CMShimi(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode, MarkList);
            }

            search_studenttxt.IsEnabled = true;
            students.IsEnabled = true;
            show_btn.IsEnabled = true;
            show_Click( true , e);
            list_mark.Visibility = Visibility.Visible;
            change_mark_stack.Visibility = Visibility.Hidden;
        }

        private void cancel_mark_Click(object sender, RoutedEventArgs e)
        {
            list_mark.Visibility = Visibility.Visible;
            change_mark_stack.Visibility = Visibility.Hidden;
        }
    }
}
