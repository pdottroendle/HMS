using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
//////////////////////////////////////////////////
using System.Net.Http;
/////////////////////////////////////////////////
using Newtonsoft.Json;
// Ensure that the Newtonsoft.Json package is installed in your project.
// To fix the CS0246 error, follow these steps:

// 1. Open the NuGet Package Manager in Visual Studio:
//    Tools -> NuGet Package Manager -> Manage NuGet Packages for Solution.

// 2. Search for "Newtonsoft.Json" in the "Browse" tab and install the latest version for your project.

// 3. After installation, the reference to Newtonsoft.Json will be resolved, and the error will be fixed.

// No changes to the code are required if the package is installed correctly. However, ensure the following using directive is present:

namespace BookManagementPractice
{
   
        public partial class Form1 : Form
        {
            public Form1()
        {
            InitializeComponent();
            txtLastUpdated.Text = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ");
        }

            private async void btnAdd_Click(object sender, EventArgs e)
            {
                string itemID = txtItemID.Text;
                string name = txtName.Text;
                string quantityText = txtQuantity.Text;
                string thresholdText = txtThreshold.Text;
                string lastUpdated = txtLastUpdated.Text;

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

            private async void btnSearch_Click(object sender, EventArgs e)
            {
                string name = txtSearchName.Text;
                string url = $"http://xlynseyes.ddns.net:3001/Inventory?Name={name}";

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
        }
    }
