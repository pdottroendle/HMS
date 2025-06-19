namespace Hospital_Management
{
    partial class Register
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
            this.label_registerUsername = new System.Windows.Forms.Label();
            this.label_registerPassword = new System.Windows.Forms.Label();
            this.label_role = new System.Windows.Forms.Label();
            this.button_register = new System.Windows.Forms.Button();
            this.textBox_registerUsername = new System.Windows.Forms.TextBox();
            this.textBox_registerPassword = new System.Windows.Forms.TextBox();
            this.textBox_role = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_registerUsername
            // 
            this.label_registerUsername.AutoSize = true;
            this.label_registerUsername.Location = new System.Drawing.Point(440, 93);
            this.label_registerUsername.Name = "label_registerUsername";
            this.label_registerUsername.Size = new System.Drawing.Size(105, 25);
            this.label_registerUsername.TabIndex = 0;
            this.label_registerUsername.Text = "username:";
            // 
            // label_registerPassword
            // 
            this.label_registerPassword.AutoSize = true;
            this.label_registerPassword.Location = new System.Drawing.Point(440, 152);
            this.label_registerPassword.Name = "label_registerPassword";
            this.label_registerPassword.Size = new System.Drawing.Size(102, 25);
            this.label_registerPassword.TabIndex = 1;
            this.label_registerPassword.Text = "password:";
            // 
            // label_role
            // 
            this.label_role.AutoSize = true;
            this.label_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label_role.Location = new System.Drawing.Point(449, 213);
            this.label_role.Name = "label_role";
            this.label_role.Size = new System.Drawing.Size(54, 25);
            this.label_role.TabIndex = 2;
            this.label_role.Text = "role:";
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(500, 305);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(123, 56);
            this.button_register.TabIndex = 3;
            this.button_register.Text = "Register";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // textBox_registerUsername
            // 
            this.textBox_registerUsername.Location = new System.Drawing.Point(583, 93);
            this.textBox_registerUsername.Name = "textBox_registerUsername";
            this.textBox_registerUsername.Size = new System.Drawing.Size(188, 29);
            this.textBox_registerUsername.TabIndex = 4;
            // 
            // textBox_registerPassword
            // 
            this.textBox_registerPassword.Location = new System.Drawing.Point(583, 152);
            this.textBox_registerPassword.Name = "textBox_registerPassword";
            this.textBox_registerPassword.Size = new System.Drawing.Size(188, 29);
            this.textBox_registerPassword.TabIndex = 5;
            // 
            // textBox_role
            // 
            this.textBox_role.Location = new System.Drawing.Point(583, 209);
            this.textBox_role.Name = "textBox_role";
            this.textBox_role.Size = new System.Drawing.Size(188, 29);
            this.textBox_role.TabIndex = 6;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 559);
            this.Controls.Add(this.textBox_role);
            this.Controls.Add(this.textBox_registerPassword);
            this.Controls.Add(this.textBox_registerUsername);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.label_role);
            this.Controls.Add(this.label_registerPassword);
            this.Controls.Add(this.label_registerUsername);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_registerUsername;
        private System.Windows.Forms.Label label_registerPassword;
        private System.Windows.Forms.Label label_role;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.TextBox textBox_registerUsername;
        private System.Windows.Forms.TextBox textBox_registerPassword;
        private System.Windows.Forms.TextBox textBox_role;
    }
}