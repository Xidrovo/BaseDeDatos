namespace PROYECTOBBDD
{
    partial class IngresarProveedor
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
            this.tdireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bQuitar = new System.Windows.Forms.Button();
            this.lagreagar = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lTelefono = new System.Windows.Forms.TextBox();
            this.lteléfono = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lnombreEmpresa = new System.Windows.Forms.Label();
            this.lruc = new System.Windows.Forms.Label();
            this.lapellido = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.tdireccion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bQuitar);
            this.panel1.Controls.Add(this.lagreagar);
            this.panel1.Controls.Add(this.bGuardar);
            this.panel1.Controls.Add(this.bCancelar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lnombreEmpresa);
            this.panel1.Controls.Add(this.lruc);
            this.panel1.Controls.Add(this.lapellido);
            this.panel1.Controls.Add(this.lNombre);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 450);
            this.panel1.TabIndex = 0;
            // 
            // tdireccion
            // 
            this.tdireccion.Location = new System.Drawing.Point(129, 210);
            this.tdireccion.MaxLength = 40;
            this.tdireccion.Name = "tdireccion";
            this.tdireccion.Size = new System.Drawing.Size(190, 20);
            this.tdireccion.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 210);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Dirección";
            // 
            // bQuitar
            // 
            this.bQuitar.Location = new System.Drawing.Point(224, 358);
            this.bQuitar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bQuitar.Name = "bQuitar";
            this.bQuitar.Size = new System.Drawing.Size(75, 23);
            this.bQuitar.TabIndex = 12;
            this.bQuitar.Text = "Quitar";
            this.bQuitar.UseVisualStyleBackColor = true;
            this.bQuitar.Click += new System.EventHandler(this.bQuitar_Click);
            // 
            // lagreagar
            // 
            this.lagreagar.Location = new System.Drawing.Point(119, 358);
            this.lagreagar.Name = "lagreagar";
            this.lagreagar.Size = new System.Drawing.Size(98, 23);
            this.lagreagar.TabIndex = 11;
            this.lagreagar.Text = "Agregar Telefono";
            this.lagreagar.UseVisualStyleBackColor = true;
            this.lagreagar.Click += new System.EventHandler(this.lagreagar_Click_1);
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(224, 418);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(75, 23);
            this.bGuardar.TabIndex = 10;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(45, 418);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 9;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.lTelefono);
            this.panel2.Controls.Add(this.lteléfono);
            this.panel2.Location = new System.Drawing.Point(10, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 99);
            this.panel2.TabIndex = 8;
            // 
            // lTelefono
            // 
            this.lTelefono.Location = new System.Drawing.Point(118, 9);
            this.lTelefono.MaxLength = 10;
            this.lTelefono.Name = "lTelefono";
            this.lTelefono.Size = new System.Drawing.Size(190, 20);
            this.lTelefono.TabIndex = 1;
            this.lTelefono.TextChanged += new System.EventHandler(this.lTelefono_TextChanged);
            this.lTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // lteléfono
            // 
            this.lteléfono.AutoSize = true;
            this.lteléfono.Location = new System.Drawing.Point(11, 9);
            this.lteléfono.Name = "lteléfono";
            this.lteléfono.Size = new System.Drawing.Size(49, 13);
            this.lteléfono.TabIndex = 0;
            this.lteléfono.Text = "Teléfono";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(129, 171);
            this.textBox4.MaxLength = 40;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(190, 20);
            this.textBox4.TabIndex = 7;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(129, 125);
            this.textBox3.MaxLength = 13;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(190, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(129, 76);
            this.textBox2.MaxLength = 40;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(190, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 32);
            this.textBox1.MaxLength = 40;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lnombreEmpresa
            // 
            this.lnombreEmpresa.AutoSize = true;
            this.lnombreEmpresa.Location = new System.Drawing.Point(22, 171);
            this.lnombreEmpresa.Name = "lnombreEmpresa";
            this.lnombreEmpresa.Size = new System.Drawing.Size(88, 13);
            this.lnombreEmpresa.TabIndex = 3;
            this.lnombreEmpresa.Text = "Nombre Empresa";
            // 
            // lruc
            // 
            this.lruc.AutoSize = true;
            this.lruc.Location = new System.Drawing.Point(22, 125);
            this.lruc.Name = "lruc";
            this.lruc.Size = new System.Drawing.Size(30, 13);
            this.lruc.TabIndex = 2;
            this.lruc.Text = "RUC";
            // 
            // lapellido
            // 
            this.lapellido.AutoSize = true;
            this.lapellido.Location = new System.Drawing.Point(22, 76);
            this.lapellido.Name = "lapellido";
            this.lapellido.Size = new System.Drawing.Size(44, 13);
            this.lapellido.TabIndex = 1;
            this.lapellido.Text = "Apellido";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(19, 32);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(44, 13);
            this.lNombre.TabIndex = 0;
            this.lNombre.Text = "Nombre";
            // 
            // IngresarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 473);
            this.Controls.Add(this.panel1);
            this.Name = "IngresarProveedor";
            this.Text = "Ingresar Proveedor";
            this.Load += new System.EventHandler(this.IngresarProveedor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lnombreEmpresa;
        private System.Windows.Forms.Label lruc;
        private System.Windows.Forms.Label lapellido;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lteléfono;
        private System.Windows.Forms.TextBox lTelefono;
        private System.Windows.Forms.Button lagreagar;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bQuitar;
        private System.Windows.Forms.TextBox tdireccion;
        private System.Windows.Forms.Label label1;
    }
}