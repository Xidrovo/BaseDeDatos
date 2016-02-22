using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROYECTOBBDD
{

    public partial class IngresarPersonaNatural : Form
    {
        Validacion val = new Validacion();
        List<TextBox> lista = new List<TextBox>();
        List<Label> labelList = new List<Label>();
        public IngresarPersonaNatural()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            lista.Add(this.textTelefono);
            labelList.Add(this.lTelefono);

            bQuitar.Enabled = false;
            BGuardar.Enabled = false;
            if (Buscador.Actualizar == true)
            {
                this.Text = "Actualizar Cliente";
                #region
                int ContTemp = 1;
                //NCedula   [0]
                //Nombre    [1]
                //Apellido  [2]
                //Direccion [3]
                //Telefono  [4]...[9]
                tcedula.Text = Buscador.informacion[0];
                tcedula.Enabled = false;
                tnombres.Text = Buscador.informacion[1];
                tapellido.Text = Buscador.informacion[2];
                tdireccion.Text = Buscador.informacion[3];
                lista[0].Text = Buscador.informacion[4];

                while (Buscador.informacion[ContTemp + 4] != null)
                {
                    bAgregar_Click(null, null);
                    lista[ContTemp].Text = Buscador.informacion[ContTemp + 4];
                    ContTemp++;
                }
                BGuardar.Text = "Actualizar";
                #endregion
            }
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

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void bcancelar_Click(object sender, EventArgs e)
        {
            Buscador.Actualizar = false;
            this.Close();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            bool desicion = true;
            foreach (TextBox val in lista)
            {
                if (val.TextLength == 8)
                {
                    desicion = false;
                    val.BackColor = Color.PaleVioletRed;
                }
                else
                {
                    val.BackColor = Color.White;
                }
            }
            if (!desicion)
            {
                MessageBox.Show("Debe escribir un telefono valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!Principal.VerificaCedula(tcedula.Text))
            {
                tcedula.BackColor = Color.PaleVioletRed;
                MessageBox.Show("Cedula ingresada no válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                desicion = false;
            }
            else
                tcedula.BackColor = Color.White;

            if (desicion)
            {
                //Comunicarme con el sql

                try
                {
                    if (Buscador.Actualizar == false)
                    {
                        guardarDatos(tnombres.Text, tapellido.Text, tcedula.Text, tdireccion.Text);
                        this.Close();
                    }
                    else
                    {
                        ActualizarDatos(tnombres.Text, tapellido.Text, tcedula.Text, tdireccion.Text);
                        Buscador.Actualizar = false;
                        this.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("Persona ya existe en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public void guardarDatos(String Nombre, String Apellido, String Cedula, String Direccion)
        {
            Colaborador conexion = new Colaborador();
            using (SqlConnection con = new SqlConnection("Data Source=25.22.77.136,49170;Database=imp_isabelita;Integrated Security=False;User ID=sa;Password=imprentaisabelita;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                using (SqlCommand cmd = new SqlCommand("spAgregarClienteNatural", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Direccion", Direccion);
                    cmd.Parameters.AddWithValue("@NCedula", Cedula);
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", Apellido);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            using (SqlConnection con2 = new SqlConnection("Data Source=25.22.77.136,49170;Database=imp_isabelita;Integrated Security=False;User ID=sa;Password=imprentaisabelita;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {

                SqlConnection sqlConnection1 = new SqlConnection("Data Source=25.22.77.136,49170;Database=imp_isabelita;Integrated Security=False;User ID=sa;Password=imprentaisabelita;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlCommand cmd3 = new SqlCommand();
                SqlDataReader reader;
                cmd3.CommandText = "SELECT Id_Cliente FROM Persona_Natural where Ncedula='" + Cedula + "'";
                cmd3.CommandType = CommandType.Text;
                cmd3.Connection = sqlConnection1;
                sqlConnection1.Open();
                reader = cmd3.ExecuteReader();
                reader.Read();
                int id = reader.GetInt32(0);
                for (int i = 0; i < lista.Count(); i++)
                {
                    using (SqlCommand cmd2 = new SqlCommand("spAgregarTelefono", con2))
                    {
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@Id_Cliente", id);
                        cmd2.Parameters.AddWithValue("@Telefono", lista.ElementAt(i).Text);
                        con2.Open();
                        cmd2.ExecuteNonQuery();
                        con2.Close();
                    }
                }
                sqlConnection1.Close();
            }

        }

        public void ActualizarDatos(String Nombre, String Apellido, String Cedula, String Direccion)
        {
            Colaborador conexion = new Colaborador();
            using (SqlConnection con = new SqlConnection("Data Source=25.22.77.136,49170;Database=imp_isabelita;Integrated Security=False;User ID=sa;Password=imprentaisabelita;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                using (SqlCommand cmd = new SqlCommand("spActualizarClienteNatural", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Direccion", Direccion);
                    cmd.Parameters.AddWithValue("@NCedula", Cedula);
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", Apellido);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }


            using (SqlConnection con2 = new SqlConnection("Data Source=25.22.77.136,49170;Database=imp_isabelita;Integrated Security=False;User ID=sa;Password=imprentaisabelita;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {

                SqlConnection sqlConnection1 = new SqlConnection("Data Source=25.22.77.136,49170;Database=imp_isabelita;Integrated Security=False;User ID=sa;Password=imprentaisabelita;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlCommand cmd3 = new SqlCommand();
                SqlDataReader reader;
                cmd3.CommandText = "SELECT Id_Cliente FROM Persona_Natural where Ncedula='" + Cedula + "'";
                cmd3.CommandType = CommandType.Text;
                cmd3.Connection = sqlConnection1;
                sqlConnection1.Open();
                reader = cmd3.ExecuteReader();
                reader.Read();
                int id = reader.GetInt32(0);
                using (SqlCommand cmdx = new SqlCommand("spEliminarTelefonos", con2))
                {
                    cmdx.CommandType = CommandType.StoredProcedure;
                    cmdx.Parameters.AddWithValue("@Id_Cliente", id);
                    con2.Open();
                    cmdx.ExecuteNonQuery();
                    con2.Close();
                }

                for (int i = 0; i < lista.Count(); i++)
                {
                    using (SqlCommand cmd2 = new SqlCommand("spAgregarTelefono", con2))
                    {
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@Id_Cliente", id);
                        cmd2.Parameters.AddWithValue("@Telefono", lista.ElementAt(i).Text);
                        con2.Open();
                        cmd2.ExecuteNonQuery();
                        con2.Close();
                    }
                }
                sqlConnection1.Close();
            }

        }

        public static bool HasSomething(List<TextBox> lista)
        {
            foreach (TextBox texto in lista)
            {
                if (texto.Text != "")
                {
                    return true;
                }
            }
            return false;

        }

        private void bAgregar_Click(object sender, EventArgs e)
        {

            Label Telefono = new Label();
            TextBox tTelefono = new TextBox();

            Telefono.Text = this.lTelefono.Text;
            Telefono.Size = this.lTelefono.Size;
            Telefono.Location = new Point(this.lTelefono.Location.X,
                                          this.lista.Last<TextBox>().Location.Y + 50);

            tTelefono.Size = this.textTelefono.Size;
            tTelefono.Location = new Point(this.textTelefono.Location.X,
                                          this.lista.Last<TextBox>().Location.Y + 50);

            tTelefono.Show();
            Telefono.Show();

            lista.Add(tTelefono);
            labelList.Add(Telefono);

            tTelefono.KeyPress += textBox5_KeyPress;
            tTelefono.TextChanged += textTelefono_TextChanged;
            tTelefono.TabIndex = this.lista.Last<TextBox>().TabIndex + 1;
            tTelefono.MaxLength = 10;
            panel2.Controls.Add(tTelefono);
            panel2.Controls.Add(Telefono);

            bQuitar.Enabled = true;
            BloquearBoton();
        }


        private void bQuitar_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(lista[lista.Count - 1]);
            lista[lista.Count - 1].Dispose();
            lista.RemoveAt(lista.Count - 1);

            this.Controls.Remove(labelList[labelList.Count - 1]);
            labelList[labelList.Count - 1].Dispose();
            labelList.RemoveAt(labelList.Count - 1);

            if (lista.Count == 1)
            {
                bQuitar.Enabled = false;
            }
            BloquearBoton();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BloquearBoton();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            BloquearBoton();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            BloquearBoton();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            BloquearBoton();
        }

        private void textTelefono_TextChanged(object sender, EventArgs e)
        {
            BloquearBoton();
        }

        private void BloquearBoton()
        {
            var bl = !string.IsNullOrEmpty(tnombres.Text) &&
                    !string.IsNullOrEmpty(tapellido.Text) &&
                    !string.IsNullOrEmpty(tcedula.Text) &&
                    !string.IsNullOrEmpty(tdireccion.Text);

            foreach (TextBox var in lista)
            {
                if (var.TextLength < 7)
                {
                    bl = false;
                    break;
                }

            }
            BGuardar.Enabled = bl;

        }

        private void textTelefono_TextChanged_1(object sender, EventArgs e)
        {
            BloquearBoton();
        }

        private void IngresarPersonaNatural_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IngresarPersonaNatural_FormClosed(object sender, FormClosedEventArgs e)
        {
            Buscador.Actualizar = false;
        }
    }
}