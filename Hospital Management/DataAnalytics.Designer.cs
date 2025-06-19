namespace Hospital_Management
{
    partial class DataAnalytics
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
            this.comboBoxReportType = new System.Windows.Forms.ComboBox();
            this.dataGridView_ReportResults = new System.Windows.Forms.DataGridView();
            this.label_ReportType = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label_Start = new System.Windows.Forms.Label();
            this.label_End = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.statusStrip_Status = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ReportResults)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxReportType
            // 
            this.comboBoxReportType.FormattingEnabled = true;
            this.comboBoxReportType.Location = new System.Drawing.Point(145, 92);
            this.comboBoxReportType.Name = "comboBoxReportType";
            this.comboBoxReportType.Size = new System.Drawing.Size(301, 32);
            this.comboBoxReportType.TabIndex = 0;
            // 
            // dataGridView_ReportResults
            // 
            this.dataGridView_ReportResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ReportResults.Location = new System.Drawing.Point(480, 50);
            this.dataGridView_ReportResults.Name = "dataGridView_ReportResults";
            this.dataGridView_ReportResults.RowHeadersWidth = 72;
            this.dataGridView_ReportResults.RowTemplate.Height = 31;
            this.dataGridView_ReportResults.Size = new System.Drawing.Size(822, 421);
            this.dataGridView_ReportResults.TabIndex = 1;
            // 
            // label_ReportType
            // 
            this.label_ReportType.AutoSize = true;
            this.label_ReportType.Location = new System.Drawing.Point(12, 92);
            this.label_ReportType.Name = "label_ReportType";
            this.label_ReportType.Size = new System.Drawing.Size(125, 25);
            this.label_ReportType.TabIndex = 2;
            this.label_ReportType.Text = "Report Type:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(585, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generate Report";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(922, 506);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(161, 55);
            this.button_Close.TabIndex = 3;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(145, 179);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(313, 29);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label_Start
            // 
            this.label_Start.AutoSize = true;
            this.label_Start.Location = new System.Drawing.Point(17, 183);
            this.label_Start.Name = "label_Start";
            this.label_Start.Size = new System.Drawing.Size(105, 25);
            this.label_Start.TabIndex = 5;
            this.label_Start.Text = "Start Date:";
            // 
            // label_End
            // 
            this.label_End.AutoSize = true;
            this.label_End.Location = new System.Drawing.Point(17, 289);
            this.label_End.Name = "label_End";
            this.label_End.Size = new System.Drawing.Size(99, 25);
            this.label_End.TabIndex = 5;
            this.label_End.Text = "End Date:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(145, 285);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(313, 29);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // statusStrip_Status
            // 
            this.statusStrip_Status.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip_Status.Location = new System.Drawing.Point(0, 563);
            this.statusStrip_Status.Name = "statusStrip_Status";
            this.statusStrip_Status.Size = new System.Drawing.Size(1489, 33);
            this.statusStrip_Status.TabIndex = 6;
            this.statusStrip_Status.Text = "statusStrip1";
            // 
            // DataAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 596);
            this.Controls.Add(this.statusStrip_Status);
            this.Controls.Add(this.label_End);
            this.Controls.Add(this.label_Start);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_ReportType);
            this.Controls.Add(this.dataGridView_ReportResults);
            this.Controls.Add(this.comboBoxReportType);
            this.Name = "DataAnalytics";
            this.Text = "DataAnalytics";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ReportResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxReportType;
        private System.Windows.Forms.DataGridView dataGridView_ReportResults;
        private System.Windows.Forms.Label label_ReportType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_Start;
        private System.Windows.Forms.Label label_End;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.StatusStrip statusStrip_Status;
    }
}