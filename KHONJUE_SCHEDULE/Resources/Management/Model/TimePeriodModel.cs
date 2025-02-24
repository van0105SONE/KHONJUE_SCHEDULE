using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHONJUE_SCHEDULE.Resources.Management.Model
{
    public class TimePeriodModel
    {
        public int Id { get; set; }
        public string periodCode { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
    }
}
