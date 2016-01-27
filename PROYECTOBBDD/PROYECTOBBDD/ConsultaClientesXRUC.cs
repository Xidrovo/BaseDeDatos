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
    public partial class ConsultaClientesXRUC : Form
    {
        Validacion val = new Validacion();
        public ConsultaClientesXRUC()
        {
            InitializeComponent();
            bConsulta.Enabled = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void bConsulta_Click(object sender, EventArgs e)
        {
            if (Principal.VerificaRucEmpresas(truc.Text) || Principal.VerificaRucPersonaNatural(truc.Text))
            {
                //Consultar Query
                MostrarDatosClientesPorRuc();
            }
            else
            {
                MessageBox.Show("Debe escribir un RUC valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void MostrarDatosClientesPorRuc()
        {
            //Colaborador conexion = new Colaborador();
            using (SqlConnection con = new SqlConnection("Data Source=25.22.77.136,49170;Initial Catalog=imp_isabelita;Integrated Security=False;User ID=sa;Password=imprentaisabelita;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                using (SqlCommand cmd = new SqlCommand("spGetIdFromRUC", con))
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RUC", truc.Text);
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    celdaResultados.DataSource = dt;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }



        }

        private void bsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BloquearBoton();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConsultaClientesXRUC_Load(object sender, EventArgs e)
        {

        }
        private void BloquearBoton()
        {
            var bl = !string.IsNullOrEmpty(truc.Text) && truc.TextLength == 13;

            bConsulta.Enabled = bl;
        }
    }
}