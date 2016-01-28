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
    public partial class ReporteEgresos : Form
    {
        Validacion val = new Validacion();

        public ReporteEgresos()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarEgresos();
            //this.Close();
        }

        private void dFechaFinal_ValueChanged(object sender, EventArgs e)
        {
            if (dFechaFinal.Value <= dFechaInicio.Value)
            {
                MessageBox.Show("La fecha final debe ser mayor a la fecha inicio");

            }
        }

        public void MostrarEgresos()
        {
            //Colaborador conexion = new Colaborador();
            using (SqlConnection con = new SqlConnection("Data Source=25.22.77.136,49170;Initial Catalog=imp_isabelita;Integrated Security=False;User ID=sa;Password=imprentaisabelita;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                using (SqlCommand cmd = new SqlCommand("consultarEgreso", con))
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Fecha_Inicio", dFechaInicio.Text);
                    cmd.Parameters.AddWithValue("@Fecha_Final", dFechaFinal.Text);
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    CeldaResultado.DataSource = dt;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }


        }
    }
}
