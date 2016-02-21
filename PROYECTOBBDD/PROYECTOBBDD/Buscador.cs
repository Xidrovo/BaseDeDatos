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
            if (Principal.State == (int)Principal.Estado.Cliente)
            {
                //Abrir lo de editar cliente
                //Buscar si existe el Id de lo que esté buscando.
                //En caso de existir y tener una longitud de 10, abrir el "IngresarPersonaNatural"
                //Caso contrario, y de existir, abrir "IngresarEmpresa"
                //Nótese que en estos caso la celda de RUC/Cédula debe estar bloqueada.
                using (SqlConnection con = new SqlConnection("Data Source=25.22.77.136,49170;Initial Catalog=imp_isabelita;Integrated Security=False;User ID=sa;Password=imprentaisabelita;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {

                }
                Buscador.Actualizar = true;
                IngresarPersonaNatural ing = new IngresarPersonaNatural();
                ing.Show();
                this.Dispose();
            }
            else if (Principal.State == (int)Principal.Estado.Colaborador)
            {
                //Abrir editar colaborador
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
