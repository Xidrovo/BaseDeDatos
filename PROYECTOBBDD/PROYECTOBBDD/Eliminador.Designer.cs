namespace PROYECTOBBDD
{
    partial class Eliminador
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
            this.Texto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Eliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Texto
            // 
            this.Texto.AutoSize = true;
            this.Texto.Location = new System.Drawing.Point(29, 72);
            this.Texto.Name = "Texto";
            this.Texto.Size = new System.Drawing.Size(41, 13);
            this.Texto.TabIndex = 0;
            this.Texto.Text = "Opcion";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(274, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(179, 155);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Eliminar.TabIndex = 2;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Eliminador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 233);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Texto);
            this.Name = "Eliminador";
            this.Text = "Eliminador";
            this.Load += new System.EventHandler(this.Eliminador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Texto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Eliminar;
    }
}