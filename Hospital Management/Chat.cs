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
    public partial class Chat : Form
    {
        public Chat()
        {
            InitializeComponent();
            textBox_Timestamp.Text = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ");
            textBox_Timestamp.ReadOnly = true;
        }

        public class MessageSqlHelper
        {
            private string connectionString = "Server=OKQWERTY\\SQLEXPRESS;Database=HMSDB;Trusted_Connection=True;";

            public void AddOrUpdateMessage(string messageId, string senderId, string receiverId, DateTime timestamp, string content)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                MERGE Message AS target
                USING (SELECT @MessageID AS MessageID) AS source
                ON target.MessageID = source.MessageID
                WHEN MATCHED THEN
                    UPDATE SET SenderID = @SenderID, ReceiverID = @ReceiverID, Timestamp = @Timestamp, Content = @Content
                WHEN NOT MATCHED THEN
                    INSERT (MessageID, SenderID, ReceiverID, Timestamp, Content)
                    VALUES (@MessageID, @SenderID, @ReceiverID, @Timestamp, @Content);";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MessageID", messageId);
                        cmd.Parameters.AddWithValue("@SenderID", senderId);
                        cmd.Parameters.AddWithValue("@ReceiverID", receiverId);
                        cmd.Parameters.AddWithValue("@Timestamp", timestamp);
                        cmd.Parameters.AddWithValue("@Content", content);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private async void buttonChatAdd_Click(object sender, EventArgs e)
        {
            string messageId = textBox_MessageID.Text;
            string senderId = textBox_SenderID.Text;
            string receiverId = textBox_ReceiverID.Text;
            string content = textBox_Content.Text;

            if (!DateTime.TryParse(textBox_Timestamp.Text, out DateTime timestamp))
            {
                MessageBox.Show("Please enter a valid timestamp.");
                return;
            }

            MessageSqlHelper helper = new MessageSqlHelper();
            helper.AddOrUpdateMessage(messageId, senderId, receiverId, timestamp, content);

            MessageBox.Show("Message added or updated successfully!");
        }

        private async void buttonChatSearch_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=OKQWERTY\\SQLEXPRESS;Database=HMSDB;Trusted_Connection=True;";
            string query = "SELECT * FROM Message WHERE 1=1";

            if (!string.IsNullOrWhiteSpace(textBox_MessageID.Text))
                query += " AND MessageID = @MessageID";
            if (!string.IsNullOrWhiteSpace(textBox_SenderID.Text))
                query += " AND SenderID = @SenderID";
            if (!string.IsNullOrWhiteSpace(textBox_ReceiverID.Text))
                query += " AND ReceiverID = @ReceiverID";
            if (!string.IsNullOrWhiteSpace(textBox_Timestamp.Text))
                query += " AND Timestamp = @Timestamp";
            if (!string.IsNullOrWhiteSpace(textBox_Content.Text))
                query += " AND Content LIKE @Content";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (!string.IsNullOrWhiteSpace(textBox_MessageID.Text))
                    cmd.Parameters.AddWithValue("@MessageID", textBox_MessageID.Text);
                if (!string.IsNullOrWhiteSpace(textBox_SenderID.Text))
                    cmd.Parameters.AddWithValue("@SenderID", textBox_SenderID.Text);
                if (!string.IsNullOrWhiteSpace(textBox_ReceiverID.Text))
                    cmd.Parameters.AddWithValue("@ReceiverID", textBox_ReceiverID.Text);
                if (!string.IsNullOrWhiteSpace(textBox_Timestamp.Text))
                    cmd.Parameters.AddWithValue("@Timestamp", DateTime.Parse(textBox_Timestamp.Text));
                if (!string.IsNullOrWhiteSpace(textBox_Content.Text))
                    cmd.Parameters.AddWithValue("@Content", "%" + textBox_Content.Text + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewChat.DataSource = table;
            }
        }

    }
}
