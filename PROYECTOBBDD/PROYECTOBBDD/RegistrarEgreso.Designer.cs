namespace PROYECTOBBDD
{
    partial class RegistrarEgreso
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
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tIdProveedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tCedulaColab = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tNumFactura = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tDescripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tDescripcion);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(17, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 536);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Parámetros del Registro";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tValor);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tIdProveedor);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tCedulaColab);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.tNumFactura);
            this.panel2.Location = new System.Drawing.Point(29, 31);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 202);
            this.panel2.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número de factura";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Recibido";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cedula Colaborador";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tValor
            // 
            this.tValor.Location = new System.Drawing.Point(451, 149);
            this.tValor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tValor.MaxLength = 7;
            this.tValor.Name = "tValor";
            this.tValor.Size = new System.Drawing.Size(132, 22);
            this.tValor.TabIndex = 11;
            this.tValor.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.tValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Id Proveedor";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tIdProveedor
            // 
            this.tIdProveedor.Location = new System.Drawing.Point(177, 153);
            this.tIdProveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tIdProveedor.MaxLength = 7;
            this.tIdProveedor.Name = "tIdProveedor";
            this.tIdProveedor.Size = new System.Drawing.Size(132, 22);
            this.tIdProveedor.TabIndex = 10;
            this.tIdProveedor.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.tIdProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tCedulaColab
            // 
            this.tCedulaColab.Location = new System.Drawing.Point(451, 94);
            this.tCedulaColab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tCedulaColab.MaxLength = 10;
            this.tCedulaColab.Name = "tCedulaColab";
            this.tCedulaColab.Size = new System.Drawing.Size(132, 22);
            this.tCedulaColab.TabIndex = 9;
            this.tCedulaColab.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.tCedulaColab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(177, 33);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(128, 22);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // tNumFactura
            // 
            this.tNumFactura.Location = new System.Drawing.Point(173, 92);
            this.tNumFactura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tNumFactura.MaxLength = 7;
            this.tNumFactura.Name = "tNumFactura";
            this.tNumFactura.Size = new System.Drawing.Size(132, 22);
            this.tNumFactura.TabIndex = 8;
            this.tNumFactura.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.tNumFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(392, 454);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 13;
            this.button2.Text = "Registrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 454);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tDescripcion
            // 
            this.tDescripcion.Location = new System.Drawing.Point(87, 282);
            this.tDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tDescripcion.MaxLength = 50;
            this.tDescripcion.Multiline = true;
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tDescripcion.Size = new System.Drawing.Size(437, 96);
            this.tDescripcion.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 249);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Descripción";
            // 
            // RegistrarEgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 567);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegistrarEgreso";
            this.Text = "RegistrarEgreso";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tValor;
        private System.Windows.Forms.TextBox tIdProveedor;
        private System.Windows.Forms.TextBox tCedulaColab;
        private System.Windows.Forms.TextBox tNumFactura;
        private System.Windows.Forms.TextBox tDescripcion;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
    }
}