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
            this.comboBoxLogItem = new System.Windows.Forms.ComboBox();
            this.label_LogChange = new System.Windows.Forms.Label();
            this.label_LogReason = new System.Windows.Forms.Label();
            this.textBox_LogChange = new System.Windows.Forms.TextBox();
            this.textBox_LogReason = new System.Windows.Forms.TextBox();
            this.button_LogAdd = new System.Windows.Forms.Button();
            this.button_LogSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventoryLog)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInventoryLog
            // 
            this.dataGridViewInventoryLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventoryLog.Location = new System.Drawing.Point(524, 80);
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
            // comboBoxLogItem
            // 
            this.comboBoxLogItem.FormattingEnabled = true;
            this.comboBoxLogItem.Location = new System.Drawing.Point(231, 101);
            this.comboBoxLogItem.Name = "comboBoxLogItem";
            this.comboBoxLogItem.Size = new System.Drawing.Size(169, 32);
            this.comboBoxLogItem.TabIndex = 2;
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
            this.button_LogAdd.Location = new System.Drawing.Point(644, 557);
            this.button_LogAdd.Name = "button_LogAdd";
            this.button_LogAdd.Size = new System.Drawing.Size(184, 47);
            this.button_LogAdd.TabIndex = 5;
            this.button_LogAdd.Text = "Add";
            this.button_LogAdd.UseVisualStyleBackColor = true;
            // 
            // button_LogSearch
            // 
            this.button_LogSearch.Location = new System.Drawing.Point(1021, 555);
            this.button_LogSearch.Name = "button_LogSearch";
            this.button_LogSearch.Size = new System.Drawing.Size(136, 51);
            this.button_LogSearch.TabIndex = 5;
            this.button_LogSearch.Text = "Search";
            this.button_LogSearch.UseVisualStyleBackColor = true;
            // 
            // InventoryLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 650);
            this.Controls.Add(this.button_LogSearch);
            this.Controls.Add(this.button_LogAdd);
            this.Controls.Add(this.textBox_LogReason);
            this.Controls.Add(this.textBox_LogChange);
            this.Controls.Add(this.label_LogReason);
            this.Controls.Add(this.label_LogChange);
            this.Controls.Add(this.comboBoxLogItem);
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
        private System.Windows.Forms.ComboBox comboBoxLogItem;
        private System.Windows.Forms.Label label_LogChange;
        private System.Windows.Forms.Label label_LogReason;
        private System.Windows.Forms.TextBox textBox_LogChange;
        private System.Windows.Forms.TextBox textBox_LogReason;
        private System.Windows.Forms.Button button_LogAdd;
        private System.Windows.Forms.Button button_LogSearch;
    }
}