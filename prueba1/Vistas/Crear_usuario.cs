using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NMA_DESK.models;

namespace NMA_DESK.Vistas
{
    public partial class Crear_usuario : Form
    {
        public int? id;
        usuario oUsuario = null;
        public Crear_usuario(int? id=null)
        {
            InitializeComponent();

            this.id = id;
            if (id != null)
                CargarDatos();
                
        }
        private void CargarDatos() //listar 
        {
            int telefono,tipo_usuario,id_empresa;

            telefono = int.Parse(fono.Text);
            tipo_usuario = int.Parse(Tipo_usuario.Text);
            id_empresa = int.Parse(Id_empresa.Text);

            using (NMAEntities db = new NMAEntities())
            {
              
                oUsuario=  db.usuario.Find(id);
                oUsuario.nombre = Nombres.Text;
                oUsuario.a_paterno = Apellido_p.Text;
                oUsuario.a_materno = Apellido_m.Text;
                oUsuario.run = run.Text;
                oUsuario.telefono = telefono;
                oUsuario.email = Correo.Text;
                oUsuario.contrasena = Password.Text;
                oUsuario.id_tipo_usuario = tipo_usuario;
                oUsuario.id_empresa = id_empresa;

                db.usuario.Add(oUsuario);
                db.SaveChanges();

                this.Close();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Esta funcion es para agregar usuarios
        {
            int telefono, tipo_usuario, id_empresa;
          

            telefono = int.Parse(fono.Text);
            tipo_usuario = int.Parse(Tipo_usuario.Text);
            id_empresa = int.Parse(Id_empresa.Text);

            using (NMAEntities db= new NMAEntities())
            {

                if(id==null)
                    oUsuario = new usuario();
                    
                oUsuario.nombre = Nombres.Text;
                oUsuario.a_paterno = Apellido_p.Text;
                oUsuario.a_materno = Apellido_m.Text;
                oUsuario.run = run.Text;
                oUsuario.telefono = telefono;
                oUsuario.email = Correo.Text;
                oUsuario.contrasena = Password.Text;
                oUsuario.id_tipo_usuario = tipo_usuario;
                oUsuario.id_empresa = id_empresa;

                if(id==null)
                    db.usuario.Add(oUsuario);
                else 
                {
                    db.Entry(oUsuario).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();

                MessageBox.Show("Usuario creado");

                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void fono_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
