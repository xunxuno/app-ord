using System;
using System.Windows.Forms;


namespace ProyectoSegundoParcial
{
    public partial class PlanInfoForm : Form
    {
        public PlanInfoForm()
        {
            InitializeComponent();
        }

        private void PlanInfoForm_Load(object sender, EventArgs e)
        {
            if (Sesion.IsLoggedIn)
            {
                lblPlanName.Text = "Plan Name: " + Sesion.PlanActual.NombrePlan;
                lblPhoneNumber.Text = "Phone Number: " + Sesion.PlanActual.NumeroTelefono;
                lblExpiryDate.Text = "Expiry Date: " + Sesion.PlanActual.FechaVencimiento.ToString("dd/MM/yyyy");
                lblTotalDays.Text = "Total Days: " + Sesion.PlanActual.DiasTotales;
                lblRemainingDays.Text = "Remaining Days: " + Sesion.PlanActual.DiasRestantes;
                lblTotalGb.Text = "Total GB: " + Sesion.PlanActual.GbTotales;
                lblUsedGb.Text = "Used GB: " + Sesion.PlanActual.GbUtilizados;
                lblUsedGbSocial.Text = "Used GB Social: " + Sesion.PlanActual.GbUtilizadosRedes;
            }
            else
            {
                lblPlanName.Text = "Plan Name: ";
                lblPhoneNumber.Text = "Phone Number: ";
                lblExpiryDate.Text = "Expiry Date: ";
                lblTotalDays.Text = "Total Days: ";
                lblRemainingDays.Text = "Remaining Days: ";
                lblTotalGb.Text = "Total GB: ";
                lblUsedGb.Text = "Used GB: ";
                lblUsedGbSocial.Text = "Used GB Social: ";
            }
        }
    }
}
