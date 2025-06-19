using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    public class Message
    {
        public int MessageID { get; set; }      // Primary Key
        public int SenderID { get; set; }       // FK to Users (sender)
        public int ReceiverID { get; set; }     // FK to Users (receiver)
        public DateTime Timestamp { get; set; } // Time message was sent
        public string Content { get; set; }     // Text content of the message
    }
}
