namespace Hospital_Management
{
    partial class Notification
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
            this.dataGridView_Notification = new System.Windows.Forms.DataGridView();
            this.button_MarkAsRead = new System.Windows.Forms.Button();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.label_Status = new System.Windows.Forms.Label();
            this.statusStrip_Message = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Notification)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Notification
            // 
            this.dataGridView_Notification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Notification.Location = new System.Drawing.Point(319, 53);
            this.dataGridView_Notification.Name = "dataGridView_Notification";
            this.dataGridView_Notification.RowHeadersWidth = 72;
            this.dataGridView_Notification.RowTemplate.Height = 31;
            this.dataGridView_Notification.Size = new System.Drawing.Size(883, 454);
            this.dataGridView_Notification.TabIndex = 0;
            // 
            // button_MarkAsRead
            // 
            this.button_MarkAsRead.Location = new System.Drawing.Point(371, 552);
            this.button_MarkAsRead.Name = "button_MarkAsRead";
            this.button_MarkAsRead.Size = new System.Drawing.Size(156, 35);
            this.button_MarkAsRead.TabIndex = 1;
            this.button_MarkAsRead.Text = "Mark As Read";
            this.button_MarkAsRead.UseVisualStyleBackColor = true;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(643, 552);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(156, 35);
            this.button_Refresh.TabIndex = 1;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(940, 552);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(156, 35);
            this.button_Close.TabIndex = 1;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Location = new System.Drawing.Point(37, 259);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(68, 25);
            this.label_Status.TabIndex = 2;
            this.label_Status.Text = "Status";
            // 
            // statusStrip_Message
            // 
            this.statusStrip_Message.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip_Message.Location = new System.Drawing.Point(0, 583);
            this.statusStrip_Message.Name = "statusStrip_Message";
            this.statusStrip_Message.Size = new System.Drawing.Size(1346, 33);
            this.statusStrip_Message.TabIndex = 3;
            this.statusStrip_Message.Text = "statusStrip1";
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 616);
            this.Controls.Add(this.statusStrip_Message);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.button_MarkAsRead);
            this.Controls.Add(this.dataGridView_Notification);
            this.Name = "Notification";
            this.Text = "Notification";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Notification)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Notification;
        private System.Windows.Forms.Button button_MarkAsRead;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.StatusStrip statusStrip_Message;
    }
}