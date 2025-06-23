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
            this.button_NotificationAdd = new System.Windows.Forms.Button();
            this.button_NotificationSearch = new System.Windows.Forms.Button();
            this.label_IsRead = new System.Windows.Forms.Label();
            this.statusStrip_Message = new System.Windows.Forms.StatusStrip();
            this.label_NotificationUser = new System.Windows.Forms.Label();
            this.label_NotifyMessage = new System.Windows.Forms.Label();
            this.label_Notification = new System.Windows.Forms.Label();
            this.checkBox_IsRead = new System.Windows.Forms.CheckBox();
            this.textBox_NotificationID = new System.Windows.Forms.TextBox();
            this.textBox_UserID = new System.Windows.Forms.TextBox();
            this.textBox_Message = new System.Windows.Forms.TextBox();
            this.label_NotificationTime = new System.Windows.Forms.Label();
            this.textBox_NotificationTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Notification)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Notification
            // 
            this.dataGridView_Notification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Notification.Location = new System.Drawing.Point(241, 15);
            this.dataGridView_Notification.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_Notification.Name = "dataGridView_Notification";
            this.dataGridView_Notification.RowHeadersWidth = 72;
            this.dataGridView_Notification.RowTemplate.Height = 31;
            this.dataGridView_Notification.Size = new System.Drawing.Size(443, 216);
            this.dataGridView_Notification.TabIndex = 0;
            // 
            // button_NotificationAdd
            // 
            this.button_NotificationAdd.Location = new System.Drawing.Point(389, 263);
            this.button_NotificationAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_NotificationAdd.Name = "button_NotificationAdd";
            this.button_NotificationAdd.Size = new System.Drawing.Size(85, 19);
            this.button_NotificationAdd.TabIndex = 1;
            this.button_NotificationAdd.Text = "Add";
            this.button_NotificationAdd.UseVisualStyleBackColor = true;
            this.button_NotificationAdd.Click += new System.EventHandler(this.button_NotificationAdd_Click);
            // 
            // button_NotificationSearch
            // 
            this.button_NotificationSearch.Location = new System.Drawing.Point(543, 263);
            this.button_NotificationSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_NotificationSearch.Name = "button_NotificationSearch";
            this.button_NotificationSearch.Size = new System.Drawing.Size(85, 19);
            this.button_NotificationSearch.TabIndex = 1;
            this.button_NotificationSearch.Text = "Search";
            this.button_NotificationSearch.UseVisualStyleBackColor = true;
            this.button_NotificationSearch.Click += new System.EventHandler(this.button_NotificationSearch_Click);
            // 
            // label_IsRead
            // 
            this.label_IsRead.AutoSize = true;
            this.label_IsRead.Location = new System.Drawing.Point(20, 140);
            this.label_IsRead.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_IsRead.Name = "label_IsRead";
            this.label_IsRead.Size = new System.Drawing.Size(44, 13);
            this.label_IsRead.TabIndex = 2;
            this.label_IsRead.Text = "IsRead:";
            // 
            // statusStrip_Message
            // 
            this.statusStrip_Message.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip_Message.Location = new System.Drawing.Point(0, 312);
            this.statusStrip_Message.Name = "statusStrip_Message";
            this.statusStrip_Message.Padding = new System.Windows.Forms.Padding(1, 0, 8, 0);
            this.statusStrip_Message.Size = new System.Drawing.Size(734, 22);
            this.statusStrip_Message.TabIndex = 3;
            this.statusStrip_Message.Text = "statusStrip1";
            // 
            // label_NotificationUser
            // 
            this.label_NotificationUser.AutoSize = true;
            this.label_NotificationUser.Location = new System.Drawing.Point(25, 56);
            this.label_NotificationUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_NotificationUser.Name = "label_NotificationUser";
            this.label_NotificationUser.Size = new System.Drawing.Size(32, 13);
            this.label_NotificationUser.TabIndex = 4;
            this.label_NotificationUser.Text = "User:";
            // 
            // label_NotifyMessage
            // 
            this.label_NotifyMessage.AutoSize = true;
            this.label_NotifyMessage.Location = new System.Drawing.Point(20, 95);
            this.label_NotifyMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_NotifyMessage.Name = "label_NotifyMessage";
            this.label_NotifyMessage.Size = new System.Drawing.Size(53, 13);
            this.label_NotifyMessage.TabIndex = 4;
            this.label_NotifyMessage.Text = "Message:";
            // 
            // label_Notification
            // 
            this.label_Notification.AutoSize = true;
            this.label_Notification.Location = new System.Drawing.Point(20, 24);
            this.label_Notification.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Notification.Name = "label_Notification";
            this.label_Notification.Size = new System.Drawing.Size(63, 13);
            this.label_Notification.TabIndex = 4;
            this.label_Notification.Text = "Notification:";
            // 
            // checkBox_IsRead
            // 
            this.checkBox_IsRead.AutoSize = true;
            this.checkBox_IsRead.Location = new System.Drawing.Point(117, 142);
            this.checkBox_IsRead.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_IsRead.Name = "checkBox_IsRead";
            this.checkBox_IsRead.Size = new System.Drawing.Size(15, 14);
            this.checkBox_IsRead.TabIndex = 5;
            this.checkBox_IsRead.UseVisualStyleBackColor = true;
            // 
            // textBox_NotificationID
            // 
            this.textBox_NotificationID.Location = new System.Drawing.Point(99, 24);
            this.textBox_NotificationID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_NotificationID.Name = "textBox_NotificationID";
            this.textBox_NotificationID.Size = new System.Drawing.Size(85, 20);
            this.textBox_NotificationID.TabIndex = 6;
            // 
            // textBox_UserID
            // 
            this.textBox_UserID.Location = new System.Drawing.Point(99, 54);
            this.textBox_UserID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_UserID.Name = "textBox_UserID";
            this.textBox_UserID.Size = new System.Drawing.Size(85, 20);
            this.textBox_UserID.TabIndex = 6;
            // 
            // textBox_Message
            // 
            this.textBox_Message.Location = new System.Drawing.Point(99, 95);
            this.textBox_Message.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Message.Name = "textBox_Message";
            this.textBox_Message.Size = new System.Drawing.Size(85, 20);
            this.textBox_Message.TabIndex = 6;
            // 
            // label_NotificationTime
            // 
            this.label_NotificationTime.AutoSize = true;
            this.label_NotificationTime.Location = new System.Drawing.Point(9, 269);
            this.label_NotificationTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_NotificationTime.Name = "label_NotificationTime";
            this.label_NotificationTime.Size = new System.Drawing.Size(63, 13);
            this.label_NotificationTime.TabIndex = 7;
            this.label_NotificationTime.Text = "TimeStamp:";
            // 
            // textBox_NotificationTime
            // 
            this.textBox_NotificationTime.Location = new System.Drawing.Point(99, 269);
            this.textBox_NotificationTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_NotificationTime.Name = "textBox_NotificationTime";
            this.textBox_NotificationTime.Size = new System.Drawing.Size(90, 20);
            this.textBox_NotificationTime.TabIndex = 8;
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 334);
            this.Controls.Add(this.textBox_NotificationTime);
            this.Controls.Add(this.label_NotificationTime);
            this.Controls.Add(this.textBox_Message);
            this.Controls.Add(this.textBox_UserID);
            this.Controls.Add(this.textBox_NotificationID);
            this.Controls.Add(this.checkBox_IsRead);
            this.Controls.Add(this.label_NotifyMessage);
            this.Controls.Add(this.label_Notification);
            this.Controls.Add(this.label_NotificationUser);
            this.Controls.Add(this.statusStrip_Message);
            this.Controls.Add(this.label_IsRead);
            this.Controls.Add(this.button_NotificationSearch);
            this.Controls.Add(this.button_NotificationAdd);
            this.Controls.Add(this.dataGridView_Notification);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Notification";
            this.Text = "Notification";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Notification)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Notification;
        private System.Windows.Forms.Button button_NotificationAdd;
        private System.Windows.Forms.Button button_NotificationSearch;
        private System.Windows.Forms.Label label_IsRead;
        private System.Windows.Forms.StatusStrip statusStrip_Message;
        private System.Windows.Forms.Label label_NotificationUser;
        private System.Windows.Forms.Label label_NotifyMessage;
        private System.Windows.Forms.Label label_Notification;
        private System.Windows.Forms.CheckBox checkBox_IsRead;
        private System.Windows.Forms.TextBox textBox_NotificationID;
        private System.Windows.Forms.TextBox textBox_UserID;
        private System.Windows.Forms.TextBox textBox_Message;
        private System.Windows.Forms.Label label_NotificationTime;
        private System.Windows.Forms.TextBox textBox_NotificationTime;
    }
}