using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Data.SqlClient;

namespace Hospital_Management
{
    public partial class Appoinment : Form
    {
        public Appoinment()
        {
            InitializeComponent();
            dateTimePicker_AppTime.Value = DateTime.UtcNow;
        }

        private async void button_AppAdd_Click(object sender, EventArgs e)
        {
            string appointmentId = textBox_AppoinmentID.Text;
            string patientId = textBoxPatientID.Text;
            string doctorId = textBoxDoctorID.Text;
            string status = comboBox_AppStatus.Text;
            string notes = textBox_AppNotes.Text;

            if (!DateTime.TryParse(dateTimePicker_AppTime.Text, out DateTime dateTime))
            {
                MessageBox.Show("Please enter a valid date and time.");
                return;
            }

            AppointmentSqlHelper helper = new AppointmentSqlHelper();
            helper.AddOrUpdateAppointment(appointmentId, patientId, doctorId, dateTime, status, notes);

            MessageBox.Show("Appointment added or updated successfully!");
        }

        public class AppointmentSqlHelper
        {
            private string connectionString = "Server=OKQWERTY\\SQLEXPRESS;Database=HMSDB;Trusted_Connection=True;";

            public void AddOrUpdateAppointment(string appointmentId, string patientId, string doctorId, DateTime dateTime, string status, string notes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                MERGE Appointment AS target
                USING (SELECT @AppointmentID AS AppointmentID) AS source
                ON target.AppointmentID = source.AppointmentID
                WHEN MATCHED THEN
                    UPDATE SET PatientID = @PatientID, DoctorID = @DoctorID, DateTime = @DateTime, Status = @Status, Notes = @Notes
                WHEN NOT MATCHED THEN
                    INSERT (AppointmentID, PatientID, DoctorID, DateTime, Status, Notes)
                    VALUES (@AppointmentID, @PatientID, @DoctorID, @DateTime, @Status, @Notes);";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AppointmentID", appointmentId);
                        cmd.Parameters.AddWithValue("@PatientID", patientId);
                        cmd.Parameters.AddWithValue("@DoctorID", doctorId);
                        cmd.Parameters.AddWithValue("@DateTime", dateTime);
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@Notes", notes);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private async void button_AppSearch_Click(object sender, EventArgs e)

        {
            string connectionString = "Server=OKQWERTY\\SQLEXPRESS;Database=HMSDB;Trusted_Connection=True;";
            string query = "SELECT * FROM Appointment WHERE 1=1";

            if (!string.IsNullOrWhiteSpace(textBox_AppoinmentID.Text))
                query += " AND AppointmentID = @AppointmentID";
            if (!string.IsNullOrWhiteSpace(textBoxPatientID.Text))
                query += " AND PatientID = @PatientID";
            if (!string.IsNullOrWhiteSpace(textBoxDoctorID.Text))
                query += " AND DoctorID = @DoctorID";
            if (!string.IsNullOrWhiteSpace(dateTimePicker_AppTime.Text))
                query += " AND DateTime = @DateTime";
            if (!string.IsNullOrWhiteSpace(comboBox_AppStatus.Text))
                query += " AND Status = @Status";
            if (!string.IsNullOrWhiteSpace(textBox_AppNotes.Text))
                query += " AND Notes LIKE @Notes";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (!string.IsNullOrWhiteSpace(textBox_AppoinmentID.Text))
                    cmd.Parameters.AddWithValue("@AppointmentID", textBox_AppoinmentID.Text);
                if (!string.IsNullOrWhiteSpace(textBoxPatientID.Text))
                    cmd.Parameters.AddWithValue("@PatientID", textBoxPatientID.Text);
                if (!string.IsNullOrWhiteSpace(textBoxDoctorID.Text))
                    cmd.Parameters.AddWithValue("@DoctorID", textBoxDoctorID.Text);
                if (!string.IsNullOrWhiteSpace(dateTimePicker_AppTime.Text))
                    cmd.Parameters.AddWithValue("@DateTime", DateTime.Parse(dateTimePicker_AppTime.Text));
                if (!string.IsNullOrWhiteSpace(comboBox_AppStatus.Text))
                    cmd.Parameters.AddWithValue("@Status", comboBox_AppStatus.Text);
                if (!string.IsNullOrWhiteSpace(textBox_AppNotes.Text))
                    cmd.Parameters.AddWithValue("@Notes", "%" + textBox_AppNotes.Text + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView_Appointment.DataSource = table;
            }
        }


    }
}
