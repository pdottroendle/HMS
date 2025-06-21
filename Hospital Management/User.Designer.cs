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
            this.label_Username = new System.Windows.Forms.Label();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.labelUserRole = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonUserAdd = new System.Windows.Forms.Button();
            this.buttonUserSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Location = new System.Drawing.Point(133, 148);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(108, 25);
            this.label_Username.TabIndex = 0;
            this.label_Username.Text = "Username:";
            // 
            // labelUserPassword
            // 
            this.labelUserPassword.AutoSize = true;
            this.labelUserPassword.Location = new System.Drawing.Point(133, 222);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(150, 25);
            this.labelUserPassword.TabIndex = 0;
            this.labelUserPassword.Text = "PasswordHash:";
            // 
            // labelUserRole
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
            this.dataGridView1.Location = new System.Drawing.Point(562, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(824, 395);
            this.dataGridView1.TabIndex = 1;
            // 
            // buttonUserAdd
            // 
            this.buttonUserAdd.Location = new System.Drawing.Point(788, 490);
            this.buttonUserAdd.Name = "buttonUserAdd";
            this.buttonUserAdd.Size = new System.Drawing.Size(144, 52);
            this.buttonUserAdd.TabIndex = 2;
            this.buttonUserAdd.Text = "Add";
            this.buttonUserAdd.UseVisualStyleBackColor = true;
            // 
            // buttonUserSearch
            // 
            this.buttonUserSearch.Location = new System.Drawing.Point(1014, 490);
            this.buttonUserSearch.Name = "buttonUserSearch";
            this.buttonUserSearch.Size = new System.Drawing.Size(144, 52);
            this.buttonUserSearch.TabIndex = 2;
            this.buttonUserSearch.Text = "Search";
            this.buttonUserSearch.UseVisualStyleBackColor = true;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
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

        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Label labelUserPassword;
        private System.Windows.Forms.Label labelUserRole;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonUserAdd;
        private System.Windows.Forms.Button buttonUserSearch;
    }
}