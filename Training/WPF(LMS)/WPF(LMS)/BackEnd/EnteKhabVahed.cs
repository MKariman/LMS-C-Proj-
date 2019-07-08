using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_LMS_.BackEnd
{
    public class EnteKhabVahed
    {
        public List<string> NullLessons(int UC,string Maj)
        {
            List<string> NuLLess = new List<string>();

            using (DB_Proj db=new DB_Proj())
            {
                var StInfo= db.St_InfM.Where(a => a.UniCode == UC).FirstOrDefault();

                  var ab = StInfo.GetType().GetProperties().Where(a => a.GetValue(StInfo) == null).Select(b=>b.Name).ToList();
                
                for (int i=0;i<ab.Count();i++)
                {
                    NuLLess.Add(ab[i]);

                }

                return NuLLess;
            }
        }
    }
}
