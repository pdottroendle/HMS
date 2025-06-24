using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    
    public class PatientData
    {
        public string PatientID { get; set; }       // Primary Key
        public string UserID { get; set; }          // Foreign Key to Users
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string ContactInfo { get; set; }
        public string MedicalHistory { get; set; }  // Path or text summary

    }
}
