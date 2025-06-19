using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    public class NotificationMessage
    {
        public int NotificationID { get; set; }     // Primary Key
        public int UserID { get; set; }             // Foreign Key to Users
        public string Message { get; set; }         // Notification content
        public DateTime Timestamp { get; set; }     // When the notification was created
        public bool IsRead { get; set; }
    }
}
