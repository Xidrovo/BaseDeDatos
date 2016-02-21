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
    public partial class IngresarEmpresa : Form
    {
        private List<TextBox> lista = new List<TextBox>(); //Aquí se crea una lista.
        private List<Label> labelList = new List<Label>();
        Validacion val = new Validacion();
        public IngresarEmpresa()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            lista.Add(textTelefono);
            labelList.Add(lTelefono);
            bQuitar.Enabled = false;
            bguardar.Enabled = false;
            if (Buscador.Actualizar)
            {
                #region
                int ContTemp = 1;
                //RUC   [0]
                //RazonSocial    [1]
                //Direccion  [2]
                //Telefonos [3] .. [9]
                truc.Text = Buscador.informacion[0];
                truc.Enabled = false;
                trazonsocial.Text = Buscador.informacion[1];
                tdireccion.Text = Buscador.informacion[2];
                lista[0].Text = Buscador.informacion[3];
                while (Buscador.informacion[ContTemp + 3] != null)
                {
                    bagregar_Click(null, null);
                    lista[ContTemp].Text = Buscador.informacion[ContTemp + 3];
                    ContTemp++;
                }
                bguardar.Text = "Actualizar";
                #endregion
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BloquearBoton();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloLetras(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Teléfono_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void bcancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Buscador.Actualizar)
            {
                //El botón funciona como update
            }
            //El botón funciona como inseert
            else {
            #region
            bool desicion = true;

            foreach (TextBox val in lista)
            {
                if (val.TextLength == 8)
                {
                    desicion = false;
                    val.BackColor = Color.PaleVioletRed;
                }
                else
                    val.BackColor = Color.White;
            }
            if (!desicion)
            {
                MessageBox.Show("Debe escribir un telefono valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!(Principal.VerificaRucPersonaNatural(truc.Text)
                                            || Principal.VerificaRucEmpresas(truc.Text)))
            {
                truc.BackColor = Color.PaleVioletRed;
                desicion = false;
                MessageBox.Show("Debe escribir un RUC valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                truc.BackColor = Color.White;
            }

            if (desicion)
            {
                //sql stuff
                try
                {
                    guardarDatos(truc.Text, trazonsocial.Text, tdireccion.Text);
                    this.Close();
                } catch
                {
                    MessageBox.Show("Empresa ya existe en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                #endregion
            }
        }

        public void guardarDatos(String Ruc, String RazonSocial, String Direccion)
        {
            Colaborador conexion = new Colaborador();
            using (SqlConnection con = new SqlConnection("Data Source=25.22.77.136,49170;Initial Catalog=imp_isabelita;Integrated Security=False;User ID=sa;Password=imprentaisabelita;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                using (SqlCommand cmd = new SqlCommand("spAgregarClienteEmpresa", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RUC", Ruc);
                    cmd.Parameters.AddWithValue("@Razon_Social", RazonSocial);
                    cmd.Parameters.AddWithValue("@Direccion", Direccion);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            using (SqlConnection con2 = new SqlConnection("Data Source=25.22.77.136,49170;Initial Catalog=imp_isabelita;Integrated Security=False;User ID=sa;Password=imprentaisabelita;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {

                SqlConnection sqlConnection1 = new SqlConnection("Data Source=25.22.77.136,49170;Initial Catalog=imp_isabelita;Integrated Security=False;User ID=sa;Password=imprentaisabelita;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlCommand cmd3 = new SqlCommand();
                SqlDataReader reader;
                cmd3.CommandText = "SELECT RUC FROM Empresas where RUC='" + Ruc + "'";
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
                        cmd2.Parameters.AddWithValue("@RUC", Ruc);
                        cmd2.Parameters.AddWithValue("@Telefono", lista.ElementAt(i).Text);
                        con2.Open();
                        cmd2.ExecuteNonQuery();
                        con2.Close();

                    }
                }
                sqlConnection1.Close();
            }

        }


        private void bagregar_Click(object sender, EventArgs e)
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

            tTelefono.KeyPress += textBox4_KeyPress;
            tTelefono.TextChanged += textTelefono_TextChanged;
            tTelefono.MaxLength = 10;
            contenedorARepetir.Controls.Add(Telefono);
            contenedorARepetir.Controls.Add(tTelefono);

            BloquearBoton();
            bQuitar.Enabled = true;
        }

        private void textTelefono_TextChanged(object sender, EventArgs e)
        {
            BloquearBoton();
        }

        private void IngresarEmpresa_Load(object sender, EventArgs e)
        {

        }
        private void truc_Textchanged(object sender, EventArgs e)
        {
            BloquearBoton();
        }
        private void Tdireccion_Textchanged(object sender, EventArgs e)
        {
            BloquearBoton();
        }
        private void Trazonsocial_Textchanged(object sender, EventArgs e)
        {
            BloquearBoton();
        }

        private void BloquearBoton()
        {
            var bl = !string.IsNullOrEmpty(truc.Text) &&
                     !string.IsNullOrEmpty(trazonsocial.Text) &&
                     !string.IsNullOrEmpty(tdireccion.Text);

            foreach (TextBox var in lista)
            {
                if (string.IsNullOrEmpty(var.Text) || var.TextLength < 7)
                {
                    bl = false;
                    break;
                }

            }

            bguardar.Enabled = bl;
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

        private void textTelefono_TextChanged_1(object sender, EventArgs e)
        {
            BloquearBoton();
        }

        private void trazonsocial_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tdireccion_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}