using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHONJUE_SCHEDULE.Constants
{
    class AppConstants
    {
        private List<string> roomTypes = new List<string> {"General" ,"Lecture", "Lab", };
        public AppConstants()
        {

        }



        public List<string> getRoomTypes()
        {
            return roomTypes;
        }
    }

}
