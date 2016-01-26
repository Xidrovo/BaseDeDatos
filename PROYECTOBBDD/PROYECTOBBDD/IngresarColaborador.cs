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

namespace PROYECTOBBDD
{
    public partial class IngresarColaborador : Form
    {
        Validacion val = new Validacion();
        public IngresarColaborador()
        {
            InitializeComponent();
            button1.Enabled = false;
            InstanciarCombobox();
        }

        private void InstanciarCombobox()
        {
            comboBox1.Items.Add("SECRETARIO");
            comboBox1.Items.Add("DISEÑADOR");
            comboBox1.Items.Add("GERENTE");
            comboBox1.Items.Add("JEFE");
            comboBox1.Text = "...";
            /*
                ...
                SECRETTARIO
                PRENSISTA
                DISEÑADOR
                GERENTE
                JEFE
            */
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void IngresarColaborador_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bloquearBoton();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloLetras(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloLetras(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            bloquearBoton();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            bloquearBoton();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloLetras(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloLetras(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //algoritmo cedula
            bool desicion = true;
            if (textBox5.TextLength == 8)
            {
                textBox5.BackColor = Color.PaleVioletRed;
                desicion = false;
                MessageBox.Show("Debe escribir un telefono valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBox5.BackColor = Color.White;
            }

            if (!Principal.VerificaCedula(textBox3.Text))
            {
                textBox3.BackColor = Color.PaleVioletRed;
                desicion = false;
                MessageBox.Show("Cedula ingresada no válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                textBox3.BackColor = Color.White;

            if (desicion)
            {
                guardarDatos(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text, textBox5.Text, textBox6.Text, tContrasena);
                this.Close();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            bloquearBoton();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            bloquearBoton();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            bloquearBoton();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            bloquearBoton();
        }

        void bloquearBoton()
        {
            var bl = !string.IsNullOrEmpty(textBox1.Text) &&
                                !string.IsNullOrEmpty(textBox2.Text) &&
                                !string.IsNullOrEmpty(textBox3.Text)&&
                                comboBox1.Text != "..." &&
                                !string.IsNullOrEmpty(textBox5.Text) &&
                                !string.IsNullOrEmpty(textBox6.Text) &&
                                !string.IsNullOrEmpty(tContrasena.Text) &&
                                tContrasena.TextLength >= 6 &&
                                tContrasena.TextLength <= 16 &&
                                textBox5.TextLength >= 7;

            button1.Enabled = bl;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bloquearBoton();
        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {
            bloquearBoton();
        }

        private void tContrasena_TextChanged(object sender, EventArgs e)
        {
            bloquearBoton();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            bloquearBoton();
        }
        public void guardarDatos(String Nombre, String Apellido, String Cedula, String Cargo, String Telefono, String Usuario, String Contrasena)
        {
            Colaborador conexion = new Colaborador();
            using (SqlConnection con = new SqlConnection("Data Source=25.22.77.136,49170;Database=imp_isabelita;Integrated Security=False;User ID=sa;Password=imprentaisabelita;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                using (SqlCommand cmd = new SqlCommand("spAñadirColaborador", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", Apellido);
                    cmd.Parameters.AddWithValue("@NCedula", Cedula);
                    cmd.Parameters.AddWithValue("@Cargo", Cargo);
                    cmd.Parameters.AddWithValue("@Telefono", Telefono);
                    cmd.Parameters.AddWithValue("@Usuario", Usuario);
                    cmd.Parameters.AddWithValue("@Contraseña", Contrasena);
                    
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

        }
    }
}