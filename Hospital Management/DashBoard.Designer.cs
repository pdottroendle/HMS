namespace Hospital_Management
{
    partial class DashBoard
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelBedID = new System.Windows.Forms.Label();
            this.labelWard = new System.Windows.Forms.Label();
            this.labelAvailability = new System.Windows.Forms.Label();
            this.labelEmergency = new System.Windows.Forms.Label();
            this.textBoxBedID = new System.Windows.Forms.TextBox();
            this.textBoxWard = new System.Windows.Forms.TextBox();
            this.textBoxAvailability = new System.Windows.Forms.TextBox();
            this.textBoxEmergency = new System.Windows.Forms.TextBox();
            this.buttonDashboardAdd = new System.Windows.Forms.Button();
            this.labelDashboardTimestamp = new System.Windows.Forms.Label();
            this.buttonDashboardSearch = new System.Windows.Forms.Button();
            this.labelDashboardID = new System.Windows.Forms.Label();
            this.textBoxDashboardID = new System.Windows.Forms.TextBox();
            this.dateTimePickerDashboard = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(491, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1098, 479);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelBedID
            // 
            this.labelBedID.AutoSize = true;
            this.labelBedID.Location = new System.Drawing.Point(32, 68);
            this.labelBedID.Name = "labelBedID";
            this.labelBedID.Size = new System.Drawing.Size(53, 25);
            this.labelBedID.TabIndex = 1;
            this.labelBedID.Text = "Bed:";
            // 
            // labelWard
            // 
            this.labelWard.AutoSize = true;
            this.labelWard.Location = new System.Drawing.Point(32, 135);
            this.labelWard.Name = "labelWard";
            this.labelWard.Size = new System.Drawing.Size(66, 25);
            this.labelWard.TabIndex = 1;
            this.labelWard.Text = "Ward:";
            // 
            // labelAvailability
            // 
            this.labelAvailability.AutoSize = true;
            this.labelAvailability.Location = new System.Drawing.Point(12, 211);
            this.labelAvailability.Name = "labelAvailability";
            this.labelAvailability.Size = new System.Drawing.Size(110, 25);
            this.labelAvailability.TabIndex = 1;
            this.labelAvailability.Text = "Availability:";
            // 
            // labelEmergency
            // 
            this.labelEmergency.AutoSize = true;
            this.labelEmergency.Location = new System.Drawing.Point(5, 300);
            this.labelEmergency.Name = "labelEmergency";
            this.labelEmergency.Size = new System.Drawing.Size(117, 25);
            this.labelEmergency.TabIndex = 1;
            this.labelEmergency.Text = "Emergency:";
            // 
            // textBoxBedID
            // 
            this.textBoxBedID.Location = new System.Drawing.Point(143, 68);
            this.textBoxBedID.Name = "textBoxBedID";
            this.textBoxBedID.Size = new System.Drawing.Size(163, 29);
            this.textBoxBedID.TabIndex = 2;
            // 
            // textBoxWard
            // 
            this.textBoxWard.Location = new System.Drawing.Point(143, 135);
            this.textBoxWard.Name = "textBoxWard";
            this.textBoxWard.Size = new System.Drawing.Size(163, 29);
            this.textBoxWard.TabIndex = 2;
            // 
            // textBoxAvailability
            // 
            this.textBoxAvailability.Location = new System.Drawing.Point(143, 207);
            this.textBoxAvailability.Name = "textBoxAvailability";
            this.textBoxAvailability.Size = new System.Drawing.Size(163, 29);
            this.textBoxAvailability.TabIndex = 2;
            // 
            // textBoxEmergency
            // 
            this.textBoxEmergency.Location = new System.Drawing.Point(143, 300);
            this.textBoxEmergency.Name = "textBoxEmergency";
            this.textBoxEmergency.Size = new System.Drawing.Size(163, 29);
            this.textBoxEmergency.TabIndex = 2;
            // 
            // buttonDashboardAdd
            // 
            this.buttonDashboardAdd.Location = new System.Drawing.Point(714, 558);
            this.buttonDashboardAdd.Name = "buttonDashboardAdd";
            this.buttonDashboardAdd.Size = new System.Drawing.Size(218, 48);
            this.buttonDashboardAdd.TabIndex = 3;
            this.buttonDashboardAdd.Text = "Add";
            this.buttonDashboardAdd.UseVisualStyleBackColor = true;
            this.buttonDashboardAdd.Click += new System.EventHandler(this.buttonDashboardAdd_Click);
            // 
            // labelDashboardTimestamp
            // 
            this.labelDashboardTimestamp.AutoSize = true;
            this.labelDashboardTimestamp.Location = new System.Drawing.Point(12, 380);
            this.labelDashboardTimestamp.Name = "labelDashboardTimestamp";
            this.labelDashboardTimestamp.Size = new System.Drawing.Size(115, 25);
            this.labelDashboardTimestamp.TabIndex = 1;
            this.labelDashboardTimestamp.Text = "Timestamp:";
            // 
            // buttonDashboardSearch
            // 
            this.buttonDashboardSearch.Location = new System.Drawing.Point(1065, 558);
            this.buttonDashboardSearch.Name = "buttonDashboardSearch";
            this.buttonDashboardSearch.Size = new System.Drawing.Size(218, 48);
            this.buttonDashboardSearch.TabIndex = 3;
            this.buttonDashboardSearch.Text = "Search";
            this.buttonDashboardSearch.UseVisualStyleBackColor = true;
            this.buttonDashboardSearch.Click += new System.EventHandler(this.buttonDashboardSearch_Click);
            // 
            // labelDashboardID
            // 
            this.labelDashboardID.AutoSize = true;
            this.labelDashboardID.Location = new System.Drawing.Point(5, 471);
            this.labelDashboardID.Name = "labelDashboardID";
            this.labelDashboardID.Size = new System.Drawing.Size(138, 25);
            this.labelDashboardID.TabIndex = 1;
            this.labelDashboardID.Text = "Dashboard ID:";
            // 
            // textBoxDashboardID
            // 
            this.textBoxDashboardID.Location = new System.Drawing.Point(149, 467);
            this.textBoxDashboardID.Name = "textBoxDashboardID";
            this.textBoxDashboardID.Size = new System.Drawing.Size(163, 29);
            this.textBoxDashboardID.TabIndex = 2;
            // 
            // dateTimePickerDashboard
            // 
            this.dateTimePickerDashboard.Location = new System.Drawing.Point(143, 380);
            this.dateTimePickerDashboard.Name = "dateTimePickerDashboard";
            this.dateTimePickerDashboard.Size = new System.Drawing.Size(323, 29);
            this.dateTimePickerDashboard.TabIndex = 4;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1694, 701);
            this.Controls.Add(this.dateTimePickerDashboard);
            this.Controls.Add(this.buttonDashboardSearch);
            this.Controls.Add(this.buttonDashboardAdd);
            this.Controls.Add(this.textBoxDashboardID);
            this.Controls.Add(this.textBoxEmergency);
            this.Controls.Add(this.textBoxAvailability);
            this.Controls.Add(this.textBoxWard);
            this.Controls.Add(this.textBoxBedID);
            this.Controls.Add(this.labelDashboardID);
            this.Controls.Add(this.labelDashboardTimestamp);
            this.Controls.Add(this.labelEmergency);
            this.Controls.Add(this.labelAvailability);
            this.Controls.Add(this.labelWard);
            this.Controls.Add(this.labelBedID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelBedID;
        private System.Windows.Forms.Label labelWard;
        private System.Windows.Forms.Label labelAvailability;
        private System.Windows.Forms.Label labelEmergency;
        private System.Windows.Forms.TextBox textBoxBedID;
        private System.Windows.Forms.TextBox textBoxWard;
        private System.Windows.Forms.TextBox textBoxAvailability;
        private System.Windows.Forms.TextBox textBoxEmergency;
        private System.Windows.Forms.Button buttonDashboardAdd;
        private System.Windows.Forms.Label labelDashboardTimestamp;
        private System.Windows.Forms.Button buttonDashboardSearch;
        private System.Windows.Forms.Label labelDashboardID;
        private System.Windows.Forms.TextBox textBoxDashboardID;
        private System.Windows.Forms.DateTimePicker dateTimePickerDashboard;
    }
}