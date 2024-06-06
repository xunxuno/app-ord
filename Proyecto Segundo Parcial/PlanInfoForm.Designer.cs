namespace ProyectoSegundoParcial
{
    partial class PlanInfoForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblPlanName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.lblTotalDays = new System.Windows.Forms.Label();
            this.lblRemainingDays = new System.Windows.Forms.Label();
            this.lblTotalGb = new System.Windows.Forms.Label();
            this.lblUsedGb = new System.Windows.Forms.Label();
            this.lblUsedGbSocial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPlanName
            // 
            this.lblPlanName.AutoSize = true;
            this.lblPlanName.Location = new System.Drawing.Point(50, 50);
            this.lblPlanName.Name = "lblPlanName";
            this.lblPlanName.Size = new System.Drawing.Size(67, 13);
            this.lblPlanName.TabIndex = 0;
            this.lblPlanName.Text = "Plan Name: ";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(50, 100);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.lblPhoneNumber.TabIndex = 1;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Location = new System.Drawing.Point(50, 150);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(68, 13);
            this.lblExpiryDate.TabIndex = 2;
            this.lblExpiryDate.Text = "Expiry Date:";
            // 
            // lblTotalDays
            // 
            this.lblTotalDays.AutoSize = true;
            this.lblTotalDays.Location = new System.Drawing.Point(50, 200);
            this.lblTotalDays.Name = "lblTotalDays";
            this.lblTotalDays.Size = new System.Drawing.Size(64, 13);
            this.lblTotalDays.TabIndex = 3;
            this.lblTotalDays.Text = "Total Days:";
            // 
            // lblRemainingDays
            // 
            this.lblRemainingDays.AutoSize = true;
            this.lblRemainingDays.Location = new System.Drawing.Point(50, 250);
            this.lblRemainingDays.Name = "lblRemainingDays";
            this.lblRemainingDays.Size = new System.Drawing.Size(90, 13);
            this.lblRemainingDays.TabIndex = 4;
            this.lblRemainingDays.Text = "Remaining Days:";
            // 
            // lblTotalGb
            // 
            this.lblTotalGb.AutoSize = true;
            this.lblTotalGb.Location = new System.Drawing.Point(50, 300);
            this.lblTotalGb.Name = "lblTotalGb";
            this.lblTotalGb.Size = new System.Drawing.Size(55, 13);
            this.lblTotalGb.TabIndex = 5;
            this.lblTotalGb.Text = "Total GB:";
            // 
            // lblUsedGb
            // 
            this.lblUsedGb.AutoSize = true;
            this.lblUsedGb.Location = new System.Drawing.Point(50, 350);
            this.lblUsedGb.Name = "lblUsedGb";
            this.lblUsedGb.Size = new System.Drawing.Size(56, 13);
            this.lblUsedGb.TabIndex = 6;
            this.lblUsedGb.Text = "Used GB:";
            // 
            // lblUsedGbSocial
            // 
            this.lblUsedGbSocial.AutoSize = true;
            this.lblUsedGbSocial.Location = new System.Drawing.Point(50, 400);
            this.lblUsedGbSocial.Name = "lblUsedGbSocial";
            this.lblUsedGbSocial.Size = new System.Drawing.Size(90, 13);
            this.lblUsedGbSocial.TabIndex = 7;
            this.lblUsedGbSocial.Text = "Used GB Social:";
            // 
            // PlanInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUsedGbSocial);
            this.Controls.Add(this.lblUsedGb);
            this.Controls.Add(this.lblTotalGb);
            this.Controls.Add(this.lblRemainingDays);
            this.Controls.Add(this.lblTotalDays);
            this.Controls.Add(this.lblExpiryDate);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblPlanName);
            this.Name = "PlanInfoForm";
            this.Text = "Información del Plan";
            this.Load += new System.EventHandler(this.PlanInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblPlanName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.Label lblTotalDays;
        private System.Windows.Forms.Label lblRemainingDays;
        private System.Windows.Forms.Label lblTotalGb;
        private System.Windows.Forms.Label lblUsedGb;
        private System.Windows.Forms.Label lblUsedGbSocial;
    }
}
