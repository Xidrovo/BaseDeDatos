namespace PROYECTOBBDD
{
    partial class IngresarEmpresa
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
            this.bguardar = new System.Windows.Forms.Button();
            this.bcancelar = new System.Windows.Forms.Button();
            this.bagregar = new System.Windows.Forms.Button();
            this.contenedorARepetir = new System.Windows.Forms.Panel();
            this.lTelefono = new System.Windows.Forms.Label();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.tdireccion = new System.Windows.Forms.TextBox();
            this.trazonsocial = new System.Windows.Forms.TextBox();
            this.truc = new System.Windows.Forms.TextBox();
            this.ldireccion = new System.Windows.Forms.Label();
            this.lrazon_social = new System.Windows.Forms.Label();
            this.lruc = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.contenedorARepetir.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.bQuitar);
            this.panel1.Controls.Add(this.bguardar);
            this.panel1.Controls.Add(this.bcancelar);
            this.panel1.Controls.Add(this.bagregar);
            this.panel1.Controls.Add(this.contenedorARepetir);
            this.panel1.Controls.Add(this.tdireccion);
            this.panel1.Controls.Add(this.trazonsocial);
            this.panel1.Controls.Add(this.truc);
            this.panel1.Controls.Add(this.ldireccion);
            this.panel1.Controls.Add(this.lrazon_social);
            this.panel1.Controls.Add(this.lruc);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 480);
            this.panel1.TabIndex = 0;
            // 
            // bQuitar
            // 
            this.bQuitar.Location = new System.Drawing.Point(329, 335);
            this.bQuitar.Name = "bQuitar";
            this.bQuitar.Size = new System.Drawing.Size(75, 28);
            this.bQuitar.TabIndex = 11;
            this.bQuitar.Text = "Quitar";
            this.bQuitar.UseVisualStyleBackColor = true;
            this.bQuitar.Click += new System.EventHandler(this.bQuitar_Click);
            // 
            // bguardar
            // 
            this.bguardar.Location = new System.Drawing.Point(304, 423);
            this.bguardar.Margin = new System.Windows.Forms.Padding(4);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(100, 28);
            this.bguardar.TabIndex = 10;
            this.bguardar.Text = "Guardar";
            this.bguardar.UseVisualStyleBackColor = true;
            this.bguardar.Click += new System.EventHandler(this.button2_Click);
            // 
            // bcancelar
            // 
            this.bcancelar.Location = new System.Drawing.Point(59, 423);
            this.bcancelar.Margin = new System.Windows.Forms.Padding(4);
            this.bcancelar.Name = "bcancelar";
            this.bcancelar.Size = new System.Drawing.Size(100, 28);
            this.bcancelar.TabIndex = 9;
            this.bcancelar.Text = "Cancelar";
            this.bcancelar.UseVisualStyleBackColor = true;
            this.bcancelar.Click += new System.EventHandler(this.bcancelar_Click);
            // 
            // bagregar
            // 
            this.bagregar.Location = new System.Drawing.Point(161, 335);
            this.bagregar.Margin = new System.Windows.Forms.Padding(4);
            this.bagregar.Name = "bagregar";
            this.bagregar.Size = new System.Drawing.Size(130, 28);
            this.bagregar.TabIndex = 8;
            this.bagregar.Text = "Agregar Teléfono";
            this.bagregar.UseVisualStyleBackColor = true;
            this.bagregar.Click += new System.EventHandler(this.bagregar_Click);
            // 
            // contenedorARepetir
            // 
            this.contenedorARepetir.AutoScroll = true;
            this.contenedorARepetir.Controls.Add(this.lTelefono);
            this.contenedorARepetir.Controls.Add(this.textTelefono);
            this.contenedorARepetir.Location = new System.Drawing.Point(13, 190);
            this.contenedorARepetir.Margin = new System.Windows.Forms.Padding(4);
            this.contenedorARepetir.Name = "contenedorARepetir";
            this.contenedorARepetir.Size = new System.Drawing.Size(445, 138);
            this.contenedorARepetir.TabIndex = 7;
            // 
            // lTelefono
            // 
            this.lTelefono.AutoSize = true;
            this.lTelefono.Location = new System.Drawing.Point(11, 26);
            this.lTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTelefono.Name = "lTelefono";
            this.lTelefono.Size = new System.Drawing.Size(64, 17);
            this.lTelefono.TabIndex = 7;
            this.lTelefono.Text = "Teléfono";
            this.lTelefono.Click += new System.EventHandler(this.Teléfono_Click);
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(148, 22);
            this.textTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.textTelefono.MaxLength = 10;
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(251, 22);
            this.textTelefono.TabIndex = 6;
            this.textTelefono.TextChanged += new System.EventHandler(this.textTelefono_TextChanged_1);
            this.textTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // tdireccion
            // 
            this.tdireccion.Location = new System.Drawing.Point(165, 158);
            this.tdireccion.Margin = new System.Windows.Forms.Padding(4);
            this.tdireccion.MaxLength = 50;
            this.tdireccion.Name = "tdireccion";
            this.tdireccion.Size = new System.Drawing.Size(251, 22);
            this.tdireccion.TabIndex = 5;
            this.tdireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // trazonsocial
            // 
            this.trazonsocial.Location = new System.Drawing.Point(165, 103);
            this.trazonsocial.Margin = new System.Windows.Forms.Padding(4);
            this.trazonsocial.MaxLength = 50;
            this.trazonsocial.Name = "trazonsocial";
            this.trazonsocial.Size = new System.Drawing.Size(251, 22);
            this.trazonsocial.TabIndex = 4;
            this.trazonsocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // truc
            // 
            this.truc.Location = new System.Drawing.Point(165, 42);
            this.truc.Margin = new System.Windows.Forms.Padding(4);
            this.truc.MaxLength = 13;
            this.truc.Name = "truc";
            this.truc.Size = new System.Drawing.Size(251, 22);
            this.truc.TabIndex = 3;
            this.truc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.truc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // ldireccion
            // 
            this.ldireccion.AutoSize = true;
            this.ldireccion.Location = new System.Drawing.Point(17, 158);
            this.ldireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ldireccion.Name = "ldireccion";
            this.ldireccion.Size = new System.Drawing.Size(67, 17);
            this.ldireccion.TabIndex = 2;
            this.ldireccion.Text = "Dirección";
            // 
            // lrazon_social
            // 
            this.lrazon_social.AutoSize = true;
            this.lrazon_social.Location = new System.Drawing.Point(17, 108);
            this.lrazon_social.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lrazon_social.Name = "lrazon_social";
            this.lrazon_social.Size = new System.Drawing.Size(91, 17);
            this.lrazon_social.TabIndex = 1;
            this.lrazon_social.Text = "Razón Social";
            // 
            // lruc
            // 
            this.lruc.AutoSize = true;
            this.lruc.Location = new System.Drawing.Point(17, 42);
            this.lruc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lruc.Name = "lruc";
            this.lruc.Size = new System.Drawing.Size(37, 17);
            this.lruc.TabIndex = 0;
            this.lruc.Text = "RUC";
            this.lruc.Click += new System.EventHandler(this.label1_Click);
            // 
            // IngresarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 511);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IngresarEmpresa";
            this.Text = "Ingresar Empresa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contenedorARepetir.ResumeLayout(false);
            this.contenedorARepetir.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lruc;
        private System.Windows.Forms.TextBox tdireccion;
        private System.Windows.Forms.TextBox trazonsocial;
        private System.Windows.Forms.TextBox truc;
        private System.Windows.Forms.Label ldireccion;
        private System.Windows.Forms.Label lrazon_social;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.Panel contenedorARepetir;
        private System.Windows.Forms.Label lTelefono;
        private System.Windows.Forms.Button bguardar;
        private System.Windows.Forms.Button bcancelar;
        private System.Windows.Forms.Button bagregar;
        private System.Windows.Forms.Button bQuitar;
    }
}