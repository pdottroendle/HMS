using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    public class VitalData
    {
        public string VitalID { get; set; }
        public string PatientID { get; set; }
        public DateTime Timestamp { get; set; }
        public int HeartRate { get; set; }
        public string BloodPressure { get; set; }
        public double Temperature { get; set; }
        public int OxygenLevel { get; set; }
    }
}
