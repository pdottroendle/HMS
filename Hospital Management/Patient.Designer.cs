namespace Hospital_Management
{
    partial class Patient
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
            this.label_FirstName = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.label_dob = new System.Windows.Forms.Label();
            this.label_Gender = new System.Windows.Forms.Label();
            this.label_ContactInfo = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Address = new System.Windows.Forms.Label();
            this.label_medical = new System.Windows.Forms.Label();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_Gender = new System.Windows.Forms.TextBox();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.textBox_medicalHistory = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_patientAdd = new System.Windows.Forms.Button();
            this.button_patientSearch = new System.Windows.Forms.Button();
            this.dateTimePicker_DOB = new System.Windows.Forms.DateTimePicker();
            this.label_PatientUser = new System.Windows.Forms.Label();
            this.textBox_patientUserID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_PatientID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox_PatientPatientID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(58, 25);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(107, 25);
            this.label_FirstName.TabIndex = 0;
            this.label_FirstName.Text = "FirstName:";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(58, 75);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(107, 25);
            this.label_LastName.TabIndex = 1;
            this.label_LastName.Text = "LastName:";
            // 
            // label_dob
            // 
            this.label_dob.AutoSize = true;
            this.label_dob.Location = new System.Drawing.Point(22, 133);
            this.label_dob.Name = "label_dob";
            this.label_dob.Size = new System.Drawing.Size(61, 25);
            this.label_dob.TabIndex = 2;
            this.label_dob.Text = "DOB:";
            // 
            // label_Gender
            // 
            this.label_Gender.AutoSize = true;
            this.label_Gender.Location = new System.Drawing.Point(78, 180);
            this.label_Gender.Name = "label_Gender";
            this.label_Gender.Size = new System.Drawing.Size(83, 25);
            this.label_Gender.TabIndex = 3;
            this.label_Gender.Text = "Gender:";
            // 
            // label_ContactInfo
            // 
            this.label_ContactInfo.AutoSize = true;
            this.label_ContactInfo.Location = new System.Drawing.Point(42, 236);
            this.label_ContactInfo.Name = "label_ContactInfo";
            this.label_ContactInfo.Size = new System.Drawing.Size(123, 25);
            this.label_ContactInfo.TabIndex = 4;
            this.label_ContactInfo.Text = "Contact Info:";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(95, 294);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(66, 25);
            this.label_Email.TabIndex = 5;
            this.label_Email.Text = "Email:";
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Location = new System.Drawing.Point(70, 362);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(91, 25);
            this.label_Address.TabIndex = 6;
            this.label_Address.Text = "Address:";
            // 
            // label_medical
            // 
            this.label_medical.AutoSize = true;
            this.label_medical.Location = new System.Drawing.Point(12, 424);
            this.label_medical.Name = "label_medical";
            this.label_medical.Size = new System.Drawing.Size(143, 25);
            this.label_medical.TabIndex = 7;
            this.label_medical.Text = "Medicalhistory:";
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(209, 25);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(100, 29);
            this.textBox_FirstName.TabIndex = 8;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(209, 72);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(100, 29);
            this.textBox_LastName.TabIndex = 8;
            // 
            // textBox_Gender
            // 
            this.textBox_Gender.Location = new System.Drawing.Point(209, 176);
            this.textBox_Gender.Name = "textBox_Gender";
            this.textBox_Gender.Size = new System.Drawing.Size(100, 29);
            this.textBox_Gender.TabIndex = 8;
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(209, 232);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(100, 29);
            this.textBox_Phone.TabIndex = 8;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(209, 290);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(100, 29);
            this.textBox_Email.TabIndex = 8;
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(209, 358);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(100, 29);
            this.textBox_Address.TabIndex = 8;
            // 
            // textBox_medicalHistory
            // 
            this.textBox_medicalHistory.Location = new System.Drawing.Point(209, 424);
            this.textBox_medicalHistory.Name = "textBox_medicalHistory";
            this.textBox_medicalHistory.Size = new System.Drawing.Size(100, 29);
            this.textBox_medicalHistory.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(434, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(825, 428);
            this.dataGridView1.TabIndex = 9;
            // 
            // button_patientAdd
            // 
            this.button_patientAdd.Location = new System.Drawing.Point(668, 498);
            this.button_patientAdd.Name = "button_patientAdd";
            this.button_patientAdd.Size = new System.Drawing.Size(104, 45);
            this.button_patientAdd.TabIndex = 11;
            this.button_patientAdd.Text = "Add";
            this.button_patientAdd.UseVisualStyleBackColor = true;
            this.button_patientAdd.Click += new System.EventHandler(this.button_patientAdd_Click);
            // 
            // button_patientSearch
            // 
            this.button_patientSearch.Location = new System.Drawing.Point(937, 498);
            this.button_patientSearch.Name = "button_patientSearch";
            this.button_patientSearch.Size = new System.Drawing.Size(105, 45);
            this.button_patientSearch.TabIndex = 12;
            this.button_patientSearch.Text = "Search";
            this.button_patientSearch.UseVisualStyleBackColor = true;
            this.button_patientSearch.Click += new System.EventHandler(this.button_patientSearch_Click);
            // 
            // dateTimePicker_DOB
            // 
            this.dateTimePicker_DOB.Location = new System.Drawing.Point(100, 133);
            this.dateTimePicker_DOB.Name = "dateTimePicker_DOB";
            this.dateTimePicker_DOB.Size = new System.Drawing.Size(319, 29);
            this.dateTimePicker_DOB.TabIndex = 18;
            // 
            // label_PatientUser
            // 
            this.label_PatientUser.AutoSize = true;
            this.label_PatientUser.Location = new System.Drawing.Point(70, 489);
            this.label_PatientUser.Name = "label_PatientUser";
            this.label_PatientUser.Size = new System.Drawing.Size(59, 25);
            this.label_PatientUser.TabIndex = 19;
            this.label_PatientUser.Text = "User:";
            // 
            // textBox_patientUserID
            // 
            this.textBox_patientUserID.Location = new System.Drawing.Point(209, 489);
            this.textBox_patientUserID.Name = "textBox_patientUserID";
            this.textBox_patientUserID.Size = new System.Drawing.Size(100, 29);
            this.textBox_patientUserID.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 538);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "User:";
            // 
            // label_PatientID
            // 
            this.label_PatientID.AutoSize = true;
            this.label_PatientID.Location = new System.Drawing.Point(70, 538);
            this.label_PatientID.Name = "label_PatientID";
            this.label_PatientID.Size = new System.Drawing.Size(78, 25);
            this.label_PatientID.TabIndex = 19;
            this.label_PatientID.Text = "Patient:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(209, 489);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 20;
            // 
            // textBox_PatientPatientID
            // 
            this.textBox_PatientPatientID.Location = new System.Drawing.Point(209, 538);
            this.textBox_PatientPatientID.Name = "textBox_PatientPatientID";
            this.textBox_PatientPatientID.Size = new System.Drawing.Size(100, 29);
            this.textBox_PatientPatientID.TabIndex = 20;
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1545, 631);
            this.Controls.Add(this.textBox_PatientPatientID);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox_patientUserID);
            this.Controls.Add(this.label_PatientID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_PatientUser);
            this.Controls.Add(this.dateTimePicker_DOB);
            this.Controls.Add(this.button_patientSearch);
            this.Controls.Add(this.button_patientAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_medicalHistory);
            this.Controls.Add(this.textBox_Address);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_Phone);
            this.Controls.Add(this.textBox_Gender);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.label_medical);
            this.Controls.Add(this.label_Address);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_ContactInfo);
            this.Controls.Add(this.label_Gender);
            this.Controls.Add(this.label_dob);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.label_FirstName);
            this.Name = "Patient";
            this.Text = "Patient";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Label label_dob;
        private System.Windows.Forms.Label label_Gender;
        private System.Windows.Forms.Label label_ContactInfo;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.Label label_medical;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_Gender;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.TextBox textBox_medicalHistory;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_patientAdd;
        private System.Windows.Forms.Button button_patientSearch;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DOB;
        private System.Windows.Forms.Label label_PatientUser;
        private System.Windows.Forms.TextBox textBox_patientUserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_PatientID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox_PatientPatientID;
    }
}