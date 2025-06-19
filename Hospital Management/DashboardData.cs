using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    public class DashboardData
    {
            public int BedsAvailable { get; set; }
            public int BedsOccupied { get; set; }
            public List<string> EmergencyAlerts { get; set; }
        
    }
}
