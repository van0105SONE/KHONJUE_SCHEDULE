using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHONJUE_SCHEDULE.Resources.Management.Model
{
    public class StudentClassModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string StudentClassName { get; set; }
        public int NumberOfClass { get; set; }
        
        public string Description { get; set; }

        public int LevelId { get; set; }
        public string LevelCode { get; set; }
        public string LevelName { get; set; }
    }
}
