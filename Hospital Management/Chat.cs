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

namespace Hospital_Management
{
    public partial class Chat : Form
    {
        public Chat()
        {
            InitializeComponent();
            textBox_ChatTimestamp.Text = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ");
            textBox_ChatTimestamp.ReadOnly = true;
        }


        private async void buttonChatAdd_Click(object sender, EventArgs e)
        {
            string url = "";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Message sent successfully!");
                else
                    MessageBox.Show("Error sending message.");
            }
        }
        private async void buttonChatSearch_Click(object sender, EventArgs e)
        {

            string url = "";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    var messages = JsonConvert.DeserializeObject<System.Data.DataTable>(responseData);
                    dataGridViewChat.DataSource = messages;
                }
                else
                {
                    MessageBox.Show("Error searching messages.");
                }
            }
        }
    }
}
