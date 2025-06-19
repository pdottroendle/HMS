using Hospital_Management;
using System.Data.Entity;

public class HospitalContext : DbContext
{
    public HospitalContext() : base("name=HospitalDbConnection")
    {
    }

    public DbSet<PatientData> Patients { get; set; } // use the entity class
    public DbSet<AppointmentData> Appointments { get; set; }
}
