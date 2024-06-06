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
    public partial class principalForm : Form
    {
        public principalForm()
        {
            InitializeComponent();
            
        }

        private void pagosLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Crear una instancia del formulario metodosPago
            metodosPagoForm formMetodosPago = new metodosPagoForm();

            // Mostrar el formulario de manera modal
            formMetodosPago.ShowDialog();
        }

        private void billeteraIconPictureBox_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario metodosPago
            metodosPagoForm formMetodosPago = new metodosPagoForm();

            // Mostrar el formulario de manera modal
            formMetodosPago.ShowDialog();
        }

        private void principalForm_Load(object sender, EventArgs e)
        {

        }

        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            // Aquí se puede manejar la lógica para actualizar la interfaz después de iniciar sesión
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("¿Está seguro que desea cerrar sesión?",
                                     "Confirmar Cierre de Sesión",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // Lógica para cerrar sesión
                // Limpiar información del plan
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void informacionDelPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlanInfoForm planInfoForm = new PlanInfoForm();
            planInfoForm.ShowDialog();
        }

        private void comprarPrepagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComprarPrepagoForm comprarPrepagoForm = new ComprarPrepagoForm();
            comprarPrepagoForm.ShowDialog();
        }
    }
}
