using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace Hospital_Management
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }
        // this will help connect the sql server
        public class PatientSqlHelper
        {
            private string connectionString = "Server=LAPTOP-MSNOAR3O\\SQLEXPRESS01;Database=HMSDB;Trusted_Connection=True;";

            public void AddOrUpdatePatient(string patientId, string userId, string name, DateTime dob, string gender, string address, string contactInfo, string medicalHistory)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                MERGE Patient AS target
                USING (SELECT @PatientID AS PatientID) AS source
                ON target.PatientID = source.PatientID
                WHEN MATCHED THEN
                    UPDATE SET UserID = @UserID, Name = @Name, DOB = @DOB, Gender = @Gender, Address = @Address, ContactInfo = @ContactInfo, MedicalHistory = @MedicalHistory
                WHEN NOT MATCHED THEN
                    INSERT (PatientID, UserID, Name, DOB, Gender, Address, ContactInfo, MedicalHistory)
                    VALUES (@PatientID, @UserID, @Name, @DOB, @Gender, @Address, @ContactInfo, @MedicalHistory);";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PatientID", patientId);
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@DOB", dob);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@ContactInfo", contactInfo);
                        cmd.Parameters.AddWithValue("@MedicalHistory", medicalHistory);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
        // add button for patients information
        private void button_patientAdd_Click(object sender, EventArgs e)
        {
            string patientId = textBox_PatientID.Text;
            string userId = textBox_UserID.Text;
            string name = textBox_Name.Text;
            string gender = textBox_Gender.Text;
            string address = textBox_Address.Text;
            string contactInfo = textBox_ContactInfo.Text;
            string medicalHistory = textBox_MedicalHistory.Text;

            if (!DateTime.TryParse(textBox_DOB.Text, out DateTime dob))
            {
                MessageBox.Show("Please enter a valid date of birth.");
                return;
            }

            PatientSqlHelper helper = new PatientSqlHelper();
            helper.AddOrUpdatePatient(patientId, userId, name, dob, gender, address, contactInfo, medicalHistory);

            MessageBox.Show("Patient record added or updated successfully!");
        }
        // view or search for patients information
        private void button_patientSearch_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=LAPTOP-MSNOAR3O\\SQLEXPRESS01;Database=HMSDB;Trusted_Connection=True;";
            string query = "SELECT * FROM Patient WHERE 1=1";

            if (!string.IsNullOrWhiteSpace(textBox_PatientID.Text))
                query += " AND PatientID = @PatientID";
            if (!string.IsNullOrWhiteSpace(textBox_UserID.Text))
                query += " AND UserID = @UserID";
            if (!string.IsNullOrWhiteSpace(textBox_Name.Text))
                query += " AND Name LIKE @Name";
            if (!string.IsNullOrWhiteSpace(textBox_DOB.Text))
                query += " AND DOB = @DOB";
            if (!string.IsNullOrWhiteSpace(textBox_Gender.Text))
                query += " AND Gender = @Gender";
            if (!string.IsNullOrWhiteSpace(textBox_Address.Text))
                query += " AND Address LIKE @Address";
            if (!string.IsNullOrWhiteSpace(textBox_ContactInfo.Text))
                query += " AND ContactInfo LIKE @ContactInfo";
            if (!string.IsNullOrWhiteSpace(textBox_MedicalHistory.Text))
                query += " AND MedicalHistory LIKE @MedicalHistory";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (!string.IsNullOrWhiteSpace(textBox_PatientID.Text))
                    cmd.Parameters.AddWithValue("@PatientID", textBox_PatientID.Text);
                if (!string.IsNullOrWhiteSpace(textBox_UserID.Text))
                    cmd.Parameters.AddWithValue("@UserID", textBox_UserID.Text);
                if (!string.IsNullOrWhiteSpace(textBox_Name.Text))
                    cmd.Parameters.AddWithValue("@Name", "%" + textBox_Name.Text + "%");
                if (!string.IsNullOrWhiteSpace(textBox_DOB.Text))
                    cmd.Parameters.AddWithValue("@DOB", DateTime.Parse(textBox_DOB.Text));
                if (!string.IsNullOrWhiteSpace(textBox_Gender.Text))
                    cmd.Parameters.AddWithValue("@Gender", textBox_Gender.Text);
                if (!string.IsNullOrWhiteSpace(textBox_Address.Text))
                    cmd.Parameters.AddWithValue("@Address", "%" + textBox_Address.Text + "%");
                if (!string.IsNullOrWhiteSpace(textBox_ContactInfo.Text))
                    cmd.Parameters.AddWithValue("@ContactInfo", "%" + textBox_ContactInfo.Text + "%");
                if (!string.IsNullOrWhiteSpace(textBox_MedicalHistory.Text))
                    cmd.Parameters.AddWithValue("@MedicalHistory", "%" + textBox_MedicalHistory.Text + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }
        // this button will let patient delete their information to make a new one.
        private void button_PatientDelete_Click(object sender, EventArgs e)
        {
            string patientId = textBox_PatientID.Text.Trim();

            if (string.IsNullOrEmpty(patientId))
            {
                MessageBox.Show("Please enter a Patient ID to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this patient record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;

            string connectionString = "Server=LAPTOP-MSNOAR3O\\SQLEXPRESS01;Database=HMSDB;Trusted_Connection=True;";
            string query = "DELETE FROM Patient WHERE PatientID = @PatientID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PatientID", patientId);
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Patient record deleted successfully.");
                        ClearInputFields();
                    }
                    else
                    {
                        MessageBox.Show("No matching Patient ID found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
   
        }

        private void ClearInputFields()
        {
            textBox_PatientID.Clear();
            textBox_UserID.Clear();
            textBox_Name.Clear();
            textBox_Gender.Clear();
            textBox_Address.Clear();
            textBox_ContactInfo.Clear();
            textBox_MedicalHistory.Clear();
            dataGridView1.DataSource = null;
        }

    }


}



