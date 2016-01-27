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
    public partial class RegistrarEgreso : Form
    {
        Validacion val = new Validacion();
        public RegistrarEgreso()
        {
            InitializeComponent();
            button2.Enabled = false;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            BloquearBoton();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            BloquearBoton();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && tValor.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            guardarDatos(dateTimePicker1.Value.Date, float.Parse(tValor.Text), tNumFactura.Text, 
                                    tCedulaColab.Text, tIdProveedor.Text, tDescripcion.Text);
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            BloquearBoton();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void guardarDatos(DateTime Fecha, float Valor, String NumFactura, String CedulaColab, String Id_Proveedor, String Descripcion)
        {
            Colaborador conexion = new Colaborador();
            using (SqlConnection con = new SqlConnection("Data Source=25.22.77.136,49170;Database=imp_isabelita;Integrated Security=False;User ID=sa;Password=imprentaisabelita;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                using (SqlCommand cmd = new SqlCommand("spAgregarEgreso", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Fecha", Fecha);
                    cmd.Parameters.AddWithValue("@Valor", Valor);
                    cmd.Parameters.AddWithValue("@NumFactura", NumFactura);
                    cmd.Parameters.AddWithValue("@CedulaColab", CedulaColab);
                    cmd.Parameters.AddWithValue("@Id_proveedor", Id_Proveedor);
                    cmd.Parameters.AddWithValue("@Descripcion", Descripcion);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            BloquearBoton();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BloquearBoton();
        }
        private void BloquearBoton()
        {
            var bl = !string.IsNullOrEmpty(tDescripcion.Text) &&
                     !string.IsNullOrEmpty(tNumFactura.Text) &&
                     !string.IsNullOrEmpty(tCedulaColab.Text) &&
                     !string.IsNullOrEmpty(tIdProveedor.Text) &&
                     !string.IsNullOrEmpty(tValor.Text);

            button2.Enabled = bl;
        }
    }
}