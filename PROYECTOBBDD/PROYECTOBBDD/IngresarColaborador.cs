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
            InstanciarCombobox();
            if (Buscador.Actualizar)
            {
                this.Text = "Actualizar datos";
                button1.Text = "Actualizar";
                InstanciasActualizar();
            }
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            button1.Enabled = false;
            tCargo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void InstanciasActualizar()
        {
            //Nombre [0]
            //Apellido [1]
            //Ncedula [2]
            //Cargo [3]
            //Telefono [4]
            //Contraseña [5]
            tNombre.Text = Buscador.informacion[0];
            tApellido.Text = Buscador.informacion[1];
            tCedula.Text = Buscador.informacion[2];

            if (Buscador.informacion[3] == "SECRETARIO")
                tCargo.Text = "SECRETARIO";
            else if (Buscador.informacion[3] == "DISEÑADOR")
                tCargo.Text = "DISEÑADOR";
            else if (Buscador.informacion[3] == "GERENTE")
                tCargo.Text = "GERENTE";
            else
                tCargo.Text = "JEFE";

            tTelefono.Text = Buscador.informacion[4];
            tContrasena.Text = Buscador.informacion[5];

        }
        private void InstanciarCombobox()
        {
            tCargo.Items.Add("SECRETARIO");
            tCargo.Items.Add("DISEÑADOR");
            tCargo.Items.Add("GERENTE");
            tCargo.Items.Add("JEFE");
            tCargo.Text = "...";
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
            if (tTelefono.TextLength == 8)
            {
                tTelefono.BackColor = Color.PaleVioletRed;
                desicion = false;
                MessageBox.Show("Debe escribir un telefono valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tTelefono.BackColor = Color.White;
            }

            if (!Principal.VerificaCedula(tCedula.Text))
            {
                tCedula.BackColor = Color.PaleVioletRed;
                desicion = false;
                MessageBox.Show("Cedula ingresada no válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                tCedula.BackColor = Color.White;

            if (desicion)
            {
                if (Buscador.Actualizar)
                {
                    actualizarDatos();
                    Buscador.Actualizar = false;
                    this.Close();
                }
                else
                {
                    try
                    {
                        guardarDatos(tNombre.Text, tApellido.Text, tCedula.Text, tCargo.Text, tTelefono.Text, tContrasena.Text);
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Colaborador ya existe en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void actualizarDatos()
        {
            Colaborador conexion = new Colaborador();
            using (SqlConnection con = new SqlConnection("Data Source=25.22.77.136,49170;Database=imp_isabelita;Integrated Security=False;User ID=sa;Password=imprentaisabelita;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                using (SqlCommand cmd = new SqlCommand("spActualizarColaborador", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", tNombre.Text);
                    cmd.Parameters.AddWithValue("@Apellido", tApellido.Text);
                    cmd.Parameters.AddWithValue("@Ncedula", tCedula.Text);
                    cmd.Parameters.AddWithValue("@Cargo", tCargo.Text);
                    cmd.Parameters.AddWithValue("@Telefono", tTelefono.Text);
                    
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
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



        void bloquearBoton()
        {
            var bl = !string.IsNullOrEmpty(tNombre.Text) &&
                                !string.IsNullOrEmpty(tApellido.Text) &&
                                !string.IsNullOrEmpty(tCedula.Text)&&
                                tCargo.Text != "..." &&
                                !string.IsNullOrEmpty(tTelefono.Text) &&
                                !string.IsNullOrEmpty(tContrasena.Text) &&
                                tContrasena.TextLength >= 6 &&
                                tContrasena.TextLength <= 16 &&
                                tTelefono.TextLength >= 7;

            button1.Enabled = bl;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
        public void guardarDatos(String Nombre, String Apellido, String Cedula, String Cargo, String Telefono, String Contrasena)
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
                    cmd.Parameters.AddWithValue("@Contraseña", Contrasena);
                    
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

        }

        private void IngresarColaborador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Buscador.Actualizar = false;
        }
    }
}