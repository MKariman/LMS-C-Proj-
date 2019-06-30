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

namespace WPF_LMS_.FrontEnd.View.View_Stuedent
{
    /// <summary>
    /// Interaction logic for UCreport.xaml
    /// </summary>
    public partial class UCreport : UserControl
    {
        Sign_In sign_In = new Sign_In();
        Search search = new Search();
        List<marks> mark_show = new List<marks>();

        public UCreport()
        {
            InitializeComponent();
        }

        public class marks
        {
            public string Lesson { get; set; }
            public int? Mark { get; set; }
        }


        public void show_Reprt(int unicode , string pass)
        {
            list_mark.ItemsSource = null;
            mark_show.Clear();

            if (sign_In.STsign(unicode , pass).Major == "Mechanic")
            {
                mark_show.Add(new marks() { Lesson = "کنترل", Mark = search.MechMark(unicode)[0].MControl });
                mark_show.Add(new marks() { Lesson = "ماشین", Mark = search.MechMark(unicode)[0].MMashin });
                mark_show.Add(new marks() { Lesson = "سیالات", Mark = search.MechMark(unicode)[0].MSayalat });
                mark_show.Add(new marks() { Lesson = "ترمو", Mark = search.MechMark(unicode)[0].MTermo });
                mark_show.Add(new marks() { Lesson = "ریاضی 1", Mark = search.MechMark(unicode)[0].Riazi1 });
                mark_show.Add(new marks() { Lesson = "معادلات", Mark = search.MechMark(unicode)[0].Moadelat });
                mark_show.Add(new marks() { Lesson = "ادبیات", Mark = search.MechMark(unicode)[0].Adabiat });
                mark_show.Add(new marks() { Lesson = "اندیشه", Mark = search.MechMark(unicode)[0].Andishe });
                mark_show.Add(new marks() { Lesson = "فیزیک", Mark = search.MechMark(unicode)[0].MFizik });


                list_mark.ItemsSource = mark_show;
                Mid.Text = Convert.ToString(search.MechMark(unicode)[0].MechMId);

            }

            if (sign_In.STsign(unicode, pass).Major == "Computer")
            {
                mark_show.Add(new marks() { Lesson = "دیتابیس", Mark = search.CompMark(unicode)[0].CDatabase });
                mark_show.Add(new marks() { Lesson = "گسسته", Mark = search.CompMark(unicode)[0].CGosaste });
                mark_show.Add(new marks() { Lesson = "هوش مصنوعی", Mark = search.CompMark(unicode)[0].CInteligence });
                mark_show.Add(new marks() { Lesson = "برنامه نویسی", Mark = search.CompMark(unicode)[0].CProgramming });
                mark_show.Add(new marks() { Lesson = "ریاضی 1", Mark = search.CompMark(unicode)[0].Riazi1 });
                mark_show.Add(new marks() { Lesson = "معادلات", Mark = search.CompMark(unicode)[0].Moadelat });
                mark_show.Add(new marks() { Lesson = "ادبیات", Mark = search.CompMark(unicode)[0].Adabiat });
                mark_show.Add(new marks() { Lesson = "اندیشه", Mark = search.CompMark(unicode)[0].Andishe });
                mark_show.Add(new marks() { Lesson = "مدار منطقی", Mark = search.CompMark(unicode)[0].CManteqi });


                list_mark.ItemsSource = mark_show;

                Mid.Text = Convert.ToString(search.CompMark(unicode)[0].CompMId);

            }

            if (sign_In.STsign(unicode, pass).Major == "Barq")
            {
                mark_show.Add(new marks() { Lesson = "الکترونیک", Mark = search.BarqMark(unicode)[0].BElectro });
                mark_show.Add(new marks() { Lesson = "مدار الکتریکی", Mark = search.BarqMark(unicode)[0].BMadar });
                mark_show.Add(new marks() { Lesson = "قدرت", Mark = search.BarqMark(unicode)[0].BQodrat });
                mark_show.Add(new marks() { Lesson = "مخابرات", Mark = search.BarqMark(unicode)[0].BVLSI });
                mark_show.Add(new marks() { Lesson = "سیستم دیجیتال", Mark = search.BarqMark(unicode)[0].BCmos });
                mark_show.Add(new marks() { Lesson = "ریاضی 1", Mark = search.BarqMark(unicode)[0].Riazi1 });
                mark_show.Add(new marks() { Lesson = "معادلات", Mark = search.BarqMark(unicode)[0].Moadelat });
                mark_show.Add(new marks() { Lesson = "ادبیات", Mark = search.BarqMark(unicode)[0].Adabiat });
                mark_show.Add(new marks() { Lesson = "اندیشه", Mark = search.BarqMark(unicode)[0].Andishe });


                list_mark.ItemsSource = mark_show;
                Mid.Text = Convert.ToString(search.BarqMark(unicode)[0].BarqMId);


            }


            if (sign_In.STsign(unicode, pass).Major == "Omran")
            {
                mark_show.Add(new marks() { Lesson = "استاتیک", Mark = search.OmrMark(unicode)[0].OStatik });
                mark_show.Add(new marks() { Lesson = "نقشه برداری", Mark = search.OmrMark(unicode)[0].ONaqshe });
                mark_show.Add(new marks() { Lesson = "مصالح ساختمانی", Mark = search.OmrMark(unicode)[0].OMasaleh });
                mark_show.Add(new marks() { Lesson = "دینامیک", Mark = search.OmrMark(unicode)[0].ODinamik });
                mark_show.Add(new marks() { Lesson = "ریاضی 1", Mark = search.OmrMark(unicode)[0].Riazi1 });
                mark_show.Add(new marks() { Lesson = "معادلات", Mark = search.OmrMark(unicode)[0].Moadelat });
                mark_show.Add(new marks() { Lesson = "ادبیات", Mark = search.OmrMark(unicode)[0].Adabiat });
                mark_show.Add(new marks() { Lesson = "اندیشه", Mark = search.OmrMark(unicode)[0].Andishe });
                mark_show.Add(new marks() { Lesson = "بتن", Mark = search.OmrMark(unicode)[0].OBotons });


                list_mark.ItemsSource = mark_show;
                Mid.Text = Convert.ToString(search.OmrMark(unicode)[0].OmranMId);


            }


            if (sign_In.STsign(unicode, pass).Major == "Memari")
            {
                mark_show.Add(new marks() { Lesson = "کنترل", Mark = search.MeMark(unicode)[0].MeDekor });
                mark_show.Add(new marks() { Lesson = "ماشین", Mark = search.MeMark(unicode)[0].MeFazas });
                mark_show.Add(new marks() { Lesson = "سیالات", Mark = search.MeMark(unicode)[0].MeNama });
                mark_show.Add(new marks() { Lesson = "ترمو", Mark = search.MeMark(unicode)[0].MeTarahi });
                mark_show.Add(new marks() { Lesson = "ریاضی 1", Mark = search.MeMark(unicode)[0].Riazi1 });
                mark_show.Add(new marks() { Lesson = "معادلات", Mark = search.MeMark(unicode)[0].Moadelat });
                mark_show.Add(new marks() { Lesson = "ادبیات", Mark = search.MeMark(unicode)[0].Adabiat });
                mark_show.Add(new marks() { Lesson = "اندیشه", Mark = search.MeMark(unicode)[0].Andishe });


                list_mark.ItemsSource = mark_show;
                Mid.Text = Convert.ToString(search.MeMark(unicode)[0].MemMId);

            }


            if (sign_In.STsign(unicode, pass).Major == "Shimi")
            {
                mark_show.Add(new marks() { Lesson = "گاز", Mark = search.ShiMark(unicode)[0].SHGaz });
                mark_show.Add(new marks() { Lesson = "حرارت", Mark = search.ShiMark(unicode)[0].SHHararat });
                mark_show.Add(new marks() { Lesson = "جرم", Mark = search.ShiMark(unicode)[0].SHJerm });
                mark_show.Add(new marks() { Lesson = "مواد", Mark = search.ShiMark(unicode)[0].SHMavad });
                mark_show.Add(new marks() { Lesson = "ریاضی 1", Mark = search.ShiMark(unicode)[0].Riazi1 });
                mark_show.Add(new marks() { Lesson = "معادلات", Mark = search.ShiMark(unicode)[0].Moadelat });
                mark_show.Add(new marks() { Lesson = "ادبیات", Mark = search.ShiMark(unicode)[0].Adabiat });
                mark_show.Add(new marks() { Lesson = "اندیشه", Mark = search.ShiMark(unicode)[0].Andishe });
                mark_show.Add(new marks() { Lesson = "سینماتیک", Mark = search.ShiMark(unicode)[0].SHSinema });


                list_mark.ItemsSource = mark_show;
                Mid.Text = Convert.ToString(search.ShiMark(unicode)[0].ShimiMId);


            }
        }
    }
}
