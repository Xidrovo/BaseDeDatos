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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.bGuardar);
            this.panel1.Controls.Add(this.bcancelar);
            this.panel1.Controls.Add(this.tDescripcion);
            this.panel1.Controls.Add(this.tCantidad);
            this.panel1.Controls.Add(this.tNombre);
            this.panel1.Controls.Add(this.ldescripcion);
            this.panel1.Controls.Add(this.lcantidad);
            this.panel1.Controls.Add(this.lnombre);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(17, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 441);
            this.panel1.TabIndex = 0;
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(249, 380);
            this.bGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(100, 28);
            this.bGuardar.TabIndex = 9;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // bcancelar
            // 
            this.bcancelar.Location = new System.Drawing.Point(55, 380);
            this.bcancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bcancelar.Name = "bcancelar";
            this.bcancelar.Size = new System.Drawing.Size(100, 28);
            this.bcancelar.TabIndex = 8;
            this.bcancelar.Text = "Cancelar";
            this.bcancelar.UseVisualStyleBackColor = true;
            this.bcancelar.Click += new System.EventHandler(this.bcancelar_Click);
            // 
            // tDescripcion
            // 
            this.tDescripcion.Location = new System.Drawing.Point(125, 163);
            this.tDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tDescripcion.MaxLength = 20;
            this.tDescripcion.Multiline = true;
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.Size = new System.Drawing.Size(263, 110);
            this.tDescripcion.TabIndex = 7;
            this.tDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tDescripcion_KeyPress);
            // 
            // tCantidad
            // 
            this.tCantidad.Location = new System.Drawing.Point(125, 90);
            this.tCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tCantidad.MaxLength = 7;
            this.tCantidad.Name = "tCantidad";
            this.tCantidad.Size = new System.Drawing.Size(263, 22);
            this.tCantidad.TabIndex = 5;
            this.tCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tCantidad_KeyPress);
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(125, 34);
            this.tNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tNombre.MaxLength = 20;
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(263, 22);
            this.tNombre.TabIndex = 4;
            this.tNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tNombre_KeyPress);
            // 
            // ldescripcion
            // 
            this.ldescripcion.AutoSize = true;
            this.ldescripcion.Location = new System.Drawing.Point(25, 163);
            this.ldescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ldescripcion.Name = "ldescripcion";
            this.ldescripcion.Size = new System.Drawing.Size(82, 17);
            this.ldescripcion.TabIndex = 3;
            this.ldescripcion.Text = "Descripción";
            // 
            // lcantidad
            // 
            this.lcantidad.AutoSize = true;
            this.lcantidad.Location = new System.Drawing.Point(25, 90);
            this.lcantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lcantidad.Name = "lcantidad";
            this.lcantidad.Size = new System.Drawing.Size(64, 17);
            this.lcantidad.TabIndex = 1;
            this.lcantidad.Text = "Cantidad";
            // 
            // lnombre
            // 
            this.lnombre.AutoSize = true;
            this.lnombre.Location = new System.Drawing.Point(25, 34);
            this.lnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnombre.Name = "lnombre";
            this.lnombre.Size = new System.Drawing.Size(58, 17);
            this.lnombre.TabIndex = 0;
            this.lnombre.Text = "Nombre";
            // 
            // IngresarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 473);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "IngresarProducto";
            this.Text = "Ingresar Producto";
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
    }
}