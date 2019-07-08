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
using WPF_LMS_.FrontEnd.View.View_Manager;
using WPF_LMS_.FrontEnd.View.View_Stuedent;
using WPF_LMS_.FrontEnd.View.View_Teacher;
using WPF_LMS_.BackEnd;



namespace WPF_LMS_.FrontEnd.View.View_Manager
{
    /// <summary>
    /// Interaction logic for UCaddUser.xaml
    /// </summary>
    public partial class UCaddUser : UserControl
    {
        Sign_In sign_in = new Sign_In();
        UCinfomanager ucinfomanager = new UCinfomanager();
        UCinfostudent ucinfostudent = new UCinfostudent();
        UCinfoteacher ucimfoteacher = new UCinfoteacher();

        public UCaddUser()
        {
            InitializeComponent();
        }

        public void Enabled()
        {
            manager_btn.IsEnabled = true;
            teacher_btn.IsEnabled = true;
            student_btn.IsEnabled = true;
            Add_manager_stack.Visibility = Visibility.Hidden;
            Add_teacher_stack.Visibility = Visibility.Hidden;
            Add_student_stack.Visibility = Visibility.Hidden;
        }
        public void clear()
        {
            Mname.Text = "";
            Mfamilyname.Text = "";
            Mdate.Text = "";
            Meducation.Text = "";
            Memail.Text = "";
            Mmelli.Text = "";
            Mpost.Text = "";
            Mcode.Text = "";
            Mpass.Text = "";

            Tname.Text = "";
            Tfamilyname.Text = "";
            Tdate.Text = "";
            Teducation.Text = "";
            Temail.Text = "";
            Tmelli.Text = "";
            Tlesson.Text = "";
            Tcode.Text = "";
            Tpass.Text = "";
            Tphone.Text = "";

            Sname.Text = "";
            Sfamilyname.Text = "";
            Sdate.Text = "";
            Syear.Text = "";
            Semail.Text = "";
            Smelli.Text = "";
            Smajor.Text = "";
            Scode.Text = "";
            Spass.Text = "";
            Sphone.Text = "";

        }

        private void Manager_btn_Click(object sender, RoutedEventArgs e)
        {
            Enabled();
            clear();
            manager_btn.IsEnabled = false;
            Add_manager_stack.Visibility = Visibility.Visible;


        }

        private void Teacher_btn_Click(object sender, RoutedEventArgs e)
        {
            Enabled();
            clear();

            teacher_btn.IsEnabled = false;
            Add_teacher_stack.Visibility = Visibility.Visible;


        }

        private void Student_btn_Click(object sender, RoutedEventArgs e)
        {
            Enabled();
            clear();

            student_btn.IsEnabled = false;
            Add_student_stack.Visibility = Visibility.Visible;


        }

        private void Ok_manager_btn_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {


                List<Mg_Models> mg = new List<Mg_Models>();

                mg.Add(new Mg_Models
                {

                    Name = Mname.Text,
                    LastName = Mfamilyname.Text,
                    BirthDate = Int32.Parse(Mdate.Text),
                    Education = Meducation.Text,
                    Email = Memail.Text,
                    MeliCode = Int32.Parse(Mmelli.Text),
                    Post = Mpost.Text,
                    OrgCode = Int32.Parse(Mcode.Text),
                    Password = Mpass.Text,
                    Phone = Int32.Parse(Mphone.Text)

                });

                sign_in.RegMg(mg);

                MessageBox.Show("مدیر با موفقیت ذخیره شد", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                clear();

            }
            catch
            {
                MessageBox.Show("لطفا مجددا تلاش کنید", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Ok_teacher_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                List<Tch_Models> tch = new List<Tch_Models>();

                tch.Add(new Tch_Models
                {

                    Name =Tname.Text,
                    LastName =Tfamilyname.Text,
                    BirthDate = Int32.Parse(Tdate.Text),
                    Education = Teducation.Text,
                    Email = Temail.Text,
                    MeliCode = Int32.Parse(Tmelli.Text),
                    TeachingLesson = Tlesson.Text,
                    OrgCode = Int32.Parse(Tcode.Text),
                    Password = Tpass.Text ,
                    Phone = Int32.Parse(Tphone.Text)


                });

                sign_in.RegTch(tch);

                MessageBox.Show("استاد با موفقیت ذخیره شد", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                clear();

            }
            catch
            {
                MessageBox.Show("لطفا مجددا تلاش کنید", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    

        private void Ok_student_btn_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {


                List<St_Models> st = new List<St_Models>();

                st.Add(new St_Models
                {

                    Name = Sname.Text,
                    LastName = Sfamilyname.Text,
                    Birthdate = Int32.Parse(Sdate.Text),
                    UniLog = Int32.Parse(Syear.Text),
                    Email = Semail.Text,
                    MeliCode = Int32.Parse(Smelli.Text),
                    Major = Smajor.Text,
                    UniCode = Int32.Parse(Scode.Text),
                    Password = Spass.Text,
                    Phone = Int32.Parse(Sphone.Text)


                });

                sign_in.RegST(st);

                MessageBox.Show("دانشجو با موفقیت ذخیره شد", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                clear();

            }
            catch
            {
                MessageBox.Show("لطفا مجددا تلاش کنید", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
