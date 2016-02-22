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
    public partial class ConsultarInventarioXNombre : Form
    {
        Validacion val = new Validacion();
        DataSet resultados = new DataSet();
        DataView mifiltro;

        public void leer_datos(string query, ref DataSet dstprincipal, string tabla)
        {
            try
            {
                string cadena = "Data Source=25.22.77.136,49170;Initial Catalog=imp_isabelita;Integrated Security=False;User ID=sa;Password=imprentaisabelita;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlConnection cn = new SqlConnection(cadena);
                SqlCommand cmd = new SqlCommand(query, cn);
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dstprincipal, tabla);
                da.Dispose();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            /*
                    public void MostrarMasTrabajosColaborador()
        {
            //Colaborador conexion = new Colaborador();
            using (SqlConnection con = new SqlConnection("Data Source=25.22.77.136,49170;Initial Catalog=imp_isabelita;Integrated Security=False;User ID=sa;Password=imprentaisabelita;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                using (SqlCommand cmd = new SqlCommand("spTopClientesTrabajo", con))
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    cmd.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    celdaResultados.DataSource = dt;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    
                }
            }
        }
            */
        }
        public ConsultarInventarioXNombre()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BloquearBoton();
        }
        private void BloquearBoton()
        {
            var bl = !string.IsNullOrEmpty(tnombreProducto.Text);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (tnombreProducto.Text == "")
            {
                tnombreProducto.BackColor = Color.White;
                dataGridView1.DataSource = null;


            }
            else
            {
                using (SqlConnection con = new SqlConnection("Data Source=25.22.77.136,49170;Database=imp_isabelita;Integrated Security=False;User ID=sa;Password=imprentaisabelita;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Producto_inventario WHERE Id_producto_inv LIKE" + " " + tnombreProducto.Text, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        con.Open();
                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());
                        dataGridView1.DataSource = dt;
                        con.Close();
                    }
                }
            }
        }

        private void ConsultarInventarioXNombre_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}