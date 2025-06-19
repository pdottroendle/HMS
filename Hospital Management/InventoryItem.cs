using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    public class InventoryItem
    {
        public int ItemID { get; set; }           // Primary Key
        public string Name { get; set; }          // Name of medication or supply
        public int Quantity { get; set; }         // Current stock quantity
        public int Threshold { get; set; }        // Low stock threshold for alerts
        public DateTime LastUpdated { get; set; } // Last update timestamp

        public InventoryItem()
        {
            LastUpdated = DateTime.Now;
        }

        public void UpdateQuantity(int changeAmount)
        {
            Quantity += changeAmount;
            LastUpdated = DateTime.Now;
        }
    }
}
