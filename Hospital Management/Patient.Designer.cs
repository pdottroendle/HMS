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
            this.label_dob = new System.Windows.Forms.Label();
            this.label_Gender = new System.Windows.Forms.Label();
            this.label_ContactInfo = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Address = new System.Windows.Forms.Label();
            this.label_medical = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Gender = new System.Windows.Forms.TextBox();
            this.textBox_ContactInfo = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.textBox_MedicalHistory = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_patientAdd = new System.Windows.Forms.Button();
            this.button_patientSearch = new System.Windows.Forms.Button();
            this.textBox_DOB = new System.Windows.Forms.DateTimePicker();
            this.label_PatientUser = new System.Windows.Forms.Label();
            this.textBox_patientUserID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_PatientID = new System.Windows.Forms.Label();
            this.textBox_UserID = new System.Windows.Forms.TextBox();
            this.textBox_PatientID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(32, 14);
            this.label_FirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(38, 13);
            this.label_FirstName.TabIndex = 0;
            this.label_FirstName.Text = "Name:";
            // 
            // label_dob
            // 
            this.label_dob.AutoSize = true;
            this.label_dob.Location = new System.Drawing.Point(12, 72);
            this.label_dob.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_dob.Name = "label_dob";
            this.label_dob.Size = new System.Drawing.Size(33, 13);
            this.label_dob.TabIndex = 2;
            this.label_dob.Text = "DOB:";
            // 
            // label_Gender
            // 
            this.label_Gender.AutoSize = true;
            this.label_Gender.Location = new System.Drawing.Point(43, 98);
            this.label_Gender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Gender.Name = "label_Gender";
            this.label_Gender.Size = new System.Drawing.Size(45, 13);
            this.label_Gender.TabIndex = 3;
            this.label_Gender.Text = "Gender:";
            // 
            // label_ContactInfo
            // 
            this.label_ContactInfo.AutoSize = true;
            this.label_ContactInfo.Location = new System.Drawing.Point(23, 128);
            this.label_ContactInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ContactInfo.Name = "label_ContactInfo";
            this.label_ContactInfo.Size = new System.Drawing.Size(68, 13);
            this.label_ContactInfo.TabIndex = 4;
            this.label_ContactInfo.Text = "Contact Info:";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(52, 159);
            this.label_Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(35, 13);
            this.label_Email.TabIndex = 5;
            this.label_Email.Text = "Email:";
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Location = new System.Drawing.Point(38, 196);
            this.label_Address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(48, 13);
            this.label_Address.TabIndex = 6;
            this.label_Address.Text = "Address:";
            // 
            // label_medical
            // 
            this.label_medical.AutoSize = true;
            this.label_medical.Location = new System.Drawing.Point(7, 230);
            this.label_medical.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_medical.Name = "label_medical";
            this.label_medical.Size = new System.Drawing.Size(77, 13);
            this.label_medical.TabIndex = 7;
            this.label_medical.Text = "Medicalhistory:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(114, 14);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(56, 20);
            this.textBox_Name.TabIndex = 8;
            // 
            // textBox_Gender
            // 
            this.textBox_Gender.Location = new System.Drawing.Point(114, 95);
            this.textBox_Gender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Gender.Name = "textBox_Gender";
            this.textBox_Gender.Size = new System.Drawing.Size(56, 20);
            this.textBox_Gender.TabIndex = 8;
            // 
            // textBox_ContactInfo
            // 
            this.textBox_ContactInfo.Location = new System.Drawing.Point(114, 126);
            this.textBox_ContactInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_ContactInfo.Name = "textBox_ContactInfo";
            this.textBox_ContactInfo.Size = new System.Drawing.Size(56, 20);
            this.textBox_ContactInfo.TabIndex = 8;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(114, 157);
            this.textBox_Email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(56, 20);
            this.textBox_Email.TabIndex = 8;
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(114, 194);
            this.textBox_Address.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(56, 20);
            this.textBox_Address.TabIndex = 8;
            // 
            // textBox_MedicalHistory
            // 
            this.textBox_MedicalHistory.Location = new System.Drawing.Point(114, 230);
            this.textBox_MedicalHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_MedicalHistory.Name = "textBox_MedicalHistory";
            this.textBox_MedicalHistory.Size = new System.Drawing.Size(56, 20);
            this.textBox_MedicalHistory.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(237, 14);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(450, 232);
            this.dataGridView1.TabIndex = 9;
            // 
            // button_patientAdd
            // 
            this.button_patientAdd.Location = new System.Drawing.Point(364, 270);
            this.button_patientAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_patientAdd.Name = "button_patientAdd";
            this.button_patientAdd.Size = new System.Drawing.Size(57, 24);
            this.button_patientAdd.TabIndex = 11;
            this.button_patientAdd.Text = "Add";
            this.button_patientAdd.UseVisualStyleBackColor = true;
            this.button_patientAdd.Click += new System.EventHandler(this.button_patientAdd_Click);
            // 
            // button_patientSearch
            // 
            this.button_patientSearch.Location = new System.Drawing.Point(511, 270);
            this.button_patientSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_patientSearch.Name = "button_patientSearch";
            this.button_patientSearch.Size = new System.Drawing.Size(57, 24);
            this.button_patientSearch.TabIndex = 12;
            this.button_patientSearch.Text = "Search";
            this.button_patientSearch.UseVisualStyleBackColor = true;
            this.button_patientSearch.Click += new System.EventHandler(this.button_patientSearch_Click);
            // 
            // textBox_DOB
            // 
            this.textBox_DOB.Location = new System.Drawing.Point(55, 72);
            this.textBox_DOB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_DOB.Name = "textBox_DOB";
            this.textBox_DOB.Size = new System.Drawing.Size(176, 20);
            this.textBox_DOB.TabIndex = 18;
            // 
            // label_PatientUser
            // 
            this.label_PatientUser.AutoSize = true;
            this.label_PatientUser.Location = new System.Drawing.Point(38, 265);
            this.label_PatientUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_PatientUser.Name = "label_PatientUser";
            this.label_PatientUser.Size = new System.Drawing.Size(32, 13);
            this.label_PatientUser.TabIndex = 19;
            this.label_PatientUser.Text = "User:";
            // 
            // textBox_patientUserID
            // 
            this.textBox_patientUserID.Location = new System.Drawing.Point(114, 265);
            this.textBox_patientUserID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_patientUserID.Name = "textBox_patientUserID";
            this.textBox_patientUserID.Size = new System.Drawing.Size(56, 20);
            this.textBox_patientUserID.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 291);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "User:";
            // 
            // label_PatientID
            // 
            this.label_PatientID.AutoSize = true;
            this.label_PatientID.Location = new System.Drawing.Point(38, 291);
            this.label_PatientID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_PatientID.Name = "label_PatientID";
            this.label_PatientID.Size = new System.Drawing.Size(43, 13);
            this.label_PatientID.TabIndex = 19;
            this.label_PatientID.Text = "Patient:";
            // 
            // textBox_UserID
            // 
            this.textBox_UserID.Location = new System.Drawing.Point(114, 265);
            this.textBox_UserID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_UserID.Name = "textBox_UserID";
            this.textBox_UserID.Size = new System.Drawing.Size(56, 20);
            this.textBox_UserID.TabIndex = 20;
            // 
            // textBox_PatientID
            // 
            this.textBox_PatientID.Location = new System.Drawing.Point(114, 291);
            this.textBox_PatientID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_PatientID.Name = "textBox_PatientID";
            this.textBox_PatientID.Size = new System.Drawing.Size(56, 20);
            this.textBox_PatientID.TabIndex = 20;
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 342);
            this.Controls.Add(this.textBox_PatientID);
            this.Controls.Add(this.textBox_UserID);
            this.Controls.Add(this.textBox_patientUserID);
            this.Controls.Add(this.label_PatientID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_PatientUser);
            this.Controls.Add(this.textBox_DOB);
            this.Controls.Add(this.button_patientSearch);
            this.Controls.Add(this.button_patientAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_MedicalHistory);
            this.Controls.Add(this.textBox_Address);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_ContactInfo);
            this.Controls.Add(this.textBox_Gender);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_medical);
            this.Controls.Add(this.label_Address);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_ContactInfo);
            this.Controls.Add(this.label_Gender);
            this.Controls.Add(this.label_dob);
            this.Controls.Add(this.label_FirstName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Patient";
            this.Text = "Patient";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Label label_dob;
        private System.Windows.Forms.Label label_Gender;
        private System.Windows.Forms.Label label_ContactInfo;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.Label label_medical;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Gender;
        private System.Windows.Forms.TextBox textBox_ContactInfo;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.TextBox textBox_MedicalHistory;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_patientAdd;
        private System.Windows.Forms.Button button_patientSearch;
        private System.Windows.Forms.DateTimePicker textBox_DOB;
        private System.Windows.Forms.Label label_PatientUser;
        private System.Windows.Forms.TextBox textBox_patientUserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_PatientID;
        private System.Windows.Forms.TextBox textBox_UserID;
        private System.Windows.Forms.TextBox textBox_PatientID;
    }
}