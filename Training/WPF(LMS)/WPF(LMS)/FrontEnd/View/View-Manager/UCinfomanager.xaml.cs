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

namespace WPF_LMS_.FrontEnd.View.View_Manager
{
    /// <summary>
    /// Interaction logic for UCinfomanager.xaml
    /// </summary>
    public partial class UCinfomanager : UserControl
    {

        public UCinfomanager()
        {
            InitializeComponent();

       
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            name.IsEnabled = true;
            familyname.IsEnabled = true;
            birth.IsEnabled = true;
            melli.IsEnabled = true;
            semat.IsEnabled = true;
            phone.IsEnabled = true;
            email.IsEnabled = true;
            teach.IsEnabled = true;
            code.IsEnabled = true;

            name.BorderBrush = Brushes.Black;
            familyname.BorderBrush = Brushes.Black;
            birth.BorderBrush = Brushes.Black;
            melli.BorderBrush = Brushes.Black;
            semat.BorderBrush = Brushes.Black;
            phone.BorderBrush = Brushes.Black;
            email.BorderBrush = Brushes.Black;
            teach.BorderBrush = Brushes.Black;
            code.BorderBrush = Brushes.Black;


            ok.Visibility = Visibility.Visible;
            edit.IsEnabled = false;
            
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            name.IsEnabled = false;
            familyname.IsEnabled = false;
            birth.IsEnabled = false;
            melli.IsEnabled = false;
            semat.IsEnabled = false;
            phone.IsEnabled = false;
            email.IsEnabled = false;
            teach.IsEnabled = false;
            code.IsEnabled = false;

            name.BorderBrush = null;
            familyname.BorderBrush = null;
            birth.BorderBrush = null;
            melli.BorderBrush = null;
            semat.BorderBrush = null;
            phone.BorderBrush = null;
            email.BorderBrush = null;
            teach.BorderBrush = null;
            code.BorderBrush = null;

            ok.Visibility = Visibility.Hidden;
            edit.IsEnabled = true;
        }
    }
}
