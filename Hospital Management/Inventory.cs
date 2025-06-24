
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
        // loading the inventory form
        public Inventory()
        {
            InitializeComponent();
            textBox_InventoryLastUpdate.Text = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ");
        }

        // search button will be connect with sql databases
        private void buttonSearchSQL_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=LAPTOP-MSNOAR3O\\SQLEXPRESS01;Database=HMSDB;Trusted_Connection=True;";
            string query = "SELECT * FROM Inventory WHERE 1=1";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;

                if (!string.IsNullOrEmpty(textBox_ItemID.Text))
                {
                    query += " AND ItemID = @ItemID";
                    cmd.Parameters.AddWithValue("@ItemID", textBox_ItemID.Text);
                }

                if (!string.IsNullOrEmpty(textBox_InventoryName.Text))
                {
                    query += " AND Name LIKE @Name";
                    cmd.Parameters.AddWithValue("@Name", "%" + textBox_InventoryName.Text + "%");
                }

                if (int.TryParse(textBox_InventoryQuantity.Text, out int quantity))
                {
                    query += " AND Quantity = @Quantity";
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                }

                if (int.TryParse(textBox_InventoryThreshold.Text, out int threshold))
                {
                    query += " AND Threshold = @Threshold";
                    cmd.Parameters.AddWithValue("@Threshold", threshold);
                }

                if (DateTime.TryParse(textBox_InventoryLastUpdate.Text, out DateTime lastUpdated))
                {
                    query += " AND CAST(LastUpdated AS DATE) = @LastUpdated";
                    cmd.Parameters.AddWithValue("@LastUpdated", lastUpdated.Date);
                }

                cmd.CommandText = query;

                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;

                    if (table.Rows.Count == 0)
                        MessageBox.Show("No records found.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }




        // this is the add button for inventory 
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

            if (quantity < threshold)
            {
                MessageBox.Show($"⚠️ Warning: Stock level is below the threshold for '{name}'.", "Low Stock Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // add or update inventory

        public class InventorySqlHelper
        {
            private string connectionString = "Server=LAPTOP-MSNOAR3O\\SQLEXPRESS01;Database=HMSDB;Trusted_Connection=True;";

            public void AddOrUpdateInventory(string itemId, string name, int quantity, int threshold, DateTime lastUpdated)
            {
                string query = @"
        MERGE INTO Inventory AS target
        USING (SELECT @ItemID AS ItemID) AS source
        ON target.ItemID = source.ItemID
        WHEN MATCHED THEN
            UPDATE SET 
                Name = @Name,
                Quantity = @Quantity,
                Threshold = @Threshold,
                LastUpdated = @LastUpdated
        WHEN NOT MATCHED THEN
            INSERT (ItemID, Name, Quantity, Threshold, LastUpdated)
            VALUES (@ItemID, @Name, @Quantity, @Threshold, @LastUpdated);";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ItemID", itemId);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@Threshold", threshold);
                    cmd.Parameters.AddWithValue("@LastUpdated", lastUpdated);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

        }

    }
}

