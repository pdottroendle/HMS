using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    public class InventoryData
    {
        public string ItemID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Threshold { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}