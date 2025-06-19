namespace Hospital_Management
{
    partial class Inventory
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_InventoryAdd = new System.Windows.Forms.Button();
            this.button_InventoryEdit = new System.Windows.Forms.Button();
            this.button_InventoryDelete = new System.Windows.Forms.Button();
            this.label_Low = new System.Windows.Forms.Label();
            this.timer_InventoryTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(294, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(826, 382);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_InventoryAdd
            // 
            this.button_InventoryAdd.Location = new System.Drawing.Point(321, 473);
            this.button_InventoryAdd.Name = "button_InventoryAdd";
            this.button_InventoryAdd.Size = new System.Drawing.Size(159, 56);
            this.button_InventoryAdd.TabIndex = 1;
            this.button_InventoryAdd.Text = "Add Item";
            this.button_InventoryAdd.UseVisualStyleBackColor = true;
            // 
            // button_InventoryEdit
            // 
            this.button_InventoryEdit.Location = new System.Drawing.Point(614, 478);
            this.button_InventoryEdit.Name = "button_InventoryEdit";
            this.button_InventoryEdit.Size = new System.Drawing.Size(146, 47);
            this.button_InventoryEdit.TabIndex = 1;
            this.button_InventoryEdit.Text = "Edit Item";
            this.button_InventoryEdit.UseVisualStyleBackColor = true;
            // 
            // button_InventoryDelete
            // 
            this.button_InventoryDelete.Location = new System.Drawing.Point(870, 478);
            this.button_InventoryDelete.Name = "button_InventoryDelete";
            this.button_InventoryDelete.Size = new System.Drawing.Size(150, 47);
            this.button_InventoryDelete.TabIndex = 1;
            this.button_InventoryDelete.Text = "Delete Item";
            this.button_InventoryDelete.UseVisualStyleBackColor = true;
            // 
            // label_Low
            // 
            this.label_Low.AutoSize = true;
            this.label_Low.Location = new System.Drawing.Point(68, 261);
            this.label_Low.Name = "label_Low";
            this.label_Low.Size = new System.Drawing.Size(148, 25);
            this.label_Low.TabIndex = 2;
            this.label_Low.Text = "Low Stock Alert";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 582);
            this.Controls.Add(this.label_Low);
            this.Controls.Add(this.button_InventoryDelete);
            this.Controls.Add(this.button_InventoryEdit);
            this.Controls.Add(this.button_InventoryAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Inventory";
            this.Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_InventoryAdd;
        private System.Windows.Forms.Button button_InventoryEdit;
        private System.Windows.Forms.Button button_InventoryDelete;
        private System.Windows.Forms.Label label_Low;
        private System.Windows.Forms.Timer timer_InventoryTimer;
    }
}