using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PROYECTOBBDD
{
    class Productos_Inventario
    {
        public static List<Proveedor> ObtenerProveedores()
        {
            List<Proveedor> _lista = new List<Proveedor>();

            SqlConnection MiConexion = new SqlConnection();
            MiConexion = new SqlConnection("Data Source=25.22.77.136,49170;Initial Catalog=imp_isabelita;Integrated Security=False;User ID=sa;Password=imprentaisabelita;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            MiConexion.Open();
            SqlCommand _comando = new SqlCommand("select RUC , Nombre_empresa from Proveedor", MiConexion);
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Proveedor nProveedor = new Proveedor();

                nProveedor.RUC = _reader.GetString(0);
                nProveedor.Nombre_empresa = _reader.GetString(1);

                _lista.Add(nProveedor);
            }
            MiConexion.Close();
            return _lista;
        }
    }
}
