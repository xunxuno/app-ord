using System;
using System.Windows.Forms;

namespace ProyectoSegundoParcial
{
    public partial class ComprarPrepagoForm : Form
    {
        public ComprarPrepagoForm()
        {
            InitializeComponent();
        }

        private void btnSeleccionarPlan_Click(object sender, EventArgs e)
        {
            MetodosPagoForm metodosPagoForm = new MetodosPagoForm();
            metodosPagoForm.ShowDialog();
        }
    }
}

}
