using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ProyectoSegundoParcial
{
    public partial class MetodosPagoForm : Form
    {
        public MetodosPagoForm()
        {
            InitializeComponent();
        }

        private void btnTarjeta_Click(object sender, EventArgs e)
        {
            PagoTarjetaForm pagoTarjetaForm = new PagoTarjetaForm();
            pagoTarjetaForm.ShowDialog();
        }

        private void btnOxxo_Click(object sender, EventArgs e)
        {
            // Lógica para pago en OXXO
            MessageBox.Show("Pago en OXXO seleccionado");
        }

        private void btnSoriana_Click(object sender, EventArgs e)
        {
            // Lógica para pago en Soriana
            MessageBox.Show("Pago en Soriana seleccionado");
        }

        private void btnSPEI_Click(object sender, EventArgs e)
        {
            // Lógica para pago por transferencia SPEI
            MessageBox.Show("Transferencia SPEI seleccionada");
        }
    }
}
