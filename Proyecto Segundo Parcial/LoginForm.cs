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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validar credenciales
            // Aquí puedes poner tu lógica de validación
            if (txtUsername.Text == "admin" && txtPassword.Text == "password")
            {
                Sesion.IsLoggedIn = true;
                Sesion.NombreUsuario = txtUsername.Text;
                Sesion.NumeroTelefono = "1234567890"; // Ejemplo de número de teléfono

                // Lógica para actualizar la información del plan
                Sesion.PlanActual.NombrePlan = "PLAN 25 GB 15 DÍAS";
                Sesion.PlanActual.NumeroTelefono = "1234567890";
                Sesion.PlanActual.FechaVencimiento = DateTime.Now.AddDays(15);
                Sesion.PlanActual.DiasTotales = 15;
                Sesion.PlanActual.DiasRestantes = 15;
                Sesion.PlanActual.GbTotales = 25;
                Sesion.PlanActual.GbUtilizados = 0;
                Sesion.PlanActual.GbUtilizadosRedes = 0;

                this.Close();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

