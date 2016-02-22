using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOBBDD
{
    public partial class Eliminador : Form
    {
        public Eliminador()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Eliminador_Load(object sender, EventArgs e)
        {
            if (Principal.State == (int)Principal.Estado.Cliente)
            {
                Texto.Text = "Escriba la identificación del cliente";
            }
            else if (Principal.State == (int)Principal.Estado.Colaborador)
            {
                Texto.Text = "Escriba la cedula del colaborador";
            }
            else if (Principal.State == (int)Principal.Estado.Inventario)
            {
                Texto.Text = "Escriba la Id del inventario";
            }
            else
            {
                Texto.Text = "Ingrese nombre del proveedor";
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (Principal.State == (int)Principal.Estado.Cliente)
            {
#region
                using (SqlConnection con = new SqlConnection("Data Source=25.22.77.136,49170;Initial Catalog=imp_isabelita;Integrated Security=False;User ID=sa;Password=imprentaisabelita;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    if (textBox1.Text.Length == 10)
                    {

                        try
                        {
                            int id = 0;
                            SqlCommand cmd = new SqlCommand();
                            SqlDataReader reader;
                            cmd.CommandText = "spGetIdFromPersona_Natural";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("@Ncedula", textBox1.Text);
                            con.Open();
                            reader = cmd.ExecuteReader();
                            reader.Read();
                            id = reader.GetInt32(0);
                            con.Close();
                            delete(id);
                        }
                        catch
                        {
                            MessageBox.Show("No se encontraron datos del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    if (textBox1.Text.Length == 13)
                    { 
                    
                        try
                        {
                            int id = 0;
                            SqlCommand cmd = new SqlCommand();
                            SqlDataReader reader;
                            cmd.CommandText = "spGetIdFromRUC";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("@RUC", textBox1.Text);
                            con.Open();
                            reader = cmd.ExecuteReader();
                            reader.Read();
                            id = reader.GetInt32(0);
                            con.Close();
                            delete(id);
                        }
                        catch
                        {
                            MessageBox.Show("No se encontraron datos del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                     
                    }
                }
                #endregion
            }

            if (Principal.State == (int)Principal.Estado.Colaborador)
            {
                #region
                using (SqlConnection con = new SqlConnection("Data Source=25.22.77.136,49170;Initial Catalog=imp_isabelita;Integrated Security=False;User ID=sa;Password=imprentaisabelita;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    int encontrado = 0;
                       
                            SqlCommand cmd = new SqlCommand();
                            cmd.CommandText = "spEliminarColaborador";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("@Cedula", textBox1.Text);
                            con.Open();
                            encontrado= cmd.ExecuteNonQuery();
                            con.Close();
                            if (encontrado == 0)
                            {
                                MessageBox.Show("No se encontraron datos del Colaborador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            if (encontrado > 0)
                            {
                                MessageBox.Show("Colaborador Eliminado Satisfactoriamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                this.Dispose();
                            }
                         

                }
                #endregion
            }


        }

        private void delete(int id)
        {
            int ingresado = 0;
            using (SqlConnection con = new SqlConnection("Data Source=25.22.77.136,49170;Initial Catalog=imp_isabelita;Integrated Security=False;User ID=sa;Password=imprentaisabelita;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "spEliminarCliente";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("@idCliente", id);
                ingresado= cmd.ExecuteNonQuery();
                con.Close();
            }
            if (ingresado > 0)
            {
                MessageBox.Show("Cliente Eliminado Satisfactoriamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Dispose();
            }

            
        }
    }
}
