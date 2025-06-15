using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHONJUE_SCHEDULE.Resources.Management.Model
{
    public class SubjectModel
    {
       public int Id { get; set;  }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public string Description { get; set; }

        public int Lecture { get; set;  }
        public int Lab { get; set; }

    }
}
