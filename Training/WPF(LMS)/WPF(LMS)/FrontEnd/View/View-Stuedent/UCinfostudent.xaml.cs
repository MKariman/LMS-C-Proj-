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

namespace WPF_LMS_.FrontEnd.View.View_Stuedent
{
    /// <summary>
    /// Interaction logic for UCinfostudent.xaml
    /// </summary>
    public partial class UCinfostudent : UserControl
    {
        Sign_In sign_in = new Sign_In();

        public UCinfostudent()
        {
            InitializeComponent();
        }
        public void set_info(int username, string password, UCinfostudent ucs)
        {

            ucs.name.Text = sign_in.STsign(username, password).Name;
            ucs.familyname.Text = sign_in.STsign(username, password).LastName;
            ucs.melli.Text = Convert.ToString(sign_in.STsign(username, password).MeliCode);
            ucs.birth.Text = Convert.ToString(sign_in.STsign(username, password).Birthdate);
            ucs.phone.Text = Convert.ToString(sign_in.STsign(username, password).Phone);
            ucs.email.Text = sign_in.STsign(username, password).Email;
            ucs.code.Text = Convert.ToString(sign_in.STsign(username, password).UniCode);
            ucs.year.Text = Convert.ToString(sign_in.STsign(username, password).UniLog);
            ucs.unit.Text = Convert.ToString(sign_in.STsign(username, password).Vahedha);
            ucs.reshteh.Text = sign_in.STsign(username, password).Major;
        }
    }
}
