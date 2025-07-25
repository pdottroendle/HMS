﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
namespace Hospital_Management
{
    public class ReportData
    {
        public string ReportID { get; set; }
        public string Type { get; set; } // Visits, Ailments, Medications
        public string GeneratedBy { get; set; }
        public DateTime Timestamp { get; set; }
        public string FilePath { get; set; }
    }
}