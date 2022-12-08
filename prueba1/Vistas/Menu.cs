using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMA_DESK.Vistas
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios ventana = new Usuarios();
            ventana.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Facturas  ventana= new Facturas();
            ventana.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reporte_cliente ventana = new Reporte_cliente();
            ventana.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reporte_global ventana = new Reporte_global();
            ventana.Show();

            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Gestion_cliente ventana = new Gestion_cliente();
            ventana.Show();

            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Gestion_contratos ventana = new Gestion_contratos();
            ventana.Show();

            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Profesionales ventana = new Profesionales();
            ventana.Show();

            this.Hide();
        }
    }
}
