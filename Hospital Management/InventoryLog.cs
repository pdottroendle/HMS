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
    public partial class InventoryLog : Form
    {
        // This will help to load the inventory log form
        public InventoryLog()
        {
            InitializeComponent();

            textBox_LogTimestamp.Text = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ");

        }
        // This allow to add any change for medicine 
        private void button_LogAdd_Click(object sender, EventArgs e)
        {
            string logId = textBoxLogID.Text;
            string itemId = textBoxLogItemID.Text;
            string userId = textBox_LogUserID.Text;
            string reason = textBox_LogReason.Text;

            if (!int.TryParse(textBox_LogChange.Text, out int changeAmount))
            {
                MessageBox.Show("Please enter a valid number for Change Amount.");
                return;
            }

            if (!DateTime.TryParse(textBox_LogTimestamp.Text, out DateTime timestamp))
            {
                MessageBox.Show("Please enter a valid date for Timestamp.");
                return;
            }

            InventoryLogSqlHelper helper = new InventoryLogSqlHelper();
            helper.AddOrUpdateInventoryLog(logId, itemId, changeAmount, timestamp, userId, reason);

            MessageBox.Show("Inventory log entry added or updated successfully!");
        }
        public class InventoryLogSqlHelper
        {
            private string connectionString = "Server=LAPTOP-MSNOAR3O\\SQLEXPRESS01;Database=HMSDB;Trusted_Connection=True;";

            public void AddOrUpdateInventoryLog(string logId, string itemId, int changeAmount, DateTime timestamp, string userId, string reason)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                MERGE InventoryLog AS target
                USING (SELECT @LogID AS LogID) AS source
                ON target.LogID = source.LogID
                WHEN MATCHED THEN
                    UPDATE SET ItemID = @ItemID, ChangeAmount = @ChangeAmount, Timestamp = @Timestamp, UserID = @UserID, Reason = @Reason
                WHEN NOT MATCHED THEN
                    INSERT (LogID, ItemID, ChangeAmount, Timestamp, UserID, Reason)
                    VALUES (@LogID, @ItemID, @ChangeAmount, @Timestamp, @UserID, @Reason);";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@LogID", logId);
                        cmd.Parameters.AddWithValue("@ItemID", itemId);
                        cmd.Parameters.AddWithValue("@ChangeAmount", changeAmount);
                        cmd.Parameters.AddWithValue("@Timestamp", timestamp);
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        cmd.Parameters.AddWithValue("@Reason", reason);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        // This button will help to view the data

        private void button_LogSearch_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=LAPTOP-MSNOAR3O\\SQLEXPRESS01;Database=HMSDB;Trusted_Connection=True;";
            string query = "SELECT * FROM InventoryLog WHERE 1=1";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;

                if (!string.IsNullOrWhiteSpace(textBoxLogID.Text))
                {
                    query += " AND LogID = @LogID";
                    cmd.Parameters.AddWithValue("@LogID", textBoxLogID.Text);
                }

                if (!string.IsNullOrWhiteSpace(textBoxLogItemID.Text))
                {
                    query += " AND ItemID = @ItemID";
                    cmd.Parameters.AddWithValue("@ItemID", textBoxLogItemID.Text);
                }

                if (!string.IsNullOrWhiteSpace(textBox_LogChange.Text))
                {
                    if (int.TryParse(textBox_LogChange.Text, out int changeAmount))
                    {
                        query += " AND ChangeAmount = @ChangeAmount";
                        cmd.Parameters.AddWithValue("@ChangeAmount", changeAmount);
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid number for Change Amount.");
                        return;
                    }
                }

                if (!string.IsNullOrWhiteSpace(textBox_LogTimestamp.Text))
                {
                    if (DateTime.TryParse(textBox_LogTimestamp.Text, out DateTime timestamp))
                    {
                        // Optional: compare only date part
                        query += " AND CAST(Timestamp AS DATE) = @Timestamp";
                        cmd.Parameters.AddWithValue("@Timestamp", timestamp.Date);
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid date for Timestamp.");
                        return;
                    }
                }

                if (!string.IsNullOrWhiteSpace(textBox_LogUserID.Text))
                {
                    query += " AND UserID = @UserID";
                    cmd.Parameters.AddWithValue("@UserID", textBox_LogUserID.Text);
                }

                if (!string.IsNullOrWhiteSpace(textBox_LogReason.Text))
                {
                    query += " AND Reason LIKE @Reason";
                    cmd.Parameters.AddWithValue("@Reason", "%" + textBox_LogReason.Text + "%");
                }

                cmd.CommandText = query;

                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewInventoryLog.DataSource = table;

                    if (table.Rows.Count == 0)
                    {
                        MessageBox.Show("No records found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during search: " + ex.Message);
                }
            }
        }



    }
}
