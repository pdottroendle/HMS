using Hospital_Management;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class AppointmentData
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string AppointmentID { get; set; }

    [BsonRepresentation(BsonType.ObjectId)]
    public string PatientID { get; set; }

    [BsonRepresentation(BsonType.ObjectId)]
    public string DoctorID { get; set; }

    public DateTime DateTime { get; set; }
    public string Status { get; set; } // Scheduled, Cancelled, Completed
    public string Notes { get; set; }
}

