using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHONJUE_SCHEDULE.Resources.Management.Model
{
  public  class MajorModel
    {
        public int Id { get; set; }
        public string MajorCode  { get; set; }
        public string MajorName { get; set; }
        public int LimitPerClass { get; set; }  
        public int   CurriculumId { get; set; }
        public string CurriculumName { get; set; }
    }
}
