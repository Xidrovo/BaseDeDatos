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
    public partial class ActualizarProducto : Form
    {
        Validacion Val = new Validacion();
        public ActualizarProducto()
        {
            InitializeComponent();
            rAgregar.Checked = true;
            groupBox1.Controls.Add(rAgregar);
            groupBox1.Controls.Add(rQuitar);
            bActualizar.Enabled = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void Ingresar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.soloNumeros(e);
        }

        private void Ingresar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int Value = Int32.Parse(Ingresar.Text);

                if (Value > 0)
                {
                    bActualizar.Enabled = true;
                }
                else
                    bActualizar.Enabled = false;
            }
            catch (Exception exc)
            {
                bActualizar.Enabled = false;
            }
        }

        private void ActualizarProducto_Load(object sender, EventArgs e)
        {

        }

        private void bActualizar_Click(object sender, EventArgs e)
        {
            Colaborador conexion = new Colaborador();
            using (SqlConnection con = new SqlConnection("Data Source=25.22.77.136,49170;Database=imp_isabelita;Integrated Security=False;User ID=sa;Password=imprentaisabelita;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                using (SqlCommand cmd = new SqlCommand("spActualizarProducto", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cod", Tid.Text);
                    if (rAgregar.Checked)
                        cmd.Parameters.AddWithValue("@cant", Convert.ToInt32(Ingresar.Text));
                    else if (rQuitar.Checked)
                        cmd.Parameters.AddWithValue("@cant", (-1) * Convert.ToInt32(Ingresar.Text));


                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            this.Close();
        }
    }
}
