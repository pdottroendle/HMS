namespace Hospital_Management
{
    partial class User
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.textBox_UserID = new System.Windows.Forms.TextBox();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_Role = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.label_UserID = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_Role = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Phone = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_UserID
            // 
            this.textBox_UserID.Location = new System.Drawing.Point(320, 50);
            this.textBox_UserID.Name = "textBox_UserID";
            this.textBox_UserID.Size = new System.Drawing.Size(200, 29);
            this.textBox_UserID.TabIndex = 0;
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(320, 90);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(200, 29);
            this.textBox_Username.TabIndex = 1;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(320, 130);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(200, 29);
            this.textBox_Password.TabIndex = 2;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // textBox_Role
            // 
            this.textBox_Role.Location = new System.Drawing.Point(320, 170);
            this.textBox_Role.Name = "textBox_Role";
            this.textBox_Role.Size = new System.Drawing.Size(200, 29);
            this.textBox_Role.TabIndex = 3;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(320, 210);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(200, 29);
            this.textBox_Email.TabIndex = 4;
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(320, 250);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(200, 29);
            this.textBox_Phone.TabIndex = 5;
            // 
            // label_UserID
            // 
            this.label_UserID.AutoSize = true;
            this.label_UserID.Location = new System.Drawing.Point(220, 53);
            this.label_UserID.Name = "label_UserID";
            this.label_UserID.Size = new System.Drawing.Size(78, 25);
            this.label_UserID.TabIndex = 6;
            this.label_UserID.Text = "UserID:";
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Location = new System.Drawing.Point(220, 93);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(108, 25);
            this.label_Username.TabIndex = 7;
            this.label_Username.Text = "Username:";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(220, 133);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(104, 25);
            this.label_Password.TabIndex = 8;
            this.label_Password.Text = "Password:";
            // 
            // label_Role
            // 
            this.label_Role.AutoSize = true;
            this.label_Role.Location = new System.Drawing.Point(220, 173);
            this.label_Role.Name = "label_Role";
            this.label_Role.Size = new System.Drawing.Size(57, 25);
            this.label_Role.TabIndex = 9;
            this.label_Role.Text = "Role:";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(220, 213);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(66, 25);
            this.label_Email.TabIndex = 10;
            this.label_Email.Text = "Email:";
            // 
            // label_Phone
            // 
            this.label_Phone.AutoSize = true;
            this.label_Phone.Location = new System.Drawing.Point(220, 253);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(75, 25);
            this.label_Phone.TabIndex = 11;
            this.label_Phone.Text = "Phone:";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(550, 90);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(130, 40);
            this.button_Add.TabIndex = 12;
            this.button_Add.Text = "Add User";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(550, 150);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(130, 40);
            this.button_Search.TabIndex = 13;
            this.button_Search.Text = "Search User";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.Location = new System.Drawing.Point(207, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(750, 300);
            this.dataGridView1.TabIndex = 14;
            // 
            // User
            // 
            this.ClientSize = new System.Drawing.Size(1460, 630);
            this.Controls.Add(this.textBox_UserID);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Role);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_Phone);
            this.Controls.Add(this.label_UserID);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Role);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_Phone);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.dataGridView1);
            this.Name = "User";
            this.Text = "User Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_UserID;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_Role;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_Phone;

        private System.Windows.Forms.Label label_UserID;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_Role;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_Phone;

        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Search;

        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
