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

namespace Hospital_Management
{
    public partial class Login : Form
    {
        IMongoCollection<User> usersCollection;

        public Login()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;


            var databaseName = MongoUrl.Create(connectionString).DatabaseName;

            var mongoClient = new MongoClient(connectionString);


            var database = mongoClient.GetDatabase(databaseName);


            usersCollection = database.GetCollection<User>("User");

        }

        private void button_login_Click(object sender, EventArgs e)
        {

            string username = textBox_loginUserName.Text;
            string password = textBox_loginPassword.Text;


            var filter = Builders<User>.Filter.Eq(u => u.username, username) &
              Builders<User>.Filter.Eq(u => u.passwordHash, password);

            var user = usersCollection.Find(filter).FirstOrDefault();

            if (user != null)
            {
                MessageBox.Show("Login successful!");

                // Open main form
                Form1 mainForm = new Form1();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }

        }
    }
}
