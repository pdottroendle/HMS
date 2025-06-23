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
            this.textBox_GeneratedBy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ReportResults)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxReportType
            // 
            this.comboBoxReportType.FormattingEnabled = true;
            this.comboBoxReportType.Location = new System.Drawing.Point(86, 70);
            this.comboBoxReportType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxReportType.Name = "comboBoxReportType";
            this.comboBoxReportType.Size = new System.Drawing.Size(166, 21);
            this.comboBoxReportType.TabIndex = 0;
            // 
            // dataGridView_ReportResults
            // 
            this.dataGridView_ReportResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ReportResults.Location = new System.Drawing.Point(267, 6);
            this.dataGridView_ReportResults.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_ReportResults.Name = "dataGridView_ReportResults";
            this.dataGridView_ReportResults.RowHeadersWidth = 72;
            this.dataGridView_ReportResults.RowTemplate.Height = 31;
            this.dataGridView_ReportResults.Size = new System.Drawing.Size(448, 228);
            this.dataGridView_ReportResults.TabIndex = 1;
            // 
            // label_ReportType
            // 
            this.label_ReportType.AutoSize = true;
            this.label_ReportType.Location = new System.Drawing.Point(-3, 74);
            this.label_ReportType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ReportType.Name = "label_ReportType";
            this.label_ReportType.Size = new System.Drawing.Size(69, 13);
            this.label_ReportType.TabIndex = 2;
            this.label_ReportType.Text = "Report Type:";
            // 
            // buttonDataAdd
            // 
            this.buttonDataAdd.Location = new System.Drawing.Point(328, 248);
            this.buttonDataAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDataAdd.Name = "buttonDataAdd";
            this.buttonDataAdd.Size = new System.Drawing.Size(98, 30);
            this.buttonDataAdd.TabIndex = 3;
            this.buttonDataAdd.Text = "Add";
            this.buttonDataAdd.UseVisualStyleBackColor = true;
            this.buttonDataAdd.Click += new System.EventHandler(this.buttonDataAdd_Click);
            // 
            // buttonDataSearch
            // 
            this.buttonDataSearch.Location = new System.Drawing.Point(529, 248);
            this.buttonDataSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDataSearch.Name = "buttonDataSearch";
            this.buttonDataSearch.Size = new System.Drawing.Size(88, 30);
            this.buttonDataSearch.TabIndex = 3;
            this.buttonDataSearch.Text = "Search";
            this.buttonDataSearch.UseVisualStyleBackColor = true;
            this.buttonDataSearch.Click += new System.EventHandler(this.buttonDataSearch_Click);
            // 
            // label_dtpReport
            // 
            this.label_dtpReport.AutoSize = true;
            this.label_dtpReport.Location = new System.Drawing.Point(7, 239);
            this.label_dtpReport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_dtpReport.Name = "label_dtpReport";
            this.label_dtpReport.Size = new System.Drawing.Size(61, 13);
            this.label_dtpReport.TabIndex = 5;
            this.label_dtpReport.Text = "Timestamp:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(79, 239);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(173, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // statusStrip_Status
            // 
            this.statusStrip_Status.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip_Status.Location = new System.Drawing.Point(0, 301);
            this.statusStrip_Status.Name = "statusStrip_Status";
            this.statusStrip_Status.Padding = new System.Windows.Forms.Padding(1, 0, 8, 0);
            this.statusStrip_Status.Size = new System.Drawing.Size(812, 22);
            this.statusStrip_Status.TabIndex = 6;
            this.statusStrip_Status.Text = "statusStrip1";
            // 
            // textBox_ReportID
            // 
            this.textBox_ReportID.Location = new System.Drawing.Point(86, 36);
            this.textBox_ReportID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_ReportID.Name = "textBox_ReportID";
            this.textBox_ReportID.Size = new System.Drawing.Size(153, 20);
            this.textBox_ReportID.TabIndex = 7;
            // 
            // label_DataReport
            // 
            this.label_DataReport.AutoSize = true;
            this.label_DataReport.Location = new System.Drawing.Point(4, 38);
            this.label_DataReport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_DataReport.Name = "label_DataReport";
            this.label_DataReport.Size = new System.Drawing.Size(42, 13);
            this.label_DataReport.TabIndex = 2;
            this.label_DataReport.Text = "Report:";
            // 
            // label_FilePath
            // 
            this.label_FilePath.AutoSize = true;
            this.label_FilePath.Location = new System.Drawing.Point(-3, 108);
            this.label_FilePath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_FilePath.Name = "label_FilePath";
            this.label_FilePath.Size = new System.Drawing.Size(47, 13);
            this.label_FilePath.TabIndex = 2;
            this.label_FilePath.Text = "Filepath:";
            // 
            // textBox_ReportFilepath
            // 
            this.textBox_ReportFilepath.Location = new System.Drawing.Point(86, 106);
            this.textBox_ReportFilepath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_ReportFilepath.Name = "textBox_ReportFilepath";
            this.textBox_ReportFilepath.Size = new System.Drawing.Size(153, 20);
            this.textBox_ReportFilepath.TabIndex = 7;
            // 
            // textBox_GeneratedBy
            // 
            this.textBox_GeneratedBy.Location = new System.Drawing.Point(86, 141);
            this.textBox_GeneratedBy.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_GeneratedBy.Name = "textBox_GeneratedBy";
            this.textBox_GeneratedBy.Size = new System.Drawing.Size(153, 20);
            this.textBox_GeneratedBy.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Generated by:";
            // 
            // DataAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 323);
            this.Controls.Add(this.textBox_GeneratedBy);
            this.Controls.Add(this.label1);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox textBox_GeneratedBy;
        private System.Windows.Forms.Label label1;
    }
}