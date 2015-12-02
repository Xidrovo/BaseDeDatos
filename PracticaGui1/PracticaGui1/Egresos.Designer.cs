namespace PracticaGui1
{
    partial class Egresos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Dia = new System.Windows.Forms.TextBox();
            this.Mes = new System.Windows.Forms.TextBox();
            this.Anio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Valor = new System.Windows.Forms.TextBox();
            this.Provedor = new System.Windows.Forms.ComboBox();
            this.NumFactura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Desc1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha (DD/NN/AA): ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de Factura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Provedor";
            // 
            // Dia
            // 
            this.Dia.Location = new System.Drawing.Point(381, 102);
            this.Dia.MaxLength = 2;
            this.Dia.Name = "Dia";
            this.Dia.Size = new System.Drawing.Size(54, 22);
            this.Dia.TabIndex = 5;
            this.Dia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Dia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Mes
            // 
            this.Mes.Location = new System.Drawing.Point(441, 102);
            this.Mes.MaxLength = 2;
            this.Mes.Name = "Mes";
            this.Mes.Size = new System.Drawing.Size(48, 22);
            this.Mes.TabIndex = 6;
            this.Mes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Mes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // Anio
            // 
            this.Anio.Location = new System.Drawing.Point(495, 102);
            this.Anio.MaxLength = 4;
            this.Anio.Name = "Anio";
            this.Anio.Size = new System.Drawing.Size(104, 22);
            this.Anio.TabIndex = 7;
            this.Anio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Anio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(935, 590);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 56);
            this.button1.TabIndex = 10;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 623);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Valor
            // 
            this.Valor.Location = new System.Drawing.Point(381, 39);
            this.Valor.MaxLength = 4;
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(218, 22);
            this.Valor.TabIndex = 4;
            this.Valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // Provedor
            // 
            this.Provedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Provedor.FormattingEnabled = true;
            this.Provedor.Location = new System.Drawing.Point(381, 216);
            this.Provedor.Name = "Provedor";
            this.Provedor.Size = new System.Drawing.Size(302, 24);
            this.Provedor.Sorted = true;
            this.Provedor.TabIndex = 9;
            // 
            // NumFactura
            // 
            this.NumFactura.Location = new System.Drawing.Point(381, 155);
            this.NumFactura.MaxLength = 10;
            this.NumFactura.Name = "NumFactura";
            this.NumFactura.Size = new System.Drawing.Size(218, 22);
            this.NumFactura.TabIndex = 8;
            this.NumFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumFactura_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Descripción";
            // 
            // Desc1
            // 
            this.Desc1.AcceptsReturn = true;
            this.Desc1.Location = new System.Drawing.Point(381, 270);
            this.Desc1.MaxLength = 3000;
            this.Desc1.Multiline = true;
            this.Desc1.Name = "Desc1";
            this.Desc1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Desc1.Size = new System.Drawing.Size(677, 162);
            this.Desc1.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(813, 449);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(244, 58);
            this.button3.TabIndex = 14;
            this.button3.Text = "Detallar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Egresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 658);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Desc1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NumFactura);
            this.Controls.Add(this.Provedor);
            this.Controls.Add(this.Valor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Anio);
            this.Controls.Add(this.Mes);
            this.Controls.Add(this.Dia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Egresos";
            this.Text = "Registrar Egreso";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Egresos_FormClosed);
            this.Load += new System.EventHandler(this.Egresos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Dia;
        private System.Windows.Forms.TextBox Mes;
        private System.Windows.Forms.TextBox Anio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Valor;
        private System.Windows.Forms.ComboBox Provedor;
        private System.Windows.Forms.TextBox NumFactura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Desc1;
        private System.Windows.Forms.Button button3;
    }
}