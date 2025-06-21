using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    [Table("Patients")]
    public class PatientData
    {
        public int PatientID { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string ContactInfo { get; set; }
        public string MedicalHistory { get; set; } // path to file

    }
}
