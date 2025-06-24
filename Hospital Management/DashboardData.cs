using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    public class DashboardData
    {
        public string DashboardID { get; set; }
        public string WardName { get; set; }
        public string BedAvailability { get; set; }
        public string EmergencyStatus { get; set; }
        public DateTime Timestamp { get; set; }

    }
}
