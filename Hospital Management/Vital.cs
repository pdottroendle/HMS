using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class Vital : Form
    {
        public Vital()
        {
            InitializeComponent();
            dateTimePickerVital.Value = DateTime.UtcNow;
        }
        // This button allow to add patient monitoring data
        private void button_VitalAdd_Click(object sender, EventArgs e)
        {
            string vitalId = textBox_VitalID.Text;
            string patientId = textBox_PatientID.Text;
            string bloodPressure = textBox_BloodPressure.Text;

            if (!DateTime.TryParse(dateTimePickerVital.Text, out DateTime timestamp))
            {
                MessageBox.Show("Please enter a valid timestamp.");
                return;
            }

            if (!int.TryParse(textBox_HeartRate.Text, out int heartRate) ||
                !float.TryParse(textBox_Temperature.Text, out float temperature) ||
                !int.TryParse(textBox_OxygenLevel.Text, out int oxygenLevel))
            {
                MessageBox.Show("Please enter valid numeric values for vitals.");
                return;
            }

            VitalSqlHelper helper = new VitalSqlHelper();
            helper.AddOrUpdateVital(vitalId, patientId, timestamp, heartRate, bloodPressure, temperature, oxygenLevel);

            MessageBox.Show("Vital record added or updated successfully!");
        }
        // This help to connect to the vital table in SQL
        public class VitalSqlHelper
        {
            private string connectionString = "Server=LAPTOP-MSNOAR3O\\SQLEXPRESS01;Database=HMSDB;Trusted_Connection=True;";

            public void AddOrUpdateVital(string vitalId, string patientId, DateTime timestamp, int heartRate, string bloodPressure, float temperature, int oxygenLevel)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        MERGE Vital AS target
                        USING (SELECT @VitalID AS VitalID) AS source
                        ON target.VitalID = source.VitalID
                        WHEN MATCHED THEN
                            UPDATE SET 
                                PatientID = @PatientID, 
                                Timestamp = @Timestamp, 
                                HeartRate = @HeartRate, 
                                BloodPressure = @BloodPressure, 
                                Temperature = @Temperature, 
                                OxygenLevel = @OxygenLevel
                        WHEN NOT MATCHED THEN
                            INSERT (VitalID, PatientID, Timestamp, HeartRate, BloodPressure, Temperature, OxygenLevel)
                            VALUES (@VitalID, @PatientID, @Timestamp, @HeartRate, @BloodPressure, @Temperature, @OxygenLevel);";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@VitalID", vitalId);
                        cmd.Parameters.AddWithValue("@PatientID", patientId);
                        cmd.Parameters.AddWithValue("@Timestamp", timestamp);
                        cmd.Parameters.AddWithValue("@HeartRate", heartRate);
                        cmd.Parameters.AddWithValue("@BloodPressure", bloodPressure);
                        cmd.Parameters.AddWithValue("@Temperature", temperature);
                        cmd.Parameters.AddWithValue("@OxygenLevel", oxygenLevel);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
        // This is a View data button for information of patient monitoring
        private void button_SearchVital_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=LAPTOP-MSNOAR3O\\SQLEXPRESS01;Database=HMSDB;Trusted_Connection=True;";
            string query = "SELECT * FROM Vital WHERE 1=1";

            if (!string.IsNullOrWhiteSpace(textBox_VitalID.Text))
                query += " AND VitalID = @VitalID";
            if (!string.IsNullOrWhiteSpace(textBox_PatientID.Text))
                query += " AND PatientID = @PatientID";
            if (!string.IsNullOrWhiteSpace(dateTimePickerVital.Text))
                query += " AND Timestamp = @Timestamp";
            if (!string.IsNullOrWhiteSpace(textBox_HeartRate.Text))
                query += " AND HeartRate = @HeartRate";
            if (!string.IsNullOrWhiteSpace(textBox_BloodPressure.Text))
                query += " AND BloodPressure = @BloodPressure";
            if (!string.IsNullOrWhiteSpace(textBox_Temperature.Text))
                query += " AND Temperature = @Temperature";
            if (!string.IsNullOrWhiteSpace(textBox_OxygenLevel.Text))
                query += " AND OxygenLevel = @OxygenLevel";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (!string.IsNullOrWhiteSpace(textBox_VitalID.Text))
                    cmd.Parameters.AddWithValue("@VitalID", textBox_VitalID.Text);
                if (!string.IsNullOrWhiteSpace(textBox_PatientID.Text))
                    cmd.Parameters.AddWithValue("@PatientID", textBox_PatientID.Text);
                if (!string.IsNullOrWhiteSpace(dateTimePickerVital.Text))
                    cmd.Parameters.AddWithValue("@Timestamp", DateTime.Parse(dateTimePickerVital.Text));
                if (!string.IsNullOrWhiteSpace(textBox_HeartRate.Text))
                    cmd.Parameters.AddWithValue("@HeartRate", int.Parse(textBox_HeartRate.Text));
                if (!string.IsNullOrWhiteSpace(textBox_BloodPressure.Text))
                    cmd.Parameters.AddWithValue("@BloodPressure", textBox_BloodPressure.Text);
                if (!string.IsNullOrWhiteSpace(textBox_Temperature.Text))
                    cmd.Parameters.AddWithValue("@Temperature", float.Parse(textBox_Temperature.Text));
                if (!string.IsNullOrWhiteSpace(textBox_OxygenLevel.Text))
                    cmd.Parameters.AddWithValue("@OxygenLevel", int.Parse(textBox_OxygenLevel.Text));

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }
    }
}
