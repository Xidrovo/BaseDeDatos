namespace PROYECTOBBDD
{
    partial class IngresarProducto
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
            this.bGuardar = new System.Windows.Forms.Button();
            this.bcancelar = new System.Windows.Forms.Button();
            this.tDescripcion = new System.Windows.Forms.TextBox();
            this.tCantidad = new System.Windows.Forms.TextBox();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.ldescripcion = new System.Windows.Forms.Label();
            this.lcantidad = new System.Windows.Forms.Label();
            this.lnombre = new System.Windows.Forms.Label();
            this.lproveedor = new System.Windows.Forms.Label();
            this.cbProveedores = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cbProveedores);
            this.panel1.Controls.Add(this.lproveedor);
            this.panel1.Controls.Add(this.bGuardar);
            this.panel1.Controls.Add(this.bcancelar);
            this.panel1.Controls.Add(this.tDescripcion);
            this.panel1.Controls.Add(this.tCantidad);
            this.panel1.Controls.Add(this.tNombre);
            this.panel1.Controls.Add(this.ldescripcion);
            this.panel1.Controls.Add(this.lcantidad);
            this.panel1.Controls.Add(this.lnombre);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 359);
            this.panel1.TabIndex = 0;
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(187, 309);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(75, 23);
            this.bGuardar.TabIndex = 9;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // bcancelar
            // 
            this.bcancelar.Location = new System.Drawing.Point(41, 309);
            this.bcancelar.Name = "bcancelar";
            this.bcancelar.Size = new System.Drawing.Size(75, 23);
            this.bcancelar.TabIndex = 8;
            this.bcancelar.Text = "Cancelar";
            this.bcancelar.UseVisualStyleBackColor = true;
            this.bcancelar.Click += new System.EventHandler(this.bcancelar_Click);
            // 
            // tDescripcion
            // 
            this.tDescripcion.Location = new System.Drawing.Point(94, 165);
            this.tDescripcion.MaxLength = 20;
            this.tDescripcion.Multiline = true;
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.Size = new System.Drawing.Size(198, 90);
            this.tDescripcion.TabIndex = 7;
            this.tDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tDescripcion_KeyPress);
            // 
            // tCantidad
            // 
            this.tCantidad.Location = new System.Drawing.Point(94, 119);
            this.tCantidad.MaxLength = 7;
            this.tCantidad.Name = "tCantidad";
            this.tCantidad.Size = new System.Drawing.Size(198, 20);
            this.tCantidad.TabIndex = 5;
            this.tCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tCantidad_KeyPress);
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(94, 77);
            this.tNombre.MaxLength = 20;
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(198, 20);
            this.tNombre.TabIndex = 4;
            this.tNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tNombre_KeyPress);
            // 
            // ldescripcion
            // 
            this.ldescripcion.AutoSize = true;
            this.ldescripcion.Location = new System.Drawing.Point(19, 165);
            this.ldescripcion.Name = "ldescripcion";
            this.ldescripcion.Size = new System.Drawing.Size(63, 13);
            this.ldescripcion.TabIndex = 3;
            this.ldescripcion.Text = "Descripción";
            // 
            // lcantidad
            // 
            this.lcantidad.AutoSize = true;
            this.lcantidad.Location = new System.Drawing.Point(19, 119);
            this.lcantidad.Name = "lcantidad";
            this.lcantidad.Size = new System.Drawing.Size(49, 13);
            this.lcantidad.TabIndex = 1;
            this.lcantidad.Text = "Cantidad";
            // 
            // lnombre
            // 
            this.lnombre.AutoSize = true;
            this.lnombre.Location = new System.Drawing.Point(19, 77);
            this.lnombre.Name = "lnombre";
            this.lnombre.Size = new System.Drawing.Size(44, 13);
            this.lnombre.TabIndex = 0;
            this.lnombre.Text = "Nombre";
            // 
            // lproveedor
            // 
            this.lproveedor.AutoSize = true;
            this.lproveedor.Location = new System.Drawing.Point(19, 27);
            this.lproveedor.Name = "lproveedor";
            this.lproveedor.Size = new System.Drawing.Size(56, 13);
            this.lproveedor.TabIndex = 10;
            this.lproveedor.Text = "Proveedor";
            // 
            // cbProveedores
            // 
            this.cbProveedores.FormattingEnabled = true;
            this.cbProveedores.Location = new System.Drawing.Point(94, 27);
            this.cbProveedores.Name = "cbProveedores";
            this.cbProveedores.Size = new System.Drawing.Size(198, 21);
            this.cbProveedores.TabIndex = 11;
            this.cbProveedores.SelectedIndexChanged += new System.EventHandler(this.cbProveedores_SelectedIndexChanged);
            // 
            // IngresarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 384);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "IngresarProducto";
            this.Text = "Ingresar Producto";
            this.Load += new System.EventHandler(this.IngresarProducto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lcantidad;
        private System.Windows.Forms.Label lnombre;
        private System.Windows.Forms.TextBox tDescripcion;
        private System.Windows.Forms.TextBox tCantidad;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.Label ldescripcion;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button bcancelar;
        private System.Windows.Forms.ComboBox cbProveedores;
        private System.Windows.Forms.Label lproveedor;
    }
}