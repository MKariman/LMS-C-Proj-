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
using WPF_LMS_.FrontEnd.View.View_Stuedent;

namespace WPF_LMS_.FrontEnd.View.View_Manager
{
    /// <summary>
    /// Interaction logic for UCinfo_Allstudent.xaml
    /// </summary>
    public partial class UCinfo_Allstudent : UserControl
    {
        Search search = new Search();
        static List<string> student_listshow = new List<string>();
        UCinfostudent uinfostudent = new UCinfostudent();
        UCStudent ucstudent = new UCStudent();

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
                string s =  view.UniCode+"\t" + view.Name + " " + view.LastName ; 
                student_listshow.Add( Convert.ToString(s) );
            }

            student_listshow.Sort();

            list_students.ItemsSource = student_listshow;

        }

        private void Show_btn_Click(object sender, RoutedEventArgs e)
        {

            if (list_students.SelectedItem != null )
            {
                int selected = Int32.Parse(student_listshow[list_students.Items.IndexOf(list_students.SelectedItem)].Substring(0, 4));

                information.Visibility = Visibility.Visible;
                show_btn.Visibility = Visibility.Hidden;
                students.Visibility = Visibility.Hidden;
                infostudents_stack.Children.Clear();

                ucstudent.set_info(selected , search.STFilter(Convert.ToString(selected))[0].Password , uinfostudent);

                uinfostudent.Margin =new Thickness(-25,-25,0,0);
                uinfostudent.MaxHeight = 320;
                uinfostudent.MaxWidth = 820;
                infostudents_stack.Children.Add(uinfostudent);

            }
            else
            {
                MessageBox.Show("لطفا روی  یکی از دانشجویان کلیک کنید", "ERROR", MessageBoxButton.OK , MessageBoxImage.Error );


            }
        }
    }
}
