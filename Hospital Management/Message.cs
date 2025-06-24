using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    public class Message
    {
        public string MessageID { get; set; }
        public string SenderID { get; set; }
        public string ReceiverID { get; set; }
        public DateTime Timestamp { get; set; }
        public string Content { get; set; }
    }
}
