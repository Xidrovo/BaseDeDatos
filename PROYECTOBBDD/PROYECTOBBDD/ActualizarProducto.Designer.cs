namespace PROYECTOBBDD
{
    partial class ActualizarProducto
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
            this.Tid = new System.Windows.Forms.TextBox();
            this.rAgregar = new System.Windows.Forms.RadioButton();
            this.rQuitar = new System.Windows.Forms.RadioButton();
            this.Ingresar = new System.Windows.Forms.TextBox();
            this.Lid = new System.Windows.Forms.Label();
            this.bActualizar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tid
            // 
            this.Tid.Location = new System.Drawing.Point(126, 39);
            this.Tid.Name = "Tid";
            this.Tid.Size = new System.Drawing.Size(100, 22);
            this.Tid.TabIndex = 0;
            // 
            // rAgregar
            // 
            this.rAgregar.AutoSize = true;
            this.rAgregar.Location = new System.Drawing.Point(472, 67);
            this.rAgregar.Name = "rAgregar";
            this.rAgregar.Size = new System.Drawing.Size(80, 21);
            this.rAgregar.TabIndex = 1;
            this.rAgregar.TabStop = true;
            this.rAgregar.Text = "Agregar";
            this.rAgregar.UseVisualStyleBackColor = true;
            // 
            // rQuitar
            // 
            this.rQuitar.AutoSize = true;
            this.rQuitar.Location = new System.Drawing.Point(132, 9);
            this.rQuitar.Name = "rQuitar";
            this.rQuitar.Size = new System.Drawing.Size(68, 21);
            this.rQuitar.TabIndex = 2;
            this.rQuitar.TabStop = true;
            this.rQuitar.Text = "Quitar";
            this.rQuitar.UseVisualStyleBackColor = true;
            // 
            // Ingresar
            // 
            this.Ingresar.Location = new System.Drawing.Point(362, 39);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Size = new System.Drawing.Size(264, 22);
            this.Ingresar.TabIndex = 3;
            // 
            // Lid
            // 
            this.Lid.AutoSize = true;
            this.Lid.Location = new System.Drawing.Point(13, 43);
            this.Lid.Name = "Lid";
            this.Lid.Size = new System.Drawing.Size(80, 17);
            this.Lid.TabIndex = 4;
            this.Lid.Text = "Id Producto";
            // 
            // bActualizar
            // 
            this.bActualizar.Location = new System.Drawing.Point(362, 122);
            this.bActualizar.Name = "bActualizar";
            this.bActualizar.Size = new System.Drawing.Size(91, 23);
            this.bActualizar.TabIndex = 5;
            this.bActualizar.Text = "Actualizar";
            this.bActualizar.UseVisualStyleBackColor = true;
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(151, 122);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 6;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rQuitar);
            this.groupBox1.Location = new System.Drawing.Point(442, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 49);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // ActualizarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 157);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bActualizar);
            this.Controls.Add(this.Lid);
            this.Controls.Add(this.Ingresar);
            this.Controls.Add(this.rAgregar);
            this.Controls.Add(this.Tid);
            this.Controls.Add(this.groupBox1);
            this.Name = "ActualizarProducto";
            this.Text = "ActualizarProducto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tid;
        private System.Windows.Forms.RadioButton rAgregar;
        private System.Windows.Forms.RadioButton rQuitar;
        private System.Windows.Forms.TextBox Ingresar;
        private System.Windows.Forms.Label Lid;
        private System.Windows.Forms.Button bActualizar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}