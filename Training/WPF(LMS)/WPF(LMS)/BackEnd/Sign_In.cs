using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_LMS_.BackEnd
{
    public class Sign_In
    {
        public Mg_Models Mgsign (int usern,string pass)
        {
            using (var Db = new DB_Proj())
            {
                var login = Db.Mg_InfM.Where
                (i => i.OrgCode == usern && i.Password == pass).FirstOrDefault();
                Db.SaveChanges();
                return login;
            }
                
        }
        public St_Models STsign(int usern, string pass)
        {
            using (var Db = new DB_Proj())
            {
                var login = Db.St_InfM.Where
                (i => i.UniCode == usern && i.Password == pass).FirstOrDefault();
                Db.SaveChanges();
                return login;
            }

        }
        public Tch_Models Tchsign(int usern, string pass)
        {
            using (var Db = new DB_Proj())
            {
                var login = Db.Tch_InfM.Where
                (i => i.OrgCode == usern && i.Password == pass).FirstOrDefault();
                Db.SaveChanges();
                return login;
            }

        }
        public void AddUser()
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
                        Db.St_InfM.Add(new St_Models { Name = Users[i], Password = (Users[i] + "123"), LastName = Users[j] + "i", UniLog = (62 + i), UniCode = ((62 + i) * 100 + i + j) });
                    }
                }


                Db.Mg_InfM.Add(new Mg_Models
                {
                    Name = "Mahdi",
                    LastName = "Kariman",
                    OrgCode = 97216,
                    Password = "mahdi123",
                    Age = 19,
                    BirthDate = 1378,
                    MeliCode = 00225,
                    Phone = 77950
                });

              

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Db.Tch_InfM.Add(new Tch_Models { Name = Users[i], Password = (Users[i] + "123"), LastName = Users[j] + "i",  OrgCode = ((62 + i) * 100 + i + j) });
                    }
                }

                Db.SaveChanges();
            }
        }
    }
}
