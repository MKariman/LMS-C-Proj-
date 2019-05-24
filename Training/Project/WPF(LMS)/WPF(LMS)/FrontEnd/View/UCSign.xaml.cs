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

namespace WPF_LMS_.FrontEnd.View
{
    /// <summary>
    /// Interaction logic for UCSign.xaml
    /// </summary>
    public partial class UCSign : UserControl
    {
        public UCSign()
        {
            InitializeComponent();
        }

     

        private void Sign_Click(object sender, RoutedEventArgs e)
        {
            using (var Db = new DB_Proj())
            {
                if (RBuser.IsChecked == true)
                {
                    var logs = Db.St_InfM.Where
                        (i => i.UniCode == (Convert.ToInt16(usernametxt.Text)) && i.Password == (passwordtxt.Password)).FirstOrDefault();
                    
                    if (logs!=null)
                    {

                    
                       MessageBox.Show("شما با موفقیت وارد شدید", "Sign in", MessageBoxButton.OK, MessageBoxImage.Information);

                    }
                    
                   
                    else
                    {
                        var logt = Db.Tch_InfM.Where
                       (i => i.OrgCode == (Convert.ToInt16(usernametxt.Text)) && i.Password == (passwordtxt.Password)).FirstOrDefault();

                        if (logt != null)
                        {
                            MessageBox.Show("شما با موفقیت وارد شدید", "خوش آمدید", MessageBoxButton.OK, MessageBoxImage.Information);

                        }
                        else
                        {
                            MessageBox.Show("نام کاربری یا رمز عبور اشتباه است", "خطا", MessageBoxButton.OK, MessageBoxImage.Error);
                            usernametxt.Text = "";
                            passwordtxt.Password = "";
                        }
                    }
                }

                else if (RBManager.IsChecked == true)
                {
                    var logm = Db.Mg_InfM.Where
                                            (i => i.OrgCode == Convert.ToInt16(usernametxt.Text) && i.Password == passwordtxt.Password).FirstOrDefault();
                    if (logm != null)
                    {
                        MessageBox.Show("شما با موفقیت وارد شدید", "Sign in", MessageBoxButton.OK, MessageBoxImage.Information);

                    }
                    else
                    {
                        MessageBox.Show("ERROR !", "Sign in", MessageBoxButton.OK, MessageBoxImage.Error);
                        usernametxt.Text = "";
                        passwordtxt.Password = "";
                    }
                }
                Db.SaveChanges();
            }
        }

      
        private void user_click(object sender, RoutedEventArgs e)
        {
            using (var Db = new DB_Proj())
            {
                List<string> Users = new List<string>()
                {"mohammad","mohsen","hossein","ahmad","soheil","babak","ramin","amin","rahim","amir","asqar",
                "akbar","armin","iman","erfan","reza","nima","saeid","saber","masoud","karim","baqer","naeim","jalil",
                "jalal","aziz","saman","navid","vahid","farid","hamid","hamed","sajad","mahmud","sattar"
                };
                for (int i = 0; i < Users.Count; i++)
                {
                    for (int j = 0; j < Users.Count; j++)
                    {
                        Db.St_InfM.Add(new St_Models { Name = Users[i], Password = (Users[i] + "123"), LastName = Users[j], UniLog = (62 + i), UniCode = ((62 + i) * 100 + i + j) });
                    }
                }
                Db.SaveChanges();
            }
        }
    }
}
