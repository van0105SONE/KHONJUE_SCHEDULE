using KHONJUE_SCHEDULE.DatabaseContexts;
using KHONJUE_SCHEDULE.Resources.Notifications.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHONJUE_SCHEDULE.Resources.Notifications.Controller
{
   public class NotificationController
    {
        private DatabaseContext _databaseContext;
        public NotificationController(DatabaseContext context)
        {
            _databaseContext = context;
        }


        public List<NotificationModel> GetAllMessages()
        {
            var messages = new List<NotificationModel>();

            using (var conn = _databaseContext.connect())
            {


                string query = "SELECT id, teacher_name, phone, message FROM teacher_messages";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        messages.Add(new NotificationModel
                        {
                            Id = reader.GetInt32(0),
                            TeacherName = reader.GetString(1),
                            Phone = reader.IsDBNull(2) ? null : reader.GetString(2),
                            Message = reader.IsDBNull(3) ? null : reader.GetString(3),
                        });
                    }
                }
            }

            return messages;
        }


        
    }
}
