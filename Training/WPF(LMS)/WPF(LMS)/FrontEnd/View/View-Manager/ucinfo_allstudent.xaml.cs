using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;using System.Threading.Tasks;
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
using WPF_LMS_.FrontEnd.View.View_Teacher;


namespace WPF_LMS_.FrontEnd.View.View_Manager
{
    /// <summary>
    /// Interaction logic for UCinfo_Allstudent.xaml
    /// </summary>
    public partial class UCinfo_Allstudent : UserControl
    {
        Search search = new Search();
        Edit edit_user = new Edit();
        UCinfostudent uinfostudent = new UCinfostudent();
        UCinfomanager uinfomanager = new UCinfomanager();
        UCinfoteacher uinfoteacher = new UCinfoteacher();

    

        public UCinfo_Allstudent()
        {
            InitializeComponent();
            information.Visibility = Visibility.Hidden;
        }

        

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            edit.Visibility = Visibility.Hidden;
            chang_pass.Visibility = Visibility.Hidden;


            if (student_radio.IsChecked == true)
                {
                list_students.Visibility = Visibility.Visible;
                list_users.Visibility = Visibility.Hidden;

                list_students.ItemsSource = null;


                    Users.Visibility = Visibility.Visible;
                    show_btn.Visibility = Visibility.Visible;
                    information.Visibility = Visibility.Hidden;


                list_students.ItemsSource = search.STFilter(search_userstxt.Text);


                //CollectionView student_listshow_sort = (CollectionView)CollectionViewSource.GetDefaultView(list_users.ItemsSource);
                //student_listshow_sort.SortDescriptions.Add(new SortDescription("UniCode", ListSortDirection.Ascending));


            }
            if (teacher_radio.IsChecked == true)
                {
                list_students.Visibility = Visibility.Hidden;
                list_users.Visibility = Visibility.Visible;

                list_users.ItemsSource = null;

                    Users.Visibility = Visibility.Visible;
                    show_btn.Visibility = Visibility.Visible;
                    information.Visibility = Visibility.Hidden;

                list_users.ItemsSource = search.TchFilter(search_userstxt.Text);

            }

            if (manager_radio.IsChecked == true)
                {
                list_students.Visibility = Visibility.Hidden;
                list_users.Visibility = Visibility.Visible;


                list_users.ItemsSource = null;

                    Users.Visibility = Visibility.Visible;
                    show_btn.Visibility = Visibility.Visible;
                    information.Visibility = Visibility.Hidden;

                list_users.ItemsSource = search.MgFilter(search_userstxt.Text);

            }




        }

        private void Show_btn_Click(object sender, RoutedEventArgs e)
        {


            if (list_students.SelectedItem != null && student_radio.IsChecked == true)
            {
                uinfostudent.change_pass.Visibility = Visibility.Hidden;
                edit.Visibility = Visibility.Visible;
                chang_pass.Visibility = Visibility.Visible;

                information.Visibility = Visibility.Visible;
                show_btn.Visibility = Visibility.Hidden;
                Users.Visibility = Visibility.Hidden;
                infousers_stack.Children.Clear();


                uinfostudent.set_info(search.STFilter(search_userstxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode, search.STFilter(search_userstxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].Password, uinfostudent);

                uinfostudent.Margin = new Thickness(-35, -35, -35, 0);
                uinfostudent.MaxHeight = 320;
                uinfostudent.MaxWidth = 820;

                infousers_stack.Children.Add(uinfostudent);


            }

            if (list_students.SelectedItem == null && student_radio.IsChecked == true)
            {
                MessageBox.Show("لطفا روی  یکی از دانشجویان کلیک کنید", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);

            }

            if (list_users.SelectedItem != null && teacher_radio.IsChecked == true || manager_radio.IsChecked == true)
            {
                edit.Visibility = Visibility.Visible;
                chang_pass.Visibility = Visibility.Visible;

                information.Visibility = Visibility.Visible;
                show_btn.Visibility = Visibility.Hidden;
                Users.Visibility = Visibility.Hidden;
                infousers_stack.Children.Clear();

                if (teacher_radio.IsChecked == true)
                {
                    uinfoteacher.set_info(search.TchFilter(search_userstxt.Text)[list_users.Items.IndexOf(list_users.SelectedItem)].OrgCode, search.TchFilter(search_userstxt.Text)[list_users.Items.IndexOf(list_users.SelectedItem)].Password, uinfoteacher);

                    uinfoteacher.Margin = new Thickness(-35, -35, -35, 0);
                    uinfoteacher.MaxHeight = 320;
                    uinfoteacher.MaxWidth = 820;
                    uinfoteacher.change_pass_btn.Visibility = Visibility.Hidden;


                    infousers_stack.Children.Add(uinfoteacher);
                }

                if (manager_radio.IsChecked == true)
                {

                    uinfomanager.set_info(search.MgFilter(search_userstxt.Text)[list_users.Items.IndexOf(list_users.SelectedItem)].OrgCode , search.MgFilter(search_userstxt.Text)[list_users.Items.IndexOf(list_users.SelectedItem)].Password, uinfomanager);

                    uinfomanager.Margin = new Thickness(-35, -35, -35, 0);
                    uinfomanager.MaxHeight = 320;
                    uinfomanager.MaxWidth = 820;
                    uinfomanager.change_pass.Visibility = Visibility.Hidden;
                    uinfomanager.edit.Visibility = Visibility.Hidden;


                    infousers_stack.Children.Add(uinfomanager);
                }

            }

            if (list_users.SelectedItem == null && teacher_radio.IsChecked == true || list_users.SelectedItem == null && manager_radio.IsChecked == true)
            {
                MessageBox.Show("لطفا روی  یکی از کاربران کلیک کنید", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {


            if (list_students.SelectedItem != null && student_radio.IsChecked == true)
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

                ok.Visibility = Visibility.Visible;
                chang_pass.Visibility = Visibility.Hidden;
                edit.Visibility = Visibility.Hidden;

            }

            if (list_students.SelectedItem == null && student_radio.IsChecked == true)
            {
                MessageBox.Show("لطفا روی  یکی از دانشجویان کلیک کنید", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);

            }

            if (list_users.SelectedItem != null && teacher_radio.IsChecked == true || manager_radio.IsChecked == true)
            {


                if (teacher_radio.IsChecked == true)
                {
                    uinfoteacher.name.IsEnabled = true;
                    uinfoteacher.familyname.IsEnabled = true;
                    uinfoteacher.melli.IsEnabled = true;
                    uinfoteacher.birth.IsEnabled = true;
                    uinfoteacher.reshteh.IsEnabled = true;
                    uinfoteacher.email.IsEnabled = true;
                    uinfoteacher.darajeh.IsEnabled = true;
                    uinfoteacher.code.IsEnabled = true;
                    uinfoteacher.phone.IsEnabled = true;
                    uinfoteacher.teach.IsEnabled = true;

                    uinfoteacher.name.BorderBrush = Brushes.Black;
                    uinfoteacher.familyname.BorderBrush = Brushes.Black;
                    uinfoteacher.melli.BorderBrush = Brushes.Black;
                    uinfoteacher.birth.BorderBrush = Brushes.Black;
                    uinfoteacher.reshteh.BorderBrush = Brushes.Black;
                    uinfoteacher.email.BorderBrush = Brushes.Black;
                    uinfoteacher.darajeh.BorderBrush = Brushes.Black;
                    uinfoteacher.code.BorderBrush = Brushes.Black;
                    uinfoteacher.phone.BorderBrush = Brushes.Black;
                    uinfoteacher.teach.BorderBrush = Brushes.Black;
                }

                if (manager_radio.IsChecked == true)
                {
                    uinfomanager.name.IsEnabled = true;
                    uinfomanager.familyname.IsEnabled = true;
                    uinfomanager.birth.IsEnabled = true;
                    uinfomanager.melli.IsEnabled = true;
                    uinfomanager.semat.IsEnabled = true;
                    uinfomanager.phone.IsEnabled = true;
                    uinfomanager.email.IsEnabled = true;
                    uinfomanager.teach.IsEnabled = true;
                    uinfomanager.code.IsEnabled = true;

                    uinfomanager.name.BorderBrush = Brushes.Black;
                    uinfomanager.familyname.BorderBrush = Brushes.Black;
                    uinfomanager.birth.BorderBrush = Brushes.Black;
                    uinfomanager.melli.BorderBrush = Brushes.Black;
                    uinfomanager.semat.BorderBrush = Brushes.Black;
                    uinfomanager.phone.BorderBrush = Brushes.Black;
                    uinfomanager.email.BorderBrush = Brushes.Black;
                    uinfomanager.teach.BorderBrush = Brushes.Black;
                    uinfomanager.code.BorderBrush = Brushes.Black;

                  
                }

                chang_pass.Visibility = Visibility.Hidden;
                edit.Visibility = Visibility.Hidden;
                ok.Visibility = Visibility.Visible;




            }

            if (list_users.SelectedItem == null && teacher_radio.IsChecked == true || list_users.SelectedItem == null && manager_radio.IsChecked == true)
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

                List<St_Models> st = new List<St_Models>();
                st.Add(new St_Models
                {
                    Name = uinfostudent.name.Text,
                    LastName = uinfostudent.familyname.Text,
                    Phone = Int32.Parse(uinfostudent.phone.Text),
                    UniCode = Int32.Parse(uinfostudent.code.Text),
                    Email = uinfostudent.email.Text,
                    Birthdate = Int32.Parse(uinfostudent.birth.Text),
                    MeliCode = Int32.Parse(uinfostudent.melli.Text),
                    Major = uinfostudent.reshteh.Text,
                    Vahedha = Int32.Parse(uinfostudent.unit.Text),
                    UniLog = Int32.Parse(uinfostudent.year.Text),
                    Password = search.STFilter(search_userstxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].Password,
                    AMarks = search.STFilter(search_userstxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].AMarks

                });

                edit_user.InfSt(st, search.STFilter(search_userstxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].UniCode);

            }

            if (teacher_radio.IsChecked == true)
            {
                uinfoteacher.name.IsEnabled = false;
                uinfoteacher.familyname.IsEnabled = false;
                uinfoteacher.birth.IsEnabled = false;
                uinfoteacher.melli.IsEnabled = false;
                uinfoteacher.darajeh.IsEnabled = false;
                uinfoteacher.phone.IsEnabled = false;
                uinfoteacher.email.IsEnabled = false;
                uinfoteacher.teach.IsEnabled = false;
                uinfoteacher.code.IsEnabled = false;
                uinfoteacher.reshteh.IsEnabled = false;


                uinfoteacher.name.BorderBrush = null;
                uinfoteacher.familyname.BorderBrush = null;
                uinfoteacher.birth.BorderBrush = null;
                uinfoteacher.melli.BorderBrush = null;
                uinfoteacher.darajeh.BorderBrush = null;
                uinfoteacher.phone.BorderBrush = null;
                uinfoteacher.email.BorderBrush = null;
                uinfoteacher.teach.BorderBrush = null;
                uinfoteacher.reshteh.BorderBrush = null;
                uinfoteacher.code.BorderBrush = null;


                List<Tch_Models> tch = new List<Tch_Models>();
                tch.Add(new Tch_Models
                {
                    Name = uinfoteacher.name.Text,
                    LastName = uinfoteacher.familyname.Text,
                    Phone = Int32.Parse(uinfoteacher.phone.Text),
                    OrgCode = Int32.Parse(uinfoteacher.code.Text),
                    BirthDate = Int32.Parse(uinfoteacher.birth.Text),
                    Email = uinfoteacher.email.Text,
                    MeliCode = Int32.Parse(uinfoteacher.melli.Text),
                    Password = search.TchFilter(search_userstxt.Text)[list_users.Items.IndexOf(list_users.SelectedItem)].Password ,
                    Education = uinfoteacher.teach.Text 

                });

                edit_user.InfTch(tch, Int32.Parse(uinfoteacher.code.Text));
            }

            if (manager_radio.IsChecked == true)
            {
                uinfomanager.name.IsEnabled = false;
                uinfomanager.familyname.IsEnabled = false;
                uinfomanager.birth.IsEnabled = false;
                uinfomanager.melli.IsEnabled = false;
                uinfomanager.semat.IsEnabled = false;
                uinfomanager.phone.IsEnabled = false;
                uinfomanager.email.IsEnabled = false;
                uinfomanager.teach.IsEnabled = false;
                uinfomanager.code.IsEnabled = false;

                uinfomanager.name.BorderBrush = null;
                uinfomanager.familyname.BorderBrush = null;
                uinfomanager.birth.BorderBrush = null;
                uinfomanager.melli.BorderBrush = null;
                uinfomanager.semat.BorderBrush = null;
                uinfomanager.phone.BorderBrush = null;
                uinfomanager.email.BorderBrush = null;
                uinfomanager.teach.BorderBrush = null;
                uinfomanager.code.BorderBrush = null;

             
                List<Mg_Models> mg = new List<Mg_Models>();
                mg.Add(new Mg_Models
                {
                    Name = uinfomanager.name.Text,
                    LastName = uinfomanager.familyname.Text,
                    Phone = Int32.Parse(uinfomanager.phone.Text),
                    OrgCode = Int32.Parse(uinfomanager.code.Text),
                    BirthDate = Int32.Parse(uinfomanager.birth.Text),
                    Email = uinfomanager.email.Text,
                    MeliCode = Int32.Parse(uinfomanager.melli.Text),
                    Password = search.MgFilter(search_userstxt.Text)[list_users.Items.IndexOf(list_users.SelectedItem)].Password ,
                    Post = uinfomanager.semat.Text ,
                    Education = uinfomanager.teach.Text

                });

                edit_user.InfMg(mg, Int32.Parse(uinfomanager.code.Text));
            }

            ok.Visibility = Visibility.Hidden;
            chang_pass.Visibility = Visibility.Visible;
            edit.Visibility = Visibility.Visible;


          

            MessageBox.Show("اطلاعات با موفقیت ذخیره شد", "Information", MessageBoxButton.OK, MessageBoxImage.Information);


        }

        private void chang_pass_Click(object sender, RoutedEventArgs e)
        {
            information.Visibility = Visibility.Hidden;
            pass_change.Visibility = Visibility.Visible;
            edit.Visibility = Visibility.Hidden;
            chang_pass.Visibility = Visibility.Hidden;

        }

        private void ok_pass_Click(object sender, RoutedEventArgs e)
        {

            if (student_radio.IsChecked == true)
            {
                if (prevpass.Password == search.STFilter(search_userstxt.Text)[list_students.Items.IndexOf(list_students.SelectedItem)].Password)
                {
                    if (pass1.Password == pass2.Password && pass1.Password != "")
                    {

                        edit_user.ChangePass(Int32.Parse(uinfostudent.code.Text), prevpass.Password, pass1.Password, "Student");


                        MessageBox.Show("رمز جدید با موفقیت ذخیره شد", "Information", MessageBoxButton.OK, MessageBoxImage.Information);

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

                        information.Visibility = Visibility.Visible;
                        pass_change.Visibility = Visibility.Hidden;
                        edit.Visibility = Visibility.Visible;
                        chang_pass.Visibility = Visibility.Visible;



                    }

                    else
                    {
                        MessageBox.Show("رمز جدید خود را صحیح وارد نمایید", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                        prevpass.Password = "";
                        pass1.Password = "";
                        pass2.Password = "";

                    }
                }
                else
                {
                    MessageBox.Show("رمز خود را صحیح وارد نمایید", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                    prevpass.Password = "";
                    pass1.Password = "";
                    pass2.Password = "";

                }

            }

            if(teacher_radio.IsChecked == true)
            {
                if (prevpass.Password == search.TchFilter(search_userstxt.Text)[list_users.Items.IndexOf(list_users.SelectedItem)].Password)
                {
                    if (pass1.Password == pass2.Password && pass1.Password != "")
                    {

                        edit_user.ChangePass(Int32.Parse(uinfoteacher.code.Text), prevpass.Password, pass1.Password, "Teacher");


                        MessageBox.Show("رمز جدید با موفقیت ذخیره شد", "Information", MessageBoxButton.OK, MessageBoxImage.Information);

                        uinfoteacher.name.IsEnabled = false;
                        uinfoteacher.familyname.IsEnabled = false;
                        uinfoteacher.birth.IsEnabled = false;
                        uinfoteacher.melli.IsEnabled = false;
                        uinfoteacher.darajeh.IsEnabled = false;
                        uinfoteacher.phone.IsEnabled = false;
                        uinfoteacher.email.IsEnabled = false;
                        uinfoteacher.teach.IsEnabled = false;
                        uinfoteacher.code.IsEnabled = false;
                        uinfoteacher.reshteh.IsEnabled = false;


                        uinfoteacher.name.BorderBrush = null;
                        uinfoteacher.familyname.BorderBrush = null;
                        uinfoteacher.birth.BorderBrush = null;
                        uinfoteacher.melli.BorderBrush = null;
                        uinfoteacher.darajeh.BorderBrush = null;
                        uinfoteacher.phone.BorderBrush = null;
                        uinfoteacher.email.BorderBrush = null;
                        uinfoteacher.teach.BorderBrush = null;
                        uinfoteacher.reshteh.BorderBrush = null;
                        uinfoteacher.code.BorderBrush = null;

                        information.Visibility = Visibility.Visible;
                        pass_change.Visibility = Visibility.Hidden;
                        edit.Visibility = Visibility.Visible;
                        chang_pass.Visibility = Visibility.Visible;

                    }
                    else
                    {
                        MessageBox.Show("رمز جدید خود را صحیح وارد نمایید", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                        prevpass.Password = "";
                        pass1.Password = "";
                        pass2.Password = "";

                    }
                }
                else
                {
                    MessageBox.Show("رمز خود را صحیح وارد نمایید", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                    prevpass.Password = "";
                    pass1.Password = "";
                    pass2.Password = "";

                }


            }



            if(manager_radio.IsChecked == true)
            {

                    if (prevpass.Password == search.MgFilter(search_userstxt.Text)[list_users.Items.IndexOf(list_users.SelectedItem)].Password)
                    {
                        if (pass1.Password == pass2.Password && pass1.Password != "")
                        {

                            edit_user.ChangePass(Int32.Parse(uinfomanager.code.Text), prevpass.Password, pass1.Password, "Manager");


                            MessageBox.Show("رمز جدید با موفقیت ذخیره شد", "Information", MessageBoxButton.OK, MessageBoxImage.Information);

                            uinfomanager.name.IsEnabled = false;
                            uinfomanager.familyname.IsEnabled = false;
                            uinfomanager.birth.IsEnabled = false;
                            uinfomanager.melli.IsEnabled = false;
                            uinfomanager.semat.IsEnabled = false;
                            uinfomanager.phone.IsEnabled = false;
                            uinfomanager.email.IsEnabled = false;
                            uinfomanager.teach.IsEnabled = false;
                            uinfomanager.code.IsEnabled = false;

                            uinfomanager.name.BorderBrush = null;
                            uinfomanager.familyname.BorderBrush = null;
                            uinfomanager.birth.BorderBrush = null;
                            uinfomanager.melli.BorderBrush = null;
                            uinfomanager.semat.BorderBrush = null;
                            uinfomanager.phone.BorderBrush = null;
                            uinfomanager.email.BorderBrush = null;
                            uinfomanager.teach.BorderBrush = null;
                            uinfomanager.code.BorderBrush = null;

                            information.Visibility = Visibility.Visible;
                            pass_change.Visibility = Visibility.Hidden;
                            edit.Visibility = Visibility.Visible;
                            chang_pass.Visibility = Visibility.Hidden;

                        }
                        else
                        {
                            MessageBox.Show("رمز جدید خود را صحیح وارد نمایید", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                            prevpass.Password = "";
                            pass1.Password = "";
                            pass2.Password = "";

                        }
                    }
                    else
                    {
                        MessageBox.Show("رمز خود را صحیح وارد نمایید", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                        prevpass.Password = "";
                        pass1.Password = "";
                        pass2.Password = "";

                    }

                    

            }
            

        }

        private void cancel_pass_Click(object sender, RoutedEventArgs e)
        {


            pass_change.Visibility = Visibility.Hidden;
            information.Visibility = Visibility.Visible;
            edit.Visibility = Visibility.Visible;
            chang_pass.Visibility = Visibility.Visible;

            prevpass.Password = "";
            pass1.Password = "";
            pass2.Password = "";

        }
    }
}
