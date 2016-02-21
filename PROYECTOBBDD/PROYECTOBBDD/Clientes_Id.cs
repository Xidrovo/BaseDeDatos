using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PROYECTOBBDD
{
    class Clientes_Id
    {
        public static List<Cliente> ObtenerClientes()
        {
            List<Cliente> _lista = new List<Cliente>();

            SqlConnection MiConexion = new SqlConnection();
            MiConexion = new SqlConnection("Data Source=25.22.77.136,49170;Initial Catalog=imp_isabelita;Integrated Security=False;User ID=sa;Password=imprentaisabelita;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            MiConexion.Open();
            SqlCommand _comando = new SqlCommand("MostrarClientes", MiConexion);
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Cliente nCliente = new Cliente();

                nCliente.Nombre = _reader.GetString(0);
                nCliente.Id = Convert.ToString(_reader.GetInt32(1));

                _lista.Add(nCliente);
            }
            MiConexion.Close();
            return _lista;
        }
    }
}