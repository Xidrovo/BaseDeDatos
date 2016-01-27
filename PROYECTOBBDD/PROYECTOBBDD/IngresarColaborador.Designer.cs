namespace PROYECTOBBDD
{
    partial class IngresarColaborador
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tCargo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tContrasena = new System.Windows.Forms.TextBox();
            this.tUsuario = new System.Windows.Forms.TextBox();
            this.tTelefono = new System.Windows.Forms.TextBox();
            this.tCedula = new System.Windows.Forms.TextBox();
            this.tApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tCargo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tContrasena);
            this.panel1.Controls.Add(this.tUsuario);
            this.panel1.Controls.Add(this.tTelefono);
            this.panel1.Controls.Add(this.tCedula);
            this.panel1.Controls.Add(this.tApellido);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tNombre);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 291);
            this.panel1.TabIndex = 0;
            // 
            // tCargo
            // 
            this.tCargo.FormattingEnabled = true;
            this.tCargo.Location = new System.Drawing.Point(104, 138);
            this.tCargo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tCargo.Name = "tCargo";
            this.tCargo.Size = new System.Drawing.Size(183, 21);
            this.tCargo.TabIndex = 3;
            this.tCargo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cargo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cédula";
            // 
            // tContrasena
            // 
            this.tContrasena.Location = new System.Drawing.Point(104, 246);
            this.tContrasena.MaxLength = 16;
            this.tContrasena.Name = "tContrasena";
            this.tContrasena.PasswordChar = '*';
            this.tContrasena.Size = new System.Drawing.Size(183, 20);
            this.tContrasena.TabIndex = 6;
            this.tContrasena.TextChanged += new System.EventHandler(this.tContrasena_TextChanged);
            // 
            // tUsuario
            // 
            this.tUsuario.Location = new System.Drawing.Point(104, 209);
            this.tUsuario.MaxLength = 10;
            this.tUsuario.Name = "tUsuario";
            this.tUsuario.Size = new System.Drawing.Size(183, 20);
            this.tUsuario.TabIndex = 5;
            this.tUsuario.TextChanged += new System.EventHandler(this.textBox6_TextChanged_1);
            this.tUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // tTelefono
            // 
            this.tTelefono.Location = new System.Drawing.Point(104, 172);
            this.tTelefono.MaxLength = 10;
            this.tTelefono.Name = "tTelefono";
            this.tTelefono.Size = new System.Drawing.Size(183, 20);
            this.tTelefono.TabIndex = 4;
            this.tTelefono.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.tTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // tCedula
            // 
            this.tCedula.Location = new System.Drawing.Point(104, 97);
            this.tCedula.MaxLength = 10;
            this.tCedula.Name = "tCedula";
            this.tCedula.Size = new System.Drawing.Size(183, 20);
            this.tCedula.TabIndex = 2;
            this.tCedula.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.tCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // tApellido
            // 
            this.tApellido.Location = new System.Drawing.Point(104, 58);
            this.tApellido.MaxLength = 40;
            this.tApellido.Name = "tApellido";
            this.tApellido.Size = new System.Drawing.Size(183, 20);
            this.tApellido.TabIndex = 1;
            this.tApellido.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            this.tApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(104, 19);
            this.tNombre.MaxLength = 40;
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(183, 20);
            this.tNombre.TabIndex = 0;
            this.tNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(13, 310);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 65);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IngresarColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 384);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "IngresarColaborador";
            this.Text = "Ingresar Colaborador";
            this.Load += new System.EventHandler(this.IngresarColaborador_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tContrasena;
        private System.Windows.Forms.TextBox tUsuario;
        private System.Windows.Forms.TextBox tTelefono;
        private System.Windows.Forms.TextBox tCedula;
        private System.Windows.Forms.TextBox tApellido;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox tCargo;
    }
}