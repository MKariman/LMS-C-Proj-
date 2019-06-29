using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_LMS_.BackEnd.Marks
{
    public class MemM : AllMarks
    {
        public int MemMId { get; set; }
        public int? MeTarahi { get; set; }
        public int? MeNaqshe { get; set; }
        public int? MeDekor { get; set; }
        public int? MeNama { get; set; }
        public int? MeFazas { get; set; }
    }
}
