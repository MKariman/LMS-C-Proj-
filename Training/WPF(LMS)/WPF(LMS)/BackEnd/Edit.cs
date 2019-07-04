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

       // public string ChangeMark(int UCode,string Maj,List)


        public void CMComp(int UCode, List<Marks.CompM> MarkList)
        {
            using(DB_Proj db=new DB_Proj())
            {
                int STID =(from item in db.St_InfM where item.UniCode == UCode select item.St_ModelsId).FirstOrDefault();
                var ST = db.CompD.Where(i => i.St_ModelsId == STID).FirstOrDefault();
                ST.Adabiat = MarkList[0].Adabiat;
                ST.Andishe = MarkList[0].Andishe;
                ST.CDatabase = MarkList[0].CDatabase;
                ST.CGosaste = MarkList[0].CGosaste;
                ST.CInteligence = MarkList[0].CInteligence;
                ST.CManteqi = MarkList[0].CManteqi;
                ST.CProgramming = MarkList[0].CProgramming;
                ST.Moadelat = MarkList[0].Moadelat;
                ST.Riazi1 = MarkList[0].Riazi1;
                db.SaveChanges();

            }
        }
        public void CMOmran(int UCode, List<Marks.OmranM> MarkList)
        {
            using (DB_Proj db = new DB_Proj())
            {
                int STID = (from item in db.St_InfM where item.UniCode == UCode select item.St_ModelsId).FirstOrDefault();
                var ST = db.OmranD.Where(i => i.St_ModelsId == STID).FirstOrDefault();
                ST.Adabiat = MarkList[0].Adabiat;
                ST.Andishe = MarkList[0].Andishe;
                ST.Moadelat = MarkList[0].Moadelat;
                ST.OBotons = MarkList[0].OBotons;
                ST.ODinamik = MarkList[0].ODinamik;
                ST.OMasaleh = MarkList[0].OMasaleh;
                ST.ONaqshe = MarkList[0].ONaqshe;
                ST.OStatik = MarkList[0].OStatik;
                ST.Riazi1 = MarkList[0].Riazi1;
                db.SaveChanges();

            }
        }
        public void CMBarq(int UCode, List<Marks.BarqM> MarkList)
        {
            using (DB_Proj db = new DB_Proj())
            {
                int STID = (from item in db.St_InfM where item.UniCode == UCode select item.St_ModelsId).FirstOrDefault();
                var ST = db.BarqD.Where(i => i.St_ModelsId == STID).FirstOrDefault();
                ST.Adabiat = MarkList[0].Adabiat;
                ST.Andishe = MarkList[0].Andishe;
                ST.Moadelat = MarkList[0].Moadelat;
                ST.BCmos = MarkList[0].BCmos;
                ST.BElectro = MarkList[0].BElectro;
                ST.BMadar = MarkList[0].BMadar;
                ST.BQodrat = MarkList[0].BQodrat;
                ST.BVLSI = MarkList[0].BVLSI;
                ST.Riazi1 = MarkList[0].Riazi1;
                db.SaveChanges();

            }
        }
        public void CMMech(int UCode, List<Marks.MechM> MarkList)
        {
            using (DB_Proj db = new DB_Proj())
            {
                int STID = (from item in db.St_InfM where item.UniCode == UCode select item.St_ModelsId).FirstOrDefault();
                var ST = db.MechD.Where(i => i.St_ModelsId == STID).FirstOrDefault();
                ST.Adabiat = MarkList[0].Adabiat;
                ST.Andishe = MarkList[0].Andishe;
                ST.Moadelat = MarkList[0].Moadelat;
                ST.MControl = MarkList[0].MControl;
                ST.MFizik = MarkList[0].MFizik;
                ST.MMashin = MarkList[0].MMashin;
                ST.MSayalat = MarkList[0].MSayalat;
                ST.MTermo = MarkList[0].MTermo;
                ST.Riazi1 = MarkList[0].Riazi1;
                db.SaveChanges();

            }
        }
        public void CMShimi(int UCode, List<Marks.ShimiM> MarkList)
        {
            using (DB_Proj db = new DB_Proj())
            {
                int STID = (from item in db.St_InfM where item.UniCode == UCode select item.St_ModelsId).FirstOrDefault();
                var ST = db.ShimiD.Where(i => i.St_ModelsId == STID).FirstOrDefault();
                ST.Adabiat = MarkList[0].Adabiat;
                ST.Andishe = MarkList[0].Andishe;
                ST.Moadelat = MarkList[0].Moadelat;
                ST.SHGaz = MarkList[0].SHGaz;
                ST.SHHararat = MarkList[0].SHHararat;
                ST.SHJerm = MarkList[0].SHJerm;
                ST.SHMavad = MarkList[0].SHMavad ;
                ST.SHSinema = MarkList[0].SHSinema;
                ST.Riazi1 = MarkList[0].Riazi1;
                db.SaveChanges();

            }
        }
        public void CMMemari(int UCode, List<Marks.MemM> MarkList)
        {
            using (DB_Proj db = new DB_Proj())
            {
                int STID = (from item in db.St_InfM where item.UniCode == UCode select item.St_ModelsId).FirstOrDefault();
                var ST = db.MemD.Where(i => i.St_ModelsId == STID).FirstOrDefault();
                ST.Adabiat = MarkList[0].Adabiat;
                ST.Andishe = MarkList[0].Andishe;
                ST.Moadelat = MarkList[0].Moadelat;
                ST.MeDekor = MarkList[0].MeDekor;
                ST.MeFazas = MarkList[0].MeFazas;
                ST.MeNama = MarkList[0].MeNama;
                ST.MeNaqshe = MarkList[0].MeNaqshe;
                ST.MeTarahi = MarkList[0].MeTarahi;
                ST.Riazi1 = MarkList[0].Riazi1;
                db.SaveChanges();
            }
        }

        public string ChangePass(int Code,string OPass,string NPass,string Who)
        {
            using (DB_Proj db =new DB_Proj())
            {
                if (Who == "Student")
                {
                    var ST=db.St_InfM.Where(i => i.UniCode == Code).FirstOrDefault();
                    if (ST.Password == OPass)
                    {
                        ST.Password = NPass;
                        db.SaveChanges();
                        return "Seuccess";
                    }
                    else
                    {
                        return "PassWrong";
                    }
                }
                if (Who == "Manager")
                {
                    var Mg = db.Mg_InfM.Where(i => i.OrgCode == Code).FirstOrDefault();
                    if (Mg.Password == OPass)
                    {
                        Mg.Password = NPass;
                        db.SaveChanges();
                        return "Seuccess";
                    }
                    else
                    {
                        return "PassWrong";
                    }
                }
                if (Who == "Teacher")
                {
                    var Tch = db.Tch_InfM.Where(i => i.OrgCode == Code).FirstOrDefault();
                    if (Tch.Password == OPass)
                    {
                        Tch.Password = NPass;
                        db.SaveChanges();
                        return "Seuccess";
                    }
                    else
                    {
                        return "PassWrong";
                    }
                }
                return "CodeWrong";

            }
        }





    }

}
