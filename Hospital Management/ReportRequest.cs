using System;
namespace Hospital_Management
{
    public class ReportRequest
    {
        public int ReportID { get; set; }         // Primary Key
        public string Type { get; set; }          // Visits, Ailments, Medications (as plain text)
        public int GeneratedBy { get; set; }      // UserID of the person who generated the report
        public DateTime Timestamp { get; set; }
    }
}