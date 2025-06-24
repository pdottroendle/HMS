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
    // loading the Notification form
    public partial class Notification : Form
    {
        public Notification()
        {
            InitializeComponent();
            textBox_NotificationTime.Text = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ");
            textBox_NotificationTime.ReadOnly = true;
            checkBox_IsRead.Checked = false;
        }
        // helping connect to SQL databases
        public class NotificationSqlHelper
        {
            private string connectionString = "Server=LAPTOP-MSNOAR3O\\SQLEXPRESS01;Database=HMSDB;Trusted_Connection=True;";

            public void AddOrUpdateNotification(string notificationId, string userId, string message, DateTime timestamp, int isRead)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                MERGE Notification AS target
                USING (SELECT @NotificationID AS NotificationID) AS source
                ON target.NotificationID = source.NotificationID
                WHEN MATCHED THEN
                    UPDATE SET UserID = @UserID, Message = @Message, Timestamp = @Timestamp, IsRead = @IsRead
                WHEN NOT MATCHED THEN
                    INSERT (NotificationID, UserID, Message, Timestamp, IsRead)
                    VALUES (@NotificationID, @UserID, @Message, @Timestamp, @IsRead);";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NotificationID", notificationId);
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        cmd.Parameters.AddWithValue("@Message", message);
                        cmd.Parameters.AddWithValue("@Timestamp", timestamp);
                        cmd.Parameters.AddWithValue("@IsRead", isRead);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
        // add button for notification
        private void button_NotificationAdd_Click(object sender, EventArgs e)
        {
            string notificationId = textBox_NotificationID.Text;
            string userId = textBox_UserID.Text;
            string message = textBox_Message.Text;

            if (!DateTime.TryParse(textBox_NotificationTime.Text, out DateTime timestamp))
            {
                MessageBox.Show("Please enter a valid timestamp.");
                return;
            }

            if (!int.TryParse(checkBox_IsRead.Text, out int isRead))
            {
                MessageBox.Show("Please enter 0 or 1 for IsRead.");
                return;
            }

            NotificationSqlHelper helper = new NotificationSqlHelper();
            helper.AddOrUpdateNotification(notificationId, userId, message, timestamp, isRead);

            MessageBox.Show("Notification added or updated successfully!");
        }

        // this button is to view the information for notification
        private void button_NotificationSearch_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=LAPTOP-MSNOAR3O\\SQLEXPRESS01;Database=HMSDB;Trusted_Connection=True;";
            string query = "SELECT * FROM Notification WHERE 1=1";

            if (!string.IsNullOrWhiteSpace(textBox_NotificationID.Text))
                query += " AND NotificationID = @NotificationID";
            if (!string.IsNullOrWhiteSpace(textBox_UserID.Text))
                query += " AND UserID = @UserID";
            if (!string.IsNullOrWhiteSpace(textBox_Message.Text))
                query += " AND Message LIKE @Message";
            if (!string.IsNullOrWhiteSpace(textBox_NotificationTime.Text))
                query += " AND Timestamp = @Timestamp";
            if (!string.IsNullOrWhiteSpace(checkBox_IsRead.Text))
                query += " AND IsRead = @IsRead";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (!string.IsNullOrWhiteSpace(textBox_NotificationID.Text))
                    cmd.Parameters.AddWithValue("@NotificationID", textBox_NotificationID.Text);
                if (!string.IsNullOrWhiteSpace(textBox_UserID.Text))
                    cmd.Parameters.AddWithValue("@UserID", textBox_UserID.Text);
                if (!string.IsNullOrWhiteSpace(textBox_Message.Text))
                    cmd.Parameters.AddWithValue("@Message", "%" + textBox_Message.Text + "%");
                if (!string.IsNullOrWhiteSpace(textBox_NotificationTime.Text))
                    cmd.Parameters.AddWithValue("@Timestamp", DateTime.Parse(textBox_NotificationTime.Text));
                if (!string.IsNullOrWhiteSpace(checkBox_IsRead.Text))
                    cmd.Parameters.AddWithValue("@IsRead", int.Parse(checkBox_IsRead.Text));

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView_Notification.DataSource = table;
            }
        }

    }
}
