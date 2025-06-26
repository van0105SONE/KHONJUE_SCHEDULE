using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHONJUE_SCHEDULE.Resources.Notifications.Model
{
   public class NotificationModel
    {
        public int Id { get; set; }
        [DisplayName("ຊື່ອາຈານ")]
        public string TeacherName { get; set; }
        [DisplayName("ເບີໂທ")]
        public string Phone { get; set; }
        [DisplayName("ຂໍ້ຄວາມສົ່ງໄປແຈ້ງເຕືອນ")]
        public string Message { get; set; }
    }
}
