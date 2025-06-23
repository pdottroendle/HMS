namespace Hospital_Management
{
    partial class Vital
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
            this.label_SelectPatient = new System.Windows.Forms.Label();
            this.label_HeartRate = new System.Windows.Forms.Label();
            this.label_BP = new System.Windows.Forms.Label();
            this.label_temp = new System.Windows.Forms.Label();
            this.label_Oxygen = new System.Windows.Forms.Label();
            this.label_PatientStatus = new System.Windows.Forms.Label();
            this.statusStrip_patientStatus = new System.Windows.Forms.StatusStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePickerVital = new System.Windows.Forms.DateTimePicker();
            this.labelVitalTimeStamp = new System.Windows.Forms.Label();
            this.button_VitalAdd = new System.Windows.Forms.Button();
            this.button_SearchVital = new System.Windows.Forms.Button();
            this.textBox_PatientID = new System.Windows.Forms.TextBox();
            this.textBox_HeartRate = new System.Windows.Forms.TextBox();
            this.textBox_BloodPressure = new System.Windows.Forms.TextBox();
            this.textBox_Temperature = new System.Windows.Forms.TextBox();
            this.textBox_OxygenLevel = new System.Windows.Forms.TextBox();
            this.label_Vital = new System.Windows.Forms.Label();
            this.textBox_VitalID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_SelectPatient
            // 
            this.label_SelectPatient.AutoSize = true;
            this.label_SelectPatient.Location = new System.Drawing.Point(44, 48);
            this.label_SelectPatient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_SelectPatient.Name = "label_SelectPatient";
            this.label_SelectPatient.Size = new System.Drawing.Size(46, 13);
            this.label_SelectPatient.TabIndex = 0;
            this.label_SelectPatient.Text = " Patient:";
            // 
            // label_HeartRate
            // 
            this.label_HeartRate.AutoSize = true;
            this.label_HeartRate.Location = new System.Drawing.Point(34, 89);
            this.label_HeartRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_HeartRate.Name = "label_HeartRate";
            this.label_HeartRate.Size = new System.Drawing.Size(62, 13);
            this.label_HeartRate.TabIndex = 2;
            this.label_HeartRate.Text = "Heart Rate:";
            // 
            // label_BP
            // 
            this.label_BP.AutoSize = true;
            this.label_BP.Location = new System.Drawing.Point(47, 133);
            this.label_BP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_BP.Name = "label_BP";
            this.label_BP.Size = new System.Drawing.Size(24, 13);
            this.label_BP.TabIndex = 2;
            this.label_BP.Text = "BP:";
            // 
            // label_temp
            // 
            this.label_temp.AutoSize = true;
            this.label_temp.Location = new System.Drawing.Point(44, 175);
            this.label_temp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_temp.Name = "label_temp";
            this.label_temp.Size = new System.Drawing.Size(37, 13);
            this.label_temp.TabIndex = 2;
            this.label_temp.Text = "Temp:";
            // 
            // label_Oxygen
            // 
            this.label_Oxygen.AutoSize = true;
            this.label_Oxygen.Location = new System.Drawing.Point(34, 211);
            this.label_Oxygen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Oxygen.Name = "label_Oxygen";
            this.label_Oxygen.Size = new System.Drawing.Size(46, 13);
            this.label_Oxygen.TabIndex = 2;
            this.label_Oxygen.Text = "Oxygen:";
            // 
            // label_PatientStatus
            // 
            this.label_PatientStatus.AutoSize = true;
            this.label_PatientStatus.Location = new System.Drawing.Point(340, 253);
            this.label_PatientStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_PatientStatus.Name = "label_PatientStatus";
            this.label_PatientStatus.Size = new System.Drawing.Size(40, 13);
            this.label_PatientStatus.TabIndex = 3;
            this.label_PatientStatus.Text = "Status:";
            // 
            // statusStrip_patientStatus
            // 
            this.statusStrip_patientStatus.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip_patientStatus.Location = new System.Drawing.Point(0, 294);
            this.statusStrip_patientStatus.Name = "statusStrip_patientStatus";
            this.statusStrip_patientStatus.Padding = new System.Windows.Forms.Padding(1, 0, 8, 0);
            this.statusStrip_patientStatus.Size = new System.Drawing.Size(850, 22);
            this.statusStrip_patientStatus.TabIndex = 4;
            this.statusStrip_patientStatus.Text = "statusStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(330, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(437, 210);
            this.dataGridView1.TabIndex = 5;
            // 
            // dateTimePickerVital
            // 
            this.dateTimePickerVital.Location = new System.Drawing.Point(128, 255);
            this.dateTimePickerVital.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerVital.Name = "dateTimePickerVital";
            this.dateTimePickerVital.Size = new System.Drawing.Size(181, 20);
            this.dateTimePickerVital.TabIndex = 6;
            // 
            // labelVitalTimeStamp
            // 
            this.labelVitalTimeStamp.AutoSize = true;
            this.labelVitalTimeStamp.Location = new System.Drawing.Point(26, 257);
            this.labelVitalTimeStamp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVitalTimeStamp.Name = "labelVitalTimeStamp";
            this.labelVitalTimeStamp.Size = new System.Drawing.Size(61, 13);
            this.labelVitalTimeStamp.TabIndex = 7;
            this.labelVitalTimeStamp.Text = "Timestamp:";
            // 
            // button_VitalAdd
            // 
            this.button_VitalAdd.Location = new System.Drawing.Point(545, 249);
            this.button_VitalAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_VitalAdd.Name = "button_VitalAdd";
            this.button_VitalAdd.Size = new System.Drawing.Size(77, 21);
            this.button_VitalAdd.TabIndex = 8;
            this.button_VitalAdd.Text = "Add";
            this.button_VitalAdd.UseVisualStyleBackColor = true;
            this.button_VitalAdd.Click += new System.EventHandler(this.button_VitalAdd_Click);
            // 
            // button_SearchVital
            // 
            this.button_SearchVital.Location = new System.Drawing.Point(665, 249);
            this.button_SearchVital.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_SearchVital.Name = "button_SearchVital";
            this.button_SearchVital.Size = new System.Drawing.Size(77, 21);
            this.button_SearchVital.TabIndex = 8;
            this.button_SearchVital.Text = "Search";
            this.button_SearchVital.UseVisualStyleBackColor = true;
            this.button_SearchVital.Click += new System.EventHandler(this.button_SearchVital_Click);
            // 
            // textBox_PatientID
            // 
            this.textBox_PatientID.Location = new System.Drawing.Point(173, 46);
            this.textBox_PatientID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_PatientID.Name = "textBox_PatientID";
            this.textBox_PatientID.Size = new System.Drawing.Size(111, 20);
            this.textBox_PatientID.TabIndex = 9;
            // 
            // textBox_HeartRate
            // 
            this.textBox_HeartRate.Location = new System.Drawing.Point(173, 87);
            this.textBox_HeartRate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_HeartRate.Name = "textBox_HeartRate";
            this.textBox_HeartRate.Size = new System.Drawing.Size(111, 20);
            this.textBox_HeartRate.TabIndex = 9;
            // 
            // textBox_BloodPressure
            // 
            this.textBox_BloodPressure.Location = new System.Drawing.Point(173, 131);
            this.textBox_BloodPressure.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_BloodPressure.Name = "textBox_BloodPressure";
            this.textBox_BloodPressure.Size = new System.Drawing.Size(111, 20);
            this.textBox_BloodPressure.TabIndex = 9;
            // 
            // textBox_Temperature
            // 
            this.textBox_Temperature.Location = new System.Drawing.Point(173, 173);
            this.textBox_Temperature.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Temperature.Name = "textBox_Temperature";
            this.textBox_Temperature.Size = new System.Drawing.Size(111, 20);
            this.textBox_Temperature.TabIndex = 9;
            // 
            // textBox_OxygenLevel
            // 
            this.textBox_OxygenLevel.Location = new System.Drawing.Point(173, 209);
            this.textBox_OxygenLevel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_OxygenLevel.Name = "textBox_OxygenLevel";
            this.textBox_OxygenLevel.Size = new System.Drawing.Size(111, 20);
            this.textBox_OxygenLevel.TabIndex = 9;
            // 
            // label_Vital
            // 
            this.label_Vital.AutoSize = true;
            this.label_Vital.Location = new System.Drawing.Point(44, 17);
            this.label_Vital.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Vital.Name = "label_Vital";
            this.label_Vital.Size = new System.Drawing.Size(27, 13);
            this.label_Vital.TabIndex = 0;
            this.label_Vital.Text = "Vital";
            // 
            // textBox_VitalID
            // 
            this.textBox_VitalID.Location = new System.Drawing.Point(173, 17);
            this.textBox_VitalID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_VitalID.Name = "textBox_VitalID";
            this.textBox_VitalID.Size = new System.Drawing.Size(111, 20);
            this.textBox_VitalID.TabIndex = 9;
            // 
            // Vital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 316);
            this.Controls.Add(this.textBox_OxygenLevel);
            this.Controls.Add(this.textBox_Temperature);
            this.Controls.Add(this.textBox_BloodPressure);
            this.Controls.Add(this.textBox_HeartRate);
            this.Controls.Add(this.textBox_VitalID);
            this.Controls.Add(this.textBox_PatientID);
            this.Controls.Add(this.button_SearchVital);
            this.Controls.Add(this.button_VitalAdd);
            this.Controls.Add(this.labelVitalTimeStamp);
            this.Controls.Add(this.dateTimePickerVital);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip_patientStatus);
            this.Controls.Add(this.label_PatientStatus);
            this.Controls.Add(this.label_Oxygen);
            this.Controls.Add(this.label_temp);
            this.Controls.Add(this.label_BP);
            this.Controls.Add(this.label_HeartRate);
            this.Controls.Add(this.label_Vital);
            this.Controls.Add(this.label_SelectPatient);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Vital";
            this.Text = "Vital";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_SelectPatient;
        private System.Windows.Forms.Label label_HeartRate;
        private System.Windows.Forms.Label label_BP;
        private System.Windows.Forms.Label label_temp;
        private System.Windows.Forms.Label label_Oxygen;
        private System.Windows.Forms.Label label_PatientStatus;
        private System.Windows.Forms.StatusStrip statusStrip_patientStatus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePickerVital;
        private System.Windows.Forms.Label labelVitalTimeStamp;
        private System.Windows.Forms.Button button_VitalAdd;
        private System.Windows.Forms.Button button_SearchVital;
        private System.Windows.Forms.TextBox textBox_PatientID;
        private System.Windows.Forms.TextBox textBox_HeartRate;
        private System.Windows.Forms.TextBox textBox_BloodPressure;
        private System.Windows.Forms.TextBox textBox_Temperature;
        private System.Windows.Forms.TextBox textBox_OxygenLevel;
        private System.Windows.Forms.Label label_Vital;
        private System.Windows.Forms.TextBox textBox_VitalID;
    }
}