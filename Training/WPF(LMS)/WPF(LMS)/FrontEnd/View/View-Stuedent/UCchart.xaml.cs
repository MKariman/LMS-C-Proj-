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
        Search search = new Search();

        public UCchart()
        {
            InitializeComponent();
        }

        private void GridViewColumn_SourceUpdated(object sender, DataTransferEventArgs e)
        {

        }
    }
}
