using System;
namespace Hospital_Management
{
    public class ReportData
    {
        public int ReportID { get; set; }
        public string Type { get; set; } // Visits, Ailments, Medications
        public int GeneratedBy { get; set; }
        public DateTime Timestamp { get; set; }
        public string FilePath { get; set; }
    }
}