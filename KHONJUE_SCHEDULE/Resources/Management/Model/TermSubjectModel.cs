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
        public int TermId { get; set; }
        public string TermName { get; set; }
        public int LevelId { get; set; }
        public string LevelName { get; set; }
        public int MajorId { get; set; }
        public string MajorName { get; set; }
        public int CurriculumId { get; set; }
        public string CurriculumName { get; set; }
    }
}
