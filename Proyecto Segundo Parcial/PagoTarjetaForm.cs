using System;
using System.Windows.Forms;

namespace ProyectoSegundoParcial
{
    public partial class PagoTarjetaForm : Form
    {
        public PagoTarjetaForm()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Validar los datos de la tarjeta
            if (ValidarDatosTarjeta())
            {
                // Mostrar ventana de resumen de compra si los datos son válidos
                ResumenCompraForm resumenCompraForm = new ResumenCompraForm();
                resumenCompraForm.ShowDialog();

                // Actualizar la información del plan después de la compra
                ActualizarInformacionPlan();
            }
            else
            {
                MessageBox.Show("Datos de la tarjeta inválidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarDatosTarjeta()
        {
            // Validar nombre del titular, número de tarjeta, CVV y fecha de expiración
            if (txtNombreTitular.Text.Length > 0 && txtNumeroTarjeta.Text.Length == 16 && txtCVV.Text.Length == 3)
            {
                DateTime fechaExpiracion;
                if (DateTime.TryParseExact(txtFechaExpiracion.Text, "MM/yyyy", null, System.Globalization.DateTimeStyles.None, out fechaExpiracion))
                {
                    if (fechaExpiracion > DateTime.Now)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void ActualizarInformacionPlan()
        {
            // Actualizar la información del plan basado en el plan seleccionado
            switch (Sesion.PlanActual.NombrePlan)
            {
                case "PLAN 10 GB 7 DÍAS":
                    Sesion.PlanActual.DiasTotales = 7;
                    Sesion.PlanActual.GbTotales = 10;
                    break;
                case "PLAN 25 GB 15 DÍAS":
                    Sesion.PlanActual.DiasTotales = 15;
                    Sesion.PlanActual.GbTotales = 25;
                    break;
                case "PLAN 40 GB 30 DÍAS":
                    Sesion.PlanActual.DiasTotales = 30;
                    Sesion.PlanActual.GbTotales = 40;
                    break;
            }
            Sesion.PlanActual.FechaVencimiento = DateTime.Now.AddDays(Sesion.PlanActual.DiasTotales);
            Sesion.PlanActual.DiasRestantes = Sesion.PlanActual.DiasTotales;
            Sesion.PlanActual.GbUtilizados = 0;
            Sesion.PlanActual.GbUtilizadosRedes = 0;
        }
    }
}
