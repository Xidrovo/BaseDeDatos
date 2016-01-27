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
    public partial class ConsultaCLientesCedula : Form
    {
        public ConsultaCLientesCedula()
        {
            InitializeComponent();
        }

        private void bconsultar_Click(object sender, EventArgs e)
        {
            MostrarDatosClientesPorCedula();
        }
        public void MostrarDatosClientesPorCedula()
        {
            //Colaborador conexion = new Colaborador();
            using (SqlConnection con = new SqlConnection("Data Source=25.22.77.136,49170;Initial Catalog=imp_isabelita;Integrated Security=False;User ID=sa;Password=imprentaisabelita;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                using (SqlCommand cmd = new SqlCommand("spClientePorCedula", con))
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Cedula", tcedula.Text);
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    celdaResultados.DataSource = dt;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }



        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
