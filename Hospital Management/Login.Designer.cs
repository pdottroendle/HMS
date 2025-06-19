namespace Hospital_Management
{
    partial class Login
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
            this.button_login = new System.Windows.Forms.Button();
            this.label_loginUserName = new System.Windows.Forms.Label();
            this.label_loginPassword = new System.Windows.Forms.Label();
            this.textBox_loginUserName = new System.Windows.Forms.TextBox();
            this.textBox_loginPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(502, 290);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(131, 44);
            this.button_login.TabIndex = 0;
            this.button_login.Text = "login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // label_loginUserName
            // 
            this.label_loginUserName.AutoSize = true;
            this.label_loginUserName.Location = new System.Drawing.Point(467, 141);
            this.label_loginUserName.Name = "label_loginUserName";
            this.label_loginUserName.Size = new System.Drawing.Size(105, 25);
            this.label_loginUserName.TabIndex = 1;
            this.label_loginUserName.Text = "username:";
            // 
            // label_loginPassword
            // 
            this.label_loginPassword.AutoSize = true;
            this.label_loginPassword.Location = new System.Drawing.Point(467, 197);
            this.label_loginPassword.Name = "label_loginPassword";
            this.label_loginPassword.Size = new System.Drawing.Size(102, 25);
            this.label_loginPassword.TabIndex = 2;
            this.label_loginPassword.Text = "password:";
            // 
            // textBox_loginUserName
            // 
            this.textBox_loginUserName.Location = new System.Drawing.Point(630, 141);
            this.textBox_loginUserName.Name = "textBox_loginUserName";
            this.textBox_loginUserName.Size = new System.Drawing.Size(100, 29);
            this.textBox_loginUserName.TabIndex = 3;
            // 
            // textBox_loginPassword
            // 
            this.textBox_loginPassword.Location = new System.Drawing.Point(630, 197);
            this.textBox_loginPassword.Name = "textBox_loginPassword";
            this.textBox_loginPassword.Size = new System.Drawing.Size(107, 29);
            this.textBox_loginPassword.TabIndex = 4;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 554);
            this.Controls.Add(this.textBox_loginPassword);
            this.Controls.Add(this.textBox_loginUserName);
            this.Controls.Add(this.label_loginPassword);
            this.Controls.Add(this.label_loginUserName);
            this.Controls.Add(this.button_login);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Label label_loginUserName;
        private System.Windows.Forms.Label label_loginPassword;
        private System.Windows.Forms.TextBox textBox_loginUserName;
        private System.Windows.Forms.TextBox textBox_loginPassword;
    }
}