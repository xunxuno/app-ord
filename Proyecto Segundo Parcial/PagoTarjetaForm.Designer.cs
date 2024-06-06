namespace ProyectoSegundoParcial
{
    partial class PagoTarjetaForm
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
            this.txtNombreTitular = new System.Windows.Forms.TextBox();
            this.txtNumeroTarjeta = new System.Windows.Forms.TextBox();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.txtFechaExpiracion = new System.Windows.Forms.TextBox();
            this.lblNombreTitular = new System.Windows.Forms.Label();
            this.lblNumeroTarjeta = new System.Windows.Forms.Label();
            this.lblCVV = new System.Windows.Forms.Label();
            this.lblFechaExpiracion = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreTitular
            // 
            this.txtNombreTitular.Location = new System.Drawing.Point(150, 50);
            this.txtNombreTitular.MaxLength = 40;
            this.txtNombreTitular.Name = "txtNombreTitular";
            this.txtNombreTitular.Size = new System.Drawing.Size(200, 20);
            this.txtNombreTitular.TabIndex = 0;
            // 
            // txtNumeroTarjeta
            // 
            this.txtNumeroTarjeta.Location = new System.Drawing.Point(150, 100);
            this.txtNumeroTarjeta.MaxLength = 16;
            this.txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            this.txtNumeroTarjeta.Size = new System.Drawing.Size(200, 20);
            this.txtNumeroTarjeta.TabIndex = 1;
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(150, 150);
            this.txtCVV.MaxLength = 3;
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(50, 20);
            this.txtCVV.TabIndex = 2;
            // 
            // txtFechaExpiracion
            // 
            this.txtFechaExpiracion.Location = new System.Drawing.Point(150, 200);
            this.txtFechaExpiracion.Name = "txtFechaExpiracion";
            this.txtFechaExpiracion.Size = new System.Drawing.Size(100, 20);
            this.txtFechaExpiracion.TabIndex = 3;
            // 
            // lblNombreTitular
            // 
            this.lblNombreTitular.AutoSize = true;
            this.lblNombreTitular.Location = new System.Drawing.Point(50, 50);
            this.lblNombreTitular.Name = "lblNombreTitular";
            this.lblNombreTitular.Size = new System.Drawing.Size(94, 13);
            this.lblNombreTitular.TabIndex = 4;
            this.lblNombreTitular.Text = "Nombre del Titular:";
            // 
            // lblNumeroTarjeta
            // 
            this.lblNumeroTarjeta.AutoSize = true;
            this.lblNumeroTarjeta.Location = new System.Drawing.Point(50, 100);
            this.lblNumeroTarjeta.Name = "lblNumeroTarjeta";
            this.lblNumeroTarjeta.Size = new System.Drawing.Size(90, 13);
            this.lblNumeroTarjeta.TabIndex = 5;
            this.lblNumeroTarjeta.Text = "Número de Tarjeta:";
            // 
            // lblCVV
            // 
            this.lblCVV.AutoSize = true;
            this.lblCVV.Location = new System.Drawing.Point(50, 150);
            this.lblCVV.Name = "lblCVV";
            this.lblCVV.Size = new System.Drawing.Size(30, 13);
            this.lblCVV.TabIndex = 6;
            this.lblCVV.Text = "CVV:";
            // 
            // lblFechaExpiracion
            // 
            this.lblFechaExpiracion.AutoSize = true;
            this.lblFechaExpiracion.Location = new System.Drawing.Point(50, 200);
            this.lblFechaExpiracion.Name = "lblFechaExpiracion";
            this.lblFechaExpiracion.Size = new System.Drawing.Size(94, 13);
            this.lblFechaExpiracion.TabIndex = 7;
            this.lblFechaExpiracion.Text = "Fecha de Expiración:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(150, 250);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 23);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // PagoTarjetaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblFechaExpiracion);
            this.Controls.Add(this.lblCVV);
            this.Controls.Add(this.lblNumeroTarjeta);
            this.Controls.Add(this.lblNombreTitular);
            this.Controls.Add(this.txtFechaExpiracion);
            this.Controls.Add(this.txtCVV);
            this.Controls.Add(this.txtNumeroTarjeta);
            this.Controls.Add(this.txtNombreTitular);
            this.Name = "PagoTarjetaForm";
            this.Text = "Pago con Tarjeta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtNombreTitular;
        private System.Windows.Forms.TextBox txtNumeroTarjeta;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.TextBox txtFechaExpiracion;
        private System.Windows.Forms.Label lblNombreTitular;
        private System.Windows.Forms.Label lblNumeroTarjeta;
        private System.Windows.Forms.Label lblCVV;
        private System.Windows.Forms.Label lblFechaExpiracion;
        private System.Windows.Forms.Button btnConfirmar;
    }
}
