using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    public class Vital
    {
        public int VitalID { get; set; }            // Primary Key
        public int PatientID { get; set; }          // Foreign Key to Patients
        public DateTime Timestamp { get; set; }     // Time the vitals were recorded
        public int HeartRate { get; set; }          // in bpm
        public string BloodPressure { get; set; }   // e.g. "120/80"
        public float Temperature { get; set; }      // in Celsius
        public int OxygenLevel { get; set; }        // in %
    }
}
