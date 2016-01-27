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
    public partial class IngresarProducto : Form

    {

        Validacion val = new Validacion();
        public IngresarProducto()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bcancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            //Proveedor nProveedor = new Proveedor();
            //nProveedor.Nombre_empresa = cbProveedores;
            guardarDatos(tNombre.Text, tCantidad.Text, tDescripcion.Text);
            this.Close();
        }

        public void guardarDatos(String Nombre, String Cantidad, String Descripcion)
        {
            Colaborador conexion = new Colaborador();
            using (SqlConnection con = new SqlConnection("Data Source=25.22.77.136,49170;Initial Catalog=imp_isabelita;Integrated Security=False;User ID=sa;Password=imprentaisabelita;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                using (SqlCommand cmd = new SqlCommand("spAgregarProducto", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);
                    cmd.Parameters.AddWithValue("@Cantidad", Cantidad);
                    cmd.Parameters.AddWithValue("@Descricion", Descripcion);
                    cmd.Parameters.AddWithValue("@RUC", Convert.ToString(cbProveedores.SelectedValue));
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

            }

        }

        private void tNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloLetras(e);
        }

        private void tCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void Tidtrabajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void tDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloLetras(e);
        }

        private void IngresarProducto_Load(object sender, EventArgs e)
        {
            cbProveedores.DataSource = Productos_Inventario.ObtenerProveedores();
            string texto;
            cbProveedores.ValueMember = "RUC";
            texto = cbProveedores.DisplayMember;
            cbProveedores.DisplayMember = "Nombre_empresa";
        }

        private void cbProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
