using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    public class InventoryLog
    {
        public int LogID { get; set; }             // Primary Key
        public int ItemID { get; set; }            // Foreign Key to InventoryItem
        public int ChangeAmount { get; set; }      // Change in quantity (+/-)
        public DateTime Timestamp { get; set; }    // When the change occurred
        public int UserID { get; set; }            // User who made the change
        public string Reason { get; set; }         // Reason for change (e.g. restock, usage)

        public InventoryLog()
        {
            Timestamp = DateTime.Now;
        }
    }
}
