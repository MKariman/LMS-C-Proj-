using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_LMS_.BackEnd.Marks
{
    public class AllMarks 
    {
        public int AllMarksId { get; set; }
        public string Major { get; set; }
        public int Riazi1 { get; set; }
        public int Moadelat { get; set; }
        public int Adabiat { get; set; }
        public int Andishe { get; set; }

        public int St_ModelsId { get; set; }

        public St_Models St_Models { get; set; }
    }
}
