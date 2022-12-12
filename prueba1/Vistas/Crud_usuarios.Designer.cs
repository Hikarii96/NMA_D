namespace NMA_DESK.Vistas
{
    partial class Crud_usuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Datos = new System.Windows.Forms.GroupBox();
            this.txtapellido_m = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtapellido_p = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.txtrun = new System.Windows.Forms.TextBox();
            this.xdd = new System.Windows.Forms.Label();
            this.eee = new System.Windows.Forms.Label();
            this.qq = new System.Windows.Forms.Label();
            this.aa = new System.Windows.Forms.Label();
            this.dd = new System.Windows.Forms.Label();
            this.xx = new System.Windows.Forms.Label();
            this.xd = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.salir = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.cmbempresa = new System.Windows.Forms.ComboBox();
            this.Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Datos
            // 
            this.Datos.Controls.Add(this.cmbempresa);
            this.Datos.Controls.Add(this.txtusuario);
            this.Datos.Controls.Add(this.label2);
            this.Datos.Controls.Add(this.label1);
            this.Datos.Controls.Add(this.btnbuscar);
            this.Datos.Controls.Add(this.txtapellido_m);
            this.Datos.Controls.Add(this.txtemail);
            this.Datos.Controls.Add(this.txttelefono);
            this.Datos.Controls.Add(this.txtapellido_p);
            this.Datos.Controls.Add(this.txtnombre);
            this.Datos.Controls.Add(this.txtcontrasena);
            this.Datos.Controls.Add(this.txtrun);
            this.Datos.Controls.Add(this.xdd);
            this.Datos.Controls.Add(this.eee);
            this.Datos.Controls.Add(this.qq);
            this.Datos.Controls.Add(this.aa);
            this.Datos.Controls.Add(this.dd);
            this.Datos.Controls.Add(this.xx);
            this.Datos.Controls.Add(this.xd);
            this.Datos.Location = new System.Drawing.Point(23, 41);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(765, 193);
            this.Datos.TabIndex = 1;
            this.Datos.TabStop = false;
            this.Datos.Text = "Datos";
            this.Datos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtapellido_m
            // 
            this.txtapellido_m.Location = new System.Drawing.Point(371, 80);
            this.txtapellido_m.Name = "txtapellido_m";
            this.txtapellido_m.Size = new System.Drawing.Size(100, 22);
            this.txtapellido_m.TabIndex = 13;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(317, 130);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 22);
            this.txtemail.TabIndex = 12;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(630, 26);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(100, 22);
            this.txttelefono.TabIndex = 11;
            // 
            // txtapellido_p
            // 
            this.txtapellido_p.Location = new System.Drawing.Point(358, 29);
            this.txtapellido_p.Name = "txtapellido_p";
            this.txtapellido_p.Size = new System.Drawing.Size(100, 22);
            this.txtapellido_p.TabIndex = 10;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(74, 130);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 22);
            this.txtnombre.TabIndex = 9;
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Location = new System.Drawing.Point(86, 77);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.Size = new System.Drawing.Size(100, 22);
            this.txtcontrasena.TabIndex = 8;
            // 
            // txtrun
            // 
            this.txtrun.Location = new System.Drawing.Point(61, 32);
            this.txtrun.Name = "txtrun";
            this.txtrun.Size = new System.Drawing.Size(100, 22);
            this.txtrun.TabIndex = 7;
            // 
            // xdd
            // 
            this.xdd.AutoSize = true;
            this.xdd.Location = new System.Drawing.Point(527, 32);
            this.xdd.Name = "xdd";
            this.xdd.Size = new System.Drawing.Size(61, 16);
            this.xdd.TabIndex = 6;
            this.xdd.Text = "Telefono";
            this.xdd.Click += new System.EventHandler(this.label7_Click);
            // 
            // eee
            // 
            this.eee.AutoSize = true;
            this.eee.Location = new System.Drawing.Point(229, 130);
            this.eee.Name = "eee";
            this.eee.Size = new System.Drawing.Size(40, 16);
            this.eee.TabIndex = 5;
            this.eee.Text = "email";
            // 
            // qq
            // 
            this.qq.AutoSize = true;
            this.qq.Location = new System.Drawing.Point(229, 80);
            this.qq.Name = "qq";
            this.qq.Size = new System.Drawing.Size(108, 16);
            this.qq.TabIndex = 4;
            this.qq.Text = "apellido materno";
            // 
            // aa
            // 
            this.aa.AutoSize = true;
            this.aa.Location = new System.Drawing.Point(229, 32);
            this.aa.Name = "aa";
            this.aa.Size = new System.Drawing.Size(105, 16);
            this.aa.TabIndex = 3;
            this.aa.Text = "apellido paterno";
            // 
            // dd
            // 
            this.dd.AutoSize = true;
            this.dd.Location = new System.Drawing.Point(6, 130);
            this.dd.Name = "dd";
            this.dd.Size = new System.Drawing.Size(53, 16);
            this.dd.TabIndex = 2;
            this.dd.Text = "nombre";
            // 
            // xx
            // 
            this.xx.AutoSize = true;
            this.xx.Location = new System.Drawing.Point(6, 80);
            this.xx.Name = "xx";
            this.xx.Size = new System.Drawing.Size(74, 16);
            this.xx.TabIndex = 1;
            this.xx.Text = "contraseña";
            // 
            // xd
            // 
            this.xd.AutoSize = true;
            this.xd.Location = new System.Drawing.Point(6, 32);
            this.xd.Name = "xd";
            this.xd.Size = new System.Drawing.Size(21, 16);
            this.xd.TabIndex = 0;
            this.xd.Text = "rut";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(882, 304);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(810, 13);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(164, 23);
            this.salir.TabIndex = 5;
            this.salir.Text = "Volver al menu";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(28, 12);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 6;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(134, 12);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 23);
            this.btneditar.TabIndex = 7;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(255, 13);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 8;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(786, 209);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(128, 22);
            this.txtbuscar.TabIndex = 14;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(659, 168);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 15;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(527, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "id_tipo_usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "id_empresa";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(634, 133);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(100, 22);
            this.txtusuario.TabIndex = 19;
            // 
            // cmbempresa
            // 
            this.cmbempresa.FormattingEnabled = true;
            this.cmbempresa.Location = new System.Drawing.Point(630, 78);
            this.cmbempresa.Name = "cmbempresa";
            this.cmbempresa.Size = new System.Drawing.Size(121, 24);
            this.cmbempresa.TabIndex = 20;
            // 
            // Crud_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 582);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Datos);
            this.Name = "Crud_usuarios";
            this.Text = "Crud_usuarios";
            this.Load += new System.EventHandler(this.Crud_usuarios_Load);
            this.Datos.ResumeLayout(false);
            this.Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox Datos;
        private System.Windows.Forms.Label xd;
        private System.Windows.Forms.Label qq;
        private System.Windows.Forms.Label aa;
        private System.Windows.Forms.Label dd;
        private System.Windows.Forms.Label xx;
        private System.Windows.Forms.Label xdd;
        private System.Windows.Forms.Label eee;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtapellido_m;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtapellido_p;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcontrasena;
        private System.Windows.Forms.TextBox txtrun;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.ComboBox cmbempresa;
    }
}