using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
namespace Hospital_Management
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
            textBox_InventoryLastUpdate.Text = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ");
        }

        private async void button_InventoryAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_InventoryQuantity.Text, out int quantity))
            {
                MessageBox.Show("Please enter a valid number for Quantity.");
                return;
            }
            if (!int.TryParse(textBox_InventoryThreshold.Text, out int threshold))
            {
                MessageBox.Show("Please enter a valid number for Threshold.");
                return;
            }

            string url = $"";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Item added successfully!");
                else
                    MessageBox.Show("Error adding item.");
            }
        }

        private async void button_InventorySearch_Click(object sender, EventArgs e)
        {
            string url = "";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    var items = JsonConvert.DeserializeObject<System.Data.DataTable>(responseData);
                    dataGridView1.DataSource = items;
                }
                else
                {
                    MessageBox.Show("Error searching for item.");
                }
            }
        }
    }
}

