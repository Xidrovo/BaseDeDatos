namespace PROYECTOBBDD
{
    partial class IngresarPersonaNatural
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
            this.bQuitar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.lTelefono = new System.Windows.Forms.Label();
            this.bAgregar = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.bcancelar = new System.Windows.Forms.Button();
            this.tdireccion = new System.Windows.Forms.TextBox();
            this.tcedula = new System.Windows.Forms.TextBox();
            this.tapellido = new System.Windows.Forms.TextBox();
            this.tnombres = new System.Windows.Forms.TextBox();
            this.ldirección = new System.Windows.Forms.Label();
            this.lcedula = new System.Windows.Forms.Label();
            this.lapellido = new System.Windows.Forms.Label();
            this.lnombre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.bQuitar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.bAgregar);
            this.panel1.Controls.Add(this.BGuardar);
            this.panel1.Controls.Add(this.bcancelar);
            this.panel1.Controls.Add(this.tdireccion);
            this.panel1.Controls.Add(this.tcedula);
            this.panel1.Controls.Add(this.tapellido);
            this.panel1.Controls.Add(this.tnombres);
            this.panel1.Controls.Add(this.ldirección);
            this.panel1.Controls.Add(this.lcedula);
            this.panel1.Controls.Add(this.lapellido);
            this.panel1.Controls.Add(this.lnombre);
            this.panel1.Location = new System.Drawing.Point(17, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 514);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bQuitar
            // 
            this.bQuitar.Location = new System.Drawing.Point(308, 388);
            this.bQuitar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bQuitar.Name = "bQuitar";
            this.bQuitar.Size = new System.Drawing.Size(75, 28);
            this.bQuitar.TabIndex = 5;
            this.bQuitar.Text = "Quitar";
            this.bQuitar.UseVisualStyleBackColor = true;
            this.bQuitar.Click += new System.EventHandler(this.bQuitar_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.textTelefono);
            this.panel2.Controls.Add(this.lTelefono);
            this.panel2.Location = new System.Drawing.Point(19, 249);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 132);
            this.panel2.TabIndex = 13;
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(108, 25);
            this.textTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textTelefono.MaxLength = 10;
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(279, 22);
            this.textTelefono.TabIndex = 0;
            this.textTelefono.TextChanged += new System.EventHandler(this.textTelefono_TextChanged_1);
            this.textTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // lTelefono
            // 
            this.lTelefono.AutoSize = true;
            this.lTelefono.Location = new System.Drawing.Point(9, 25);
            this.lTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTelefono.Name = "lTelefono";
            this.lTelefono.Size = new System.Drawing.Size(64, 17);
            this.lTelefono.TabIndex = 1;
            this.lTelefono.Text = "Teléfono";
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(161, 389);
            this.bAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(131, 28);
            this.bAgregar.TabIndex = 4;
            this.bAgregar.Text = "Agregar Teléfono";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // BGuardar
            // 
            this.BGuardar.Location = new System.Drawing.Point(283, 469);
            this.BGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(100, 28);
            this.BGuardar.TabIndex = 6;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // bcancelar
            // 
            this.bcancelar.Location = new System.Drawing.Point(48, 469);
            this.bcancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bcancelar.Name = "bcancelar";
            this.bcancelar.Size = new System.Drawing.Size(100, 28);
            this.bcancelar.TabIndex = 7;
            this.bcancelar.Text = "Cancelar";
            this.bcancelar.UseVisualStyleBackColor = true;
            this.bcancelar.Click += new System.EventHandler(this.bcancelar_Click);
            // 
            // tdireccion
            // 
            this.tdireccion.Location = new System.Drawing.Point(127, 214);
            this.tdireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tdireccion.MaxLength = 50;
            this.tdireccion.Name = "tdireccion";
            this.tdireccion.Size = new System.Drawing.Size(279, 22);
            this.tdireccion.TabIndex = 3;
            this.tdireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // tcedula
            // 
            this.tcedula.Location = new System.Drawing.Point(127, 153);
            this.tcedula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tcedula.MaxLength = 10;
            this.tcedula.Name = "tcedula";
            this.tcedula.Size = new System.Drawing.Size(279, 22);
            this.tcedula.TabIndex = 2;
            this.tcedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // tapellido
            // 
            this.tapellido.Location = new System.Drawing.Point(127, 81);
            this.tapellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tapellido.MaxLength = 20;
            this.tapellido.Name = "tapellido";
            this.tapellido.Size = new System.Drawing.Size(279, 22);
            this.tapellido.TabIndex = 1;
            this.tapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // tnombres
            // 
            this.tnombres.BackColor = System.Drawing.Color.White;
            this.tnombres.Location = new System.Drawing.Point(127, 36);
            this.tnombres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tnombres.MaxLength = 20;
            this.tnombres.Name = "tnombres";
            this.tnombres.Size = new System.Drawing.Size(279, 22);
            this.tnombres.TabIndex = 0;
            this.tnombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // ldirección
            // 
            this.ldirección.AutoSize = true;
            this.ldirección.Location = new System.Drawing.Point(24, 214);
            this.ldirección.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ldirección.Name = "ldirección";
            this.ldirección.Size = new System.Drawing.Size(67, 17);
            this.ldirección.TabIndex = 3;
            this.ldirección.Text = "Dirección";
            // 
            // lcedula
            // 
            this.lcedula.AutoSize = true;
            this.lcedula.Location = new System.Drawing.Point(24, 153);
            this.lcedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lcedula.Name = "lcedula";
            this.lcedula.Size = new System.Drawing.Size(52, 17);
            this.lcedula.TabIndex = 2;
            this.lcedula.Text = "Cédula";
            // 
            // lapellido
            // 
            this.lapellido.AutoSize = true;
            this.lapellido.Location = new System.Drawing.Point(24, 91);
            this.lapellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lapellido.Name = "lapellido";
            this.lapellido.Size = new System.Drawing.Size(58, 17);
            this.lapellido.TabIndex = 1;
            this.lapellido.Text = "Apellido";
            // 
            // lnombre
            // 
            this.lnombre.AutoSize = true;
            this.lnombre.Location = new System.Drawing.Point(24, 36);
            this.lnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnombre.Name = "lnombre";
            this.lnombre.Size = new System.Drawing.Size(58, 17);
            this.lnombre.TabIndex = 0;
            this.lnombre.Text = "Nombre";
            // 
            // IngresarPersonaNatural
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 545);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "IngresarPersonaNatural";
            this.Text = "IngresarPersonaNatural";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IngresarPersonaNatural_FormClosed);
            this.Load += new System.EventHandler(this.IngresarPersonaNatural_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lnombre;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.TextBox tdireccion;
        private System.Windows.Forms.TextBox tcedula;
        private System.Windows.Forms.TextBox tapellido;
        private System.Windows.Forms.TextBox tnombres;
        private System.Windows.Forms.Label lTelefono;
        private System.Windows.Forms.Label ldirección;
        private System.Windows.Forms.Label lcedula;
        private System.Windows.Forms.Label lapellido;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button bcancelar;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bQuitar;
    }
}