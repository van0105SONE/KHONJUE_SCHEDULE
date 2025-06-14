using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHONJUE_SCHEDULE.Resources.Management.Model
{
    public class TeacherSubject
    {
      public int Id { get; set; }
       
      public int TeacherId { get; set; }
      public string TeacherName { get; set; }
      public string SubjectName { get; set; }

    }
}
