namespace PracticaGui1
{
    partial class Descripciones
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
            this.LaCantidad = new System.Windows.Forms.Label();
            this.LaDescripcion = new System.Windows.Forms.Label();
            this.LaValor = new System.Windows.Forms.Label();
            this.Agregar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Desc1 = new System.Windows.Forms.TextBox();
            this.Valor = new System.Windows.Forms.TextBox();
            this.Cantidad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LaCantidad
            // 
            this.LaCantidad.AutoSize = true;
            this.LaCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaCantidad.Location = new System.Drawing.Point(34, 96);
            this.LaCantidad.Name = "LaCantidad";
            this.LaCantidad.Size = new System.Drawing.Size(109, 29);
            this.LaCantidad.TabIndex = 0;
            this.LaCantidad.Text = "Cantidad";
            // 
            // LaDescripcion
            // 
            this.LaDescripcion.AutoSize = true;
            this.LaDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaDescripcion.Location = new System.Drawing.Point(47, 168);
            this.LaDescripcion.Name = "LaDescripcion";
            this.LaDescripcion.Size = new System.Drawing.Size(141, 29);
            this.LaDescripcion.TabIndex = 1;
            this.LaDescripcion.Text = "Descripcion";
            // 
            // LaValor
            // 
            this.LaValor.AutoSize = true;
            this.LaValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaValor.Location = new System.Drawing.Point(34, 36);
            this.LaValor.Name = "LaValor";
            this.LaValor.Size = new System.Drawing.Size(69, 29);
            this.LaValor.TabIndex = 2;
            this.LaValor.Text = "Valor";
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(13, 532);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 4;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.Desc1);
            this.panel1.Controls.Add(this.Valor);
            this.panel1.Controls.Add(this.LaValor);
            this.panel1.Controls.Add(this.Cantidad);
            this.panel1.Controls.Add(this.LaCantidad);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 513);
            this.panel1.TabIndex = 5;
            // 
            // Desc1
            // 
            this.Desc1.Location = new System.Drawing.Point(245, 155);
            this.Desc1.Multiline = true;
            this.Desc1.Name = "Desc1";
            this.Desc1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Desc1.Size = new System.Drawing.Size(385, 100);
            this.Desc1.TabIndex = 2;
            // 
            // Valor
            // 
            this.Valor.Location = new System.Drawing.Point(245, 96);
            this.Valor.MaxLength = 5;
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(100, 22);
            this.Valor.TabIndex = 1;
            this.Valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Valor_KeyPress);
            // 
            // Cantidad
            // 
            this.Cantidad.Location = new System.Drawing.Point(245, 36);
            this.Cantidad.MaxLength = 4;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(100, 22);
            this.Cantidad.TabIndex = 0;
            this.Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cantidad_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(530, 555);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Hecho!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Descripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 610);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.LaDescripcion);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Descripciones";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Descripciones";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LaCantidad;
        private System.Windows.Forms.Label LaDescripcion;
        private System.Windows.Forms.Label LaValor;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Desc1;
        private System.Windows.Forms.TextBox Valor;
        private System.Windows.Forms.TextBox Cantidad;
        private System.Windows.Forms.Button button1;
    }
}