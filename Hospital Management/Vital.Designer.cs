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
            this.comboBox_SelectPatient = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_SelectPatient
            // 
            this.label_SelectPatient.AutoSize = true;
            this.label_SelectPatient.Location = new System.Drawing.Point(41, 52);
            this.label_SelectPatient.Name = "label_SelectPatient";
            this.label_SelectPatient.Size = new System.Drawing.Size(138, 25);
            this.label_SelectPatient.TabIndex = 0;
            this.label_SelectPatient.Text = "Select Patient:";
            // 
            // comboBox_SelectPatient
            // 
            this.comboBox_SelectPatient.FormattingEnabled = true;
            this.comboBox_SelectPatient.Location = new System.Drawing.Point(243, 52);
            this.comboBox_SelectPatient.Name = "comboBox_SelectPatient";
            this.comboBox_SelectPatient.Size = new System.Drawing.Size(121, 32);
            this.comboBox_SelectPatient.TabIndex = 1;
            // 
            // label_HeartRate
            // 
            this.label_HeartRate.AutoSize = true;
            this.label_HeartRate.Location = new System.Drawing.Point(48, 126);
            this.label_HeartRate.Name = "label_HeartRate";
            this.label_HeartRate.Size = new System.Drawing.Size(110, 25);
            this.label_HeartRate.TabIndex = 2;
            this.label_HeartRate.Text = "Heart Rate:";
            // 
            // label_BP
            // 
            this.label_BP.AutoSize = true;
            this.label_BP.Location = new System.Drawing.Point(80, 188);
            this.label_BP.Name = "label_BP";
            this.label_BP.Size = new System.Drawing.Size(44, 25);
            this.label_BP.TabIndex = 2;
            this.label_BP.Text = "BP:";
            // 
            // label_temp
            // 
            this.label_temp.AutoSize = true;
            this.label_temp.Location = new System.Drawing.Point(62, 253);
            this.label_temp.Name = "label_temp";
            this.label_temp.Size = new System.Drawing.Size(69, 25);
            this.label_temp.TabIndex = 2;
            this.label_temp.Text = "Temp:";
            // 
            // label_Oxygen
            // 
            this.label_Oxygen.AutoSize = true;
            this.label_Oxygen.Location = new System.Drawing.Point(62, 319);
            this.label_Oxygen.Name = "label_Oxygen";
            this.label_Oxygen.Size = new System.Drawing.Size(87, 25);
            this.label_Oxygen.TabIndex = 2;
            this.label_Oxygen.Text = "Oxygen:";
            // 
            // label_PatientStatus
            // 
            this.label_PatientStatus.AutoSize = true;
            this.label_PatientStatus.Location = new System.Drawing.Point(353, 474);
            this.label_PatientStatus.Name = "label_PatientStatus";
            this.label_PatientStatus.Size = new System.Drawing.Size(74, 25);
            this.label_PatientStatus.TabIndex = 3;
            this.label_PatientStatus.Text = "Status:";
            // 
            // statusStrip_patientStatus
            // 
            this.statusStrip_patientStatus.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip_patientStatus.Location = new System.Drawing.Point(0, 562);
            this.statusStrip_patientStatus.Name = "statusStrip_patientStatus";
            this.statusStrip_patientStatus.Size = new System.Drawing.Size(1559, 22);
            this.statusStrip_patientStatus.TabIndex = 4;
            this.statusStrip_patientStatus.Text = "statusStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(605, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(801, 388);
            this.dataGridView1.TabIndex = 5;
            // 
            // dateTimePickerVital
            // 
            this.dateTimePickerVital.Location = new System.Drawing.Point(243, 401);
            this.dateTimePickerVital.Name = "dateTimePickerVital";
            this.dateTimePickerVital.Size = new System.Drawing.Size(328, 29);
            this.dateTimePickerVital.TabIndex = 6;
            // 
            // labelVitalTimeStamp
            // 
            this.labelVitalTimeStamp.AutoSize = true;
            this.labelVitalTimeStamp.Location = new System.Drawing.Point(48, 401);
            this.labelVitalTimeStamp.Name = "labelVitalTimeStamp";
            this.labelVitalTimeStamp.Size = new System.Drawing.Size(115, 25);
            this.labelVitalTimeStamp.TabIndex = 7;
            this.labelVitalTimeStamp.Text = "Timestamp:";
            // 
            // button_VitalAdd
            // 
            this.button_VitalAdd.Location = new System.Drawing.Point(786, 460);
            this.button_VitalAdd.Name = "button_VitalAdd";
            this.button_VitalAdd.Size = new System.Drawing.Size(141, 39);
            this.button_VitalAdd.TabIndex = 8;
            this.button_VitalAdd.Text = "Add";
            this.button_VitalAdd.UseVisualStyleBackColor = true;
            // 
            // button_SearchVital
            // 
            this.button_SearchVital.Location = new System.Drawing.Point(1088, 460);
            this.button_SearchVital.Name = "button_SearchVital";
            this.button_SearchVital.Size = new System.Drawing.Size(141, 39);
            this.button_SearchVital.TabIndex = 8;
            this.button_SearchVital.Text = "Search";
            this.button_SearchVital.UseVisualStyleBackColor = true;
            // 
            // Vital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 584);
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
            this.Controls.Add(this.comboBox_SelectPatient);
            this.Controls.Add(this.label_SelectPatient);
            this.Name = "Vital";
            this.Text = "Vital";
            this.Load += new System.EventHandler(this.PatientMonotoring_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_SelectPatient;
        private System.Windows.Forms.ComboBox comboBox_SelectPatient;
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
    }
}