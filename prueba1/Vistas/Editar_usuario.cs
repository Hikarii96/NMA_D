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
    public partial class Editar_usuario : Form
    {
        public Editar_usuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Editar_usuario(oUsuarios);
            this.Close();
        }
    }
}
