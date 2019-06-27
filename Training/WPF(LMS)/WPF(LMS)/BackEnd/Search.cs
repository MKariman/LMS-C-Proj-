using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_LMS_.BackEnd
{
    public class Search
    {

        public List<St_Models> STFilter(string UCS)
        {
            using (var Db = new DB_Proj())
            {
                var login = Db.St_InfM.Where(i => i.UniCode.ToString().StartsWith(UCS));
                List<St_Models> SList = new List<St_Models>();
                foreach (var item in login)
                {
                    SList.Add(new St_Models
                    {
                        Name = item.Name,
                        UniCode = item.UniCode,
                        LastName = item.LastName,
                        Password = item.Password,
                        Major = item.Major

                    });
                }

                return SList;
            }
        }
        public Mg_Models MgSearch(int usern)
        {
            using (var Db = new DB_Proj())
            {
                var login = Db.Mg_InfM.Where
                (i => i.OrgCode == usern).FirstOrDefault();
                return login;
            }

        }
        public St_Models STSearch(int usern)
        {
            using (var Db = new DB_Proj())
            {
                var login = Db.St_InfM.Where
                (i => i.UniCode == usern).FirstOrDefault();
                return login;
            }
        }
        public Tch_Models TchSearch(int usern)
        {
            using (var Db = new DB_Proj())
            {
                var login = Db.Tch_InfM.Where
                (i => i.OrgCode == usern).FirstOrDefault();
                return login;
            }
        }

        public IQueryable<MajorsLessons> AuChart(string RMajor)
        {
            using(DB_Proj db=new DB_Proj())
            {
                var Chart = db.Lessons.Where(i => i.Major == RMajor);
                
                return Chart;
            }
            
        }
    }
}
