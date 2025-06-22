namespace Hospital_Management
{
    partial class InventoryLog
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
            this.dataGridViewInventoryLog = new System.Windows.Forms.DataGridView();
            this.label_logItem = new System.Windows.Forms.Label();
            this.label_LogChange = new System.Windows.Forms.Label();
            this.label_LogReason = new System.Windows.Forms.Label();
            this.textBox_LogChange = new System.Windows.Forms.TextBox();
            this.textBox_LogReason = new System.Windows.Forms.TextBox();
            this.button_LogAdd = new System.Windows.Forms.Button();
            this.button_LogSearch = new System.Windows.Forms.Button();
            this.textBoxLogItemID = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_LogUserID = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLogID = new System.Windows.Forms.TextBox();
            this.label_Log = new System.Windows.Forms.Label();
            this.textBox_LogUserID = new System.Windows.Forms.TextBox();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_LogTimestamp = new System.Windows.Forms.TextBox();
            this.label_LogTimestamp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventoryLog)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInventoryLog
            // 
            this.dataGridViewInventoryLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventoryLog.Location = new System.Drawing.Point(518, 12);
            this.dataGridViewInventoryLog.Name = "dataGridViewInventoryLog";
            this.dataGridViewInventoryLog.RowHeadersWidth = 72;
            this.dataGridViewInventoryLog.RowTemplate.Height = 31;
            this.dataGridViewInventoryLog.Size = new System.Drawing.Size(768, 447);
            this.dataGridViewInventoryLog.TabIndex = 0;
            // 
            // label_logItem
            // 
            this.label_logItem.AutoSize = true;
            this.label_logItem.Location = new System.Drawing.Point(24, 108);
            this.label_logItem.Name = "label_logItem";
            this.label_logItem.Size = new System.Drawing.Size(55, 25);
            this.label_logItem.TabIndex = 1;
            this.label_logItem.Text = "Item:";
            // 
            // label_LogChange
            // 
            this.label_LogChange.AutoSize = true;
            this.label_LogChange.Location = new System.Drawing.Point(12, 207);
            this.label_LogChange.Name = "label_LogChange";
            this.label_LogChange.Size = new System.Drawing.Size(161, 25);
            this.label_LogChange.TabIndex = 3;
            this.label_LogChange.Text = "Change Amount:";
            // 
            // label_LogReason
            // 
            this.label_LogReason.AutoSize = true;
            this.label_LogReason.Location = new System.Drawing.Point(24, 309);
            this.label_LogReason.Name = "label_LogReason";
            this.label_LogReason.Size = new System.Drawing.Size(85, 25);
            this.label_LogReason.TabIndex = 3;
            this.label_LogReason.Text = "Reason:";
            // 
            // textBox_LogChange
            // 
            this.textBox_LogChange.Location = new System.Drawing.Point(231, 207);
            this.textBox_LogChange.Name = "textBox_LogChange";
            this.textBox_LogChange.Size = new System.Drawing.Size(171, 29);
            this.textBox_LogChange.TabIndex = 4;
            // 
            // textBox_LogReason
            // 
            this.textBox_LogReason.Location = new System.Drawing.Point(228, 305);
            this.textBox_LogReason.Name = "textBox_LogReason";
            this.textBox_LogReason.Size = new System.Drawing.Size(174, 29);
            this.textBox_LogReason.TabIndex = 4;
            // 
            // button_LogAdd
            // 
            this.button_LogAdd.Location = new System.Drawing.Point(626, 495);
            this.button_LogAdd.Name = "button_LogAdd";
            this.button_LogAdd.Size = new System.Drawing.Size(184, 47);
            this.button_LogAdd.TabIndex = 5;
            this.button_LogAdd.Text = "Add";
            this.button_LogAdd.UseVisualStyleBackColor = true;
            this.button_LogAdd.Click += new System.EventHandler(this.button_LogAdd_Click);
            // 
            // button_LogSearch
            // 
            this.button_LogSearch.Location = new System.Drawing.Point(984, 495);
            this.button_LogSearch.Name = "button_LogSearch";
            this.button_LogSearch.Size = new System.Drawing.Size(136, 51);
            this.button_LogSearch.TabIndex = 5;
            this.button_LogSearch.Text = "Search";
            this.button_LogSearch.UseVisualStyleBackColor = true;
            this.button_LogSearch.Click += new System.EventHandler(this.button_LogSearch_Click);
            // 
            // textBoxLogItemID
            // 
            this.textBoxLogItemID.Location = new System.Drawing.Point(231, 36);
            this.textBoxLogItemID.Name = "textBoxLogItemID";
            this.textBoxLogItemID.Size = new System.Drawing.Size(160, 29);
            this.textBoxLogItemID.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(228, 379);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 29);
            this.textBox1.TabIndex = 7;
            // 
            // label_LogUserID
            // 
            this.label_LogUserID.AutoSize = true;
            this.label_LogUserID.Location = new System.Drawing.Point(24, 108);
            this.label_LogUserID.Name = "label_LogUserID";
            this.label_LogUserID.Size = new System.Drawing.Size(59, 25);
            this.label_LogUserID.TabIndex = 1;
            this.label_LogUserID.Text = "User:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(228, 379);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 29);
            this.textBox2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item:";
            // 
            // textBoxLogID
            // 
            this.textBoxLogID.Location = new System.Drawing.Point(228, 379);
            this.textBoxLogID.Name = "textBoxLogID";
            this.textBoxLogID.Size = new System.Drawing.Size(174, 29);
            this.textBoxLogID.TabIndex = 7;
            // 
            // label_Log
            // 
            this.label_Log.AutoSize = true;
            this.label_Log.Location = new System.Drawing.Point(41, 392);
            this.label_Log.Name = "label_Log";
            this.label_Log.Size = new System.Drawing.Size(51, 25);
            this.label_Log.TabIndex = 1;
            this.label_Log.Text = "Log:";
            // 
            // textBox_LogUserID
            // 
            this.textBox_LogUserID.Location = new System.Drawing.Point(228, 108);
            this.textBox_LogUserID.Name = "textBox_LogUserID";
            this.textBox_LogUserID.Size = new System.Drawing.Size(160, 29);
            this.textBox_LogUserID.TabIndex = 6;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(228, 484);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(174, 29);
            this.textBox3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Log:";
            // 
            // textBox_LogTimestamp
            // 
            this.textBox_LogTimestamp.Location = new System.Drawing.Point(228, 484);
            this.textBox_LogTimestamp.Name = "textBox_LogTimestamp";
            this.textBox_LogTimestamp.Size = new System.Drawing.Size(174, 29);
            this.textBox_LogTimestamp.TabIndex = 7;
            // 
            // label_LogTimestamp
            // 
            this.label_LogTimestamp.AutoSize = true;
            this.label_LogTimestamp.Location = new System.Drawing.Point(41, 484);
            this.label_LogTimestamp.Name = "label_LogTimestamp";
            this.label_LogTimestamp.Size = new System.Drawing.Size(119, 25);
            this.label_LogTimestamp.TabIndex = 1;
            this.label_LogTimestamp.Text = "TimeStamp:";
            // 
            // InventoryLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 650);
            this.Controls.Add(this.textBox_LogTimestamp);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBoxLogID);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox_LogUserID);
            this.Controls.Add(this.textBoxLogItemID);
            this.Controls.Add(this.button_LogSearch);
            this.Controls.Add(this.button_LogAdd);
            this.Controls.Add(this.textBox_LogReason);
            this.Controls.Add(this.textBox_LogChange);
            this.Controls.Add(this.label_LogTimestamp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_LogReason);
            this.Controls.Add(this.label_Log);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_LogUserID);
            this.Controls.Add(this.label_LogChange);
            this.Controls.Add(this.label_logItem);
            this.Controls.Add(this.dataGridViewInventoryLog);
            this.Name = "InventoryLog";
            this.Text = "InventoryLog";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventoryLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInventoryLog;
        private System.Windows.Forms.Label label_logItem;
        private System.Windows.Forms.Label label_LogChange;
        private System.Windows.Forms.Label label_LogReason;
        private System.Windows.Forms.TextBox textBox_LogChange;
        private System.Windows.Forms.TextBox textBox_LogReason;
        private System.Windows.Forms.Button button_LogAdd;
        private System.Windows.Forms.Button button_LogSearch;
        private System.Windows.Forms.TextBox textBoxLogItemID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_LogUserID;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLogID;
        private System.Windows.Forms.Label label_Log;
        private System.Windows.Forms.TextBox textBox_LogUserID;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_LogTimestamp;
        private System.Windows.Forms.Label label_LogTimestamp;
    }
}