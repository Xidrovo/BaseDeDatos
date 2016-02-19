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
    public partial class Sustentacion : Form
    {
        public Sustentacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarMasTrabajosColaborador();

        }

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

        private void celdaResultados_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (celdaResultados.RowCount > 5)
            {
                celdaResultados.AllowUserToAddRows = false;
            }
        }

        private void celdaResultados_RowLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void celdaResultados_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            celdaResultados.CancelEdit();
            

            if (celdaResultados.RowCount > 5)
            {
                return;
                celdaResultados.AllowUserToAddRows = false;
            }
        }
    }
}
