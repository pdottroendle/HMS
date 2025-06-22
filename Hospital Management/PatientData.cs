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
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string PatientID { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string UserID { get; set; }

        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string ContactInfo { get; set; }
        public string MedicalHistory { get; set; } // File path

    }
}
