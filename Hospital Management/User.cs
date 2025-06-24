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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hospital_Management
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        // This async need to be using for MongoDB connection
        // This add will allow user to register to the system
        private async void button_Add_Click(object sender, EventArgs e)
        {
            string UserID = textBox_UserID.Text;
            string Username = textBox_Username.Text;
            string PasswordHash = textBox_Password.Text;
            string Role = textBox_Role.Text;
            string Email = textBox_Email.Text;
            string Phone = textBox_Phone.Text;

            string url = $"http://xlynseyes.ddns.net:3001/add_User?UserID={UserID}&Username={Username}&PasswordHash={PasswordHash}&Role={Role}&Email={Email}&Phone={Phone}";
            MessageBox.Show(url);

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
        // This is the login for users
        private async void button_Search_Click(object sender, EventArgs e)
        {

            string url = $"http://xlynseyes.ddns.net:3001/User?UserID={textBox_UserID.Text}&Username={textBox_Username.Text}&PasswordHash={textBox_Password.Text}&Role={textBox_Role.Text}&Email={textBox_Email.Text}&Phone={textBox_Phone.Text}";
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

     
    }
}

