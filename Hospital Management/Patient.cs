using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
            LoadPatients();
        }

        private void LoadPatients()
        {
            using (var context = new HospitalContext())
            {
                var patients = context.Patients.ToList();
                dataGridView1.DataSource = patients;

                // Optional: adjust column headers, hide unwanted columns
                dataGridView1.Columns["PatientId"].HeaderText = "ID";
                dataGridView1.Columns["MedicalHistory"].Visible = false; // Hide if too long

                ClearForm();
            }
        }
      

        private void button_patientAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new HospitalContext())
                {
                    // Basic validation example
                    if (string.IsNullOrWhiteSpace(textBox_FirstName.Text) || string.IsNullOrWhiteSpace(textBox_LastName.Text))
                    {
                        MessageBox.Show("First Name and Last Name are required.");
                        return;
                    }

                    // Create new patient entity
                    var patient = new PatientData
                    {
                        FirstName = textBox_FirstName.Text.Trim(),
                        LastName = textBox_LastName.Text.Trim(),
                        DateOfBirth = dateTimePicker_DOB.Value.Date,  // get date only
                        Gender = textBox_Gender.Text.Trim(),
                        Phone = textBox_Phone.Text.Trim(),
                        Email = textBox_Email.Text.Trim(),
                        Address = textBox_Address.Text.Trim(),
                        MedicalHistory = textBox_medicalHistory.Text.Trim()
                    };

                    // Add to DB and save
                    context.Patients.Add(patient);
                    context.SaveChanges();

                    MessageBox.Show("Patient added successfully.");
                    LoadPatients(); // refresh grid or list

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding patient: " + ex.Message);
            }
        }

        private void button_patientEdit_Click(object sender, EventArgs e)
        {
            var patientId = GetSelectedPatientId();
            if (patientId == null)
            {
                MessageBox.Show("Please select a valid patient row to edit.");
                return;
            }

            try
            {
                using (var context = new HospitalContext())
                {
                    var patient = context.Patients.FirstOrDefault(p => p.PatientId == patientId.Value);
                    if (patient == null)
                    {
                        MessageBox.Show("Selected patient not found.");
                        return;
                    }

                   
                    if (string.IsNullOrWhiteSpace(textBox_FirstName.Text) || string.IsNullOrWhiteSpace(textBox_LastName.Text))
                    {
                        MessageBox.Show("First Name and Last Name cannot be empty.");
                        return;
                    }

                    patient.FirstName = textBox_FirstName.Text;
                    patient.LastName = textBox_LastName.Text;
                    patient.DateOfBirth = dateTimePicker_DOB.Value.Date;
                    patient.Gender = textBox_Gender.Text;
                    patient.Phone = textBox_Phone.Text;
                    patient.Email = textBox_Email.Text;
                    patient.Address = textBox_Address.Text;
                    patient.MedicalHistory = textBox_medicalHistory.Text;

                    context.SaveChanges();

                    MessageBox.Show("Patient updated successfully.");
                    LoadPatients();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating patient: " + ex.Message + "\n" + ex.InnerException?.Message);
            }
        }
        
    

        private void button_patientDelete_Click(object sender, EventArgs e)
        {
            var patientId = GetSelectedPatientId();
            if (patientId == null)
            {
                MessageBox.Show("Please select a valid patient row to delete.");
                return;
            }

            try
            {
                using (var context = new HospitalContext())
                {
                    var patient = context.Patients.FirstOrDefault(p => p.PatientId == patientId.Value);
                    if (patient == null)
                    {
                        MessageBox.Show("Selected patient not found.");
                        return;
                    }

                    var confirmResult = MessageBox.Show($"Are you sure to delete patient '{patient.FirstName} {patient.LastName}'?",
                                                        "Confirm Delete",
                                                        MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        context.Patients.Remove(patient);
                        context.SaveChanges();

                        MessageBox.Show("Patient deleted successfully.");
                        LoadPatients();
                        ClearForm();  // Optionally clear input fields after delete
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting patient: " + ex.Message + "\n" + ex.InnerException?.Message);
            }
        }
        private void ClearForm()
        {
            textBox_patientID.Clear();
            textBox_FirstName.Clear();
            textBox_LastName.Clear();
            textBox_Gender.Clear();
            textBox_Phone.Clear();
            textBox_Email.Clear();
            textBox_Address.Clear();
            textBox_medicalHistory.Clear();
            dateTimePicker_DOB.Value = DateTime.Today;

            // Optional: Set focus to the first input
            textBox_FirstName.Focus();
        }

        private void button_patientClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                textBox_FirstName.Text = row.Cells["FirstName"].Value?.ToString();
                textBox_LastName.Text = row.Cells["LastName"].Value?.ToString();

                if (DateTime.TryParse(row.Cells["DateOfBirth"].Value?.ToString(), out DateTime dob))
                    dateTimePicker_DOB.Value = dob;
                else
                    dateTimePicker_DOB.Value = DateTime.Today;

                textBox_Gender.Text = row.Cells["Gender"].Value?.ToString();
                textBox_Phone.Text = row.Cells["Phone"].Value?.ToString();
                textBox_Email.Text = row.Cells["Email"].Value?.ToString();
                textBox_Address.Text = row.Cells["Address"].Value?.ToString();
                textBox_medicalHistory.Text = row.Cells["MedicalHistory"].Value?.ToString();
            }
        }

        private int? GetSelectedPatientId()
        {
            if (dataGridView1.CurrentRow == null) return null;

            var cellValue = dataGridView1.CurrentRow.Cells["PatientId"].Value;
            if (cellValue == null) return null;

            if (int.TryParse(cellValue.ToString(), out int id))
                return id;

            return null;
        }
    }
    }


