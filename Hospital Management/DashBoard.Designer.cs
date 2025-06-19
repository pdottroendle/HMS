namespace Hospital_Management
{
    partial class DashBoard
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
            this.labelBedAvailable = new System.Windows.Forms.Label();
            this.labelBedOccupied = new System.Windows.Forms.Label();
            this.listViewEmergency = new System.Windows.Forms.ListView();
            this.label_DashboardStatus = new System.Windows.Forms.Label();
            this.statusStrip_DashboardStatus = new System.Windows.Forms.StatusStrip();
            this.SuspendLayout();
            // 
            // labelBedAvailable
            // 
            this.labelBedAvailable.AutoSize = true;
            this.labelBedAvailable.Location = new System.Drawing.Point(272, 155);
            this.labelBedAvailable.Name = "labelBedAvailable";
            this.labelBedAvailable.Size = new System.Drawing.Size(138, 25);
            this.labelBedAvailable.TabIndex = 0;
            this.labelBedAvailable.Text = "Bed Available:";
            // 
            // labelBedOccupied
            // 
            this.labelBedOccupied.AutoSize = true;
            this.labelBedOccupied.Location = new System.Drawing.Point(272, 222);
            this.labelBedOccupied.Name = "labelBedOccupied";
            this.labelBedOccupied.Size = new System.Drawing.Size(142, 25);
            this.labelBedOccupied.TabIndex = 0;
            this.labelBedOccupied.Text = "Bed Occupied:";
            // 
            // listViewEmergency
            // 
            this.listViewEmergency.HideSelection = false;
            this.listViewEmergency.Location = new System.Drawing.Point(277, 282);
            this.listViewEmergency.Name = "listViewEmergency";
            this.listViewEmergency.Size = new System.Drawing.Size(232, 97);
            this.listViewEmergency.TabIndex = 1;
            this.listViewEmergency.UseCompatibleStateImageBehavior = false;
            // 
            // label_DashboardStatus
            // 
            this.label_DashboardStatus.AutoSize = true;
            this.label_DashboardStatus.Location = new System.Drawing.Point(287, 423);
            this.label_DashboardStatus.Name = "label_DashboardStatus";
            this.label_DashboardStatus.Size = new System.Drawing.Size(74, 25);
            this.label_DashboardStatus.TabIndex = 2;
            this.label_DashboardStatus.Text = "Status:";
            // 
            // statusStrip_DashboardStatus
            // 
            this.statusStrip_DashboardStatus.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip_DashboardStatus.Location = new System.Drawing.Point(0, 572);
            this.statusStrip_DashboardStatus.Name = "statusStrip_DashboardStatus";
            this.statusStrip_DashboardStatus.Size = new System.Drawing.Size(1372, 22);
            this.statusStrip_DashboardStatus.TabIndex = 3;
            this.statusStrip_DashboardStatus.Text = "statusStrip1";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 594);
            this.Controls.Add(this.statusStrip_DashboardStatus);
            this.Controls.Add(this.label_DashboardStatus);
            this.Controls.Add(this.listViewEmergency);
            this.Controls.Add(this.labelBedOccupied);
            this.Controls.Add(this.labelBedAvailable);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBedAvailable;
        private System.Windows.Forms.Label labelBedOccupied;
        private System.Windows.Forms.ListView listViewEmergency;
        private System.Windows.Forms.Label label_DashboardStatus;
        private System.Windows.Forms.StatusStrip statusStrip_DashboardStatus;
    }
}