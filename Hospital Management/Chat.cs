using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class Chat : Form
    {
        // This will help to load the chat form
        public Chat()
        {
            InitializeComponent();
            textBox_Timestamp.Text = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ");
            textBox_Timestamp.ReadOnly = true;
        }
        // This is the connection to SQL
        public class MessageSqlHelper
        {
            private string connectionString = "Server=LAPTOP-MSNOAR3O\\SQLEXPRESS01;Database=HMSDB;Trusted_Connection=True;";


            public void AddOrUpdateMessage(string messageId, string senderId, string receiverId, DateTime timestamp, string content)
            {
                if (string.IsNullOrWhiteSpace(messageId))
                    throw new ArgumentException("MessageID cannot be empty.");

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                INSERT INTO Message (MessageID, SenderID, ReceiverID, Timestamp, Content)
                VALUES (@MessageID, @SenderID, @ReceiverID, @Timestamp, @Content)";

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
        // This button allow to add message 
        private void buttonChatAdd_Click(object sender, EventArgs e)
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
        // This button allow to view the message information data
        private void buttonChatSearch_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=LAPTOP-MSNOAR3O\\SQLEXPRESS01;Database=HMSDB;Trusted_Connection=True;";
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
