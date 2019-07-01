using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_LMS_.BackEnd
{
    
    public class Edit
    {
     
        public void InfSt(List<St_Models> EIS)
        {
            using(DB_Proj db=new DB_Proj())
            {
                for(int j=0;j<EIS.Count();j++)
                {
                    var STI = db.St_InfM.Where(i => i.UniCode == EIS[j].UniCode).ToList();
                    STI[j].Name = EIS[j].Name;
                    STI[j].LastName = EIS[j].LastName;
                    STI[j].Major = EIS[j].Major;
                    STI[j].MeliCode = EIS[j].MeliCode;
                    STI[j].Password = EIS[j].Password;
                    STI[j].Phone = EIS[j].Phone;
                    STI[j].Age = EIS[j].Age;
                    STI[j].Birthdate = EIS[j].Birthdate;
                    STI[j].Email = EIS[j].Email;
                    STI[j].UniCode = EIS[j].UniCode;
                    STI[j].UniLog = EIS[j].UniLog;
                    STI[j].Vahedha = EIS[j].Vahedha;
                    db.SaveChanges();
                }
                

            }
        }

        public void InfTch(List<Tch_Models> EIS)
        {
            using (DB_Proj db = new DB_Proj())
            {
                for (int j = 0; j < EIS.Count(); j++)
                {
                    var STI = db.Tch_InfM.Where(i => i.OrgCode == EIS[j].OrgCode).ToList();
                    STI[j].Name = EIS[j].Name;
                    STI[j].LastName = EIS[j].LastName;
                    STI[j].MeliCode = EIS[j].MeliCode;
                    STI[j].Password = EIS[j].Password;
                    STI[j].Phone = EIS[j].Phone;
                    STI[j].Age = EIS[j].Age;
                    STI[j].BirthDate = EIS[j].BirthDate;
                    STI[j].Email = EIS[j].Email;
                    STI[j].OrgCode = EIS[j].OrgCode;
                    db.SaveChanges();
                }
            }
        }

        public void InfMg(List<Mg_Models> EIS)
        {
            using (DB_Proj db = new DB_Proj())
            {
                for (int j = 0; j < EIS.Count(); j++)
                {
                    var STI = db.Mg_InfM.Where(i => i.OrgCode == EIS[j].OrgCode).ToList();
                    STI[j].Name = EIS[j].Name;
                    STI[j].LastName = EIS[j].LastName;
                    STI[j].MeliCode = EIS[j].MeliCode;
                    STI[j].Password = EIS[j].Password;
                    STI[j].Phone = EIS[j].Phone;
                    STI[j].Age = EIS[j].Age;
                    STI[j].BirthDate = EIS[j].BirthDate;
                    STI[j].Email = EIS[j].Email;
                    STI[j].OrgCode = EIS[j].OrgCode;
                    db.SaveChanges();
                }
            }
        }




    }

}
