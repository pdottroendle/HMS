using Hospital_Management;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class AppointmentData
{
   
        [Key]

    [Required]
    public int AppointmentID { get; set; } // Primary Key

    public int PatientID { get; set; }  // Foreign Key to Patient

    public int DoctorID { get; set; }      // Foreign Key to User (Doctor)

    public DateTime DateTime { get; set; } // Scheduled Date and Time

    public string Status { get; set; }     // Scheduled, Cancelled, Completed

    public string Notes { get; set; }      // Additional Information

    public virtual PatientData Patient { get; set; }
}

