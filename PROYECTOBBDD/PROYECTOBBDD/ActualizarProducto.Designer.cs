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
            this.Ingresar = new System.Windows.Forms.TextBox();
            this.Lid = new System.Windows.Forms.Label();
            this.bActualizar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.rQuitar = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tid
            // 
            this.Tid.Location = new System.Drawing.Point(81, 30);
            this.Tid.Margin = new System.Windows.Forms.Padding(2);
            this.Tid.Name = "Tid";
            this.Tid.Size = new System.Drawing.Size(136, 20);
            this.Tid.TabIndex = 0;
            // 
            // rAgregar
            // 
            this.rAgregar.AutoSize = true;
            this.rAgregar.Location = new System.Drawing.Point(18, 18);
            this.rAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.rAgregar.Name = "rAgregar";
            this.rAgregar.Size = new System.Drawing.Size(62, 17);
            this.rAgregar.TabIndex = 1;
            this.rAgregar.TabStop = true;
            this.rAgregar.Text = "Agregar";
            this.rAgregar.UseVisualStyleBackColor = true;
            // 
            // Ingresar
            // 
            this.Ingresar.Location = new System.Drawing.Point(295, 31);
            this.Ingresar.Margin = new System.Windows.Forms.Padding(2);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Size = new System.Drawing.Size(199, 20);
            this.Ingresar.TabIndex = 3;
            this.Ingresar.TextChanged += new System.EventHandler(this.Ingresar_TextChanged);
            this.Ingresar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ingresar_KeyPress);
            // 
            // Lid
            // 
            this.Lid.AutoSize = true;
            this.Lid.Location = new System.Drawing.Point(9, 34);
            this.Lid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lid.Name = "Lid";
            this.Lid.Size = new System.Drawing.Size(62, 13);
            this.Lid.TabIndex = 4;
            this.Lid.Text = "Id Producto";
            // 
            // bActualizar
            // 
            this.bActualizar.Location = new System.Drawing.Point(272, 99);
            this.bActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.bActualizar.Name = "bActualizar";
            this.bActualizar.Size = new System.Drawing.Size(68, 19);
            this.bActualizar.TabIndex = 5;
            this.bActualizar.Text = "Actualizar";
            this.bActualizar.UseVisualStyleBackColor = true;
            this.bActualizar.Click += new System.EventHandler(this.bActualizar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(113, 99);
            this.bCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(56, 19);
            this.bCancelar.TabIndex = 6;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // rQuitar
            // 
            this.rQuitar.AutoSize = true;
            this.rQuitar.Location = new System.Drawing.Point(94, 18);
            this.rQuitar.Margin = new System.Windows.Forms.Padding(2);
            this.rQuitar.Name = "rQuitar";
            this.rQuitar.Size = new System.Drawing.Size(53, 17);
            this.rQuitar.TabIndex = 2;
            this.rQuitar.TabStop = true;
            this.rQuitar.Text = "Quitar";
            this.rQuitar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rQuitar);
            this.groupBox1.Controls.Add(this.rAgregar);
            this.groupBox1.Location = new System.Drawing.Point(332, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(150, 40);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cantidad";
            // 
            // ActualizarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 128);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bActualizar);
            this.Controls.Add(this.Lid);
            this.Controls.Add(this.Ingresar);
            this.Controls.Add(this.Tid);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ActualizarProducto";
            this.Text = "ActualizarProducto";
            this.Load += new System.EventHandler(this.ActualizarProducto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tid;
        private System.Windows.Forms.RadioButton rAgregar;
        private System.Windows.Forms.TextBox Ingresar;
        private System.Windows.Forms.Label Lid;
        private System.Windows.Forms.Button bActualizar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.RadioButton rQuitar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}