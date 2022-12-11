namespace NMA_DESK.Vistas
{
    partial class CRUD_usuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtrun = new System.Windows.Forms.TextBox();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.txtapellido_p = new System.Windows.Forms.TextBox();
            this.txtapellido_m = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtelefono = new System.Windows.Forms.TextBox();
            this.txt_id_empresa = new System.Windows.Forms.TextBox();
            this.txt_tipo_usuario = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Lista_usuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Lista_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rut";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido paterno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Apellido Materno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Telléfono";
            this.label7.Click += new System.EventHandler(this.txtelefono_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "ID_empresa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tipo de usuario";
            // 
            // txtrun
            // 
            this.txtrun.Location = new System.Drawing.Point(143, 29);
            this.txtrun.Name = "txtrun";
            this.txtrun.Size = new System.Drawing.Size(225, 22);
            this.txtrun.TabIndex = 10;
            this.txtrun.TextChanged += new System.EventHandler(this.txtrun_TextChanged);
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Location = new System.Drawing.Point(143, 64);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.Size = new System.Drawing.Size(225, 22);
            this.txtcontrasena.TabIndex = 11;
            // 
            // txtnombres
            // 
            this.txtnombres.Location = new System.Drawing.Point(143, 106);
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(225, 22);
            this.txtnombres.TabIndex = 12;
            // 
            // txtapellido_p
            // 
            this.txtapellido_p.Location = new System.Drawing.Point(143, 144);
            this.txtapellido_p.Name = "txtapellido_p";
            this.txtapellido_p.Size = new System.Drawing.Size(225, 22);
            this.txtapellido_p.TabIndex = 13;
            // 
            // txtapellido_m
            // 
            this.txtapellido_m.Location = new System.Drawing.Point(143, 184);
            this.txtapellido_m.Name = "txtapellido_m";
            this.txtapellido_m.Size = new System.Drawing.Size(225, 22);
            this.txtapellido_m.TabIndex = 14;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(143, 222);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(225, 22);
            this.txtcorreo.TabIndex = 15;
            // 
            // txtelefono
            // 
            this.txtelefono.Location = new System.Drawing.Point(143, 259);
            this.txtelefono.Name = "txtelefono";
            this.txtelefono.Size = new System.Drawing.Size(225, 22);
            this.txtelefono.TabIndex = 16;
            // 
            // txt_id_empresa
            // 
            this.txt_id_empresa.Location = new System.Drawing.Point(143, 294);
            this.txt_id_empresa.Name = "txt_id_empresa";
            this.txt_id_empresa.Size = new System.Drawing.Size(225, 22);
            this.txt_id_empresa.TabIndex = 17;
            // 
            // txt_tipo_usuario
            // 
            this.txt_tipo_usuario.Location = new System.Drawing.Point(143, 338);
            this.txt_tipo_usuario.Name = "txt_tipo_usuario";
            this.txt_tipo_usuario.Size = new System.Drawing.Size(225, 22);
            this.txt_tipo_usuario.TabIndex = 18;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(34, 406);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(146, 23);
            this.btn_guardar.TabIndex = 19;
            this.btn_guardar.Text = "Guardar usuario";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(429, 29);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 20;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(34, 455);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(151, 23);
            this.btn_modificar.TabIndex = 21;
            this.btn_modificar.Text = "Modificar usuario";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(34, 505);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(146, 23);
            this.btn_eliminar.TabIndex = 22;
            this.btn_eliminar.Text = "Eliminar usuario";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(986, 541);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 23;
            this.button5.Text = "Salir";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Lista_usuarios
            // 
            this.Lista_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Lista_usuarios.Location = new System.Drawing.Point(429, 67);
            this.Lista_usuarios.Name = "Lista_usuarios";
            this.Lista_usuarios.RowHeadersWidth = 51;
            this.Lista_usuarios.RowTemplate.Height = 24;
            this.Lista_usuarios.Size = new System.Drawing.Size(632, 350);
            this.Lista_usuarios.TabIndex = 24;
            this.Lista_usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CRUD_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 586);
            this.Controls.Add(this.Lista_usuarios);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_tipo_usuario);
            this.Controls.Add(this.txt_id_empresa);
            this.Controls.Add(this.txtelefono);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txtapellido_m);
            this.Controls.Add(this.txtapellido_p);
            this.Controls.Add(this.txtnombres);
            this.Controls.Add(this.txtcontrasena);
            this.Controls.Add(this.txtrun);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CRUD_usuario";
            this.Text = "CRUD_usuario";
            ((System.ComponentModel.ISupportInitialize)(this.Lista_usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtrun;
        private System.Windows.Forms.TextBox txtcontrasena;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.TextBox txtapellido_p;
        private System.Windows.Forms.TextBox txtapellido_m;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txtelefono;
        private System.Windows.Forms.TextBox txt_id_empresa;
        private System.Windows.Forms.TextBox txt_tipo_usuario;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView Lista_usuarios;
    }
}