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
using NMA_DESK.Vistas;

namespace NMA_DESK.Vistas
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vistas.Crear_usuario oCrear_usuario = new Vistas.Crear_usuario();
            oCrear_usuario.ShowDialog();

            refrescar();

            //this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            refrescar();
        }
        #region HELPER
        private void refrescar()
        {
            using (NMAEntities db = new NMAEntities())
            {
                var lst = from d in db.usuario
                          select d;
                Lista.DataSource = lst.ToList();
            }
        } //es como un select de sql

        private int? GetId()
        {
            try
            {
                return int.Parse(Lista.Rows[Lista.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion


        private void button2_Click(object sender, EventArgs e)
        {
            Menu ventana = new Menu();
            ventana.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                Vistas.Crear_usuario oCrear_usuario = new Vistas.Crear_usuario(id);
                oCrear_usuario.ShowDialog();
            }
            
        }

        private void Lista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
