using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHONJUE_SCHEDULE.Resources.Management.Model
{
    public class TeacherModel
    {
        public int Id { get; set; }
        public string TeacherCode { get; set; }
        public string TeacherName { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public int QuotaPerWeek { get; set; }
    }
}
