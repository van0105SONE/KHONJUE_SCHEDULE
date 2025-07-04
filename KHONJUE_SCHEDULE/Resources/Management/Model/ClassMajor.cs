using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHONJUE_SCHEDULE.Resources.Management.Model
{
    public class ClassMajor
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public int  LevelId { get; set; }
        public string LevelName { get; set; }
        public int MajorId { get; set; }
        public string MajorName { get; set; }
    }
}
