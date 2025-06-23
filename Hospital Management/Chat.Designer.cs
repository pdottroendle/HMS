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
            this.textBox_SenderID = new System.Windows.Forms.TextBox();
            this.textBox_ReceiveID = new System.Windows.Forms.TextBox();
            this.label_Content = new System.Windows.Forms.Label();
            this.textBox_ReceiverID = new System.Windows.Forms.TextBox();
            this.dataGridViewChat = new System.Windows.Forms.DataGridView();
            this.textBox_Content = new System.Windows.Forms.TextBox();
            this.label_ChatTimestamp = new System.Windows.Forms.Label();
            this.textBox_Timestamp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Chat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChat)).BeginInit();
            this.SuspendLayout();
            // 
            // label_MessageInput
            // 
            this.label_MessageInput.AutoSize = true;
            this.label_MessageInput.Location = new System.Drawing.Point(7, 20);
            this.label_MessageInput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_MessageInput.Name = "label_MessageInput";
            this.label_MessageInput.Size = new System.Drawing.Size(53, 13);
            this.label_MessageInput.TabIndex = 4;
            this.label_MessageInput.Text = "Message:";
            // 
            // textBox_MessageID
            // 
            this.textBox_MessageID.Location = new System.Drawing.Point(114, 20);
            this.textBox_MessageID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_MessageID.Name = "textBox_MessageID";
            this.textBox_MessageID.Size = new System.Drawing.Size(114, 20);
            this.textBox_MessageID.TabIndex = 5;
            // 
            // buttonChatAdd
            // 
            this.buttonChatAdd.Location = new System.Drawing.Point(356, 265);
            this.buttonChatAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonChatAdd.Name = "buttonChatAdd";
            this.buttonChatAdd.Size = new System.Drawing.Size(110, 23);
            this.buttonChatAdd.TabIndex = 6;
            this.buttonChatAdd.Text = "Add";
            this.buttonChatAdd.UseVisualStyleBackColor = true;
            this.buttonChatAdd.Click += new System.EventHandler(this.buttonChatAdd_Click);
            // 
            // buttonChatSearch
            // 
            this.buttonChatSearch.Location = new System.Drawing.Point(547, 265);
            this.buttonChatSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonChatSearch.Name = "buttonChatSearch";
            this.buttonChatSearch.Size = new System.Drawing.Size(110, 23);
            this.buttonChatSearch.TabIndex = 6;
            this.buttonChatSearch.Text = "Search";
            this.buttonChatSearch.UseVisualStyleBackColor = true;
            this.buttonChatSearch.Click += new System.EventHandler(this.buttonChatSearch_Click);
            // 
            // labelChatStatus
            // 
            this.labelChatStatus.AutoSize = true;
            this.labelChatStatus.Location = new System.Drawing.Point(189, 275);
            this.labelChatStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelChatStatus.Name = "labelChatStatus";
            this.labelChatStatus.Size = new System.Drawing.Size(37, 13);
            this.labelChatStatus.TabIndex = 7;
            this.labelChatStatus.Text = "Status";
            // 
            // statusStripChat
            // 
            this.statusStripChat.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStripChat.Location = new System.Drawing.Point(0, 301);
            this.statusStripChat.Name = "statusStripChat";
            this.statusStripChat.Padding = new System.Windows.Forms.Padding(1, 0, 8, 0);
            this.statusStripChat.Size = new System.Drawing.Size(763, 22);
            this.statusStripChat.TabIndex = 8;
            this.statusStripChat.Text = "statusStrip1";
            // 
            // dataGridView_Chat
            // 
            this.dataGridView_Chat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Chat.Location = new System.Drawing.Point(311, 32);
            this.dataGridView_Chat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_Chat.Name = "dataGridView_Chat";
            this.dataGridView_Chat.RowHeadersWidth = 72;
            this.dataGridView_Chat.RowTemplate.Height = 31;
            this.dataGridView_Chat.Size = new System.Drawing.Size(408, 202);
            this.dataGridView_Chat.TabIndex = 9;
            // 
            // label_Send
            // 
            this.label_Send.AutoSize = true;
            this.label_Send.Location = new System.Drawing.Point(7, 53);
            this.label_Send.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Send.Name = "label_Send";
            this.label_Send.Size = new System.Drawing.Size(35, 13);
            this.label_Send.TabIndex = 4;
            this.label_Send.Text = "Send:";
            // 
            // label_Receive
            // 
            this.label_Receive.AutoSize = true;
            this.label_Receive.Location = new System.Drawing.Point(7, 94);
            this.label_Receive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Receive.Name = "label_Receive";
            this.label_Receive.Size = new System.Drawing.Size(50, 13);
            this.label_Receive.TabIndex = 4;
            this.label_Receive.Text = "Receive:";
            // 
            // textBox_SenderID
            // 
            this.textBox_SenderID.Location = new System.Drawing.Point(114, 50);
            this.textBox_SenderID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_SenderID.Name = "textBox_SenderID";
            this.textBox_SenderID.Size = new System.Drawing.Size(114, 20);
            this.textBox_SenderID.TabIndex = 5;
            // 
            // textBox_ReceiveID
            // 
            this.textBox_ReceiveID.Location = new System.Drawing.Point(114, 92);
            this.textBox_ReceiveID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_ReceiveID.Name = "textBox_ReceiveID";
            this.textBox_ReceiveID.Size = new System.Drawing.Size(114, 20);
            this.textBox_ReceiveID.TabIndex = 5;
            // 
            // label_Content
            // 
            this.label_Content.AutoSize = true;
            this.label_Content.Location = new System.Drawing.Point(7, 138);
            this.label_Content.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Content.Name = "label_Content";
            this.label_Content.Size = new System.Drawing.Size(47, 13);
            this.label_Content.TabIndex = 4;
            this.label_Content.Text = "Content:";
            // 
            // textBox_ReceiverID
            // 
            this.textBox_ReceiverID.Location = new System.Drawing.Point(114, 92);
            this.textBox_ReceiverID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_ReceiverID.Name = "textBox_ReceiverID";
            this.textBox_ReceiverID.Size = new System.Drawing.Size(114, 20);
            this.textBox_ReceiverID.TabIndex = 5;
            // 
            // dataGridViewChat
            // 
            this.dataGridViewChat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChat.Location = new System.Drawing.Point(311, 32);
            this.dataGridViewChat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewChat.Name = "dataGridViewChat";
            this.dataGridViewChat.RowHeadersWidth = 72;
            this.dataGridViewChat.RowTemplate.Height = 31;
            this.dataGridViewChat.Size = new System.Drawing.Size(408, 202);
            this.dataGridViewChat.TabIndex = 9;
            // 
            // textBox_Content
            // 
            this.textBox_Content.Location = new System.Drawing.Point(114, 136);
            this.textBox_Content.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Content.Name = "textBox_Content";
            this.textBox_Content.Size = new System.Drawing.Size(114, 20);
            this.textBox_Content.TabIndex = 5;
            // 
            // label_ChatTimestamp
            // 
            this.label_ChatTimestamp.AutoSize = true;
            this.label_ChatTimestamp.Location = new System.Drawing.Point(7, 200);
            this.label_ChatTimestamp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ChatTimestamp.Name = "label_ChatTimestamp";
            this.label_ChatTimestamp.Size = new System.Drawing.Size(61, 13);
            this.label_ChatTimestamp.TabIndex = 11;
            this.label_ChatTimestamp.Text = "Timestamp:";
            // 
            // textBox_Timestamp
            // 
            this.textBox_Timestamp.Location = new System.Drawing.Point(114, 198);
            this.textBox_Timestamp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Timestamp.Name = "textBox_Timestamp";
            this.textBox_Timestamp.Size = new System.Drawing.Size(98, 20);
            this.textBox_Timestamp.TabIndex = 12;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 323);
            this.Controls.Add(this.textBox_Timestamp);
            this.Controls.Add(this.label_ChatTimestamp);
            this.Controls.Add(this.dataGridViewChat);
            this.Controls.Add(this.dataGridView_Chat);
            this.Controls.Add(this.statusStripChat);
            this.Controls.Add(this.labelChatStatus);
            this.Controls.Add(this.buttonChatSearch);
            this.Controls.Add(this.textBox_Content);
            this.Controls.Add(this.textBox_ReceiverID);
            this.Controls.Add(this.buttonChatAdd);
            this.Controls.Add(this.textBox_ReceiveID);
            this.Controls.Add(this.textBox_SenderID);
            this.Controls.Add(this.textBox_MessageID);
            this.Controls.Add(this.label_Content);
            this.Controls.Add(this.label_Receive);
            this.Controls.Add(this.label_Send);
            this.Controls.Add(this.label_MessageInput);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox textBox_SenderID;
        private System.Windows.Forms.TextBox textBox_ReceiveID;
        private System.Windows.Forms.Label label_Content;
        private System.Windows.Forms.TextBox textBox_ReceiverID;
        private System.Windows.Forms.DataGridView dataGridViewChat;
        private System.Windows.Forms.TextBox textBox_Content;
        private System.Windows.Forms.Label label_ChatTimestamp;
        private System.Windows.Forms.TextBox textBox_Timestamp;
    }
}