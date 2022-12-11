using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using NMA_DESK.models;
using NMA_DESK.Vistas;

namespace NMA_DESK.Vistas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logeo();
        }

        private void Logeo()
        {
            SqlConnection connection = new SqlConnection(@"Data Source = 192.99.253.83; Initial Catalog = NMA; Integrated Security=True");
            connection.Open();
            string consulta = "SELECT * FROM usuario WHERE email ='" + txtCorreo + " AND contrasena ='" + txtpassword + '"';
            SqlCommand comando = new SqlCommand(consulta, connection);
            SqlDataReader lector;
            lector = comando.ExecuteReader();

            if (lector.HasRows == true)
            {
                Menu ventana = new Menu();
                ventana.Show();
            }
            else
            {
                MessageBox.Show("Información invalida");
            }
        }
        
   
    }
}
