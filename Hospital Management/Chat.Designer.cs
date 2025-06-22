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
            this.label_MessageInput = new System.Windows.Forms.Label();
            this.textBox_MessageID = new System.Windows.Forms.TextBox();
            this.buttonChatAdd = new System.Windows.Forms.Button();
            this.buttonChatSearch = new System.Windows.Forms.Button();
            this.labelChatStatus = new System.Windows.Forms.Label();
            this.statusStripChat = new System.Windows.Forms.StatusStrip();
            this.dataGridView_Chat = new System.Windows.Forms.DataGridView();
            this.label_Send = new System.Windows.Forms.Label();
            this.label_Receive = new System.Windows.Forms.Label();
            this.textBox_SendID = new System.Windows.Forms.TextBox();
            this.textBox_ReceiveID = new System.Windows.Forms.TextBox();
            this.label_Content = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridViewChat = new System.Windows.Forms.DataGridView();
            this.textBox_Content = new System.Windows.Forms.TextBox();
            this.label_ChatTimestamp = new System.Windows.Forms.Label();
            this.textBox_ChatTimestamp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Chat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChat)).BeginInit();
            this.SuspendLayout();
            // 
            // label_MessageInput
            // 
            this.label_MessageInput.AutoSize = true;
            this.label_MessageInput.Location = new System.Drawing.Point(12, 36);
            this.label_MessageInput.Name = "label_MessageInput";
            this.label_MessageInput.Size = new System.Drawing.Size(99, 25);
            this.label_MessageInput.TabIndex = 4;
            this.label_MessageInput.Text = "Message:";
            // 
            // textBox_MessageID
            // 
            this.textBox_MessageID.Location = new System.Drawing.Point(209, 36);
            this.textBox_MessageID.Name = "textBox_MessageID";
            this.textBox_MessageID.Size = new System.Drawing.Size(205, 29);
            this.textBox_MessageID.TabIndex = 5;
            // 
            // buttonChatAdd
            // 
            this.buttonChatAdd.Location = new System.Drawing.Point(653, 490);
            this.buttonChatAdd.Name = "buttonChatAdd";
            this.buttonChatAdd.Size = new System.Drawing.Size(201, 42);
            this.buttonChatAdd.TabIndex = 6;
            this.buttonChatAdd.Text = "Add";
            this.buttonChatAdd.UseVisualStyleBackColor = true;
            this.buttonChatAdd.Click += new System.EventHandler(this.buttonChatAdd_Click);
            // 
            // buttonChatSearch
            // 
            this.buttonChatSearch.Location = new System.Drawing.Point(1003, 490);
            this.buttonChatSearch.Name = "buttonChatSearch";
            this.buttonChatSearch.Size = new System.Drawing.Size(201, 42);
            this.buttonChatSearch.TabIndex = 6;
            this.buttonChatSearch.Text = "Search";
            this.buttonChatSearch.UseVisualStyleBackColor = true;
            this.buttonChatSearch.Click += new System.EventHandler(this.buttonChatSearch_Click);
            // 
            // labelChatStatus
            // 
            this.labelChatStatus.AutoSize = true;
            this.labelChatStatus.Location = new System.Drawing.Point(346, 507);
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
            // dataGridView_Chat
            // 
            this.dataGridView_Chat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Chat.Location = new System.Drawing.Point(571, 59);
            this.dataGridView_Chat.Name = "dataGridView_Chat";
            this.dataGridView_Chat.RowHeadersWidth = 72;
            this.dataGridView_Chat.RowTemplate.Height = 31;
            this.dataGridView_Chat.Size = new System.Drawing.Size(748, 373);
            this.dataGridView_Chat.TabIndex = 9;
            // 
            // label_Send
            // 
            this.label_Send.AutoSize = true;
            this.label_Send.Location = new System.Drawing.Point(12, 97);
            this.label_Send.Name = "label_Send";
            this.label_Send.Size = new System.Drawing.Size(65, 25);
            this.label_Send.TabIndex = 4;
            this.label_Send.Text = "Send:";
            // 
            // label_Receive
            // 
            this.label_Receive.AutoSize = true;
            this.label_Receive.Location = new System.Drawing.Point(12, 173);
            this.label_Receive.Name = "label_Receive";
            this.label_Receive.Size = new System.Drawing.Size(88, 25);
            this.label_Receive.TabIndex = 4;
            this.label_Receive.Text = "Receive:";
            // 
            // textBox_SendID
            // 
            this.textBox_SendID.Location = new System.Drawing.Point(209, 93);
            this.textBox_SendID.Name = "textBox_SendID";
            this.textBox_SendID.Size = new System.Drawing.Size(205, 29);
            this.textBox_SendID.TabIndex = 5;
            // 
            // textBox_ReceiveID
            // 
            this.textBox_ReceiveID.Location = new System.Drawing.Point(209, 170);
            this.textBox_ReceiveID.Name = "textBox_ReceiveID";
            this.textBox_ReceiveID.Size = new System.Drawing.Size(205, 29);
            this.textBox_ReceiveID.TabIndex = 5;
            // 
            // label_Content
            // 
            this.label_Content.AutoSize = true;
            this.label_Content.Location = new System.Drawing.Point(12, 255);
            this.label_Content.Name = "label_Content";
            this.label_Content.Size = new System.Drawing.Size(87, 25);
            this.label_Content.TabIndex = 4;
            this.label_Content.Text = "Content:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(209, 170);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 29);
            this.textBox1.TabIndex = 5;
            // 
            // dataGridViewChat
            // 
            this.dataGridViewChat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChat.Location = new System.Drawing.Point(571, 59);
            this.dataGridViewChat.Name = "dataGridViewChat";
            this.dataGridViewChat.RowHeadersWidth = 72;
            this.dataGridViewChat.RowTemplate.Height = 31;
            this.dataGridViewChat.Size = new System.Drawing.Size(748, 373);
            this.dataGridViewChat.TabIndex = 9;
            // 
            // textBox_Content
            // 
            this.textBox_Content.Location = new System.Drawing.Point(209, 251);
            this.textBox_Content.Name = "textBox_Content";
            this.textBox_Content.Size = new System.Drawing.Size(205, 29);
            this.textBox_Content.TabIndex = 5;
            // 
            // label_ChatTimestamp
            // 
            this.label_ChatTimestamp.AutoSize = true;
            this.label_ChatTimestamp.Location = new System.Drawing.Point(13, 369);
            this.label_ChatTimestamp.Name = "label_ChatTimestamp";
            this.label_ChatTimestamp.Size = new System.Drawing.Size(115, 25);
            this.label_ChatTimestamp.TabIndex = 11;
            this.label_ChatTimestamp.Text = "Timestamp:";
            // 
            // textBox_ChatTimestamp
            // 
            this.textBox_ChatTimestamp.Location = new System.Drawing.Point(209, 365);
            this.textBox_ChatTimestamp.Name = "textBox_ChatTimestamp";
            this.textBox_ChatTimestamp.Size = new System.Drawing.Size(177, 29);
            this.textBox_ChatTimestamp.TabIndex = 12;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 597);
            this.Controls.Add(this.textBox_ChatTimestamp);
            this.Controls.Add(this.label_ChatTimestamp);
            this.Controls.Add(this.dataGridViewChat);
            this.Controls.Add(this.dataGridView_Chat);
            this.Controls.Add(this.statusStripChat);
            this.Controls.Add(this.labelChatStatus);
            this.Controls.Add(this.buttonChatSearch);
            this.Controls.Add(this.textBox_Content);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonChatAdd);
            this.Controls.Add(this.textBox_ReceiveID);
            this.Controls.Add(this.textBox_SendID);
            this.Controls.Add(this.textBox_MessageID);
            this.Controls.Add(this.label_Content);
            this.Controls.Add(this.label_Receive);
            this.Controls.Add(this.label_Send);
            this.Controls.Add(this.label_MessageInput);
            this.Name = "Chat";
            this.Text = "Chat";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Chat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_MessageInput;
        private System.Windows.Forms.TextBox textBox_MessageID;
        private System.Windows.Forms.Button buttonChatAdd;
        private System.Windows.Forms.Button buttonChatSearch;
        private System.Windows.Forms.Label labelChatStatus;
        private System.Windows.Forms.StatusStrip statusStripChat;
        private System.Windows.Forms.DataGridView dataGridView_Chat;
        private System.Windows.Forms.Label label_Send;
        private System.Windows.Forms.Label label_Receive;
        private System.Windows.Forms.TextBox textBox_SendID;
        private System.Windows.Forms.TextBox textBox_ReceiveID;
        private System.Windows.Forms.Label label_Content;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridViewChat;
        private System.Windows.Forms.TextBox textBox_Content;
        private System.Windows.Forms.Label label_ChatTimestamp;
        private System.Windows.Forms.TextBox textBox_ChatTimestamp;
    }
}