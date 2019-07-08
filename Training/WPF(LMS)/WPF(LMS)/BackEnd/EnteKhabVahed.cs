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
                var Omumi = db.Marks.Where(i => i.St_ModelsId == StInfo.St_ModelsId).FirstOrDefault();
                //var OLN = Omumi.GetType().GetProperties().Where(a => a.GetValue(Omumi) == null).Select(b => b.Name).ToList();
                //for (int i = 0; i < OLN.Count(); i++)
                //{
                //    NuLLess.Add(OLN[i]);
                //}


                if (Maj == "Computer")
                {
                    var ComRow = db.CompD.Where(i => i.St_ModelsId == StInfo.St_ModelsId).FirstOrDefault();
                    var LLN = ComRow.GetType().GetProperties().Where(a => a.GetValue(ComRow) == null).Select(b => b.Name).ToList();
                    for (int i = 0; i < LLN.Count(); i++)
                    {
                        NuLLess.Add(LLN[i]);
                    }

                    return NuLLess;
                }
                if (Maj == "Barq")
                {
                    var ComRow = db.BarqD.Where(i => i.St_ModelsId == StInfo.St_ModelsId).FirstOrDefault();
                    var LLN = ComRow.GetType().GetProperties().Where(a => a.GetValue(ComRow) == null).Select(b => b.Name).ToList();
                    for (int i = 0; i < LLN.Count(); i++)
                    {
                        NuLLess.Add(LLN[i]);
                    }

                    return NuLLess;
                }
                if (Maj == "Mechanic")
                {
                    var ComRow = db.MechD.Where(i => i.St_ModelsId == StInfo.St_ModelsId).FirstOrDefault();
                    var LLN = ComRow.GetType().GetProperties().Where(a => a.GetValue(ComRow) == null).Select(b => b.Name).ToList();
                    for (int i = 0; i < LLN.Count(); i++)
                    {
                        NuLLess.Add(LLN[i]);
                    }

                    return NuLLess;
                }
                if (Maj == "Omran")
                {
                    var ComRow = db.OmranD.Where(i => i.St_ModelsId == StInfo.St_ModelsId).FirstOrDefault();
                    var LLN = ComRow.GetType().GetProperties().Where(a => a.GetValue(ComRow) == null).Select(b => b.Name).ToList();
                    for (int i = 0; i < LLN.Count(); i++)
                    {
                        NuLLess.Add(LLN[i]);
                    }

                    return NuLLess;
                }
                if (Maj == "Shimi")
                {
                    var ComRow = db.ShimiD.Where(i => i.St_ModelsId == StInfo.St_ModelsId).FirstOrDefault();
                    var LLN = ComRow.GetType().GetProperties().Where(a => a.GetValue(ComRow) == null).Select(b => b.Name).ToList();
                    for (int i = 0; i < LLN.Count(); i++)
                    {
                        NuLLess.Add(LLN[i]);
                    }

                    return NuLLess;
                }
                if (Maj == "Memari")
                {
                    var ComRow = db.MemD.Where(i => i.St_ModelsId == StInfo.St_ModelsId).FirstOrDefault();
                    var LLN = ComRow.GetType().GetProperties().Where(a => a.GetValue(ComRow) == null).Select(b => b.Name).ToList();
                    for (int i = 0; i < LLN.Count(); i++)
                    {
                        NuLLess.Add(LLN[i]);
                    }

                    return NuLLess;
                }

                return NuLLess;

            }
        }

       
    }

}
