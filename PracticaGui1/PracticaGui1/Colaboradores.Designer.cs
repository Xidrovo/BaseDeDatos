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
            this.productBox = new System.Windows.Forms.TextBox();
            this.TansactionBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.IngresarProd = new System.Windows.Forms.Button();
            this.MostrarProd = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.IngresarTransacc = new System.Windows.Forms.Button();
            this.MostrarTransac = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // productBox
            // 
            this.productBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.productBox.Location = new System.Drawing.Point(38, 198);
            this.productBox.Name = "productBox";
            this.productBox.ReadOnly = true;
            this.productBox.Size = new System.Drawing.Size(493, 34);
            this.productBox.TabIndex = 0;
            this.productBox.Text = "Producto";
            this.productBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TansactionBox
            // 
            this.TansactionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TansactionBox.Location = new System.Drawing.Point(622, 198);
            this.TansactionBox.Name = "TansactionBox";
            this.TansactionBox.ReadOnly = true;
            this.TansactionBox.Size = new System.Drawing.Size(490, 34);
            this.TansactionBox.TabIndex = 1;
            this.TansactionBox.Text = "Tansacciones";
            this.TansactionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 174);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aquí va la imagen de la imprenta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.IngresarProd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MostrarProd, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(38, 281);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(496, 143);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // IngresarProd
            // 
            this.IngresarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresarProd.Location = new System.Drawing.Point(3, 3);
            this.IngresarProd.Name = "IngresarProd";
            this.IngresarProd.Size = new System.Drawing.Size(490, 55);
            this.IngresarProd.TabIndex = 0;
            this.IngresarProd.Text = "Ingresar";
            this.IngresarProd.UseVisualStyleBackColor = true;
            // 
            // MostrarProd
            // 
            this.MostrarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostrarProd.Location = new System.Drawing.Point(3, 64);
            this.MostrarProd.Name = "MostrarProd";
            this.MostrarProd.Size = new System.Drawing.Size(490, 55);
            this.MostrarProd.TabIndex = 1;
            this.MostrarProd.Text = "Mostrar";
            this.MostrarProd.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.IngresarTransacc, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.MostrarTransac, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(622, 281);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(490, 143);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // IngresarTransacc
            // 
            this.IngresarTransacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresarTransacc.Location = new System.Drawing.Point(3, 3);
            this.IngresarTransacc.Name = "IngresarTransacc";
            this.IngresarTransacc.Size = new System.Drawing.Size(484, 55);
            this.IngresarTransacc.TabIndex = 0;
            this.IngresarTransacc.Text = "Ingresar";
            this.IngresarTransacc.UseVisualStyleBackColor = true;
            // 
            // MostrarTransac
            // 
            this.MostrarTransac.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostrarTransac.Location = new System.Drawing.Point(3, 64);
            this.MostrarTransac.Name = "MostrarTransac";
            this.MostrarTransac.Size = new System.Drawing.Size(484, 55);
            this.MostrarTransac.TabIndex = 1;
            this.MostrarTransac.Text = "Mostrar";
            this.MostrarTransac.UseVisualStyleBackColor = true;
            // 
            // Colaboradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 627);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TansactionBox);
            this.Controls.Add(this.productBox);
            this.Name = "Colaboradores";
            this.Text = "Colaboradores";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productBox;
        private System.Windows.Forms.TextBox TansactionBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button IngresarProd;
        private System.Windows.Forms.Button MostrarProd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button IngresarTransacc;
        private System.Windows.Forms.Button MostrarTransac;
    }
}