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
    public partial class Buscador : Form
    {
        public static bool Actualizar;
        public static string[] informacion = new string[10];
        public Buscador()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Buscador_Load(object sender, EventArgs e)
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

        private void Buscar_Click(object sender, EventArgs e)
        {
            int ContTemp;
            bool error = false;
            if (Principal.State == (int)Principal.Estado.Cliente)
            {
                //Abrir lo de editar cliente
                //Buscar si existe el Id de lo que esté buscando.
                //En caso de existir y tener una longitud de 10, abrir el "IngresarPersonaNatural"
                //Caso contrario, y de existir, abrir "IngresarEmpresa"
                //Nótese que en estos caso la celda de RUC/Cédula debe estar bloqueada.
                    using (SqlConnection con = new SqlConnection("Data Source=25.22.77.136,49170;Initial Catalog=imp_isabelita;Integrated Security=False;User ID=sa;Password=imprentaisabelita;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                    {
                    if (textBox1.Text.Length == 10)
                    {
                        #region
                        SqlCommand cmd = new SqlCommand();
                        SqlDataReader reader;
                        cmd.CommandText = "buscarInfoPesonaNatural";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@Ncedula", textBox1.Text);
                        con.Open();
                        reader = cmd.ExecuteReader();
                        reader.Read();
                        //NCedula   [0]
                        //Nombre    [1]
                        //Apellido  [2]
                        //Direccion [3]
                        //Telefono  [4]...[9]
                        try
                        {
                            informacion[0] = reader.GetString(0);
                            informacion[1] = reader.GetString(1);
                            informacion[2] = reader.GetString(2);
                            informacion[3] = reader.GetString(3);
                            informacion[4] = reader.GetString(4);

                            ContTemp = 5;
                            while (reader.Read())
                            {
                                informacion[ContTemp] = reader.GetString(4);
                                ContTemp++;
                            }
                        }
                        catch
                        {
                            error = true;
                        }
                        con.Close();
                        #endregion
                    }
                    else if (textBox1.Text.Length == 13)
                    {
                        #region
                        // RUC para pruebas 1400016877001
                        SqlCommand cmd = new SqlCommand();
                        SqlDataReader reader;
                        cmd.CommandText = "buscarInfoEmpresas";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@RUC", textBox1.Text);
                        con.Open();
                        reader = cmd.ExecuteReader();
                        reader.Read();
                        //RUC   [0]
                        //RazonSocial    [1]
                        //Direccion  [2]
                        //Telefonos [3] .. [9]
                        try
                        {
                            informacion[0] = reader.GetString(0);
                            informacion[1] = reader.GetString(1);
                            informacion[2] = reader.GetString(2);
                            informacion[3] = reader.GetString(3);

                            ContTemp = 4;
                            while (reader.Read())
                            {
                                informacion[ContTemp] = reader.GetString(3);
                                ContTemp++;
                            }
                        }
                        catch
                        {
                            error = true;
                        }
                        con.Close();
                        #endregion
                    }
                    else
                    {
                        error = true;
                    }
                        /*
                        cmd.CommandText = "buscarInfoPesonaNatural";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@Cedula", textBox1.Text);
                        sqlConnection1.Open();

                        reader = cmd.ExecuteReader();
                        */
                    }
                if (!error)
                {
                    Buscador.Actualizar = true;
                    if (textBox1.Text.Length == 10)
                    {
                        IngresarPersonaNatural ing = new IngresarPersonaNatural();
                        ing.Show();
                    }
                    else
                    {
                        IngresarEmpresa ing2 = new IngresarEmpresa();
                        ing2.Show();
                    }
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("No se encontraron datos del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (Principal.State == (int)Principal.Estado.Colaborador)
            {
                //Abrir editar colaborador
                using (SqlConnection con = new SqlConnection("Data Source=25.22.77.136,49170;Initial Catalog=imp_isabelita;Integrated Security=False;User ID=sa;Password=imprentaisabelita;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    if (textBox1.Text.Length == 10)
                    {
                        SqlCommand cmd = new SqlCommand();
                        SqlDataReader reader;
                        cmd.CommandText = "spConsultarColaborador";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@ced", textBox1.Text);
                        con.Open();
                        reader = cmd.ExecuteReader();
                        reader.Read();
                    }
                }

            }
            else if (Principal.State == (int)Principal.Estado.Inventario)
            {
                //Abrir editar Inventario
            }
            else
            {
                //Abrir proveedor
            }
        }
    }
}
