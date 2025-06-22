using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class DataAnalytics : Form
    {
        public DataAnalytics()
        {
            InitializeComponent();
        }

        private async void buttonDataAdd_Click(object sender, EventArgs e)
        {
            string url = "";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Report added successfully!");
                else
                    MessageBox.Show("Error adding report.");
            }
        }

        private async void buttonDataSearch_Click(object sender, EventArgs e)
        {
            string url = "";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    var items = JsonConvert.DeserializeObject<System.Data.DataTable>(responseData);
                    dataGridView_ReportResults.DataSource = items;
                }
                else
                {
                    MessageBox.Show("Error searching reports.");
                }
            }
        }
    }
  }

