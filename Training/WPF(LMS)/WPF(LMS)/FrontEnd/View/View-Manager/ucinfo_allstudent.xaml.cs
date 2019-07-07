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
        Edit edit_st = new Edit();
        UCinfostudent uinfostudent = new UCinfostudent();
        UCStudent ucstudent = new UCStudent();

    

        public UCinfo_Allstudent()
        {
            InitializeComponent();
            information.Visibility = Visibility.Hidden;
        }

        

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            edit.Visibility = Visibility.Hidden;

            if (student_radio.IsChecked == true)
                {

                    list_users.ItemsSource = null;


                    Users.Visibility = Visibility.Visible;
                    show_btn.Visibility = Visibility.Visible;
                    information.Visibility = Visibility.Hidden;


                    list_users.ItemsSource = search.STFilter(search_userstxt.Text);


                    //CollectionView student_listshow_sort = (CollectionView)CollectionViewSource.GetDefaultView(list_users.ItemsSource);
                    //student_listshow_sort.SortDescriptions.Add(new SortDescription("UniCode", ListSortDirection.Ascending));


                }
                if (teacher_radio.IsChecked == true)
                {
                    list_users.ItemsSource = null;

                    Users.Visibility = Visibility.Visible;
                    show_btn.Visibility = Visibility.Visible;
                    information.Visibility = Visibility.Hidden;

                list_users.ItemsSource = search.TchFilter(search_userstxt.Text);

            }

            if (manager_radio.IsChecked == true)
                {
                    list_users.ItemsSource = null;

                    Users.Visibility = Visibility.Visible;
                    show_btn.Visibility = Visibility.Visible;
                    information.Visibility = Visibility.Hidden;

                list_users.ItemsSource = search.MgFilter(search_userstxt.Text);

            }




        }

        private void Show_btn_Click(object sender, RoutedEventArgs e)
        {
           

            if (list_users.SelectedItem != null )
            {
                edit.Visibility = Visibility.Visible;

                information.Visibility = Visibility.Visible;
                show_btn.Visibility = Visibility.Hidden;
                Users.Visibility = Visibility.Hidden;
                infousers_stack.Children.Clear();

                if(student_radio.IsChecked == true)
                {
                    ucstudent.set_info(search.STFilter(search_userstxt.Text)[list_users.Items.IndexOf(list_users.SelectedItem)].UniCode, search.STFilter(search_userstxt.Text)[list_users.Items.IndexOf(list_users.SelectedItem)].Password, uinfostudent);

                    uinfostudent.Margin = new Thickness(-35, -35, -35, 0);
                    uinfostudent.MaxHeight = 320;
                    uinfostudent.MaxWidth = 820;
                    infousers_stack.Children.Add(uinfostudent);
                }
                if(teacher_radio.IsChecked == true)
                {

                }

                if(manager_radio.IsChecked == true)
                {

                }
                
            }
            else
            {
                MessageBox.Show("لطفا روی  یکی از کاربران کلیک کنید", "ERROR", MessageBoxButton.OK , MessageBoxImage.Error );
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

            if (list_users.SelectedItem != null)
            {
                if (student_radio.IsChecked == true)
                {
                    uinfostudent.name.IsEnabled = true;
                    uinfostudent.familyname.IsEnabled = true;
                    uinfostudent.melli.IsEnabled = true;
                    uinfostudent.birth.IsEnabled = true;
                    uinfostudent.reshteh.IsEnabled = true;
                    uinfostudent.email.IsEnabled = true;
                    uinfostudent.unit.IsEnabled = true;
                    uinfostudent.code.IsEnabled = true;
                    uinfostudent.phone.IsEnabled = true;
                    uinfostudent.year.IsEnabled = true;

                    uinfostudent.name.BorderBrush = Brushes.Black;
                    uinfostudent.familyname.BorderBrush = Brushes.Black;
                    uinfostudent.melli.BorderBrush = Brushes.Black;
                    uinfostudent.birth.BorderBrush = Brushes.Black;
                    uinfostudent.reshteh.BorderBrush = Brushes.Black;
                    uinfostudent.email.BorderBrush = Brushes.Black;
                    uinfostudent.unit.BorderBrush = Brushes.Black;
                    uinfostudent.code.BorderBrush = Brushes.Black;
                    uinfostudent.phone.BorderBrush = Brushes.Black;
                    uinfostudent.year.BorderBrush = Brushes.Black;


                }

                if (teacher_radio.IsChecked == true)
                {
                }

                if (manager_radio.IsChecked == true)
                {
                }


                ok.Visibility = Visibility.Visible;
                chang_pass.Visibility = Visibility.Visible;
                edit.IsEnabled = false;
            }
            else
            {
                MessageBox.Show("لطفا روی  یکی از کاربران کلیک کنید", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            if (student_radio.IsChecked == true)
            {
                uinfostudent.name.IsEnabled = false;
                uinfostudent.familyname.IsEnabled = false;
                uinfostudent.melli.IsEnabled = false;
                uinfostudent.birth.IsEnabled = false;
                uinfostudent.reshteh.IsEnabled = false;
                uinfostudent.email.IsEnabled = false;
                uinfostudent.unit.IsEnabled = false;
                uinfostudent.code.IsEnabled = false;
                uinfostudent.phone.IsEnabled = false;
                uinfostudent.year.IsEnabled = false;

                uinfostudent.name.BorderBrush = null;
                uinfostudent.familyname.BorderBrush = null;
                uinfostudent.melli.BorderBrush = null;
                uinfostudent.birth.BorderBrush = null;
                uinfostudent.reshteh.BorderBrush = null;
                uinfostudent.email.BorderBrush = null;
                uinfostudent.unit.BorderBrush = null;
                uinfostudent.code.BorderBrush = null;
                uinfostudent.phone.BorderBrush = null;
                uinfostudent.year.BorderBrush = null;
            }

            if (teacher_radio.IsChecked == true)
            {
            }

            if (manager_radio.IsChecked == true)
            {
            }

            ok.Visibility = Visibility.Hidden;
            chang_pass.Visibility = Visibility.Hidden;
            edit.IsEnabled = true;

            List<St_Models> st = new List<St_Models>();
            st.Add(new St_Models
            {
                Name = uinfostudent.name.Text,
                LastName = uinfostudent.familyname.Text,
                Phone = Int32.Parse(uinfostudent.phone.Text) ,
                UniCode = Int32.Parse(uinfostudent.code.Text) ,
                Email  = uinfostudent.email.Text,
                Birthdate = Int32.Parse(uinfostudent.birth.Text),
                MeliCode = Int32.Parse(uinfostudent.melli.Text),
                Major = uinfostudent.reshteh.Text,
                Vahedha = Int32.Parse(uinfostudent.unit.Text),
                UniLog = Int32.Parse(uinfostudent.year.Text),
                Password = search.STFilter(search_userstxt.Text)[list_users.Items.IndexOf(list_users.SelectedItem)].Password ,
                AMarks = search.STFilter(search_userstxt.Text)[list_users.Items.IndexOf(list_users.SelectedItem)].AMarks

            });

            MessageBox.Show("اطلاعات با موفقیت ذخیره شد", "Information", MessageBoxButton.OK, MessageBoxImage.Information);


        }

        private void chang_pass_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
