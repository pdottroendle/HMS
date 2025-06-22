using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private async void buttonUserAdd_Click(object sender, EventArgs e)
        {
            string url = "";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Inventory added!");
                }
                else
                {
                    MessageBox.Show("Error adding inventory.");
                }
            }
        }

        private async void buttonUserSearch_Click(object sender, EventArgs e)
        {
            string url = "";
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
