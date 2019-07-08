using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_LMS_.FrontEnd.View.View_Manager;
using WPF_LMS_.BackEnd.Marks;

namespace WPF_LMS_.BackEnd
{
       public class Sign_In
    {
        string[] Lessons = new string[] {
            "Database","Gosaste","Inteligence","Manteqi","Programming",
            "Madar","VLSI","Cmos","Electronic","Qodrat",
            "BotonSazi","Dinamik","Masaleh","Statik","NaqsheBardari",
            "Fizik","Control","Mashin","Sayalat","Termo",
            "Gaz","Jerm","Mavad","Sinematik","Hararat",
            "Dekor","Fazasazi","Tarahi","Nama","Naqshe",
            "Andishe","Adabiat","Riazi","Moadelat" };

        public Mg_Models Mgsign (int usern,string pass)
        {
            using (var Db = new DB_Proj())
            {
                var login = Db.Mg_InfM.Where
                (i => i.OrgCode == usern && i.Password == pass).FirstOrDefault();
                return login;
            }
                
        }

        public St_Models STsign(int usern, string pass)
        {
            using (var Db = new DB_Proj())
            {
                var login = Db.St_InfM.Where
                (i => i.UniCode == usern && i.Password == pass).FirstOrDefault();
                return login;
            }
        }
        public Tch_Models Tchsign(int usern, string pass)
        {
            using (var Db = new DB_Proj())
            {
                var login = Db.Tch_InfM.Where
                (i => i.OrgCode == usern && i.Password == pass).FirstOrDefault();
                return login;
            }
        }


        public void RegST(List<St_Models> UReg)
        {
            using (DB_Proj db = new DB_Proj())
            {
                db.St_InfM.AddRange(UReg);
                db.SaveChanges();

            }
        }
        public void RegTch(List<Tch_Models> UReg)
        {
            using (DB_Proj db = new DB_Proj())
            {
                db.Tch_InfM.AddRange(UReg);
                db.SaveChanges();

            }
        }
        public void RegMg(List<Mg_Models> UReg)
        {
            using (DB_Proj db = new DB_Proj())
            {
                db.Mg_InfM.AddRange(UReg);
                db.SaveChanges();

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
                string[] Major = new string[] { "Computer", "Barq", "Omran", "Mechanic", "Memari", "Shimi" };
                int CN = 1, ON = 1, MN = 1, MeN = 1, ShN = 1, BN = 1;
                int[] arrn = new int[] { 20, 5, 17, 4, 19, 13, 7, 18, 2, 6, 14, 11, 8 };
                for (int i = 0; i < Users.Count; i++)
                {
                    
                    for (int j = 0; j < Users.Count; j++)
                    {
                        string reshte = Major[j % 6];
                        if(reshte=="Computer")
                        {
                            Db.St_InfM.Add(new St_Models
                            {
                                Name = Users[i],
                                Password = (Users[i] + "123"),
                                LastName = Users[j] + "i",
                                UniLog = (62 + i),
                                UniCode = ((62 + i) * 100 + i + j),
                                Email = "@gmail.com",
                                Birthdate = 1398 - (62 + i),
                                Major = "Computer",
                                Phone = 021,

                                MeliCode = 0022,
                                Vahedha = 0,
                                AMarks = new List<AllMarks>
                                {
                                    new CompM
                                    {
                                        Riazi1=arrn[i%13],
                                        Adabiat=arrn[(i*7)%13],
                                        Andishe=arrn[(i+3)%13],
                                        Moadelat=arrn[(3*i+1)%13],
                                        Major=reshte,
                                        CompMId=CN
                                    }

                                },

                            });
                            CN++;
                        }
                        else if (reshte == "Omran")
                        {
                            Db.St_InfM.Add(new St_Models
                            {
                                Name = Users[i],
                                Password = (Users[i] + "123"),
                                LastName = Users[j] + "i",
                                UniLog = (62 + i),
                                UniCode = ((62 + i) * 100 + i + j),
                                Email = "@gmail.com",
                                Birthdate = 1398 - (62 + i),
                                Major = "Omran",
                                Phone = 021,
                                MeliCode = 0022,
                                Vahedha = 0,
                                AMarks = new List<AllMarks>
                                {
                                    new OmranM
                                    {
                                        Riazi1=arrn[(3*i+1)%13],
                                        Adabiat=arrn[(i*7)%13],
                                        Andishe=arrn[(i+3)%13],
                                        Moadelat=arrn[i%13],
                                        Major=reshte,
                                        OmranMId=ON
                                    }

                                },

                            });
                            ON++;
                        }
                        else if (reshte == "Barq")
                        {
                            Db.St_InfM.Add(new St_Models
                            {
                                Name = Users[i],
                                Password = (Users[i] + "123"),
                                LastName = Users[j] + "i",
                                UniLog = (62 + i),
                                UniCode = ((62 + i) * 100 + i + j),
                                Email = "@gmail.com",
                                Birthdate = 1398 - (62 + i),
                                Major = "Barq",
                                Phone = 021,

                                MeliCode = 0022,
                                Vahedha = 0,
                                AMarks = new List<AllMarks>
                                {
                                    new BarqM
                                    {
                                          Riazi1=arrn[(i+1)%13],
                                        Adabiat=arrn[(i+9)%13],
                                        Andishe=arrn[(3*i)%13],
                                        Moadelat=arrn[(i*4)%13],
                                        Major=reshte,
                                        BarqMId=BN
                                    }

                                },

                            });
                            BN++;
                        }
                        else if (reshte == "Memari")
                        {
                            Db.St_InfM.Add(new St_Models
                            {
                                Name = Users[i],
                                Password = (Users[i] + "123"),
                                LastName = Users[j] + "i",
                                UniLog = (62 + i),
                                UniCode = ((62 + i) * 100 + i + j),
                                Email = "@gmail.com",
                                Birthdate = 1398 - (62 + i),
                                Major = "Memari",
                                Phone = 021,

                                MeliCode = 0022,
                                Vahedha = 0,
                                AMarks = new List<AllMarks>
                                {
                                    new MemM
                                    {


                                        Adabiat=arrn[(i*7)%13],
                                        Andishe=arrn[(3*i+1)%13],

                                        Major=reshte,
                                        MemMId=MeN
                                    }

                                },

                            });
                            MeN++;
                        }
                        else if (reshte == "Shimi")
                        {
                            Db.St_InfM.Add(new St_Models
                            {
                                Name = Users[i],
                                Password = (Users[i] + "123"),
                                LastName = Users[j] + "i",
                                UniLog = (62 + i),
                                UniCode = ((62 + i) * 100 + i + j),
                                Email = "@gmail.com",
                                Birthdate = 1398 - (62 + i),
                                Major = "Shimi",
                                Phone = 021,

                                MeliCode = 0022,
                                Vahedha = 0,
                                AMarks = new List<AllMarks>
                                {
                                    new ShimiM
                                    {
                                         Riazi1=arrn[i%13],
                                        Adabiat=arrn[(i*7)%13],
                                        Andishe=arrn[(3*i+1)%13],
                                        Moadelat=arrn[(i+3)%13],
                                        Major=reshte,
                                        ShimiMId=ShN
                                    }

                                },

                            });
                            ShN++;
                        }
                        else if (reshte == "Mechanic")
                        {
                            Db.St_InfM.Add(new St_Models
                            {
                                Name = Users[i],
                                Password = (Users[i] + "123"),
                                LastName = Users[j] + "i",
                                UniLog = (62 + i),
                                UniCode = ((62 + i) * 100 + i + j),
                                Email = "@gmail.com",
                                Birthdate = 1398 - (62 + i),
                                Major = "Mechanic",
                                Phone = 021,

                                MeliCode = 0022,
                                Vahedha = 0,
                                AMarks = new List<AllMarks>
                                {
                                    new MechM
                                    {
                                          Riazi1=arrn[(3*i)%13],
                                        Adabiat=arrn[(i*4)%13],
                                        Andishe=arrn[(i+1)%13],
                                        Moadelat=arrn[(i+9)%13],
                                        Major=reshte,
                                        MechMId=MN
                                    }

                                },

                            });
                            MN++;
                        }
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
                    Phone = 77950,
                    Email ="@gmail.com" ,
                    Post="Admin",
                    Education="P.h Compuer"
                    
                });

                

                
                    for (int j = 0; j < 34; j++)
                    {
                        Db.Tch_InfM.Add(new Tch_Models
                        {
                            Name = Users[j],
                            Password = (Users[j] + "1234"),
                            LastName = Users[(j+2)%34] + "i",
                            OrgCode = ((62 + j) * 100  + j),
                            BirthDate = 1398 - (42 + j) ,
                            Age=98-42-j,
                            MeliCode =0022 ,
                            Phone = 021 ,
                            Email ="@gmail.com",
                            TeachingLesson=Lessons[j],
                            Education="dr."+Major[j%6]
                            
                            
                        });
                    }
                

                Db.SaveChanges();
            }
        }

        public void MarkAdder()
        {
            using (DB_Proj db = new DB_Proj())
            {
                var Barqia = db.BarqD.ToList();
                var Mechia = db.MechD.ToList();
                var Memaria = db.MemD.ToList();
                var Shimia = db.ShimiD.ToList();
                var Omrania = db.OmranD.ToList();
                var Compia = db.CompD.ToList();
                int[] arrM = new int[] { 20, 14, 2, 13, 16, 5, 19, 15, 8, 13, 4, 11, 9, 7, 18, 6, 12, 3, 1, 17 };

                foreach (BarqM item in Barqia)
                {
                    int i = item.BarqMId % 20;
                    if (item.BarqMId % 2 == 0)
                    {
                        item.BCmos = arrM[i];
                        item.BElectro = arrM[i+1];

                    }
                    else if (item.BarqMId % 2 == 1)
                    {
                        item.BQodrat = arrM[(2*i+1)%20];
                        item.BVLSI = arrM[(5*i)%20];
                    }
                    item.BMadar = arrM[(i*7)%20];

                }
                db.SaveChanges();
                foreach (CompM item in Compia)
                {
                    int i = (item.CompMId+1) % 8;
                    if (item.CompMId % 2 == 0)
                    {
                        item.CDatabase = arrM[i];
                        item.CGosaste = arrM[i + 1];
                    }
                    else if (item.CompMId % 2 == 1)
                    {
                        item.CProgramming = arrM[(2 * i + 1) % 20];
                        item.CInteligence = arrM[(5 * i) % 20];
                    }
                    item.CManteqi = arrM[(i * 7) % 20];

                }
                foreach (OmranM item in Omrania)
                {
                    int i = item.OmranMId % 8;
                    if (item.OmranMId % 2 == 0)
                    {
                        item.OBotons = arrM[(2 * i + 1) % 20];
                        item.ODinamik = arrM[i + 1];

                    }
                    else if (item.OmranMId % 2 == 1)
                    {
                        item.ONaqshe = arrM[i];
                        item.OStatik = arrM[(5 * i) % 20];
                    }
                    item.OMasaleh = arrM[(i * 7) % 20];
                }
                foreach (MemM item in Memaria)
                {
                    int i = item.MemMId % 8;
                    if (item.MemMId % 2 == 0)
                    {
                        item.MeDekor = arrM[(2 * i + 1) % 20];
                        item.MeFazas = arrM[i + 1];

                    }
                    else if (item.MemMId % 2 == 1)
                    {
                        item.MeNama = arrM[(5 * i) % 20];
                        item.MeNaqshe = arrM[i];
                    }
                    item.MeTarahi = arrM[(i * 7) % 20];

                }
                foreach (ShimiM item in Shimia)
                {
                    int i = item.ShimiMId % 8;
                    if (item.ShimiMId % 2 == 0)
                    {
                        item.SHGaz = arrM[(i * 7) % 20];
                        item.SHHararat = arrM[(2 * i + 1) % 20];

                    }
                    else if (item.ShimiMId % 2 == 1)
                    {
                        item.SHJerm = arrM[i + 1];
                        item.SHMavad = arrM[(5 * i) % 20];
                    }
                    item.SHSinema = arrM[i];

                }
                foreach (MechM item in Mechia)
                {
                    int i = item.MechMId % 8;
                    if (item.MechMId % 2 == 0)
                    {
                        item.MFizik = arrM[(2 * i + 1) % 20];
                        item.MMashin = arrM[(i * 7) % 20];

                    }
                    else if (item.MechMId % 2 == 1)
                    {
                        item.MSayalat = arrM[(5 * i) % 20];
                        item.MTermo = arrM[i];
                    }
                    item.MControl = arrM[(2 * i + 1) % 20];

                }
                db.SaveChanges();
            }
        }


        public void LessonAdder()
        {
            using (DB_Proj db = new DB_Proj())
            {
                string[] RMajor = new string[] { "Computer", "Barq", "Omran", "Mechanic", "Shimi", "Memari" };
                
                int d = 0;
                for (int i=0;i<6;i++)
                {
                    for (int j=0;j<5;j++)
                    {
                        db.Lessons.Add(new MajorsLessons
                        {
                            Major = RMajor[i],
                            Lesson = Lessons[d],
                            Type = "Ekhtesasi",
                            Unit = 3
                            
                        });
                        db.SaveChanges();
                        d++;
                    }
                }
                for(int i=0;i<2;i++)
                {
                    for (int j=0;j<5;j++)
                    {
                        db.Lessons.Add(new MajorsLessons
                        {
                            Major = RMajor[j],
                            Lesson = Lessons[i+30],
                            Type = "Omumi",
                            Unit = 1
                        }
                    );
                        

                        db.Lessons.Add(new MajorsLessons
                        {
                            Major=RMajor[j],
                            Lesson=Lessons[i+32],
                            Type="Paye",
                            Unit=2
                        });
                        db.SaveChanges();

                    }
                }
                db.Lessons.Add(new MajorsLessons { Major = "Memari", Lesson = "Andishe", Type = "Omumi", Unit = 1 });
                db.Lessons.Add(new MajorsLessons { Major = "Memari", Lesson = "Adabiat", Type = "Omumi", Unit = 1 });
                db.SaveChanges();
            }
        }


    }
}
