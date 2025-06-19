using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
           Login loginForm = new Login();
            loginForm.ShowDialog();


        }

        private void button_register_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.ShowDialog();
        }

        private void button_patientManagement_Click(object sender, EventArgs e)
        {
            Patient patientForm = new Patient();
            patientForm.ShowDialog();
        }

        private void button_appointmentScheduling_Click(object sender, EventArgs e)
        {
         
        }

        private void button_Inventory_Click(object sender, EventArgs e)
        {

        }

        private void button_DataAnalytics_Click(object sender, EventArgs e)
        {

        }

        private void button_Notifications_Click(object sender, EventArgs e)
        {

        }

        private void button_ChatSystem_Click(object sender, EventArgs e)
        {

        }

        private void button_PatientMonitoring_Click(object sender, EventArgs e)
        {

        }

        private void button_Dashboard_Click(object sender, EventArgs e)
        {

        }
    }
}
