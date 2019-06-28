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
using WPF_LMS_.BackEnd;


namespace WPF_LMS_.FrontEnd.View
{
    /// <summary>
    /// Interaction logic for UCManager.xaml
    /// </summary>
    public partial class UCManager : UserControl
    {
        UCmajorlessons ucmajorlessons = new UCmajorlessons();
        UCinfomanager ucinfomanager = new UCinfomanager();
        UCinfo_Allstudent ucinfo_allstudent = new UCinfo_Allstudent(); 
        Sign_In sign_in = new Sign_In();


        public UCManager()
        {
            InitializeComponent();
        }

        


        public void delet_prev()
        {
            manager_stack.Children.Clear();
        }


        public void set_info(int username , string password)
        {

            ucinfomanager.name.Text = sign_in.Mgsign( username , password ).Name;
            ucinfomanager.familyname.Text = sign_in.Mgsign(username, password).LastName;
            ucinfomanager.melli.Text = Convert.ToString(sign_in.Mgsign(username, password).MeliCode);
            ucinfomanager.birth.Text = Convert.ToString(sign_in.Mgsign(username, password).BirthDate);
            ucinfomanager.phone.Text = Convert.ToString(sign_in.Mgsign(username, password).Phone);
            ucinfomanager.email.Text = sign_in.Mgsign(username, password).Email;
            ucinfomanager.code.Text =  Convert.ToString(sign_in.Mgsign(username, password).OrgCode);
        }



        private void info_manager_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = (MainWindow)Window.GetWindow(this);

            delet_prev();
            set_info( Convert.ToInt32(win.ucsign.usernametxt.Text) , win.ucsign.passwordtxt.Password);

            ucinfomanager.MaxHeight = 315;
            ucinfomanager.MaxWidth = 800;
;           manager_stack.Children.Add(ucinfomanager);
        }

        private void info_students_Click(object sender, RoutedEventArgs e)
        {
            delet_prev();

            ucinfomanager.MaxHeight = 315;
            ucinfomanager.MaxWidth = 800;
            manager_stack.Children.Add(ucinfo_allstudent);
        }

        private void list_major_Click(object sender, RoutedEventArgs e)
        {
            delet_prev();
            manager_stack.Children.Add(ucmajorlessons);
        }

        private void see_marks_Click(object sender, RoutedEventArgs e)
        {
            delet_prev();
        }

        private void change_marks_Click(object sender, RoutedEventArgs e)
        {
            delet_prev();
        }

        private void list_marks_student_Click(object sender, RoutedEventArgs e)
        {
            delet_prev();
        }

        private void select_unit_Click(object sender, RoutedEventArgs e)
        {
            delet_prev();
        }

        private void add_remove_Click(object sender, RoutedEventArgs e)
        {
            delet_prev();
        }

        private void add_user_Click(object sender, RoutedEventArgs e)
        {
            delet_prev();
        }


        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win_prev= (MainWindow)Window.GetWindow(this);
            MainWindow win_nex = new MainWindow();
            win_prev.Close();
            win_nex.ShowDialog();
        }
    }
}
