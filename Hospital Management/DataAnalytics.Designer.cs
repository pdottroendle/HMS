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
            this.buttonDataAdd = new System.Windows.Forms.Button();
            this.buttonDataSearch = new System.Windows.Forms.Button();
            this.label_dtpReport = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.statusStrip_Status = new System.Windows.Forms.StatusStrip();
            this.textBox_ReportID = new System.Windows.Forms.TextBox();
            this.label_DataReport = new System.Windows.Forms.Label();
            this.label_FilePath = new System.Windows.Forms.Label();
            this.textBox_ReportFilepath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ReportResults)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxReportType
            // 
            this.comboBoxReportType.FormattingEnabled = true;
            this.comboBoxReportType.Location = new System.Drawing.Point(157, 129);
            this.comboBoxReportType.Name = "comboBoxReportType";
            this.comboBoxReportType.Size = new System.Drawing.Size(301, 32);
            this.comboBoxReportType.TabIndex = 0;
            // 
            // dataGridView_ReportResults
            // 
            this.dataGridView_ReportResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ReportResults.Location = new System.Drawing.Point(489, 12);
            this.dataGridView_ReportResults.Name = "dataGridView_ReportResults";
            this.dataGridView_ReportResults.RowHeadersWidth = 72;
            this.dataGridView_ReportResults.RowTemplate.Height = 31;
            this.dataGridView_ReportResults.Size = new System.Drawing.Size(822, 421);
            this.dataGridView_ReportResults.TabIndex = 1;
            // 
            // label_ReportType
            // 
            this.label_ReportType.AutoSize = true;
            this.label_ReportType.Location = new System.Drawing.Point(-5, 136);
            this.label_ReportType.Name = "label_ReportType";
            this.label_ReportType.Size = new System.Drawing.Size(125, 25);
            this.label_ReportType.TabIndex = 2;
            this.label_ReportType.Text = "Report Type:";
            // 
            // buttonDataAdd
            // 
            this.buttonDataAdd.Location = new System.Drawing.Point(601, 457);
            this.buttonDataAdd.Name = "buttonDataAdd";
            this.buttonDataAdd.Size = new System.Drawing.Size(180, 55);
            this.buttonDataAdd.TabIndex = 3;
            this.buttonDataAdd.Text = "Add";
            this.buttonDataAdd.UseVisualStyleBackColor = true;
            this.buttonDataAdd.Click += new System.EventHandler(this.buttonDataAdd_Click);
            // 
            // buttonDataSearch
            // 
            this.buttonDataSearch.Location = new System.Drawing.Point(970, 457);
            this.buttonDataSearch.Name = "buttonDataSearch";
            this.buttonDataSearch.Size = new System.Drawing.Size(161, 55);
            this.buttonDataSearch.TabIndex = 3;
            this.buttonDataSearch.Text = "Search";
            this.buttonDataSearch.UseVisualStyleBackColor = true;
            this.buttonDataSearch.Click += new System.EventHandler(this.buttonDataSearch_Click);
            // 
            // label_dtpReport
            // 
            this.label_dtpReport.AutoSize = true;
            this.label_dtpReport.Location = new System.Drawing.Point(12, 442);
            this.label_dtpReport.Name = "label_dtpReport";
            this.label_dtpReport.Size = new System.Drawing.Size(115, 25);
            this.label_dtpReport.TabIndex = 5;
            this.label_dtpReport.Text = "Timestamp:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(145, 442);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(313, 29);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // statusStrip_Status
            // 
            this.statusStrip_Status.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip_Status.Location = new System.Drawing.Point(0, 574);
            this.statusStrip_Status.Name = "statusStrip_Status";
            this.statusStrip_Status.Size = new System.Drawing.Size(1489, 22);
            this.statusStrip_Status.TabIndex = 6;
            this.statusStrip_Status.Text = "statusStrip1";
            // 
            // textBox_ReportID
            // 
            this.textBox_ReportID.Location = new System.Drawing.Point(157, 67);
            this.textBox_ReportID.Name = "textBox_ReportID";
            this.textBox_ReportID.Size = new System.Drawing.Size(278, 29);
            this.textBox_ReportID.TabIndex = 7;
            // 
            // label_DataReport
            // 
            this.label_DataReport.AutoSize = true;
            this.label_DataReport.Location = new System.Drawing.Point(7, 71);
            this.label_DataReport.Name = "label_DataReport";
            this.label_DataReport.Size = new System.Drawing.Size(75, 25);
            this.label_DataReport.TabIndex = 2;
            this.label_DataReport.Text = "Report:";
            // 
            // label_FilePath
            // 
            this.label_FilePath.AutoSize = true;
            this.label_FilePath.Location = new System.Drawing.Point(-5, 199);
            this.label_FilePath.Name = "label_FilePath";
            this.label_FilePath.Size = new System.Drawing.Size(87, 25);
            this.label_FilePath.TabIndex = 2;
            this.label_FilePath.Text = "Filepath:";
            // 
            // textBox_ReportFilepath
            // 
            this.textBox_ReportFilepath.Location = new System.Drawing.Point(157, 195);
            this.textBox_ReportFilepath.Name = "textBox_ReportFilepath";
            this.textBox_ReportFilepath.Size = new System.Drawing.Size(278, 29);
            this.textBox_ReportFilepath.TabIndex = 7;
            // 
            // DataAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 596);
            this.Controls.Add(this.textBox_ReportFilepath);
            this.Controls.Add(this.textBox_ReportID);
            this.Controls.Add(this.statusStrip_Status);
            this.Controls.Add(this.label_dtpReport);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.buttonDataSearch);
            this.Controls.Add(this.buttonDataAdd);
            this.Controls.Add(this.label_DataReport);
            this.Controls.Add(this.label_FilePath);
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
        private System.Windows.Forms.Button buttonDataAdd;
        private System.Windows.Forms.Button buttonDataSearch;
        private System.Windows.Forms.Label label_dtpReport;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.StatusStrip statusStrip_Status;
        private System.Windows.Forms.TextBox textBox_ReportID;
        private System.Windows.Forms.Label label_DataReport;
        private System.Windows.Forms.Label label_FilePath;
        private System.Windows.Forms.TextBox textBox_ReportFilepath;
    }
}