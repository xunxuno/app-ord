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
    public partial class metodosPagoForm : Form
    {
        public metodosPagoForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int diameter = 80; // Diámetro del círculo más pequeño

            // Define las coordenadas para centrar el círculo
            int x = (tarjPanel.Width - diameter) / 2;
            int y = (tarjPanel.Height - diameter) / 2;

            // Rellenar el círculo con color rojo
            SolidBrush brush = new SolidBrush(Color.Red);
            g.FillEllipse(brush, x, y, diameter, diameter);

            // Dibujar el borde del círculo
            Pen pen = new Pen(Color.Red, 3);
            g.DrawEllipse(pen, x, y, diameter, diameter);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int diameter = 80; // Diámetro del círculo más pequeño

            // Define las coordenadas para centrar el círculo
            int x = (tarjPanel.Width - diameter) / 2;
            int y = (tarjPanel.Height - diameter) / 2;

            // Rellenar el círculo con color rojo
            SolidBrush brush = new SolidBrush(Color.Red);
            g.FillEllipse(brush, x, y, diameter, diameter);

            // Dibujar el borde del círculo
            Pen pen = new Pen(Color.Red, 3);
            g.DrawEllipse(pen, x, y, diameter, diameter);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int diameter = 80; // Diámetro del círculo más pequeño

            // Define las coordenadas para centrar el círculo
            int x = (tarjPanel.Width - diameter) / 2;
            int y = (tarjPanel.Height - diameter) / 2;

            // Rellenar el círculo con color rojo
            SolidBrush brush = new SolidBrush(Color.Red);
            g.FillEllipse(brush, x, y, diameter, diameter);

            // Dibujar el borde del círculo
            Pen pen = new Pen(Color.Red, 3);
            g.DrawEllipse(pen, x, y, diameter, diameter);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int diameter = 80; // Diámetro del círculo más pequeño

            // Define las coordenadas para centrar el círculo
            int x = (tarjPanel.Width - diameter) / 2;
            int y = (tarjPanel.Height - diameter) / 2;

            // Rellenar el círculo con color rojo
            SolidBrush brush = new SolidBrush(Color.Red);
            g.FillEllipse(brush, x, y, diameter, diameter);

            // Dibujar el borde del círculo
            Pen pen = new Pen(Color.Red, 3);
            g.DrawEllipse(pen, x, y, diameter, diameter);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int diameter = 80; // Diámetro del círculo más pequeño

            // Define las coordenadas para centrar el círculo
            int x = (tarjPanel.Width - diameter) / 2;
            int y = (tarjPanel.Height - diameter) / 2;

            // Rellenar el círculo con color rojo
            SolidBrush brush = new SolidBrush(Color.Red);
            g.FillEllipse(brush, x, y, diameter, diameter);

            // Dibujar el borde del círculo
            Pen pen = new Pen(Color.Red, 3);
            g.DrawEllipse(pen, x, y, diameter, diameter);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int diameter = 80; // Diámetro del círculo más pequeño

            // Define las coordenadas para centrar el círculo
            int x = (tarjPanel.Width - diameter) / 2;
            int y = (tarjPanel.Height - diameter) / 2;

            // Rellenar el círculo con color rojo
            SolidBrush brush = new SolidBrush(Color.Red);
            g.FillEllipse(brush, x, y, diameter, diameter);

            // Dibujar el borde del círculo
            Pen pen = new Pen(Color.Red, 3);
            g.DrawEllipse(pen, x, y, diameter, diameter);
        }
    }
}
