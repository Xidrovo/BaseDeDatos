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


        }
        public ConsultarInventarioXNombre()
        {
            InitializeComponent();
            button2.Enabled = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloLetras(e);
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
            button2.Enabled = bl;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ConsultarInventarioXNombre_Load(object sender, EventArgs e)
        {
            this.leer_datos("SELECT * FROM Producto_inventario", ref resultados, "Producto_inventario");
            this.mifiltro = ((DataTable)resultados.Tables["Producto_inventario"]).DefaultView;
            this.dataGridView1.DataSource = mifiltro;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string salida_datos = " ";
            string[] palabras_busqueda = this.tnombreProducto.Text.Split(' ');

            foreach (string palabra in palabras_busqueda)
            {
                if (salida_datos.Length == 0)
                {
                    salida_datos = "(Nombre LIKE '%" + palabra + "%')";

                }
                else
                {
                    salida_datos += "  (Nombre LIKE '%" + palabra + "%')";
                }
            }
            this.mifiltro.RowFilter = salida_datos;
        }
    }
}