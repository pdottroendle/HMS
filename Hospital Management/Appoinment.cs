using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class Appoinment : Form
    {
        private HospitalContext context = new HospitalContext();
        private HubConnection connection;
        public Appoinment()
        {
            InitializeComponent();
            InitSignalR();
            LoadPatients();
            LoadAppointments();
        }
        private async void InitSignalR()
        {
            connection = new HubConnectionBuilder()
                .WithUrl("http://localhost:5000/appointmentHub")
                .WithAutomaticReconnect()
                .Build();

            connection.On<string>("ReceiveAppointmentUpdate", (message) =>
            {
                Invoke((Action)(() =>
                {
                    MessageBox.Show("Update: " + message);
                    LoadAppointments();
                }));
            });

            await connection.StartAsync();
        }

        private void LoadPatients()
        {
            var patients = context.Patients
                .Select(p => new { p.PatientID, FullName = p.FirstName + " " + p.LastName })
                .ToList();

            comboBoxPatients.DataSource = patients;
            comboBoxPatients.DisplayMember = "FullName";
            comboBoxPatients.ValueMember = "PatientId";
        }

        private void LoadAppointments()
        {
            var appointments = context.Appointments.Include("Patient")
                .Select(a => new
                {
                    a.AppointmentID,
                    PatientName = a.Patient.FirstName + " " + a.Patient.LastName,
                    a.DateTime,
                    a.Notes,
                    a.Status
                }).ToList();

            dataGridViewAppoinments.DataSource = appointments;
        }
        private void buttonAppointmentAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
