namespace PROYECTOBBDD
{
    partial class TrabajosAEntregar
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
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.lFechaInicio = new System.Windows.Forms.Label();
            this.lFechaFinal = new System.Windows.Forms.Label();
            this.dFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.celdaResultado = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.celdaResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.celdaResultado);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 358);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Resultados de la Consulta";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(261, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Consultar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(96, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Parámetros de consulta";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dFechaFinal);
            this.panel2.Controls.Add(this.lFechaInicio);
            this.panel2.Controls.Add(this.lFechaFinal);
            this.panel2.Controls.Add(this.dFechaInicio);
            this.panel2.Location = new System.Drawing.Point(15, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 50);
            this.panel2.TabIndex = 7;
            // 
            // dFechaFinal
            // 
            this.dFechaFinal.CustomFormat = "yyyy-MM-dd";
            this.dFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dFechaFinal.Location = new System.Drawing.Point(285, 16);
            this.dFechaFinal.Name = "dFechaFinal";
            this.dFechaFinal.Size = new System.Drawing.Size(119, 20);
            this.dFechaFinal.TabIndex = 4;
            this.dFechaFinal.ValueChanged += new System.EventHandler(this.dFechaFinal_ValueChanged);
            // 
            // lFechaInicio
            // 
            this.lFechaInicio.AutoSize = true;
            this.lFechaInicio.Location = new System.Drawing.Point(8, 15);
            this.lFechaInicio.Name = "lFechaInicio";
            this.lFechaInicio.Size = new System.Drawing.Size(65, 13);
            this.lFechaInicio.TabIndex = 1;
            this.lFechaInicio.Text = "Fecha Inicio";
            // 
            // lFechaFinal
            // 
            this.lFechaFinal.AutoSize = true;
            this.lFechaFinal.Location = new System.Drawing.Point(214, 19);
            this.lFechaFinal.Name = "lFechaFinal";
            this.lFechaFinal.Size = new System.Drawing.Size(62, 13);
            this.lFechaFinal.TabIndex = 2;
            this.lFechaFinal.Text = "Fecha Final";
            this.lFechaFinal.Click += new System.EventHandler(this.label2_Click);
            // 
            // dFechaInicio
            // 
            this.dFechaInicio.CustomFormat = "yyyy-MM-dd";
            this.dFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dFechaInicio.Location = new System.Drawing.Point(79, 15);
            this.dFechaInicio.Name = "dFechaInicio";
            this.dFechaInicio.Size = new System.Drawing.Size(119, 20);
            this.dFechaInicio.TabIndex = 3;
            // 
            // celdaResultado
            // 
            this.celdaResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.celdaResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.celdaResultado.Location = new System.Drawing.Point(28, 117);
            this.celdaResultado.Name = "celdaResultado";
            this.celdaResultado.Size = new System.Drawing.Size(393, 150);
            this.celdaResultado.TabIndex = 5;
            // 
            // TrabajosAEntregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 382);
            this.Controls.Add(this.panel1);
            this.Name = "TrabajosAEntregar";
            this.Text = "Trabajos a Entregar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.celdaResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dFechaFinal;
        private System.Windows.Forms.DateTimePicker dFechaInicio;
        private System.Windows.Forms.Label lFechaFinal;
        private System.Windows.Forms.Label lFechaInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView celdaResultado;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}