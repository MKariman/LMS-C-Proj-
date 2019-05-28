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
using WPF_LMS_.FrontEnd.View;
using WPF_LMS_.FrontEnd.View.View_Stuedent;
using WPF_LMS_.FrontEnd.View.View_Teacher;




namespace WPF_LMS_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public UCSign ucsign = new UCSign();
        public UCManager ucmanager= new UCManager();
        public UCStudent ucstudent = new UCStudent();
        public UCTeacher ucteacher = new UCTeacher();


        public MainWindow()
        {
            InitializeComponent();

            ucsign.MaxHeight = 350;
            ucsign.MaxWidth = 250;
            ucsign.Margin = new Thickness(0, 35, 0, 0);
            main_stack.Children.Add(ucsign);
           
        }

      
    }
}
