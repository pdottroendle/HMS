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

namespace BookManagementPractice
{
    public partial class LogInForm : Form
    {

        IMongoCollection<User> usersCollection;
        public LogInForm()
        {
            InitializeComponent();

            // Get connection string from app config
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

            // Get the name of the database from connection string
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;

            var mongoClient = new MongoClient(connectionString);

            // get the database
            var database = mongoClient.GetDatabase(databaseName);

            // get the collection
            usersCollection = database.GetCollection<User>("users");
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            //1. Get info from the user
            string username = textBox_username.Text;
            string password = textBox_password.Text;

            //2. check user info against the database to see if it exists
            var filter = Builders<User>.Filter.Eq("username", username) &
                Builders<User>.Filter.Eq("password", password);

            var user = usersCollection.Find(filter).FirstOrDefault();


            //3. If user exist, send them to the main form(form1), otherwise show them the error message
            if(user != null)
            {
                Form1 mainForm = new Form1();
                mainForm.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            //1. Get info from the user
            string username = textBox_username.Text;
            string password = textBox_password.Text;

            //2. check if the user already exist
            var filter = Builders<User>.Filter.Eq("username", username);

            var existingUser = usersCollection.Find(filter).FirstOrDefault();


            //3. if the user doesn't exist, we can add it to the database, otherwise show them a message that user already exist.

            if(existingUser == null) 
            {
                // add the user to the mondodb

                var user = new User
                {
                    Username = username,
                    Password = password
                };

                usersCollection.InsertOne(user);

                MessageBox.Show("Registration successful!");

            }
            else
            {
                MessageBox.Show("Username already exist, please choose a different one");
            }
        }
    }
}
