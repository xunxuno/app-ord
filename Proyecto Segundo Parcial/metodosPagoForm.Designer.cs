namespace ProyectoSegundoParcial
{
    partial class MetodosPagoForm
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
            this.btnTarjeta = new System.Windows.Forms.Button();
            this.btnOxxo = new System.Windows.Forms.Button();
            this.btnSoriana = new System.Windows.Forms.Button();
            this.btnSPEI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTarjeta
            // 
            this.btnTarjeta.Location = new System.Drawing.Point(50, 50);
            this.btnTarjeta.Name = "btnTarjeta";
            this.btnTarjeta.Size = new System.Drawing.Size(200, 23);
            this.btnTarjeta.TabIndex = 0;
            this.btnTarjeta.Text = "Tarjeta de Crédito/Débito";
            this.btnTarjeta.UseVisualStyleBackColor = true;
            this.btnTarjeta.Click += new System.EventHandler(this.btnTarjeta_Click);
            // 
            // btnOxxo
            // 
            this.btnOxxo.Location = new System.Drawing.Point(50, 100);
            this.btnOxxo.Name = "btnOxxo";
            this.btnOxxo.Size = new System.Drawing.Size(200, 23);
            this.btnOxxo.TabIndex = 1;
            this.btnOxxo.Text = "Pago en OXXO";
            this.btnOxxo.UseVisualStyleBackColor = true;
            this.btnOxxo.Click += new System.EventHandler(this.btnOxxo_Click);
            // 
            // btnSoriana
            // 
            this.btnSoriana.Location = new System.Drawing.Point(50, 150);
            this.btnSoriana.Name = "btnSoriana";
            this.btnSoriana.Size = new System.Drawing.Size(200, 23);
            this.btnSoriana.TabIndex = 2;
            this.btnSoriana.Text = "Pago en Soriana";
            this.btnSoriana.UseVisualStyleBackColor = true;
            this.btnSoriana.Click += new System.EventHandler(this.btnSoriana_Click);
            // 
            // btnSPEI
            // 
            this.btnSPEI.Location = new System.Drawing.Point(50, 200);
            this.btnSPEI.Name = "btnSPEI";
            this.btnSPEI.Size = new System.Drawing.Size(200, 23);
            this.btnSPEI.TabIndex = 3;
            this.btnSPEI.Text = "Transferencia SPEI";
            this.btnSPEI.UseVisualStyleBackColor = true;
            this.btnSPEI.Click += new System.EventHandler(this.btnSPEI_Click);
            // 
            // MetodosPagoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.btnSPEI);
            this.Controls.Add(this.btnSoriana);
            this.Controls.Add(this.btnOxxo);
            this.Controls.Add(this.btnTarjeta);
            this.Name = "MetodosPagoForm";
            this.Text = "Métodos de Pago";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnTarjeta;
        private System.Windows.Forms.Button btnOxxo;
        private System.Windows.Forms.Button btnSoriana;
        private System.Windows.Forms.Button btnSPEI;
    }
}
