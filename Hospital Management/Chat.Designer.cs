namespace Hospital_Management
{
    partial class Chat
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
            this.label_Chat = new System.Windows.Forms.Label();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.richTextBox_TextHistory = new System.Windows.Forms.RichTextBox();
            this.label_history = new System.Windows.Forms.Label();
            this.label_MessageInput = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonChatAdd = new System.Windows.Forms.Button();
            this.buttonChatSearch = new System.Windows.Forms.Button();
            this.labelChatStatus = new System.Windows.Forms.Label();
            this.statusStripChat = new System.Windows.Forms.StatusStrip();
            this.SuspendLayout();
            // 
            // label_Chat
            // 
            this.label_Chat.AutoSize = true;
            this.label_Chat.Location = new System.Drawing.Point(249, 88);
            this.label_Chat.Name = "label_Chat";
            this.label_Chat.Size = new System.Drawing.Size(99, 25);
            this.label_Chat.TabIndex = 0;
            this.label_Chat.Text = "Chat with:";
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(439, 85);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(217, 32);
            this.comboBoxUser.TabIndex = 1;
            // 
            // richTextBox_TextHistory
            // 
            this.richTextBox_TextHistory.Location = new System.Drawing.Point(439, 186);
            this.richTextBox_TextHistory.Name = "richTextBox_TextHistory";
            this.richTextBox_TextHistory.Size = new System.Drawing.Size(238, 48);
            this.richTextBox_TextHistory.TabIndex = 2;
            this.richTextBox_TextHistory.Text = "";
            // 
            // label_history
            // 
            this.label_history.AutoSize = true;
            this.label_history.Location = new System.Drawing.Point(249, 189);
            this.label_history.Name = "label_history";
            this.label_history.Size = new System.Drawing.Size(119, 25);
            this.label_history.TabIndex = 3;
            this.label_history.Text = "Chat History";
            // 
            // label_MessageInput
            // 
            this.label_MessageInput.AutoSize = true;
            this.label_MessageInput.Location = new System.Drawing.Point(234, 300);
            this.label_MessageInput.Name = "label_MessageInput";
            this.label_MessageInput.Size = new System.Drawing.Size(147, 25);
            this.label_MessageInput.TabIndex = 4;
            this.label_MessageInput.Text = "Message Input:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(456, 296);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 29);
            this.textBox1.TabIndex = 5;
            // 
            // buttonChatAdd
            // 
            this.buttonChatAdd.Location = new System.Drawing.Point(216, 402);
            this.buttonChatAdd.Name = "buttonChatAdd";
            this.buttonChatAdd.Size = new System.Drawing.Size(201, 42);
            this.buttonChatAdd.TabIndex = 6;
            this.buttonChatAdd.Text = "Add";
            this.buttonChatAdd.UseVisualStyleBackColor = true;
            // 
            // buttonChatSearch
            // 
            this.buttonChatSearch.Location = new System.Drawing.Point(583, 402);
            this.buttonChatSearch.Name = "buttonChatSearch";
            this.buttonChatSearch.Size = new System.Drawing.Size(201, 42);
            this.buttonChatSearch.TabIndex = 6;
            this.buttonChatSearch.Text = "Search";
            this.buttonChatSearch.UseVisualStyleBackColor = true;
            // 
            // labelChatStatus
            // 
            this.labelChatStatus.AutoSize = true;
            this.labelChatStatus.Location = new System.Drawing.Point(827, 300);
            this.labelChatStatus.Name = "labelChatStatus";
            this.labelChatStatus.Size = new System.Drawing.Size(68, 25);
            this.labelChatStatus.TabIndex = 7;
            this.labelChatStatus.Text = "Status";
            // 
            // statusStripChat
            // 
            this.statusStripChat.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStripChat.Location = new System.Drawing.Point(0, 575);
            this.statusStripChat.Name = "statusStripChat";
            this.statusStripChat.Size = new System.Drawing.Size(1398, 22);
            this.statusStripChat.TabIndex = 8;
            this.statusStripChat.Text = "statusStrip1";
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 597);
            this.Controls.Add(this.statusStripChat);
            this.Controls.Add(this.labelChatStatus);
            this.Controls.Add(this.buttonChatSearch);
            this.Controls.Add(this.buttonChatAdd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_MessageInput);
            this.Controls.Add(this.label_history);
            this.Controls.Add(this.richTextBox_TextHistory);
            this.Controls.Add(this.comboBoxUser);
            this.Controls.Add(this.label_Chat);
            this.Name = "Chat";
            this.Text = "Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Chat;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.RichTextBox richTextBox_TextHistory;
        private System.Windows.Forms.Label label_history;
        private System.Windows.Forms.Label label_MessageInput;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonChatAdd;
        private System.Windows.Forms.Button buttonChatSearch;
        private System.Windows.Forms.Label labelChatStatus;
        private System.Windows.Forms.StatusStrip statusStripChat;
    }
}