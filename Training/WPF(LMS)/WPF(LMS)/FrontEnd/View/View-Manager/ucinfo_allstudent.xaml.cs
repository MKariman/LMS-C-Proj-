using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.ComponentModel;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_LMS_.BackEnd;
using WPF_LMS_.FrontEnd.View.View_Stuedent;

namespace WPF_LMS_.FrontEnd.View.View_Manager
{
    /// <summary>
    /// Interaction logic for UCinfo_Allstudent.xaml
    /// </summary>
    public partial class UCinfo_Allstudent : UserControl
    {
        Search search = new Search();
        static List<Students> student_listshow = new List<Students>();
        UCinfostudent uinfostudent = new UCinfostudent();
        UCStudent ucstudent = new UCStudent();

        public class Students
        {
            public int UniCode { get; set; }

            public string Name { get; set; }

            public string LastName { get; set; }
        }

        public UCinfo_Allstudent()
        {
            InitializeComponent();
            information.Visibility = Visibility.Hidden;
        }

        

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            list_students.ItemsSource = null;
            student_listshow.Clear();


            students.Visibility = Visibility.Visible;
            show_btn.Visibility = Visibility.Visible;
            information.Visibility = Visibility.Hidden;
        
            foreach (var view in search.STFilter(search_studenttxt.Text))
            {
                student_listshow.Add(new Students() { UniCode = view.UniCode , Name = view.Name , LastName = view.LastName }  );
            }

            

            list_students.ItemsSource = student_listshow;


           // CollectionView student_listshow_sort = (CollectionView)CollectionViewSource.GetDefaultView(list_students.ItemsSource);
          //  student_listshow_sort.SortDescriptions.Add(new SortDescription("UniCode", ListSortDirection.Ascending));


        }

        private void Show_btn_Click(object sender, RoutedEventArgs e)
        {

            if (list_students.SelectedItem != null )
            {
                int selected = student_listshow[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode;

                information.Visibility = Visibility.Visible;
                show_btn.Visibility = Visibility.Hidden;
                students.Visibility = Visibility.Hidden;
                infostudents_stack.Children.Clear();

                ucstudent.set_info(selected , search.STFilter(Convert.ToString(selected))[0].Password , uinfostudent);

                uinfostudent.Margin =new Thickness(-25,-25,0,0);
                uinfostudent.MaxHeight = 320;
                uinfostudent.MaxWidth = 820;
                

            }
            else
            {
                MessageBox.Show("لطفا روی  یکی از دانشجویان کلیک کنید", "ERROR", MessageBoxButton.OK , MessageBoxImage.Error );


            }
        }
    }
}
