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
    /// Interaction logic for UCchart.xaml
    /// </summary>
    public partial class UCchart : UserControl
    {
        Sign_In sign_In = new Sign_In();
        Search search = new Search();

        public UCchart()
        {
            InitializeComponent();
        }

        public void chart(int unicode , string pass)
        {
            list_lessons_view.ItemsSource = search.AuChart(sign_In.STsign(unicode , pass).Major);
            list_lessons_view.SelectedItem = IsSealed;
        }
       
    }
}
