namespace PracticaGui1
{
    partial class Colaboradores
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
            this.button2 = new System.Windows.Forms.Button();
            this.ImprentaIsabelita = new System.Windows.Forms.Label();
            this.MostrarProd = new System.Windows.Forms.Button();
            this.IngresarTransacc = new System.Windows.Forms.Button();
            this.MostrarTransac = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.IngresarColaborador = new System.Windows.Forms.Button();
            this.TansactionBox = new System.Windows.Forms.TextBox();
            this.IngresarNuevo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.ImprentaIsabelita);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 269);
            this.panel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1010, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Log Out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // ImprentaIsabelita
            // 
            this.ImprentaIsabelita.AutoSize = true;
            this.ImprentaIsabelita.Image = global::PracticaGui1.Properties.Resources.logo_empresa;
            this.ImprentaIsabelita.Location = new System.Drawing.Point(303, -3);
            this.ImprentaIsabelita.MinimumSize = new System.Drawing.Size(700, 303);
            this.ImprentaIsabelita.Name = "ImprentaIsabelita";
            this.ImprentaIsabelita.Size = new System.Drawing.Size(700, 303);
            this.ImprentaIsabelita.TabIndex = 0;
            this.ImprentaIsabelita.Click += new System.EventHandler(this.label1_Click);
            // 
            // MostrarProd
            // 
            this.MostrarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostrarProd.Location = new System.Drawing.Point(40, 367);
            this.MostrarProd.Name = "MostrarProd";
            this.MostrarProd.Size = new System.Drawing.Size(490, 55);
            this.MostrarProd.TabIndex = 1;
            this.MostrarProd.Text = "Inventario";
            this.MostrarProd.UseVisualStyleBackColor = true;
            this.MostrarProd.Click += new System.EventHandler(this.MostrarProd_Click);
            // 
            // IngresarTransacc
            // 
            this.IngresarTransacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresarTransacc.Location = new System.Drawing.Point(620, 381);
            this.IngresarTransacc.Name = "IngresarTransacc";
            this.IngresarTransacc.Size = new System.Drawing.Size(484, 55);
            this.IngresarTransacc.TabIndex = 0;
            this.IngresarTransacc.Text = "Ingresar";
            this.IngresarTransacc.UseVisualStyleBackColor = true;
            // 
            // MostrarTransac
            // 
            this.MostrarTransac.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostrarTransac.Location = new System.Drawing.Point(620, 463);
            this.MostrarTransac.Name = "MostrarTransac";
            this.MostrarTransac.Size = new System.Drawing.Size(484, 55);
            this.MostrarTransac.TabIndex = 1;
            this.MostrarTransac.Text = "Mostrar";
            this.MostrarTransac.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(40, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(490, 55);
            this.button1.TabIndex = 5;
            this.button1.Text = "Registrar Egreso";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // IngresarColaborador
            // 
            this.IngresarColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresarColaborador.Location = new System.Drawing.Point(40, 428);
            this.IngresarColaborador.Name = "IngresarColaborador";
            this.IngresarColaborador.Size = new System.Drawing.Size(490, 55);
            this.IngresarColaborador.TabIndex = 6;
            this.IngresarColaborador.Text = "Ingresar Colaborador";
            this.IngresarColaborador.UseVisualStyleBackColor = true;
            this.IngresarColaborador.Click += new System.EventHandler(this.IngresarColaborador_Click);
            // 
            // TansactionBox
            // 
            this.TansactionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TansactionBox.Location = new System.Drawing.Point(620, 319);
            this.TansactionBox.Name = "TansactionBox";
            this.TansactionBox.ReadOnly = true;
            this.TansactionBox.Size = new System.Drawing.Size(484, 34);
            this.TansactionBox.TabIndex = 1;
            this.TansactionBox.Text = "Ordenes De Trabajo";
            this.TansactionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IngresarNuevo
            // 
            this.IngresarNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresarNuevo.Location = new System.Drawing.Point(40, 489);
            this.IngresarNuevo.Name = "IngresarNuevo";
            this.IngresarNuevo.Size = new System.Drawing.Size(490, 54);
            this.IngresarNuevo.TabIndex = 7;
            this.IngresarNuevo.Text = "Ingresar nuevo proveedor";
            this.IngresarNuevo.UseVisualStyleBackColor = true;
            this.IngresarNuevo.Click += new System.EventHandler(this.IngresarNuevo_Click);
            // 
            // Colaboradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 627);
            this.Controls.Add(this.IngresarNuevo);
            this.Controls.Add(this.MostrarTransac);
            this.Controls.Add(this.IngresarTransacc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MostrarProd);
            this.Controls.Add(this.IngresarColaborador);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TansactionBox);
            this.Name = "Colaboradores";
            this.Text = "Colaboradores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Colaboradores_FormClosed);
            this.Load += new System.EventHandler(this.Colaboradores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ImprentaIsabelita;
        private System.Windows.Forms.Button MostrarProd;
        private System.Windows.Forms.Button IngresarTransacc;
        private System.Windows.Forms.Button MostrarTransac;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button IngresarColaborador;
        private System.Windows.Forms.TextBox TansactionBox;
        private System.Windows.Forms.Button IngresarNuevo;
        private System.Windows.Forms.Button button2;
    }
}