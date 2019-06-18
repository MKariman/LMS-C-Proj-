using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_LMS_.BackEnd
{
    public class Search
    {

        public List<St_Models> STsearch(string UCS)
        {
            using (var Db = new DB_Proj())
            {
                var login = (List<St_Models>)Db.St_InfM.Where(i => i.UniCode.ToString().StartsWith(UCS));
                return login;
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
    }
}
