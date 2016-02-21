using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PracticaGui1
{
    public partial class LogIn : Form
    {
        public const int LogIntSize = 635;
        SplashImage Splash = new SplashImage();
        public static string Cargo = "Ninguno";
        public static string Cedula;
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

            if (this.Username.Text.Equals("0924970452"))
            {
                //Se abre shona del administrador.
                PROYECTOBBDD.Principal col = new PROYECTOBBDD.Principal();
                Cargo = "JEFE";
                col.Show();
                this.Hide();
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
                ObtenerCargo(Contrasena.Text, Username.Text);
                if (Cargo != "Ninguno")
                {
                    col.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Por favor ingresar los campos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Username.Text = "";
            this.Contrasena.Text = "";
        }


        private void ObtenerCargo(string Password, string Login)
        {
            string log = "";
            bool Error = true;
            SqlConnection MiConexion = new SqlConnection();
            MiConexion = new SqlConnection("Data Source=25.22.77.136,49170;Initial Catalog=imp_isabelita;Integrated Security=False;User ID=sa;Password=imprentaisabelita;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            MiConexion.Open();
            SqlCommand command = new SqlCommand("select NCedula, Cargo from Colaborador WHERE Colaborador.Contraseña = CONVERT(varbinary, '" + this.Contrasena.Text + "')", MiConexion);
            SqlDataReader reader = command.ExecuteReader();
            
            while(reader.Read())
            {
                log = reader.GetString(0);
                if (log == Login)
                {
                    Cargo = reader.GetString(1);
                    Error = false;
                    Cedula = log;
                    break;
                }
                else
                {
                    Error = true;
                }
            }
            if (Error)
            {
                Cargo = "Ninguno";
                MessageBox.Show("USUARIO O CONTRASEÑA NO ENCONTRADO", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MiConexion.Close();        }
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
