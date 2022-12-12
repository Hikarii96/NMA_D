using NMA_DESK.Controladores;
using NMA_DESK.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMA_DESK.Vistas
{

    public partial class Crud_usuarios : Form
    {
        private NMAEntities_ db = new NMAEntities_(); //conexion a base de datos
        public Crud_usuarios()
        {
            InitializeComponent();
        }

        Cusuario datos = new Cusuario();
        usuario usuario = new usuario();

        private int id_usuario;

        private void CargarGrid()
        {
            
            var lst = datos.Read();
            dataGridView1.DataSource = lst;

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Crud_usuarios_Load(object sender, EventArgs e)
        {
            CargarGrid();

        }
        private void CargarDatos()
        {

            usuario.id_usuario = id_usuario;
            usuario.run = txtrun.Text;
            usuario.contrasena = txtcontrasena.Text;
            usuario.nombre = txtnombre.Text;
            usuario.a_paterno = txtapellido_p.Text;
            usuario.a_materno = txtapellido_m.Text;
            usuario.email = txtemail.Text;
            usuario.telefono = Convert.ToInt32(txttelefono.Text);
            //usuario.id_empresa = Convert.ToInt32(txtempresa.Text);
            usuario.id_tipo_usuario = Convert.ToInt32(txtusuario.Text);
        }

        private void Limpiar()
        {
            id_usuario = 0;
            txtrun.Text = string.Empty;
            txtcontrasena.Text = string.Empty;
            txtnombre.Text = string.Empty;
            txtapellido_p.Text = string.Empty;
            txtapellido_m.Text = string.Empty;
            txtemail.Text = string.Empty;
            txttelefono.Text = string.Empty;
            //txtempresa.Text = string.Empty;
            txtusuario.Text = string.Empty;

        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            CargarDatos();
            datos.create(usuario);
            Limpiar();
            MessageBox.Show("usuario creado");

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (id_usuario > 0)
            {
                CargarDatos();
                datos.Update(usuario);
                Limpiar();
                MessageBox.Show("usuario modificado");
            }
            else
            {
                MessageBox.Show("no se puede modificar");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            id_usuario = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_usuario"].Value.ToString());
            txtrun.Text = dataGridView1.CurrentRow.Cells["run"].Value.ToString();
            txtcontrasena.Text = dataGridView1.CurrentRow.Cells["contrasena"].Value.ToString();
            txtnombre.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
            txtapellido_p.Text = dataGridView1.CurrentRow.Cells["a_paterno"].Value.ToString();
            txtapellido_m.Text = dataGridView1.CurrentRow.Cells["a_materno"].Value.ToString();
            txtemail.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
            txttelefono.Text = dataGridView1.CurrentRow.Cells["telefono"].Value.ToString();
            //txtempresa.Text = dataGridView1.CurrentRow.Cells["id_empresa"].Value.ToString();
            txtusuario.Text = dataGridView1.CurrentRow.Cells["id_tipo_usuario"].Value.ToString();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (id_usuario > 0)
            {
                CargarDatos();
                datos.Delete(id_usuario);
                Limpiar();
                MessageBox.Show("Usuario eliminado");
                
            }
            else
            {
                MessageBox.Show("no se puede modificar");
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if(txtbuscar.Text != string.Empty)
            {
                var lst = datos.buscarId(Convert.ToInt32(txtbuscar.Text));
                dataGridView1.DataSource = lst;
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            Menu ventana = new Menu();
            ventana.Show();
            this.Close();
        }
    }
}
