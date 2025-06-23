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
            this.textBox_ItemID = new System.Windows.Forms.TextBox();
            this.textBox_InventoryQuantity = new System.Windows.Forms.TextBox();
            this.textBox_InventoryThreshold = new System.Windows.Forms.TextBox();
            this.label_InventoryName = new System.Windows.Forms.Label();
            this.textBox_InventoryName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_InventoryLastUpdate = new System.Windows.Forms.TextBox();
            this.label_LastUpdate = new System.Windows.Forms.Label();
            this.buttonSearchSQL = new System.Windows.Forms.Button();
            this.buttonAddSQL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(261, 6);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(693, 207);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_InventoryAdd
            // 
            this.button_InventoryAdd.Location = new System.Drawing.Point(40, 256);
            this.button_InventoryAdd.Margin = new System.Windows.Forms.Padding(2);
            this.button_InventoryAdd.Name = "button_InventoryAdd";
            this.button_InventoryAdd.Size = new System.Drawing.Size(82, 21);
            this.button_InventoryAdd.TabIndex = 1;
            this.button_InventoryAdd.Text = "Mogo Add Item";
            this.button_InventoryAdd.UseVisualStyleBackColor = true;
            this.button_InventoryAdd.Click += new System.EventHandler(this.button_InventoryAdd_Click);
            // 
            // button_InventorySearch
            // 
            this.button_InventorySearch.Location = new System.Drawing.Point(40, 214);
            this.button_InventorySearch.Margin = new System.Windows.Forms.Padding(2);
            this.button_InventorySearch.Name = "button_InventorySearch";
            this.button_InventorySearch.Size = new System.Drawing.Size(82, 25);
            this.button_InventorySearch.TabIndex = 1;
            this.button_InventorySearch.Text = "Mogo Search Item";
            this.button_InventorySearch.UseVisualStyleBackColor = true;
            this.button_InventorySearch.Click += new System.EventHandler(this.button_InventorySearch_Click);
            // 
            // label_Low
            // 
            this.label_Low.AutoSize = true;
            this.label_Low.Location = new System.Drawing.Point(469, 226);
            this.label_Low.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Low.Name = "label_Low";
            this.label_Low.Size = new System.Drawing.Size(82, 13);
            this.label_Low.TabIndex = 2;
            this.label_Low.Text = "Low Stock Alert";
            // 
            // label_InventoryItem
            // 
            this.label_InventoryItem.AutoSize = true;
            this.label_InventoryItem.Location = new System.Drawing.Point(55, 13);
            this.label_InventoryItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_InventoryItem.Name = "label_InventoryItem";
            this.label_InventoryItem.Size = new System.Drawing.Size(30, 13);
            this.label_InventoryItem.TabIndex = 3;
            this.label_InventoryItem.Text = "Item:";
            // 
            // label_InventoryQuantity
            // 
            this.label_InventoryQuantity.AutoSize = true;
            this.label_InventoryQuantity.Location = new System.Drawing.Point(46, 82);
            this.label_InventoryQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_InventoryQuantity.Name = "label_InventoryQuantity";
            this.label_InventoryQuantity.Size = new System.Drawing.Size(49, 13);
            this.label_InventoryQuantity.TabIndex = 3;
            this.label_InventoryQuantity.Text = "Quantity:";
            // 
            // label_ThresHold
            // 
            this.label_ThresHold.AutoSize = true;
            this.label_ThresHold.Location = new System.Drawing.Point(39, 119);
            this.label_ThresHold.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ThresHold.Name = "label_ThresHold";
            this.label_ThresHold.Size = new System.Drawing.Size(59, 13);
            this.label_ThresHold.TabIndex = 3;
            this.label_ThresHold.Text = "ThresHold:";
            // 
            // textBox_ItemID
            // 
            this.textBox_ItemID.Location = new System.Drawing.Point(160, 13);
            this.textBox_ItemID.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_ItemID.Name = "textBox_ItemID";
            this.textBox_ItemID.Size = new System.Drawing.Size(56, 20);
            this.textBox_ItemID.TabIndex = 4;
            // 
            // textBox_InventoryQuantity
            // 
            this.textBox_InventoryQuantity.Location = new System.Drawing.Point(160, 82);
            this.textBox_InventoryQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_InventoryQuantity.Name = "textBox_InventoryQuantity";
            this.textBox_InventoryQuantity.Size = new System.Drawing.Size(56, 20);
            this.textBox_InventoryQuantity.TabIndex = 4;
            // 
            // textBox_InventoryThreshold
            // 
            this.textBox_InventoryThreshold.Location = new System.Drawing.Point(160, 116);
            this.textBox_InventoryThreshold.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_InventoryThreshold.Name = "textBox_InventoryThreshold";
            this.textBox_InventoryThreshold.Size = new System.Drawing.Size(56, 20);
            this.textBox_InventoryThreshold.TabIndex = 4;
            // 
            // label_InventoryName
            // 
            this.label_InventoryName.AutoSize = true;
            this.label_InventoryName.Location = new System.Drawing.Point(55, 44);
            this.label_InventoryName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_InventoryName.Name = "label_InventoryName";
            this.label_InventoryName.Size = new System.Drawing.Size(38, 13);
            this.label_InventoryName.TabIndex = 3;
            this.label_InventoryName.Text = "Name:";
            // 
            // textBox_InventoryName
            // 
            this.textBox_InventoryName.Location = new System.Drawing.Point(160, 44);
            this.textBox_InventoryName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_InventoryName.Name = "textBox_InventoryName";
            this.textBox_InventoryName.Size = new System.Drawing.Size(56, 20);
            this.textBox_InventoryName.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 151);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(56, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ThresHold:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 151);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(56, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ThresHold:";
            // 
            // textBox_InventoryLastUpdate
            // 
            this.textBox_InventoryLastUpdate.Location = new System.Drawing.Point(160, 151);
            this.textBox_InventoryLastUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_InventoryLastUpdate.Name = "textBox_InventoryLastUpdate";
            this.textBox_InventoryLastUpdate.Size = new System.Drawing.Size(56, 20);
            this.textBox_InventoryLastUpdate.TabIndex = 4;
            this.textBox_InventoryLastUpdate.TextChanged += new System.EventHandler(this.textBox_InventoryLastUpdate_TextChanged);
            // 
            // label_LastUpdate
            // 
            this.label_LastUpdate.AutoSize = true;
            this.label_LastUpdate.Location = new System.Drawing.Point(37, 153);
            this.label_LastUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_LastUpdate.Name = "label_LastUpdate";
            this.label_LastUpdate.Size = new System.Drawing.Size(65, 13);
            this.label_LastUpdate.TabIndex = 3;
            this.label_LastUpdate.Text = "LastUpdate:";
            // 
            // buttonSearchSQL
            // 
            this.buttonSearchSQL.Location = new System.Drawing.Point(145, 214);
            this.buttonSearchSQL.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearchSQL.Name = "buttonSearchSQL";
            this.buttonSearchSQL.Size = new System.Drawing.Size(82, 25);
            this.buttonSearchSQL.TabIndex = 7;
            this.buttonSearchSQL.Text = "SQL Search Item";
            this.buttonSearchSQL.UseVisualStyleBackColor = true;
            this.buttonSearchSQL.Click += new System.EventHandler(this.buttonSearchSQL_Click);
            // 
            // buttonAddSQL
            // 
            this.buttonAddSQL.Location = new System.Drawing.Point(145, 256);
            this.buttonAddSQL.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddSQL.Name = "buttonAddSQL";
            this.buttonAddSQL.Size = new System.Drawing.Size(82, 21);
            this.buttonAddSQL.TabIndex = 8;
            this.buttonAddSQL.Text = "SQL Add Item";
            this.buttonAddSQL.UseVisualStyleBackColor = true;
            this.buttonAddSQL.Click += new System.EventHandler(this.buttonAddSQL_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 315);
            this.Controls.Add(this.buttonSearchSQL);
            this.Controls.Add(this.buttonAddSQL);
            this.Controls.Add(this.textBox_InventoryLastUpdate);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox_InventoryThreshold);
            this.Controls.Add(this.textBox_InventoryQuantity);
            this.Controls.Add(this.textBox_InventoryName);
            this.Controls.Add(this.label_LastUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_ItemID);
            this.Controls.Add(this.label_ThresHold);
            this.Controls.Add(this.label_InventoryQuantity);
            this.Controls.Add(this.label_InventoryName);
            this.Controls.Add(this.label_InventoryItem);
            this.Controls.Add(this.label_Low);
            this.Controls.Add(this.button_InventorySearch);
            this.Controls.Add(this.button_InventoryAdd);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox textBox_ItemID;
        private System.Windows.Forms.TextBox textBox_InventoryQuantity;
        private System.Windows.Forms.TextBox textBox_InventoryThreshold;
        private System.Windows.Forms.Label label_InventoryName;
        private System.Windows.Forms.TextBox textBox_InventoryName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_InventoryLastUpdate;
        private System.Windows.Forms.Label label_LastUpdate;
        private System.Windows.Forms.Button buttonSearchSQL;
        private System.Windows.Forms.Button buttonAddSQL;
    }
}