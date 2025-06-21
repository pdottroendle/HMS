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

        private void button_Users_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.ShowDialog();
        }

        private void button_patients_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.ShowDialog();
        }

        private void button_appointmentScheduling_Click(object sender, EventArgs e)
        {
            Appoinment appointment = new Appoinment();
            appointment.ShowDialog();
        }

        private void button_DataAnalytics_Click(object sender, EventArgs e)
        {
            DataAnalytics dataAnalytics = new DataAnalytics();
            dataAnalytics.ShowDialog();
        }

        private void button_Inventory_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.ShowDialog();
        }

        private void buttonInventoryLogs_Click(object sender, EventArgs e)
        {
            Inventory InventoryLog = new Inventory();
            InventoryLog.ShowDialog();
        }

        private void button_Notifications_Click(object sender, EventArgs e)
        {
            Notification notification = new Notification();
            notification.ShowDialog();
        }

        private void button_ChatSystem_Click(object sender, EventArgs e)
        {
            Chat chat = new Chat();
            chat.ShowDialog();
        }

        private void button_Vital_Click(object sender, EventArgs e)
        {
            Vital vital = new Vital();
            vital.ShowDialog();
        }
    }
}
