using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_LMS_.BackEnd
{
    public class MajorsLessons
    {
        [Key]
        public int MajorId { get; set; }
        public string Major { get; set; }
        public string Lesson { get; set; }
        public int Unit { get; set; }
        public string Type { get; set; }

    }
}
