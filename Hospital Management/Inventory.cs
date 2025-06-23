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
using System.Data.SqlClient;

namespace Hospital_Management
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
            //textBox_InventoryLastUpdate.Text = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ");
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

 
        private void textBox_InventoryLastUpdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearchSQL_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=OKQWERTY\\SQLEXPRESS;Database=HMSDB;Trusted_Connection=True;";

            string query = "SELECT * FROM Inventory WHERE 1=1";

            // Add filters if fields are not empty
            if (!string.IsNullOrWhiteSpace(textBox_ItemID.Text))
                query += " AND ItemID = @ItemID";
            if (!string.IsNullOrWhiteSpace(textBox_InventoryName.Text))
                query += " AND Name LIKE @Name";
            if (!string.IsNullOrWhiteSpace(textBox_InventoryQuantity.Text))
                query += " AND Quantity = @Quantity";
            if (!string.IsNullOrWhiteSpace(textBox_InventoryThreshold.Text))
                query += " AND Threshold = @Threshold";
            if (!string.IsNullOrWhiteSpace(textBox_InventoryLastUpdate.Text))
                query += " AND LastUpdated = @LastUpdated";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (!string.IsNullOrWhiteSpace(textBox_ItemID.Text))
                    cmd.Parameters.AddWithValue("@ItemID", textBox_ItemID.Text);
                if (!string.IsNullOrWhiteSpace(textBox_InventoryName.Text))
                    cmd.Parameters.AddWithValue("@Name", "%" + textBox_InventoryName.Text + "%");
                if (!string.IsNullOrWhiteSpace(textBox_InventoryQuantity.Text))
                    cmd.Parameters.AddWithValue("@Quantity", int.Parse(textBox_InventoryQuantity.Text));
                if (!string.IsNullOrWhiteSpace(textBox_InventoryThreshold.Text))
                    cmd.Parameters.AddWithValue("@Threshold", int.Parse(textBox_InventoryThreshold.Text));
                if (!string.IsNullOrWhiteSpace(textBox_InventoryLastUpdate.Text))
                    cmd.Parameters.AddWithValue("@LastUpdated", textBox_InventoryLastUpdate.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }


        private void buttonAddSQL_Click(object sender, EventArgs e)
        {
            string itemId = textBox_ItemID.Text;
            string name = textBox_InventoryName.Text;

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

            if (!DateTime.TryParse(textBox_InventoryLastUpdate.Text, out DateTime lastUpdated))
            {
                MessageBox.Show("Please enter a valid date for Last Updated.");
                return;
            }

            InventorySqlHelper helper = new InventorySqlHelper();
            helper.AddOrUpdateInventory(itemId, name, quantity, threshold, lastUpdated);

            MessageBox.Show("Inventory item added or updated successfully!");
        }


        public class InventorySqlHelper
        {
            private string connectionString = "Server=OKQWERTY\\SQLEXPRESS;Database=HMSDB;Trusted_Connection=True;";

            public void AddOrUpdateInventory(string itemId, string name, int quantity, int threshold, DateTime lastUpdated)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                MERGE Inventory AS target
                USING (SELECT @ItemID AS ItemID) AS source
                ON target.ItemID = source.ItemID
                WHEN MATCHED THEN
                    UPDATE SET Name = @Name, Quantity = @Quantity, Threshold = @Threshold, LastUpdated = @LastUpdated
                WHEN NOT MATCHED THEN
                    INSERT (ItemID, Name, Quantity, Threshold, LastUpdated)
                    VALUES (@ItemID, @Name, @Quantity, @Threshold, @LastUpdated);";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ItemID", itemId);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@Threshold", threshold);
                        cmd.Parameters.AddWithValue("@LastUpdated", lastUpdated);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}

