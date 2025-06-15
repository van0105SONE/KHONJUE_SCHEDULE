using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHONJUE_SCHEDULE.Resources.Management.Model
{
   public class TermSubjectModel
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public int SubjectId { get; set; }
        public string TermName { get; set; }
        public string LevelName { get; set; }
        public string MajorName { get; set; }
        public int CurriculumId { get; set; }
        public int CurriculumName { get; set; }
    }
}
