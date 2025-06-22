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
    public partial class Notification : Form
    {
        public Notification()
        {
            InitializeComponent();
            textBox_NotificationTime.Text = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ");
            textBox_NotificationTime.ReadOnly = true;
            checkBox_IsRead.Checked = false;
        }

        private async void button_NotificationAdd_Click(object sender, EventArgs e)
        {
            string isRead = checkBox_IsRead.Checked.ToString().ToLower();
            string url = "";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Notification added successfully!");
                else
                    MessageBox.Show("Error adding notification.");
            }
        }

        private async void button_NotificationSearch_Click(object sender, EventArgs e)
        {
            string isRead = checkBox_IsRead.Checked ? "true" : "false";
            string url = "";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    var items = JsonConvert.DeserializeObject<System.Data.DataTable>(responseData);
                    dataGridView_Notification.DataSource = items;
                }
                else
                {
                    MessageBox.Show("Error searching notifications.");
                }
            }

        }
    }
}
