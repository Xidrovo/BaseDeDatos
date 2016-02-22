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

        private void Eliminador_Load(object sender, EventArgs e)
        {
            
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (Principal.State == (int)Principal.Estado.Cliente)
            {
                using (SqlConnection con = new SqlConnection("Data Source=25.22.77.136,49170;Initial Catalog=imp_isabelita;Integrated Security=False;User ID=sa;Password=imprentaisabelita;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    if (textBox1.Text.Length == 10)
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
                        SqlCommand cmd2 = new SqlCommand();
                        cmd2.CommandText = "spEliminarCliente";
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Connection = con;
                        con.Open();
                        cmd2.Parameters.AddWithValue("@idCliente", id);
                        con.Close();
                    }
                    if (textBox1.Text.Length == 13)
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
                        SqlCommand cmd2 = new SqlCommand();
                        cmd2.CommandText = "spEliminarCliente";
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Connection = con;
                        con.Open();
                        cmd2.Parameters.AddWithValue("@idCliente", id);
                        con.Close();
                    }
                }
            }
        }
    }
}

