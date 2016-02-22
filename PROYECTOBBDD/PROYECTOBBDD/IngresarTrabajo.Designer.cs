namespace PROYECTOBBDD
{
    partial class IngresarTrabajo
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
            this.contIngTra = new System.Windows.Forms.Panel();
            this.bQuitar = new System.Windows.Forms.Button();
            this.Agregar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tvalor = new System.Windows.Forms.TextBox();
            this.lDescripcion = new System.Windows.Forms.Label();
            this.tDescripcion = new System.Windows.Forms.TextBox();
            this.tcantidad = new System.Windows.Forms.TextBox();
            this.lvalor = new System.Windows.Forms.Label();
            this.lcantidad = new System.Windows.Forms.Label();
            this.EtiquetaDatos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabono = new System.Windows.Forms.TextBox();
            this.labono = new System.Windows.Forms.Label();
            this.lIdcliente = new System.Windows.Forms.Label();
            this.lFecha_entrega = new System.Windows.Forms.Label();
            this.dfechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.lFecPed = new System.Windows.Forms.Label();
            this.dfechaPedido = new System.Windows.Forms.DateTimePicker();
            this.contIngTra.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contIngTra
            // 
            this.contIngTra.AutoScroll = true;
            this.contIngTra.BackColor = System.Drawing.Color.White;
            this.contIngTra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.contIngTra.Controls.Add(this.bQuitar);
            this.contIngTra.Controls.Add(this.Agregar);
            this.contIngTra.Controls.Add(this.Guardar);
            this.contIngTra.Controls.Add(this.bCancelar);
            this.contIngTra.Controls.Add(this.label1);
            this.contIngTra.Controls.Add(this.panel2);
            this.contIngTra.Controls.Add(this.EtiquetaDatos);
            this.contIngTra.Controls.Add(this.panel1);
            this.contIngTra.Location = new System.Drawing.Point(12, 12);
            this.contIngTra.Name = "contIngTra";
            this.contIngTra.Size = new System.Drawing.Size(619, 491);
            this.contIngTra.TabIndex = 0;
            this.contIngTra.Paint += new System.Windows.Forms.PaintEventHandler(this.contIngTra_Paint);
            // 
            // bQuitar
            // 
            this.bQuitar.Location = new System.Drawing.Point(519, 375);
            this.bQuitar.Margin = new System.Windows.Forms.Padding(2);
            this.bQuitar.Name = "bQuitar";
            this.bQuitar.Size = new System.Drawing.Size(56, 27);
            this.bQuitar.TabIndex = 12;
            this.bQuitar.Text = "Quitar";
            this.bQuitar.UseVisualStyleBackColor = true;
            this.bQuitar.Click += new System.EventHandler(this.bQuitar_Click);
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(27, 376);
            this.Agregar.Margin = new System.Windows.Forms.Padding(2);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(100, 26);
            this.Agregar.TabIndex = 11;
            this.Agregar.Text = "Agregar trabajo";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(340, 445);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 10;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(99, 445);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 9;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Detalles";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tvalor);
            this.panel2.Controls.Add(this.lDescripcion);
            this.panel2.Controls.Add(this.tDescripcion);
            this.panel2.Controls.Add(this.tcantidad);
            this.panel2.Controls.Add(this.lvalor);
            this.panel2.Controls.Add(this.lcantidad);
            this.panel2.Location = new System.Drawing.Point(20, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 200);
            this.panel2.TabIndex = 7;
            // 
            // tvalor
            // 
            this.tvalor.Location = new System.Drawing.Point(453, 30);
            this.tvalor.MaxLength = 7;
            this.tvalor.Name = "tvalor";
            this.tvalor.Size = new System.Drawing.Size(100, 20);
            this.tvalor.TabIndex = 3;
            this.tvalor.TextChanged += new System.EventHandler(this.tvalor_TextChanged);
            this.tvalor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tvalor_KeyPress);
            this.tvalor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tvalor_KeyUp);
            // 
            // lDescripcion
            // 
            this.lDescripcion.AutoSize = true;
            this.lDescripcion.Location = new System.Drawing.Point(39, 79);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lDescripcion.TabIndex = 5;
            this.lDescripcion.Text = "Descripción";
            this.lDescripcion.Click += new System.EventHandler(this.label2_Click);
            // 
            // tDescripcion
            // 
            this.tDescripcion.Location = new System.Drawing.Point(147, 76);
            this.tDescripcion.MaxLength = 50;
            this.tDescripcion.Multiline = true;
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tDescripcion.Size = new System.Drawing.Size(386, 67);
            this.tDescripcion.TabIndex = 4;
            this.tDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tDescripcion_KeyPress);
            // 
            // tcantidad
            // 
            this.tcantidad.Location = new System.Drawing.Point(92, 30);
            this.tcantidad.MaxLength = 7;
            this.tcantidad.Name = "tcantidad";
            this.tcantidad.Size = new System.Drawing.Size(100, 20);
            this.tcantidad.TabIndex = 2;
            this.tcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tcantidad_KeyPress);
            // 
            // lvalor
            // 
            this.lvalor.AutoSize = true;
            this.lvalor.Location = new System.Drawing.Point(413, 30);
            this.lvalor.Name = "lvalor";
            this.lvalor.Size = new System.Drawing.Size(31, 13);
            this.lvalor.TabIndex = 1;
            this.lvalor.Text = "Valor";
            // 
            // lcantidad
            // 
            this.lcantidad.AutoSize = true;
            this.lcantidad.Location = new System.Drawing.Point(36, 30);
            this.lcantidad.Name = "lcantidad";
            this.lcantidad.Size = new System.Drawing.Size(49, 13);
            this.lcantidad.TabIndex = 0;
            this.lcantidad.Text = "Cantidad";
            // 
            // EtiquetaDatos
            // 
            this.EtiquetaDatos.AutoSize = true;
            this.EtiquetaDatos.Location = new System.Drawing.Point(40, 10);
            this.EtiquetaDatos.Name = "EtiquetaDatos";
            this.EtiquetaDatos.Size = new System.Drawing.Size(132, 13);
            this.EtiquetaDatos.TabIndex = 6;
            this.EtiquetaDatos.Text = "Datos de Orden de trabajo";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.tabono);
            this.panel1.Controls.Add(this.labono);
            this.panel1.Controls.Add(this.lIdcliente);
            this.panel1.Controls.Add(this.lFecha_entrega);
            this.panel1.Controls.Add(this.dfechaEntrega);
            this.panel1.Controls.Add(this.lFecPed);
            this.panel1.Controls.Add(this.dfechaPedido);
            this.panel1.Location = new System.Drawing.Point(20, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 114);
            this.panel1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(113, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // tabono
            // 
            this.tabono.Location = new System.Drawing.Point(453, 71);
            this.tabono.MaxLength = 6;
            this.tabono.Name = "tabono";
            this.tabono.Size = new System.Drawing.Size(100, 20);
            this.tabono.TabIndex = 8;
            this.tabono.TextChanged += new System.EventHandler(this.tabono_TextChanged);
            this.tabono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabono_KeyPress);
            // 
            // labono
            // 
            this.labono.AutoSize = true;
            this.labono.Location = new System.Drawing.Point(344, 74);
            this.labono.Name = "labono";
            this.labono.Size = new System.Drawing.Size(38, 13);
            this.labono.TabIndex = 6;
            this.labono.Text = "Abono";
            // 
            // lIdcliente
            // 
            this.lIdcliente.AutoSize = true;
            this.lIdcliente.Location = new System.Drawing.Point(17, 71);
            this.lIdcliente.Name = "lIdcliente";
            this.lIdcliente.Size = new System.Drawing.Size(95, 13);
            this.lIdcliente.TabIndex = 5;
            this.lIdcliente.Text = "Nombre del cliente";
            this.lIdcliente.Click += new System.EventHandler(this.lIdcliente_Click);
            // 
            // lFecha_entrega
            // 
            this.lFecha_entrega.AutoSize = true;
            this.lFecha_entrega.Location = new System.Drawing.Point(344, 37);
            this.lFecha_entrega.Name = "lFecha_entrega";
            this.lFecha_entrega.Size = new System.Drawing.Size(77, 13);
            this.lFecha_entrega.TabIndex = 1;
            this.lFecha_entrega.Text = "Fecha Entrega";
            this.lFecha_entrega.Click += new System.EventHandler(this.lFecha_entrega_Click);
            // 
            // dfechaEntrega
            // 
            this.dfechaEntrega.CustomFormat = "yyyy-MM-dd";
            this.dfechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dfechaEntrega.Location = new System.Drawing.Point(453, 35);
            this.dfechaEntrega.Name = "dfechaEntrega";
            this.dfechaEntrega.Size = new System.Drawing.Size(100, 20);
            this.dfechaEntrega.TabIndex = 4;
            this.dfechaEntrega.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            this.dfechaEntrega.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dfechaEntrega_KeyPress);
            // 
            // lFecPed
            // 
            this.lFecPed.AutoSize = true;
            this.lFecPed.Location = new System.Drawing.Point(34, 35);
            this.lFecPed.Name = "lFecPed";
            this.lFecPed.Size = new System.Drawing.Size(73, 13);
            this.lFecPed.TabIndex = 0;
            this.lFecPed.Text = "Fecha Pedido";
            this.lFecPed.Click += new System.EventHandler(this.lFecPed_Click);
            // 
            // dfechaPedido
            // 
            this.dfechaPedido.CustomFormat = "yyyy-MM-dd";
            this.dfechaPedido.Enabled = false;
            this.dfechaPedido.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dfechaPedido.Location = new System.Drawing.Point(113, 30);
            this.dfechaPedido.Name = "dfechaPedido";
            this.dfechaPedido.Size = new System.Drawing.Size(192, 20);
            this.dfechaPedido.TabIndex = 3;
            this.dfechaPedido.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // IngresarTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(643, 515);
            this.Controls.Add(this.contIngTra);
            this.Name = "IngresarTrabajo";
            this.Text = "Ingresar Trabajo";
            this.Load += new System.EventHandler(this.IngresarTrabajo_Load);
            this.contIngTra.ResumeLayout(false);
            this.contIngTra.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contIngTra;
        private System.Windows.Forms.DateTimePicker dfechaPedido;
        private System.Windows.Forms.Label lFecha_entrega;
        private System.Windows.Forms.Label lFecPed;
        private System.Windows.Forms.DateTimePicker dfechaEntrega;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label EtiquetaDatos;
        private System.Windows.Forms.TextBox tabono;
        private System.Windows.Forms.Label labono;
        private System.Windows.Forms.Label lIdcliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tvalor;
        private System.Windows.Forms.TextBox tcantidad;
        private System.Windows.Forms.Label lvalor;
        private System.Windows.Forms.Label lcantidad;
        private System.Windows.Forms.TextBox tDescripcion;
        private System.Windows.Forms.Label lDescripcion;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button bQuitar;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}