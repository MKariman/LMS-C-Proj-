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

namespace WPF_LMS_.FrontEnd.View.View_Teacher
{
    /// <summary>
    /// Interaction logic for UCinfoteacher.xaml
    /// </summary>
    public partial class UCinfoteacher : UserControl
    {
        Sign_In sign_in = new Sign_In();

        public UCinfoteacher()
        {
            InitializeComponent();
        }

        public void set_info(int username, string password, UCinfoteacher uct)
        {

            uct.name.Text = sign_in.Tchsign(username, password).Name;
            uct.familyname.Text = sign_in.Tchsign(username, password).LastName;
            uct.melli.Text = Convert.ToString(sign_in.Tchsign(username, password).MeliCode);
            uct.birth.Text = Convert.ToString(sign_in.Tchsign(username, password).BirthDate);
            uct.phone.Text = Convert.ToString(sign_in.Tchsign(username, password).Phone);
            uct.email.Text = sign_in.Tchsign(username, password).Email;
            uct.code.Text = Convert.ToString(sign_in.Tchsign(username, password).OrgCode);
            uct.reshteh.Text = sign_in.Tchsign(username, password).TeachingLesson;
            uct.teach.Text = sign_in.Tchsign(username, password).Education;


        }
    }
}
