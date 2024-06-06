namespace ProyectoSegundoParcial
{
    partial class ComprarPrepagoForm
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
            this.comboBoxPlanes = new System.Windows.Forms.ComboBox();
            this.btnSeleccionarPlan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxPlanes
            // 
            this.comboBoxPlanes.FormattingEnabled = true;
            this.comboBoxPlanes.Items.AddRange(new object[] {
            "PLAN 10 GB 7 DÍAS $70",
            "PLAN 25 GB 15 DÍAS $120",
            "PLAN 40 GB 30 DÍAS $250"});
            this.comboBoxPlanes.Location = new System.Drawing.Point(50, 50);
            this.comboBoxPlanes.Name = "comboBoxPlanes";
            this.comboBoxPlanes.Size = new System.Drawing.Size(200, 21);
            this.comboBoxPlanes.TabIndex = 0;
            // 
            // btnSeleccionarPlan
            // 
            this.btnSeleccionarPlan.Location = new System.Drawing.Point(100, 100);
            this.btnSeleccionarPlan.Name = "btnSeleccionarPlan";
            this.btnSeleccionarPlan.Size = new System.Drawing.Size(100, 23);
            this.btnSeleccionarPlan.TabIndex = 1;
            this.btnSeleccionarPlan.Text = "Seleccionar Plan";
            this.btnSeleccionarPlan.UseVisualStyleBackColor = true;
            this.btnSeleccionarPlan.Click += new System.EventHandler(this.btnSeleccionarPlan_Click);
            // 
            // ComprarPrepagoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.btnSeleccionarPlan);
            this.Controls.Add(this.comboBoxPlanes);
            this.Name = "ComprarPrepagoForm";
            this.Text = "Comprar Prepago";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ComboBox comboBoxPlanes;
        private System.Windows.Forms.Button btnSeleccionarPlan;
    }
}
