using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hospital_Management
{
    public partial class DashBoard : Form
    {
        // this help connect to the sql databases
        private readonly string connectionString = "Server=LAPTOP-MSNOAR3O\\SQLEXPRESS01;Database=HMSDB;Trusted_Connection=True;";
        public DashBoard()
        {
            InitializeComponent();
            dateTimePickerDashboard.Format = DateTimePickerFormat.Custom;
            dateTimePickerDashboard.CustomFormat = "yyyy-MM-ddTHH:mm:ssZ";
            dateTimePickerDashboard.Value = DateTime.UtcNow;
        }
        // this button will add dashboard status
        private void buttonDashboardAdd_Click(object sender, EventArgs e)
        {
            string dashboardId = textBoxDashboardID.Text;
            string wardName = textBoxWard.Text;
            string bedAvailability = textBoxAvailability.Text;
            string emergencyStatus = textBoxEmergency.Text;
            string timestamp = dateTimePickerDashboard.Value.ToString("yyyy-MM-ddTHH:mm:ssZ");

            if (string.IsNullOrEmpty(dashboardId))
            {
                MessageBox.Show("Dashboard ID cannot be empty.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    MERGE Dashboard AS target
                    USING (SELECT @DashboardID AS DashboardID) AS source
                    ON target.DashboardID = source.DashboardID
                    WHEN MATCHED THEN
                        UPDATE SET WardName = @WardName, BedAvailability = @BedAvailability, EmergencyStatus = @EmergencyStatus, Timestamp = @Timestamp
                    WHEN NOT MATCHED THEN
                        INSERT (DashboardID, WardName, BedAvailability, EmergencyStatus, Timestamp)
                        VALUES (@DashboardID, @WardName, @BedAvailability, @EmergencyStatus, @Timestamp);";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DashboardID", dashboardId);
                    cmd.Parameters.AddWithValue("@WardName", wardName);
                    cmd.Parameters.AddWithValue("@BedAvailability", bedAvailability);
                    cmd.Parameters.AddWithValue("@EmergencyStatus", emergencyStatus);
                    cmd.Parameters.AddWithValue("@Timestamp", timestamp);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Dashboard record added or updated successfully!");
        }
        // this button will help to view the dashboard update
        private void buttonDashboardSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Dashboard WHERE 1=1";

            if (!string.IsNullOrWhiteSpace(textBoxDashboardID.Text))
                query += " AND DashboardID = @DashboardID";
            if (!string.IsNullOrWhiteSpace(textBoxWard.Text))
                query += " AND WardName LIKE @WardName";
            if (!string.IsNullOrWhiteSpace(textBoxAvailability.Text))
                query += " AND BedAvailability LIKE @BedAvailability";
            if (!string.IsNullOrWhiteSpace(textBoxEmergency.Text))
                query += " AND EmergencyStatus LIKE @EmergencyStatus";

            // Always filter by timestamp from DateTimePicker (optional: you can add a checkbox to enable/disable this)
            query += " AND Timestamp = @Timestamp";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (!string.IsNullOrWhiteSpace(textBoxDashboardID.Text))
                    cmd.Parameters.AddWithValue("@DashboardID", textBoxDashboardID.Text);
                if (!string.IsNullOrWhiteSpace(textBoxWard.Text))
                    cmd.Parameters.AddWithValue("@WardName", "%" + textBoxWard.Text + "%");
                if (!string.IsNullOrWhiteSpace(textBoxAvailability.Text))
                    cmd.Parameters.AddWithValue("@BedAvailability", "%" + textBoxAvailability.Text + "%");
                if (!string.IsNullOrWhiteSpace(textBoxEmergency.Text))
                    cmd.Parameters.AddWithValue("@EmergencyStatus", "%" + textBoxEmergency.Text + "%");

                cmd.Parameters.AddWithValue("@Timestamp", dateTimePickerDashboard.Value.ToString("yyyy-MM-ddTHH:mm:ssZ"));

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
    }


