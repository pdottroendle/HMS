using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Management
{
    public partial class DataAnalytics : Form
    {
        public DataAnalytics()
        {
            InitializeComponent();
        }
        public class ReportSqlHelper
        {
            private string connectionString = "Server=OKQWERTY\\SQLEXPRESS;Database=HMSDB;Trusted_Connection=True;";

            public void AddOrUpdateReport(string reportId, string type, string generatedBy, DateTime timestamp, string filePath)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                MERGE Report AS target
                USING (SELECT @ReportID AS ReportID) AS source
                ON target.ReportID = source.ReportID
                WHEN MATCHED THEN
                    UPDATE SET Type = @Type, GeneratedBy = @GeneratedBy, Timestamp = @Timestamp, FilePath = @FilePath
                WHEN NOT MATCHED THEN
                    INSERT (ReportID, Type, GeneratedBy, Timestamp, FilePath)
                    VALUES (@ReportID, @Type, @GeneratedBy, @Timestamp, @FilePath);";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ReportID", reportId);
                        cmd.Parameters.AddWithValue("@Type", type);
                        cmd.Parameters.AddWithValue("@GeneratedBy", generatedBy);
                        cmd.Parameters.AddWithValue("@Timestamp", timestamp);
                        cmd.Parameters.AddWithValue("@FilePath", filePath);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private async void buttonDataAdd_Click(object sender, EventArgs e)
        {
            string reportId = textBox_ReportID.Text;
            string type = comboBoxReportType.Text;
            string generatedBy = textBox_GeneratedBy.Text;
            string filePath = textBox_ReportFilepath.Text;

            if (!DateTime.TryParse(dateTimePicker2.Text, out DateTime timestamp))
            {
                MessageBox.Show("Please enter a valid timestamp.");
                return;
            }

            ReportSqlHelper helper = new ReportSqlHelper();
            helper.AddOrUpdateReport(reportId, type, generatedBy, timestamp, filePath);

            MessageBox.Show("Report added or updated successfully!");
        }


        private async void buttonDataSearch_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=OKQWERTY\\SQLEXPRESS;Database=HMSDB;Trusted_Connection=True;";
            string query = "SELECT * FROM Report WHERE 1=1";

            if (!string.IsNullOrWhiteSpace(textBox_ReportID.Text))
                query += " AND ReportID = @ReportID";
            if (!string.IsNullOrWhiteSpace(comboBoxReportType.Text))
                query += " AND Type = @Type";
            if (!string.IsNullOrWhiteSpace(textBox_GeneratedBy.Text))
                query += " AND GeneratedBy = @GeneratedBy";
            if (!string.IsNullOrWhiteSpace(dateTimePicker2.Text))
                query += " AND Timestamp = @Timestamp";
            if (!string.IsNullOrWhiteSpace(textBox_ReportFilepath.Text))
                query += " AND FilePath LIKE @FilePath";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (!string.IsNullOrWhiteSpace(textBox_ReportID.Text))
                    cmd.Parameters.AddWithValue("@ReportID", textBox_ReportID.Text);
                if (!string.IsNullOrWhiteSpace(comboBoxReportType.Text))
                    cmd.Parameters.AddWithValue("@Type", comboBoxReportType.Text);
                if (!string.IsNullOrWhiteSpace(textBox_GeneratedBy.Text))
                    cmd.Parameters.AddWithValue("@GeneratedBy", textBox_GeneratedBy.Text);
                if (!string.IsNullOrWhiteSpace(dateTimePicker2.Text))
                    cmd.Parameters.AddWithValue("@Timestamp", DateTime.Parse(dateTimePicker2.Text));
                if (!string.IsNullOrWhiteSpace(textBox_ReportFilepath.Text))
                    cmd.Parameters.AddWithValue("@FilePath", "%" + textBox_ReportFilepath.Text + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView_ReportResults.DataSource = table;
            }
        }

    }
}

