using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    public class InventoryLogData
    {
        public string LogID { get; set; }
        public string ItemID { get; set; }
        public int ChangeAmount { get; set; }
        public DateTime Timestamp { get; set; }
        public string UserID { get; set; }
        public string Reason { get; set; }
    }
}
