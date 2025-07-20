using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHONJUE_SCHEDULE.Resources.Schedule.Model
{
  public  class ScheduleModel
    {
         public int Id { get; set; }
         public string Day { get; set; }
         public int TeacherId { get; set; }
         public int ClassMajorId { get; set; }
         public string ClassName { get; set; }
         public string TeacherName { get; set; }
         public int TermSubjectId { get; set; }
         public int subjectId { get; set; }
         public string subjectName { get; set; }
         public int majorId { get; set; }
         public string majorName { get; set; }
         public int termId { get; set; }
         public string termName { get; set; }
         public int levelId { get; set; }
         public string levelName { get; set; }
         public int periodId { get; set; }
         public String period { get; set; }
        public int RoomId { get; set; }
        public string Type { get; set; }
        public string RoomName { get; set; }    
    }
}
