namespace Hospital_Management
{
    partial class Appoinment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_Appointment = new System.Windows.Forms.DataGridView();
            this.label_AppPatient = new System.Windows.Forms.Label();
            this.label_AppDoctor = new System.Windows.Forms.Label();
            this.label_AppDateTime = new System.Windows.Forms.Label();
            this.label_AppStatus = new System.Windows.Forms.Label();
            this.label_AppNotes = new System.Windows.Forms.Label();
            this.comboBox_AppPatient = new System.Windows.Forms.ComboBox();
            this.comboBox_AppDoctor = new System.Windows.Forms.ComboBox();
            this.comboBox_AppStatus = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_AppTime = new System.Windows.Forms.DateTimePicker();
            this.textBox_AppNotes = new System.Windows.Forms.TextBox();
            this.button_AppAdd = new System.Windows.Forms.Button();
            this.button_AppSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Appointment)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Appointment
            // 
            this.dataGridView_Appointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Appointment.Location = new System.Drawing.Point(498, 44);
            this.dataGridView_Appointment.Name = "dataGridView_Appointment";
            this.dataGridView_Appointment.RowHeadersWidth = 72;
            this.dataGridView_Appointment.RowTemplate.Height = 31;
            this.dataGridView_Appointment.Size = new System.Drawing.Size(882, 433);
            this.dataGridView_Appointment.TabIndex = 0;
            // 
            // label_AppPatient
            // 
            this.label_AppPatient.AutoSize = true;
            this.label_AppPatient.Location = new System.Drawing.Point(12, 86);
            this.label_AppPatient.Name = "label_AppPatient";
            this.label_AppPatient.Size = new System.Drawing.Size(78, 25);
            this.label_AppPatient.TabIndex = 1;
            this.label_AppPatient.Text = "Patient:";
            // 
            // label_AppDoctor
            // 
            this.label_AppDoctor.AutoSize = true;
            this.label_AppDoctor.Location = new System.Drawing.Point(12, 181);
            this.label_AppDoctor.Name = "label_AppDoctor";
            this.label_AppDoctor.Size = new System.Drawing.Size(75, 25);
            this.label_AppDoctor.TabIndex = 1;
            this.label_AppDoctor.Text = "Doctor:";
            // 
            // label_AppDateTime
            // 
            this.label_AppDateTime.AutoSize = true;
            this.label_AppDateTime.Location = new System.Drawing.Point(12, 264);
            this.label_AppDateTime.Name = "label_AppDateTime";
            this.label_AppDateTime.Size = new System.Drawing.Size(103, 25);
            this.label_AppDateTime.TabIndex = 1;
            this.label_AppDateTime.Text = "DateTime:";
            // 
            // label_AppStatus
            // 
            this.label_AppStatus.AutoSize = true;
            this.label_AppStatus.Location = new System.Drawing.Point(12, 343);
            this.label_AppStatus.Name = "label_AppStatus";
            this.label_AppStatus.Size = new System.Drawing.Size(74, 25);
            this.label_AppStatus.TabIndex = 1;
            this.label_AppStatus.Text = "Status:";
            // 
            // label_AppNotes
            // 
            this.label_AppNotes.AutoSize = true;
            this.label_AppNotes.Location = new System.Drawing.Point(12, 437);
            this.label_AppNotes.Name = "label_AppNotes";
            this.label_AppNotes.Size = new System.Drawing.Size(69, 25);
            this.label_AppNotes.TabIndex = 1;
            this.label_AppNotes.Text = "Notes:";
            // 
            // comboBox_AppPatient
            // 
            this.comboBox_AppPatient.FormattingEnabled = true;
            this.comboBox_AppPatient.Location = new System.Drawing.Point(211, 86);
            this.comboBox_AppPatient.Name = "comboBox_AppPatient";
            this.comboBox_AppPatient.Size = new System.Drawing.Size(162, 32);
            this.comboBox_AppPatient.TabIndex = 2;
            // 
            // comboBox_AppDoctor
            // 
            this.comboBox_AppDoctor.FormattingEnabled = true;
            this.comboBox_AppDoctor.Location = new System.Drawing.Point(211, 174);
            this.comboBox_AppDoctor.Name = "comboBox_AppDoctor";
            this.comboBox_AppDoctor.Size = new System.Drawing.Size(162, 32);
            this.comboBox_AppDoctor.TabIndex = 2;
            // 
            // comboBox_AppStatus
            // 
            this.comboBox_AppStatus.FormattingEnabled = true;
            this.comboBox_AppStatus.Location = new System.Drawing.Point(211, 343);
            this.comboBox_AppStatus.Name = "comboBox_AppStatus";
            this.comboBox_AppStatus.Size = new System.Drawing.Size(162, 32);
            this.comboBox_AppStatus.TabIndex = 2;
            // 
            // dateTimePicker_AppTime
            // 
            this.dateTimePicker_AppTime.Location = new System.Drawing.Point(143, 264);
            this.dateTimePicker_AppTime.Name = "dateTimePicker_AppTime";
            this.dateTimePicker_AppTime.Size = new System.Drawing.Size(329, 29);
            this.dateTimePicker_AppTime.TabIndex = 3;
            // 
            // textBox_AppNotes
            // 
            this.textBox_AppNotes.Location = new System.Drawing.Point(211, 434);
            this.textBox_AppNotes.Name = "textBox_AppNotes";
            this.textBox_AppNotes.Size = new System.Drawing.Size(183, 29);
            this.textBox_AppNotes.TabIndex = 4;
            // 
            // button_AppAdd
            // 
            this.button_AppAdd.Location = new System.Drawing.Point(705, 517);
            this.button_AppAdd.Name = "button_AppAdd";
            this.button_AppAdd.Size = new System.Drawing.Size(122, 39);
            this.button_AppAdd.TabIndex = 5;
            this.button_AppAdd.Text = "Add";
            this.button_AppAdd.UseVisualStyleBackColor = true;
            // 
            // button_AppSearch
            // 
            this.button_AppSearch.Location = new System.Drawing.Point(996, 515);
            this.button_AppSearch.Name = "button_AppSearch";
            this.button_AppSearch.Size = new System.Drawing.Size(126, 43);
            this.button_AppSearch.TabIndex = 5;
            this.button_AppSearch.Text = "Search";
            this.button_AppSearch.UseVisualStyleBackColor = true;
            // 
            // Appoinment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1639, 615);
            this.Controls.Add(this.button_AppSearch);
            this.Controls.Add(this.button_AppAdd);
            this.Controls.Add(this.textBox_AppNotes);
            this.Controls.Add(this.dateTimePicker_AppTime);
            this.Controls.Add(this.comboBox_AppStatus);
            this.Controls.Add(this.comboBox_AppDoctor);
            this.Controls.Add(this.comboBox_AppPatient);
            this.Controls.Add(this.label_AppNotes);
            this.Controls.Add(this.label_AppStatus);
            this.Controls.Add(this.label_AppDateTime);
            this.Controls.Add(this.label_AppDoctor);
            this.Controls.Add(this.label_AppPatient);
            this.Controls.Add(this.dataGridView_Appointment);
            this.Name = "Appoinment";
            this.Text = "Appoinment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Appointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Appointment;
        private System.Windows.Forms.Label label_AppPatient;
        private System.Windows.Forms.Label label_AppDoctor;
        private System.Windows.Forms.Label label_AppDateTime;
        private System.Windows.Forms.Label label_AppStatus;
        private System.Windows.Forms.Label label_AppNotes;
        private System.Windows.Forms.ComboBox comboBox_AppPatient;
        private System.Windows.Forms.ComboBox comboBox_AppDoctor;
        private System.Windows.Forms.ComboBox comboBox_AppStatus;
        private System.Windows.Forms.DateTimePicker dateTimePicker_AppTime;
        private System.Windows.Forms.TextBox textBox_AppNotes;
        private System.Windows.Forms.Button button_AppAdd;
        private System.Windows.Forms.Button button_AppSearch;
    }
}