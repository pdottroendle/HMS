namespace Hospital_Management
{
    partial class User
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
            this.components = new System.ComponentModel.Container();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox_Role = new System.Windows.Forms.TextBox();
            this.textBox_PasswordHash = new System.Windows.Forms.TextBox();
            this.label_LastUpdate = new System.Windows.Forms.Label();
            this.textBox_UserID = new System.Windows.Forms.TextBox();
            this.label_ThresHold = new System.Windows.Forms.Label();
            this.label_InventoryQuantity = new System.Windows.Forms.Label();
            this.timer_InventoryTimer = new System.Windows.Forms.Timer(this.components);
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.label_InventoryName = new System.Windows.Forms.Label();
            this.label_UserID = new System.Windows.Forms.Label();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonUserAdd = new System.Windows.Forms.Button();
            this.buttonUserSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Email
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Location = new System.Drawing.Point(133, 148);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(108, 25);
            this.label_Username.TabIndex = 0;
            this.label_Username.Text = "Username:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(173, 227);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(56, 20);
            this.textBox2.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 227);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(56, 20);
            this.textBox1.TabIndex = 21;
            // 
            // textBox_Role
            // 
            this.textBox_Role.Location = new System.Drawing.Point(173, 192);
            this.textBox_Role.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Role.Name = "textBox_Role";
            this.textBox_Role.Size = new System.Drawing.Size(56, 20);
            this.textBox_Role.TabIndex = 20;
            // 
            // textBox_PasswordHash
            // 
            this.textBox_PasswordHash.Location = new System.Drawing.Point(173, 158);
            this.textBox_PasswordHash.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_PasswordHash.Name = "textBox_PasswordHash";
            this.textBox_PasswordHash.Size = new System.Drawing.Size(56, 20);
            this.textBox_PasswordHash.TabIndex = 19;
            // 
            // label_LastUpdate
            // 
            this.label_LastUpdate.AutoSize = true;
            this.label_LastUpdate.Location = new System.Drawing.Point(100, 230);
            this.label_LastUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_LastUpdate.Name = "label_LastUpdate";
            this.label_LastUpdate.Size = new System.Drawing.Size(35, 13);
            this.label_LastUpdate.TabIndex = 15;
            this.label_LastUpdate.Text = "Email:";
            // 
            // textBox_UserID
            // 
            this.textBox_UserID.Location = new System.Drawing.Point(173, 89);
            this.textBox_UserID.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_UserID.Name = "textBox_UserID";
            this.textBox_UserID.Size = new System.Drawing.Size(56, 20);
            this.textBox_UserID.TabIndex = 17;
            // 
            // label_ThresHold
            // 
            this.label_ThresHold.AutoSize = true;
            this.label_ThresHold.Location = new System.Drawing.Point(103, 195);
            this.label_ThresHold.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ThresHold.Name = "label_ThresHold";
            this.label_ThresHold.Size = new System.Drawing.Size(32, 13);
            this.label_ThresHold.TabIndex = 16;
            this.label_ThresHold.Text = "Role:";
            // 
            // label_InventoryQuantity
            // 
            this.label_InventoryQuantity.AutoSize = true;
            this.label_InventoryQuantity.Location = new System.Drawing.Point(59, 158);
            this.label_InventoryQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_InventoryQuantity.Name = "label_InventoryQuantity";
            this.label_InventoryQuantity.Size = new System.Drawing.Size(81, 13);
            this.label_InventoryQuantity.TabIndex = 14;
            this.label_InventoryQuantity.Text = "PasswordHash:";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(173, 120);
            this.textBox_Username.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(56, 20);
            this.textBox_Username.TabIndex = 18;
            // 
            // label_InventoryName
            // 
            this.label_InventoryName.AutoSize = true;
            this.label_InventoryName.Location = new System.Drawing.Point(82, 120);
            this.label_InventoryName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_InventoryName.Name = "label_InventoryName";
            this.label_InventoryName.Size = new System.Drawing.Size(58, 13);
            this.label_InventoryName.TabIndex = 11;
            this.label_InventoryName.Text = "Username:";
            // 
            // label_UserID
            // 
            this.label_UserID.AutoSize = true;
            this.label_UserID.Location = new System.Drawing.Point(97, 92);
            this.label_UserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_UserID.Name = "label_UserID";
            this.label_UserID.Size = new System.Drawing.Size(43, 13);
            this.label_UserID.TabIndex = 10;
            this.label_UserID.Text = "UserID:";
            // 
            // button_Search
            // 
            this.labelUserPassword.AutoSize = true;
            this.labelUserPassword.Location = new System.Drawing.Point(133, 222);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(150, 25);
            this.labelUserPassword.TabIndex = 0;
            this.labelUserPassword.Text = "PasswordHash:";
            // 
            // button_Add
            // 
            this.labelUserRole.AutoSize = true;
            this.labelUserRole.Location = new System.Drawing.Point(133, 292);
            this.labelUserRole.Name = "labelUserRole";
            this.labelUserRole.Size = new System.Drawing.Size(57, 25);
            this.labelUserRole.TabIndex = 0;
            this.labelUserRole.Text = "Role:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(382, 84);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(693, 302);
            this.dataGridView1.TabIndex = 6;
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(173, 261);
            this.textBox_Phone.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(56, 20);
            this.textBox_Phone.TabIndex = 28;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(173, 261);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(56, 20);
            this.textBox4.TabIndex = 27;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(173, 261);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(56, 20);
            this.textBox5.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 264);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Phone:";
            // 
            // label_UserEmail
            // 
            this.label_UserEmail.AutoSize = true;
            this.label_UserEmail.Location = new System.Drawing.Point(87, 371);
            this.label_UserEmail.Name = "label_UserEmail";
            this.label_UserEmail.Size = new System.Drawing.Size(66, 25);
            this.label_UserEmail.TabIndex = 0;
            this.label_UserEmail.Text = "Email:";
            // 
            // label_UserPhone
            // 
            this.label_UserPhone.AutoSize = true;
            this.label_UserPhone.Location = new System.Drawing.Point(78, 448);
            this.label_UserPhone.Name = "label_UserPhone";
            this.label_UserPhone.Size = new System.Drawing.Size(75, 25);
            this.label_UserPhone.TabIndex = 0;
            this.label_UserPhone.Text = "Phone:";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(341, 120);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(100, 29);
            this.textBox_UserName.TabIndex = 3;
            // 
            // textBox_PasswordHash
            // 
            this.textBox_PasswordHash.Location = new System.Drawing.Point(341, 202);
            this.textBox_PasswordHash.Name = "textBox_PasswordHash";
            this.textBox_PasswordHash.Size = new System.Drawing.Size(100, 29);
            this.textBox_PasswordHash.TabIndex = 3;
            // 
            // textBox_UserRole
            // 
            this.textBox_UserRole.Location = new System.Drawing.Point(341, 292);
            this.textBox_UserRole.Name = "textBox_UserRole";
            this.textBox_UserRole.Size = new System.Drawing.Size(100, 29);
            this.textBox_UserRole.TabIndex = 3;
            // 
            // textBox_UserEmail
            // 
            this.textBox_UserEmail.Location = new System.Drawing.Point(341, 367);
            this.textBox_UserEmail.Name = "textBox_UserEmail";
            this.textBox_UserEmail.Size = new System.Drawing.Size(100, 29);
            this.textBox_UserEmail.TabIndex = 3;
            // 
            // textBox_UserPhone
            // 
            this.textBox_UserPhone.Location = new System.Drawing.Point(341, 444);
            this.textBox_UserPhone.Name = "textBox_UserPhone";
            this.textBox_UserPhone.Size = new System.Drawing.Size(100, 29);
            this.textBox_UserPhone.TabIndex = 3;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 566);
            this.Controls.Add(this.buttonUserSearch);
            this.Controls.Add(this.buttonUserAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelUserRole);
            this.Controls.Add(this.labelUserPassword);
            this.Controls.Add(this.label_Username);
            this.Name = "User";
            this.Text = "User";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox_Role;
        private System.Windows.Forms.TextBox textBox_PasswordHash;
        private System.Windows.Forms.Label label_LastUpdate;
        private System.Windows.Forms.TextBox textBox_UserID;
        private System.Windows.Forms.Label label_ThresHold;
        private System.Windows.Forms.Label label_InventoryQuantity;
        private System.Windows.Forms.Timer timer_InventoryTimer;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.Label label_InventoryName;
        private System.Windows.Forms.Label label_UserID;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonUserAdd;
        private System.Windows.Forms.Button buttonUserSearch;
    }
}