using System;
using System.IO;
using System.Windows.Forms;

namespace ProyectoSegundoParcial
{
    public partial class ResumenCompraForm : Form
    {
        public ResumenCompraForm()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Lógica para finalizar la compra
            // Imprimir nota de compra en archivo de texto
            string compraDetails = "Resumen de Compra:\n";
            compraDetails += "Plan: " + Sesion.PlanActual.NombrePlan + "\n";
            compraDetails += "Número de Teléfono: " + Sesion.PlanActual.NumeroTelefono + "\n";
            compraDetails += "Fecha de Vencimiento: " + Sesion.PlanActual.FechaVencimiento.ToString("dd/MM/yyyy") + "\n";
            compraDetails += "Total GB: " + Sesion.PlanActual.GbTotales + "\n";
            compraDetails += "GB Utilizados: " + Sesion.PlanActual.GbUtilizados + "\n";
            compraDetails += "GB Utilizados en Redes Sociales: " + Sesion.PlanActual.GbUtilizadosRedes + "\n";

            string fileName = "NotaCompra_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";
            File.WriteAllText(fileName, compraDetails);

            // Actualizar la información del plan
            this.Close();
        }
    }
}
