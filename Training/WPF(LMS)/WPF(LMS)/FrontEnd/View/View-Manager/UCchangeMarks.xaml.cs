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
    /// Interaction logic for UCchangeMarks.xaml
    /// </summary>
    public partial class UCchangeMarks : UserControl
    {
        Search search = new Search();

        public UCchangeMarks()
        {
            InitializeComponent();
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
            

            if (list_students.SelectedItem != null)
            {
                //information.Visibility = Visibility.Visible;
                //show_btn.Visibility = Visibility.Hidden;
                //students.Visibility = Visibility.Hidden;
                //infostudents_stack.Children.Clear();

                //ucstudent.set_info(search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode, search.STFilter(search_studenttxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].Password, uinfostudent);

                //uinfostudent.Margin = new Thickness(-25, -25, 0, 0);
                //uinfostudent.MaxHeight = 320;
                //uinfostudent.MaxWidth = 820;

                //infostudents_stack.Children.Add(uinfostudent);
            }
            else
            {
                MessageBox.Show("لطفا روی  یکی از دانشجویان کلیک کنید", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);


            }
        }
    }
}
