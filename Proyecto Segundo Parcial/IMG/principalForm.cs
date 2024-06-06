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
            // Agregar y mostrar el formulario de agregar recarga
            agregarRecargaForm agregarRecarga = new agregarRecargaForm();
            agregarRecarga.Visible = true;

            // Agregar y mostrar el formulario de informacion bancaria
            informacionBancariaForm informacionBancaria = new informacionBancariaForm();
            informacionBancaria.Visible = true;

            // Agregar y mostrar el formulario de metodos de pago
            metodosPagoForm metodosPago = new metodosPagoForm();
            metodosPago.Visible = true;
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
    }
}
