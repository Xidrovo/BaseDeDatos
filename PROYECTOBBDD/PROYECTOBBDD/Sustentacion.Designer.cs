namespace PROYECTOBBDD
{
    partial class Sustentacion
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
            this.celdaResultados = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.celdaResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // celdaResultados
            // 
            this.celdaResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.celdaResultados.Location = new System.Drawing.Point(12, 12);
            this.celdaResultados.Name = "celdaResultados";
            this.celdaResultados.RowTemplate.Height = 24;
            this.celdaResultados.Size = new System.Drawing.Size(589, 234);
            this.celdaResultados.TabIndex = 0;
            this.celdaResultados.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.celdaResultados_RowEnter);
            this.celdaResultados.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.celdaResultados_RowLeave);
            this.celdaResultados.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.celdaResultados_RowsAdded);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "¡Sustentar!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sustentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 340);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.celdaResultados);
            this.Name = "Sustentacion";
            this.Text = "Sustentacion";
            ((System.ComponentModel.ISupportInitialize)(this.celdaResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView celdaResultados;
        private System.Windows.Forms.Button button1;
    }
}