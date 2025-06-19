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
using MongoDB.Driver;


namespace Hospital_Management
{
    public partial class Register : Form
    {
        private IMongoCollection<User> usersCollection;
        public Register()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);

            usersCollection = database.GetCollection<User>("User");
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            string username = textBox_registerUsername.Text;
            string password = textBox_registerPassword.Text;
            string role = textBox_role.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            var existingUser = usersCollection.Find(u => u.username == username).FirstOrDefault();
            if (existingUser != null)
            {
                MessageBox.Show("Username already exists.");
                return;
            }

            var hashedPassword = PasswordHelper.HashPassword(password);

            var newUser = new User
            {
                username = username,
                passwordHash = hashedPassword,
                role = role
            };

            usersCollection.InsertOne(newUser);
            MessageBox.Show("Registration successful!");
            this.Close(); // Optionally return to login form
        }
    }

 }

