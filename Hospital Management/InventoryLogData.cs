using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    public class InventoryLogData
    {
        public int LogID { get; set; }
        public int ItemID { get; set; }
        public int ChangeAmount { get; set; }
        public DateTime Timestamp { get; set; }
        public int UserID { get; set; }
        public string Reason { get; set; }
    }
}
