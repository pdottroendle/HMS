using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;
using MongoDB.Driver.Core.Events;
using MongoDB.Driver.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
            string itemID = textBox_ItemID.Text;
            string name = textBox_InventoryName.Text;
            string quantityText = textBox_InventoryQuantity.Text;
            string thresholdText = textBox_InventoryThreshold.Text;
            string lastUpdated = textBox_InventoryLastUpdate.Text;

            if (!int.TryParse(quantityText, out int quantity))
            {
                MessageBox.Show("Please enter a valid number for Quantity.");
                return;
            }
            if (!int.TryParse(thresholdText, out int threshold))
            {
                MessageBox.Show("Please enter a valid number for Threshold.");
                return;
            }

            string url = $"http://xlynseyes.ddns.net:3001/add_Inventory?ItemID={itemID}&Name={name}&Quantity={quantity}&Threshold={threshold}&LastUpdated={lastUpdated}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Item added successfully!");
                }
                else
                {
                    MessageBox.Show("Error adding item.");
                }
            }
        }

        private async void button_InventorySearch_Click(object sender, EventArgs e)
        {
            string alias = textBox_InventoryAlias.Text;
    
            string url = $"http://xlynseyes.ddns.net:3001/Inventory?ItemID={textBox_ItemID.Text}&Name={textBox_InventoryName.Text}&Quantity={textBox_InventoryQuantity.Text}&Threshold={textBox_InventoryThreshold.Text}&LastUpdated={textBox_InventoryLastUpdate.Text}";
            MessageBox.Show(url);

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    var items = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Data.DataTable>(responseData);
                    dataGridView1.DataSource = items;
                }
                else
                {
                    MessageBox.Show("Error searching for item.");
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_InventoryLastUpdate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

