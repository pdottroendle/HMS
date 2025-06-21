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
            this.label_Status = new System.Windows.Forms.Label();
            this.statusStrip_Message = new System.Windows.Forms.StatusStrip();
            this.label_NotifyUser = new System.Windows.Forms.Label();
            this.label_NotifyMessage = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_NotifyUser = new System.Windows.Forms.ComboBox();
            this.comboBox_NotifyMessage = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Notification)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Notification
            // 
            this.dataGridView_Notification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Notification.Location = new System.Drawing.Point(438, 55);
            this.dataGridView_Notification.Name = "dataGridView_Notification";
            this.dataGridView_Notification.RowHeadersWidth = 72;
            this.dataGridView_Notification.RowTemplate.Height = 31;
            this.dataGridView_Notification.Size = new System.Drawing.Size(813, 398);
            this.dataGridView_Notification.TabIndex = 0;
            // 
            // button_NotificationAdd
            // 
            this.button_NotificationAdd.Location = new System.Drawing.Point(604, 492);
            this.button_NotificationAdd.Name = "button_NotificationAdd";
            this.button_NotificationAdd.Size = new System.Drawing.Size(156, 35);
            this.button_NotificationAdd.TabIndex = 1;
            this.button_NotificationAdd.Text = "Add";
            this.button_NotificationAdd.UseVisualStyleBackColor = true;
            // 
            // button_NotificationSearch
            // 
            this.button_NotificationSearch.Location = new System.Drawing.Point(903, 492);
            this.button_NotificationSearch.Name = "button_NotificationSearch";
            this.button_NotificationSearch.Size = new System.Drawing.Size(156, 35);
            this.button_NotificationSearch.TabIndex = 1;
            this.button_NotificationSearch.Text = "Search";
            this.button_NotificationSearch.UseVisualStyleBackColor = true;
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
            this.statusStrip_Message.Location = new System.Drawing.Point(0, 594);
            this.statusStrip_Message.Name = "statusStrip_Message";
            this.statusStrip_Message.Size = new System.Drawing.Size(1346, 22);
            this.statusStrip_Message.TabIndex = 3;
            this.statusStrip_Message.Text = "statusStrip1";
            // 
            // label_NotifyUser
            // 
            this.label_NotifyUser.AutoSize = true;
            this.label_NotifyUser.Location = new System.Drawing.Point(42, 99);
            this.label_NotifyUser.Name = "label_NotifyUser";
            this.label_NotifyUser.Size = new System.Drawing.Size(59, 25);
            this.label_NotifyUser.TabIndex = 4;
            this.label_NotifyUser.Text = "User:";
            // 
            // label_NotifyMessage
            // 
            this.label_NotifyMessage.AutoSize = true;
            this.label_NotifyMessage.Location = new System.Drawing.Point(37, 176);
            this.label_NotifyMessage.Name = "label_NotifyMessage";
            this.label_NotifyMessage.Size = new System.Drawing.Size(99, 25);
            this.label_NotifyMessage.TabIndex = 4;
            this.label_NotifyMessage.Text = "Message:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(178, 99);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 32);
            this.comboBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(604, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox_NotifyUser
            // 
            this.comboBox_NotifyUser.FormattingEnabled = true;
            this.comboBox_NotifyUser.Location = new System.Drawing.Point(178, 99);
            this.comboBox_NotifyUser.Name = "comboBox_NotifyUser";
            this.comboBox_NotifyUser.Size = new System.Drawing.Size(121, 32);
            this.comboBox_NotifyUser.TabIndex = 5;
            // 
            // comboBox_NotifyMessage
            // 
            this.comboBox_NotifyMessage.FormattingEnabled = true;
            this.comboBox_NotifyMessage.Location = new System.Drawing.Point(178, 176);
            this.comboBox_NotifyMessage.Name = "comboBox_NotifyMessage";
            this.comboBox_NotifyMessage.Size = new System.Drawing.Size(121, 32);
            this.comboBox_NotifyMessage.TabIndex = 5;
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 616);
            this.Controls.Add(this.comboBox_NotifyMessage);
            this.Controls.Add(this.comboBox_NotifyUser);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_NotifyMessage);
            this.Controls.Add(this.label_NotifyUser);
            this.Controls.Add(this.statusStrip_Message);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.button_NotificationSearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_NotificationAdd);
            this.Controls.Add(this.dataGridView_Notification);
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
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.StatusStrip statusStrip_Message;
        private System.Windows.Forms.Label label_NotifyUser;
        private System.Windows.Forms.Label label_NotifyMessage;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_NotifyUser;
        private System.Windows.Forms.ComboBox comboBox_NotifyMessage;
    }
}