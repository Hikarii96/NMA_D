using NMA_DESK.Controladores;
using NMA_DESK.models;
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
    public partial class CRUD_usuario : Form
    {
        private DataTable usuario;
        UsuarioAdmin admin = new UsuarioAdmin();
        
        private void CrearUsuario()
        {
            usuario = new DataTable();
            usuario.Columns.Add("txtrun");
            usuario.Columns.Add("txtcontrasena");
            usuario.Columns.Add("txtnombres");
            usuario.Columns.Add("txtapellido_p");
            usuario.Columns.Add("txtapellido_m");
            usuario.Columns.Add("txtelefono");
            usuario.Columns.Add("txtcorreo");
            usuario.Columns.Add("txt_id_empresa"); 
            usuario.Columns.Add("txt_tipo_usuario");
            Lista_usuarios.DataSource = usuario;
        }
        public CRUD_usuario()
        {
            InitializeComponent();
            Consultar();
        }
        private void Consultar()
        {
            CrearUsuario();
            List<usuario> usuarios = admin.Consultar();
            foreach(var item in usuarios) 
            {
                DataRow row = usuario.NewRow();
                
                row["txtrun"] = item.run;
                row["txtcontrasena"] = item.contrasena;
                row["txtapellido_p"] = item.a_paterno;
                row["txtapellido_m"] = item.a_materno;
                row["txtcorreo"] = item.email;
                row["txtelefono"] = item.telefono;
                row["txt_id_empresa"] = item.id_empresa;
                row["txt_tipo_usuario"] = item.id_tipo_usuario;
                usuario.Rows.Add(row);  
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Limpiar()
        {
            txtrun.Text = "";
            txtcontrasena.Text = "";
            txtnombres.Text = "";
            txtapellido_p.Text = "";
            txtapellido_m.Text = "";
            txtcorreo.Text = "";
            txtelefono.Text = "";
            txt_id_empresa.Text = "";
            txt_tipo_usuario.Text = "";

        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            CrearUsuario();
            Consultar();
            Limpiar();
        }

        private void txtelefono_Click(object sender, EventArgs e)
        {

        }

        private void txtrun_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
