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
            this.button_InventorySearch = new System.Windows.Forms.Button();
            this.label_Low = new System.Windows.Forms.Label();
            this.timer_InventoryTimer = new System.Windows.Forms.Timer(this.components);
            this.label_InventoryItem = new System.Windows.Forms.Label();
            this.label_InventoryQuantity = new System.Windows.Forms.Label();
            this.label_ThresHold = new System.Windows.Forms.Label();
            this.textBox_InventoryItem = new System.Windows.Forms.TextBox();
            this.textBox_InventoryQuantity = new System.Windows.Forms.TextBox();
            this.textBox_InventoryThreshold = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(477, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(826, 382);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_InventoryAdd
            // 
            this.button_InventoryAdd.Location = new System.Drawing.Point(638, 477);
            this.button_InventoryAdd.Name = "button_InventoryAdd";
            this.button_InventoryAdd.Size = new System.Drawing.Size(159, 56);
            this.button_InventoryAdd.TabIndex = 1;
            this.button_InventoryAdd.Text = "Add Item";
            this.button_InventoryAdd.UseVisualStyleBackColor = true;
            // 
            // button_InventorySearch
            // 
            this.button_InventorySearch.Location = new System.Drawing.Point(1079, 482);
            this.button_InventorySearch.Name = "button_InventorySearch";
            this.button_InventorySearch.Size = new System.Drawing.Size(150, 47);
            this.button_InventorySearch.TabIndex = 1;
            this.button_InventorySearch.Text = "Search Item";
            this.button_InventorySearch.UseVisualStyleBackColor = true;
            // 
            // label_Low
            // 
            this.label_Low.AutoSize = true;
            this.label_Low.Location = new System.Drawing.Point(43, 360);
            this.label_Low.Name = "label_Low";
            this.label_Low.Size = new System.Drawing.Size(148, 25);
            this.label_Low.TabIndex = 2;
            this.label_Low.Text = "Low Stock Alert";
            // 
            // label_InventoryItem
            // 
            this.label_InventoryItem.AutoSize = true;
            this.label_InventoryItem.Location = new System.Drawing.Point(94, 94);
            this.label_InventoryItem.Name = "label_InventoryItem";
            this.label_InventoryItem.Size = new System.Drawing.Size(55, 25);
            this.label_InventoryItem.TabIndex = 3;
            this.label_InventoryItem.Text = "Item:";
            // 
            // label_InventoryQuantity
            // 
            this.label_InventoryQuantity.AutoSize = true;
            this.label_InventoryQuantity.Location = new System.Drawing.Point(85, 151);
            this.label_InventoryQuantity.Name = "label_InventoryQuantity";
            this.label_InventoryQuantity.Size = new System.Drawing.Size(91, 25);
            this.label_InventoryQuantity.TabIndex = 3;
            this.label_InventoryQuantity.Text = "Quantity:";
            // 
            // label_ThresHold
            // 
            this.label_ThresHold.AutoSize = true;
            this.label_ThresHold.Location = new System.Drawing.Point(72, 219);
            this.label_ThresHold.Name = "label_ThresHold";
            this.label_ThresHold.Size = new System.Drawing.Size(109, 25);
            this.label_ThresHold.TabIndex = 3;
            this.label_ThresHold.Text = "ThresHold:";
            // 
            // textBox_InventoryItem
            // 
            this.textBox_InventoryItem.Location = new System.Drawing.Point(294, 94);
            this.textBox_InventoryItem.Name = "textBox_InventoryItem";
            this.textBox_InventoryItem.Size = new System.Drawing.Size(100, 29);
            this.textBox_InventoryItem.TabIndex = 4;
            // 
            // textBox_InventoryQuantity
            // 
            this.textBox_InventoryQuantity.Location = new System.Drawing.Point(294, 151);
            this.textBox_InventoryQuantity.Name = "textBox_InventoryQuantity";
            this.textBox_InventoryQuantity.Size = new System.Drawing.Size(100, 29);
            this.textBox_InventoryQuantity.TabIndex = 4;
            // 
            // textBox_InventoryThreshold
            // 
            this.textBox_InventoryThreshold.Location = new System.Drawing.Point(294, 219);
            this.textBox_InventoryThreshold.Name = "textBox_InventoryThreshold";
            this.textBox_InventoryThreshold.Size = new System.Drawing.Size(100, 29);
            this.textBox_InventoryThreshold.TabIndex = 4;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 582);
            this.Controls.Add(this.textBox_InventoryThreshold);
            this.Controls.Add(this.textBox_InventoryQuantity);
            this.Controls.Add(this.textBox_InventoryItem);
            this.Controls.Add(this.label_ThresHold);
            this.Controls.Add(this.label_InventoryQuantity);
            this.Controls.Add(this.label_InventoryItem);
            this.Controls.Add(this.label_Low);
            this.Controls.Add(this.button_InventorySearch);
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
        private System.Windows.Forms.Button button_InventorySearch;
        private System.Windows.Forms.Label label_Low;
        private System.Windows.Forms.Timer timer_InventoryTimer;
        private System.Windows.Forms.Label label_InventoryItem;
        private System.Windows.Forms.Label label_InventoryQuantity;
        private System.Windows.Forms.Label label_ThresHold;
        private System.Windows.Forms.TextBox textBox_InventoryItem;
        private System.Windows.Forms.TextBox textBox_InventoryQuantity;
        private System.Windows.Forms.TextBox textBox_InventoryThreshold;
    }
}