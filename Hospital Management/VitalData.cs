using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    public class VitalData
    {
        public int VitalID { get; set; }
        public int PatientID { get; set; }
        public DateTime Timestamp { get; set; }
        public int HeartRate { get; set; }
        public string BloodPressure { get; set; }
        public float Temperature { get; set; }
        public int OxygenLevel { get; set; }
    }
}
