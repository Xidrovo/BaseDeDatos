using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PracticaGui1
{
    public partial class LogIn : Form
    {
        public const int LogIntSize = 635;
        SplashImage Splash = new SplashImage();
        public LogIn()
        {
            InitializeComponent();
            this.Size = new Size(675, 304);
            this.ExButton.Size = new Size(32, 28);
            //Con esto dejo el botón en la esquina superior derecha.
            this.ExButton.Location = new Point(this.Location.X + LogIntSize, this.ExButton.Location.Y);
            this.IngresarButton.Size = new Size(164, 31);
            this.IngresarButton.Location = new Point(this.Location.X + (int) (LogIntSize / 2) - 40, this.IngresarButton.Location.Y + 35);
        }

        private void ExButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IngresarButton_Click(object sender, EventArgs e)
        {
            //Esto es solo para poder mostrar las ventanas (No se hará así en el proyecto final)
            if (this.Username.Text.Equals("admin"))
            {
                //Se abre shona del administrador.
                Console.WriteLine("Hola");
            }
            else if (this.Username.Text.Equals("Jaminson"))
            {
                //Show the 'really nigga' meme.
               // Jaminson JamyTafy = new Jaminson();
               // JamyTafy.Show();
            }
            else if ((this.Username.Text) != "" && (this.Contrasena.Text != ""))
            {
                PROYECTOBBDD.Principal col = new PROYECTOBBDD.Principal();
                col.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("what did you do!!", "Oh god!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Username.Text = "";
            this.Contrasena.Text = "";
        }

        private void Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.IngresarButton_Click(null, null);
            }
        }

        private void Contrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.IngresarButton_Click(null, null);
            }
        }
    }
}
