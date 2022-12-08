namespace NMA_DESK.Vistas
{
    partial class Crear_usuario
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Nombres = new System.Windows.Forms.TextBox();
            this.Apellido_p = new System.Windows.Forms.TextBox();
            this.Apellido_m = new System.Windows.Forms.TextBox();
            this.run = new System.Windows.Forms.TextBox();
            this.fono = new System.Windows.Forms.TextBox();
            this.Correo = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Tipo_usuario = new System.Windows.Forms.TextBox();
            this.Id_empresa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido Paterno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teléfono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "RUT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(608, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(608, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Volver al menu ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Nombres
            // 
            this.Nombres.Location = new System.Drawing.Point(166, 41);
            this.Nombres.MaxLength = 50;
            this.Nombres.Name = "Nombres";
            this.Nombres.Size = new System.Drawing.Size(235, 22);
            this.Nombres.TabIndex = 14;
            // 
            // Apellido_p
            // 
            this.Apellido_p.Location = new System.Drawing.Point(166, 92);
            this.Apellido_p.MaxLength = 50;
            this.Apellido_p.Name = "Apellido_p";
            this.Apellido_p.Size = new System.Drawing.Size(235, 22);
            this.Apellido_p.TabIndex = 16;
            // 
            // Apellido_m
            // 
            this.Apellido_m.Location = new System.Drawing.Point(166, 142);
            this.Apellido_m.MaxLength = 50;
            this.Apellido_m.Name = "Apellido_m";
            this.Apellido_m.Size = new System.Drawing.Size(235, 22);
            this.Apellido_m.TabIndex = 17;
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(166, 199);
            this.run.MaxLength = 12;
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(235, 22);
            this.run.TabIndex = 18;
            // 
            // fono
            // 
            this.fono.Location = new System.Drawing.Point(166, 249);
            this.fono.MaxLength = 15;
            this.fono.Name = "fono";
            this.fono.Size = new System.Drawing.Size(235, 22);
            this.fono.TabIndex = 19;
            this.fono.TextChanged += new System.EventHandler(this.fono_TextChanged);
            // 
            // Correo
            // 
            this.Correo.Location = new System.Drawing.Point(166, 302);
            this.Correo.MaxLength = 50;
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(235, 22);
            this.Correo.TabIndex = 20;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(166, 360);
            this.Password.MaxLength = 20;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(235, 22);
            this.Password.TabIndex = 21;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Apellido Materno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(436, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "ID Empresa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(436, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Tipo de usuario";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Tipo_usuario
            // 
            this.Tipo_usuario.Location = new System.Drawing.Point(544, 47);
            this.Tipo_usuario.MaxLength = 20;
            this.Tipo_usuario.Name = "Tipo_usuario";
            this.Tipo_usuario.Size = new System.Drawing.Size(171, 22);
            this.Tipo_usuario.TabIndex = 27;
            // 
            // Id_empresa
            // 
            this.Id_empresa.Location = new System.Drawing.Point(544, 148);
            this.Id_empresa.Name = "Id_empresa";
            this.Id_empresa.Size = new System.Drawing.Size(171, 22);
            this.Id_empresa.TabIndex = 28;
            // 
            // Crear_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Id_empresa);
            this.Controls.Add(this.Tipo_usuario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.fono);
            this.Controls.Add(this.run);
            this.Controls.Add(this.Apellido_m);
            this.Controls.Add(this.Apellido_p);
            this.Controls.Add(this.Nombres);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Crear_usuario";
            this.Text = "Crear Usuario";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Nombres;
        private System.Windows.Forms.TextBox Apellido_p;
        private System.Windows.Forms.TextBox Apellido_m;
        private System.Windows.Forms.TextBox run;
        private System.Windows.Forms.TextBox fono;
        private System.Windows.Forms.TextBox Correo;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Tipo_usuario;
        private System.Windows.Forms.TextBox Id_empresa;
    }
}