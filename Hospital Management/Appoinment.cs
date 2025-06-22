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
    public partial class Appoinment : Form
    {
        public Appoinment()
        {
            InitializeComponent();
            dateTimePicker_AppTime.Value = DateTime.UtcNow;
        }

        private async void button_AppAdd_Click(object sender, EventArgs e)
        {
            string url = "";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Appointment added successfully!");
                else
                    MessageBox.Show("Error adding appointment.");
            }
        }

        private async void button_AppSearch_Click(object sender, EventArgs e)
        {
            string url = "";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    var items = JsonConvert.DeserializeObject<System.Data.DataTable>(responseData);
                    dataGridView_Appointment.DataSource = items;
                }
                else
                {
                    MessageBox.Show("Error searching for appointments.");
                }
            }
        }
    }
}
