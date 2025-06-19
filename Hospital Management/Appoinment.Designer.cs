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
            this.dataGridViewAppoinments = new System.Windows.Forms.DataGridView();
            this.buttonAppointmentAdd = new System.Windows.Forms.Button();
            this.buttonAppoinmentCancel = new System.Windows.Forms.Button();
            this.labelPatients = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.labelAppoinmentNote = new System.Windows.Forms.Label();
            this.textBoxReason = new System.Windows.Forms.TextBox();
            this.comboBoxPatients = new System.Windows.Forms.ComboBox();
            this.dateTimePickerAppoinments = new System.Windows.Forms.DateTimePicker();
            this.buttonView = new System.Windows.Forms.Button();
            this.labelDoctor = new System.Windows.Forms.Label();
            this.comboBoxDoctor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppoinments)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAppoinments
            // 
            this.dataGridViewAppoinments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppoinments.Location = new System.Drawing.Point(495, 46);
            this.dataGridViewAppoinments.Name = "dataGridViewAppoinments";
            this.dataGridViewAppoinments.RowHeadersWidth = 72;
            this.dataGridViewAppoinments.RowTemplate.Height = 31;
            this.dataGridViewAppoinments.Size = new System.Drawing.Size(839, 489);
            this.dataGridViewAppoinments.TabIndex = 0;
            // 
            // buttonAppointmentAdd
            // 
            this.buttonAppointmentAdd.Location = new System.Drawing.Point(637, 557);
            this.buttonAppointmentAdd.Name = "buttonAppointmentAdd";
            this.buttonAppointmentAdd.Size = new System.Drawing.Size(137, 54);
            this.buttonAppointmentAdd.TabIndex = 1;
            this.buttonAppointmentAdd.Text = "Add";
            this.buttonAppointmentAdd.UseVisualStyleBackColor = true;
            this.buttonAppointmentAdd.Click += new System.EventHandler(this.buttonAppointmentAdd_Click);
            // 
            // buttonAppoinmentCancel
            // 
            this.buttonAppoinmentCancel.Location = new System.Drawing.Point(1111, 557);
            this.buttonAppoinmentCancel.Name = "buttonAppoinmentCancel";
            this.buttonAppoinmentCancel.Size = new System.Drawing.Size(140, 54);
            this.buttonAppoinmentCancel.TabIndex = 2;
            this.buttonAppoinmentCancel.Text = "Cancel";
            this.buttonAppoinmentCancel.UseVisualStyleBackColor = true;
            // 
            // labelPatients
            // 
            this.labelPatients.AutoSize = true;
            this.labelPatients.Location = new System.Drawing.Point(33, 187);
            this.labelPatients.Name = "labelPatients";
            this.labelPatients.Size = new System.Drawing.Size(78, 25);
            this.labelPatients.TabIndex = 3;
            this.labelPatients.Text = "Patient:";
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(8, 330);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(103, 25);
            this.labelDateTime.TabIndex = 4;
            this.labelDateTime.Text = "DateTime:";
            // 
            // labelAppoinmentNote
            // 
            this.labelAppoinmentNote.AutoSize = true;
            this.labelAppoinmentNote.Location = new System.Drawing.Point(36, 432);
            this.labelAppoinmentNote.Name = "labelAppoinmentNote";
            this.labelAppoinmentNote.Size = new System.Drawing.Size(59, 25);
            this.labelAppoinmentNote.TabIndex = 5;
            this.labelAppoinmentNote.Text = "Note:";
            // 
            // textBoxReason
            // 
            this.textBoxReason.Location = new System.Drawing.Point(156, 429);
            this.textBoxReason.Name = "textBoxReason";
            this.textBoxReason.Size = new System.Drawing.Size(292, 29);
            this.textBoxReason.TabIndex = 7;
            // 
            // comboBoxPatients
            // 
            this.comboBoxPatients.FormattingEnabled = true;
            this.comboBoxPatients.Location = new System.Drawing.Point(211, 180);
            this.comboBoxPatients.Name = "comboBoxPatients";
            this.comboBoxPatients.Size = new System.Drawing.Size(195, 32);
            this.comboBoxPatients.TabIndex = 8;
            // 
            // dateTimePickerAppoinments
            // 
            this.dateTimePickerAppoinments.Location = new System.Drawing.Point(156, 326);
            this.dateTimePickerAppoinments.Name = "dateTimePickerAppoinments";
            this.dateTimePickerAppoinments.Size = new System.Drawing.Size(318, 29);
            this.dateTimePickerAppoinments.TabIndex = 9;
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(872, 557);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(132, 54);
            this.buttonView.TabIndex = 10;
            this.buttonView.Text = "View";
            this.buttonView.UseVisualStyleBackColor = true;
            // 
            // labelDoctor
            // 
            this.labelDoctor.AutoSize = true;
            this.labelDoctor.Location = new System.Drawing.Point(36, 248);
            this.labelDoctor.Name = "labelDoctor";
            this.labelDoctor.Size = new System.Drawing.Size(75, 25);
            this.labelDoctor.TabIndex = 11;
            this.labelDoctor.Text = "Doctor:";
            // 
            // comboBoxDoctor
            // 
            this.comboBoxDoctor.FormattingEnabled = true;
            this.comboBoxDoctor.Location = new System.Drawing.Point(211, 241);
            this.comboBoxDoctor.Name = "comboBoxDoctor";
            this.comboBoxDoctor.Size = new System.Drawing.Size(194, 32);
            this.comboBoxDoctor.TabIndex = 12;
            // 
            // Appoinment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 646);
            this.Controls.Add(this.comboBoxDoctor);
            this.Controls.Add(this.labelDoctor);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.dateTimePickerAppoinments);
            this.Controls.Add(this.comboBoxPatients);
            this.Controls.Add(this.textBoxReason);
            this.Controls.Add(this.labelAppoinmentNote);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.labelPatients);
            this.Controls.Add(this.buttonAppoinmentCancel);
            this.Controls.Add(this.buttonAppointmentAdd);
            this.Controls.Add(this.dataGridViewAppoinments);
            this.Name = "Appoinment";
            this.Text = "Appoinment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppoinments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAppoinments;
        private System.Windows.Forms.Button buttonAppointmentAdd;
        private System.Windows.Forms.Button buttonAppoinmentCancel;
        private System.Windows.Forms.Label labelPatients;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Label labelAppoinmentNote;
        private System.Windows.Forms.TextBox textBoxReason;
        private System.Windows.Forms.ComboBox comboBoxPatients;
        private System.Windows.Forms.DateTimePicker dateTimePickerAppoinments;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Label labelDoctor;
        private System.Windows.Forms.ComboBox comboBoxDoctor;
    }
}