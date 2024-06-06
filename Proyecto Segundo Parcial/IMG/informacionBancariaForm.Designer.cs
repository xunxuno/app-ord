namespace ProyectoSegundoParcial
{
    partial class informacionBancariaForm
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
            this.tituloPestLabel = new System.Windows.Forms.Label();
            this.separadorPanel1 = new System.Windows.Forms.Panel();
            this.nombreTitularLabel = new System.Windows.Forms.Label();
            this.nombreTitularTextBox = new System.Windows.Forms.TextBox();
            this.numTarjetaTextBox = new System.Windows.Forms.TextBox();
            this.numTarjetaLabel = new System.Windows.Forms.Label();
            this.CVVTextBox = new System.Windows.Forms.TextBox();
            this.CVVLabel = new System.Windows.Forms.Label();
            this.fechaExpLabel = new System.Windows.Forms.Label();
            this.mesesAnioComboBox = new System.Windows.Forms.ComboBox();
            this.mesesTLabel = new System.Windows.Forms.Label();
            this.aniosTLabel = new System.Windows.Forms.Label();
            this.aniosComboBox = new System.Windows.Forms.ComboBox();
            this.enviarInformacionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tituloPestLabel
            // 
            this.tituloPestLabel.AutoSize = true;
            this.tituloPestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloPestLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(168)))), ((int)(((byte)(170)))));
            this.tituloPestLabel.Location = new System.Drawing.Point(102, 9);
            this.tituloPestLabel.Name = "tituloPestLabel";
            this.tituloPestLabel.Size = new System.Drawing.Size(495, 25);
            this.tituloPestLabel.TabIndex = 12;
            this.tituloPestLabel.Text = "INGRESA LA INFORMACIÓN DE TU TARJETA";
            // 
            // separadorPanel1
            // 
            this.separadorPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.separadorPanel1.Location = new System.Drawing.Point(2, 43);
            this.separadorPanel1.Name = "separadorPanel1";
            this.separadorPanel1.Size = new System.Drawing.Size(699, 3);
            this.separadorPanel1.TabIndex = 11;
            // 
            // nombreTitularLabel
            // 
            this.nombreTitularLabel.AutoSize = true;
            this.nombreTitularLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTitularLabel.ForeColor = System.Drawing.Color.Gray;
            this.nombreTitularLabel.Location = new System.Drawing.Point(115, 76);
            this.nombreTitularLabel.Name = "nombreTitularLabel";
            this.nombreTitularLabel.Size = new System.Drawing.Size(142, 16);
            this.nombreTitularLabel.TabIndex = 13;
            this.nombreTitularLabel.Text = "Nombre del Titular*";
            // 
            // nombreTitularTextBox
            // 
            this.nombreTitularTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTitularTextBox.ForeColor = System.Drawing.Color.Gray;
            this.nombreTitularTextBox.Location = new System.Drawing.Point(49, 104);
            this.nombreTitularTextBox.Name = "nombreTitularTextBox";
            this.nombreTitularTextBox.Size = new System.Drawing.Size(271, 22);
            this.nombreTitularTextBox.TabIndex = 14;
            this.nombreTitularTextBox.Text = "Martha Gómez";
            // 
            // numTarjetaTextBox
            // 
            this.numTarjetaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.numTarjetaTextBox.ForeColor = System.Drawing.Color.Gray;
            this.numTarjetaTextBox.Location = new System.Drawing.Point(372, 104);
            this.numTarjetaTextBox.Name = "numTarjetaTextBox";
            this.numTarjetaTextBox.Size = new System.Drawing.Size(271, 22);
            this.numTarjetaTextBox.TabIndex = 16;
            this.numTarjetaTextBox.Text = "Martha Gómez";
            // 
            // numTarjetaLabel
            // 
            this.numTarjetaLabel.AutoSize = true;
            this.numTarjetaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTarjetaLabel.ForeColor = System.Drawing.Color.Gray;
            this.numTarjetaLabel.Location = new System.Drawing.Point(438, 76);
            this.numTarjetaLabel.Name = "numTarjetaLabel";
            this.numTarjetaLabel.Size = new System.Drawing.Size(142, 16);
            this.numTarjetaLabel.TabIndex = 15;
            this.numTarjetaLabel.Text = "Nombre del Titular*";
            // 
            // CVVTextBox
            // 
            this.CVVTextBox.ForeColor = System.Drawing.Color.Gray;
            this.CVVTextBox.Location = new System.Drawing.Point(41, 178);
            this.CVVTextBox.Name = "CVVTextBox";
            this.CVVTextBox.Size = new System.Drawing.Size(271, 20);
            this.CVVTextBox.TabIndex = 18;
            // 
            // CVVLabel
            // 
            this.CVVLabel.AutoSize = true;
            this.CVVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CVVLabel.ForeColor = System.Drawing.Color.Gray;
            this.CVVLabel.Location = new System.Drawing.Point(156, 149);
            this.CVVLabel.Name = "CVVLabel";
            this.CVVLabel.Size = new System.Drawing.Size(43, 16);
            this.CVVLabel.TabIndex = 17;
            this.CVVLabel.Text = "CVV*";
            // 
            // fechaExpLabel
            // 
            this.fechaExpLabel.AutoSize = true;
            this.fechaExpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaExpLabel.ForeColor = System.Drawing.Color.Gray;
            this.fechaExpLabel.Location = new System.Drawing.Point(44, 220);
            this.fechaExpLabel.Name = "fechaExpLabel";
            this.fechaExpLabel.Size = new System.Drawing.Size(155, 16);
            this.fechaExpLabel.TabIndex = 19;
            this.fechaExpLabel.Text = "Fecha de Expiración*";
            // 
            // mesesAnioComboBox
            // 
            this.mesesAnioComboBox.ForeColor = System.Drawing.Color.Gray;
            this.mesesAnioComboBox.FormattingEnabled = true;
            this.mesesAnioComboBox.Location = new System.Drawing.Point(41, 275);
            this.mesesAnioComboBox.Name = "mesesAnioComboBox";
            this.mesesAnioComboBox.Size = new System.Drawing.Size(271, 21);
            this.mesesAnioComboBox.TabIndex = 20;
            // 
            // mesesTLabel
            // 
            this.mesesTLabel.AutoSize = true;
            this.mesesTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mesesTLabel.ForeColor = System.Drawing.Color.Gray;
            this.mesesTLabel.Location = new System.Drawing.Point(156, 256);
            this.mesesTLabel.Name = "mesesTLabel";
            this.mesesTLabel.Size = new System.Drawing.Size(42, 16);
            this.mesesTLabel.TabIndex = 21;
            this.mesesTLabel.Text = "Mes*";
            // 
            // aniosTLabel
            // 
            this.aniosTLabel.AutoSize = true;
            this.aniosTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aniosTLabel.ForeColor = System.Drawing.Color.Gray;
            this.aniosTLabel.Location = new System.Drawing.Point(487, 256);
            this.aniosTLabel.Name = "aniosTLabel";
            this.aniosTLabel.Size = new System.Drawing.Size(40, 16);
            this.aniosTLabel.TabIndex = 23;
            this.aniosTLabel.Text = "Año*";
            // 
            // aniosComboBox
            // 
            this.aniosComboBox.ForeColor = System.Drawing.Color.Gray;
            this.aniosComboBox.FormattingEnabled = true;
            this.aniosComboBox.Location = new System.Drawing.Point(372, 275);
            this.aniosComboBox.Name = "aniosComboBox";
            this.aniosComboBox.Size = new System.Drawing.Size(271, 21);
            this.aniosComboBox.TabIndex = 22;
            // 
            // enviarInformacionButton
            // 
            this.enviarInformacionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.enviarInformacionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enviarInformacionButton.ForeColor = System.Drawing.Color.White;
            this.enviarInformacionButton.Location = new System.Drawing.Point(565, 320);
            this.enviarInformacionButton.Name = "enviarInformacionButton";
            this.enviarInformacionButton.Size = new System.Drawing.Size(94, 31);
            this.enviarInformacionButton.TabIndex = 24;
            this.enviarInformacionButton.Text = "Enviar";
            this.enviarInformacionButton.UseVisualStyleBackColor = false;
            // 
            // informacionBancariaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(671, 361);
            this.Controls.Add(this.enviarInformacionButton);
            this.Controls.Add(this.aniosTLabel);
            this.Controls.Add(this.aniosComboBox);
            this.Controls.Add(this.mesesTLabel);
            this.Controls.Add(this.mesesAnioComboBox);
            this.Controls.Add(this.fechaExpLabel);
            this.Controls.Add(this.CVVTextBox);
            this.Controls.Add(this.CVVLabel);
            this.Controls.Add(this.numTarjetaTextBox);
            this.Controls.Add(this.numTarjetaLabel);
            this.Controls.Add(this.nombreTitularTextBox);
            this.Controls.Add(this.nombreTitularLabel);
            this.Controls.Add(this.tituloPestLabel);
            this.Controls.Add(this.separadorPanel1);
            this.Name = "informacionBancariaForm";
            this.Text = "Información Bancaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloPestLabel;
        private System.Windows.Forms.Panel separadorPanel1;
        private System.Windows.Forms.Label nombreTitularLabel;
        private System.Windows.Forms.TextBox nombreTitularTextBox;
        private System.Windows.Forms.TextBox numTarjetaTextBox;
        private System.Windows.Forms.Label numTarjetaLabel;
        private System.Windows.Forms.TextBox CVVTextBox;
        private System.Windows.Forms.Label CVVLabel;
        private System.Windows.Forms.Label fechaExpLabel;
        private System.Windows.Forms.ComboBox mesesAnioComboBox;
        private System.Windows.Forms.Label mesesTLabel;
        private System.Windows.Forms.Label aniosTLabel;
        private System.Windows.Forms.ComboBox aniosComboBox;
        private System.Windows.Forms.Button enviarInformacionButton;
    }
}