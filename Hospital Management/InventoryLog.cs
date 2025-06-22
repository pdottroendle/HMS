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
    public partial class InventoryLog : Form
    {
        public InventoryLog()
        {
            InitializeComponent();

            textBox_LogTimestamp.Text = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ");

        }

        private async void button_LogAdd_Click(object sender, EventArgs e)
        {
            string url = "";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Inventory log added successfully!");
                else
                    MessageBox.Show("Error adding inventory log.");
            }
        }

        private async void button_LogSearch_Click(object sender, EventArgs e)
        {
            string url = "";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    var items = JsonConvert.DeserializeObject<System.Data.DataTable>(responseData);
                    dataGridViewInventoryLog.DataSource = items;
                }
                else
                {
                    MessageBox.Show("Error searching inventory logs.");
                }
            }
        }
    }
}
