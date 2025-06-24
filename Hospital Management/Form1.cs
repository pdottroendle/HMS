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
        // this form will help to load each of the form when click to each form
        public Form1()
        {
            InitializeComponent();
        }
        // this is user form that allow to login and register
        private void button_Users_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.ShowDialog();
        }
        // this is patient management allow to view, add patient information
        private void button_patients_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.ShowDialog();
        }
        // this will help to schedule an appoinment
        private void button_appointmentScheduling_Click(object sender, EventArgs e)
        {
            Appoinment appointment = new Appoinment();
            appointment.ShowDialog();
        }
        // to report any data 
        private void button_DataAnalytics_Click(object sender, EventArgs e)
        {
            DataAnalytics dataAnalytics = new DataAnalytics();
            dataAnalytics.ShowDialog();
        }
        // This will help user to check inventory status and stock update
        private void button_Inventory_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.ShowDialog();
        }
        // this is the inventory logs
        private void buttonInventoryLogs_Click(object sender, EventArgs e)
        {
            InventoryLog InventoryLog = new InventoryLog();
            InventoryLog.ShowDialog();
        }
        // This is the notification system 
        private void button_Notifications_Click(object sender, EventArgs e)
        {
            Notification notification = new Notification();
            notification.ShowDialog();
        }
        // this is the chat system for patient, doctor
        private void button_ChatSystem_Click(object sender, EventArgs e)
        {
            Chat chat = new Chat();
            chat.ShowDialog();
        }
        // This is the patient Monitoring 
        private void button_Vital_Click(object sender, EventArgs e)
        {
            Vital vital = new Vital();
            vital.ShowDialog();
        }
        // This is the dashboard update for bed availability and emergency status
        private void button_DashBoardUpdate_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.ShowDialog();
        }
    }
}
