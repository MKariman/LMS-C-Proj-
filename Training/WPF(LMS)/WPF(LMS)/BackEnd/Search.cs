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

        public List<MajorsLessons> AuChart(string RMajor)
        {
            using(DB_Proj db=new DB_Proj())
            {
                var EkhChart = db.Lessons.Where(i => i.Major == RMajor);
                var OmChart = db.Lessons.Where(i => i.Major == "Omumi");
                var PaChart = db.Lessons.Where(i => i.Major == "Paye");
                List<MajorsLessons> MLPer = new List<MajorsLessons>();

               foreach(var item in EkhChart)
                {
                    MLPer.Add(new MajorsLessons
                    {
                        Lesson = item.Lesson,
                        Type = item.Type,
                        Unit = item.Unit

                    });

                }
               foreach(var item in OmChart)
                {
                    MLPer.Add(new MajorsLessons
                    {
                        Lesson = item.Lesson,
                        Type = item.Type,
                        Unit = item.Unit

                    });

                }
                if ((RMajor == "Computer")||(RMajor=="Barq")||(RMajor=="Omran")||(RMajor=="Mechanic")||(RMajor=="Shimi"))
                {
                    foreach (var item in PaChart)
                    {
                        MLPer.Add(new MajorsLessons
                        {
                            Lesson = item.Lesson,
                            Type = item.Type,
                            Unit = item.Unit

                        });

                    }

                }
                
                

                return MLPer;
            }
            
        }
        public void SMark(int STID)
        {
            using(DB_Proj db=new DB_Proj())
            {
                var STRow = db.St_InfM.Where(i=> i.UniCode==STID).FirstOrDefault();
                if (STRow.Major == "Computer")
                {
                    var MRow = db.CompD.Where(i => i.St_ModelsId == STRow.St_ModelsId).FirstOrDefault();
                    CompAdd(MRow);
                }
                else if (STRow.Major == "Barq")
                {
                    var MRow = db.BarqD.Where(i => i.St_ModelsId == STRow.St_ModelsId).FirstOrDefault();
                    BarqAdd(MRow);
                }
                else if (STRow.Major == "Omran")
                {
                    var MRow = db.OmranD.Where(i => i.St_ModelsId == STRow.St_ModelsId).FirstOrDefault();
                    OmrAdd(MRow);
                }
                else if (STRow.Major == "Shimi")
                {
                    var MRow = db.ShimiD.Where(i => i.St_ModelsId == STRow.St_ModelsId).FirstOrDefault();
                    ShiAdd(MRow);
                }
                else if (STRow.Major == "Mechanic")
                {
                    var MRow = db.MechD.Where(i => i.St_ModelsId == STRow.St_ModelsId).FirstOrDefault();
                    MechAdd(MRow);
                }
                else if (STRow.Major == "Memari")
                {
                    var MRow = db.MemD.Where(i => i.St_ModelsId == STRow.St_ModelsId).FirstOrDefault();
                    MeAdd(MRow);
                }
                
            }
        }

        public List<Marks.CompM> CompAdd(Marks.CompM MRow)
        {
            List<Marks.CompM> ComMark = new List<Marks.CompM>();
            ComMark.Add(new Marks.CompM
            {
                CManteqi = MRow.CManteqi,
                CDatabase = MRow.CDatabase,
                CGosaste = MRow.CGosaste,
                CInteligence = MRow.CInteligence,
                CProgramming = MRow.CProgramming,
                Riazi1 = MRow.Riazi1,
                Adabiat = MRow.Adabiat,
                Andishe = MRow.Andishe,
                Moadelat = MRow.Moadelat
            });
            return ComMark;
        }
        public List<Marks.BarqM> BarqAdd(Marks.BarqM MRow)
        {
            List<Marks.BarqM> BarqMark = new List<Marks.BarqM>();
            BarqMark.Add(new Marks.BarqM
            {
                BCmos= MRow.BCmos,
                BElectro = MRow.BElectro,
                BVLSI = MRow.BVLSI,
                BQodrat = MRow.BQodrat,
                BMadar = MRow.BMadar,
                Riazi1 = MRow.Riazi1,
                Adabiat = MRow.Adabiat,
                Andishe = MRow.Andishe,
                Moadelat = MRow.Moadelat
            });
            return BarqMark;
        }
        public List<Marks.OmranM> OmrAdd(Marks.OmranM MRow)
        {
            List<Marks.OmranM> OmrMark = new List<Marks.OmranM>();
            OmrMark.Add(new Marks.OmranM
            {
                OBotons = MRow.OBotons,
                ODinamik = MRow.ODinamik,
                OMasaleh = MRow.OMasaleh,
                ONaqshe = MRow.ONaqshe,
                OStatik = MRow.OStatik,
                Riazi1 = MRow.Riazi1,
                Adabiat = MRow.Adabiat,
                Andishe = MRow.Andishe,
                Moadelat = MRow.Moadelat
            });
            return OmrMark;
        }
        public List<Marks.ShimiM> ShiAdd(Marks.ShimiM MRow)
        {
            List<Marks.ShimiM> ShiMark = new List<Marks.ShimiM>();
            ShiMark.Add(new Marks.ShimiM
            {
                SHGaz = MRow.SHGaz,
                SHHararat = MRow.SHHararat,
                SHJerm = MRow.SHJerm,
                SHMavad = MRow.SHMavad,
                SHSinema = MRow.SHSinema,
                Riazi1 = MRow.Riazi1,
                Adabiat = MRow.Adabiat,
                Andishe = MRow.Andishe,
                Moadelat = MRow.Moadelat
            });
            return ShiMark;
        }
        public List<Marks.MechM> MechAdd(Marks.MechM MRow)
        {
            List<Marks.MechM> MechMark = new List<Marks.MechM>();
            MechMark.Add(new Marks.MechM
            {
                MControl = MRow.MControl,
                MFizik = MRow.MFizik,
                MMashin = MRow.MMashin,
                MSayalat = MRow.MSayalat,
                MTermo = MRow.MTermo,
                Riazi1 = MRow.Riazi1,
                Adabiat = MRow.Adabiat,
                Andishe = MRow.Andishe,
                Moadelat = MRow.Moadelat
            });
            return MechMark;
        }
        public List<Marks.MemM> MeAdd(Marks.MemM MRow)
        {
            List<Marks.MemM> MeMark = new List<Marks.MemM>();
            MeMark.Add(new Marks.MemM
            {
                MeDekor = MRow.MeDekor,
                MeFazas = MRow.MeFazas,
                MeNama = MRow.MeNama,
                MeNaqshe = MRow.MeNaqshe,
                MeTarahi = MRow.MeTarahi,
                Adabiat = MRow.Adabiat,
                Andishe = MRow.Andishe
            });
            return MeMark;
        }
      



    }
}
