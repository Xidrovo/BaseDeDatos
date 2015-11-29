namespace PracticaGui1
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.Username = new System.Windows.Forms.TextBox();
            this.Contrasena = new System.Windows.Forms.TextBox();
            this.ExButton = new System.Windows.Forms.Button();
            this.IngresarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Username
            // 
            resources.ApplyResources(this.Username, "Username");
            this.Username.Name = "Username";
            this.Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Username_KeyPress);
            // 
            // Contrasena
            // 
            resources.ApplyResources(this.Contrasena, "Contrasena");
            this.Contrasena.Name = "Contrasena";
            this.Contrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Contrasena_KeyPress);
            // 
            // ExButton
            // 
            resources.ApplyResources(this.ExButton, "ExButton");
            this.ExButton.Name = "ExButton";
            this.ExButton.UseVisualStyleBackColor = true;
            this.ExButton.Click += new System.EventHandler(this.ExButton_Click);
            // 
            // IngresarButton
            // 
            resources.ApplyResources(this.IngresarButton, "IngresarButton");
            this.IngresarButton.Name = "IngresarButton";
            this.IngresarButton.UseVisualStyleBackColor = true;
            this.IngresarButton.Click += new System.EventHandler(this.IngresarButton_Click);
            // 
            // LogIn
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IngresarButton);
            this.Controls.Add(this.ExButton);
            this.Controls.Add(this.Contrasena);
            this.Controls.Add(this.Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.Opacity = 0.75D;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Contrasena;
        private System.Windows.Forms.Button ExButton;
        private System.Windows.Forms.Button IngresarButton;
    }
}

