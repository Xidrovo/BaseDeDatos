using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PROYECTOBBDD
{
    class Colaborador
    {
        SqlConnection MiConexion;
        public void Conectar()
        {
            MiConexion = new SqlConnection("Data Source=DANIEL-PC\\SQLEXPRESS;Initial Catalog=imp_isabelita;Persist Security Info=True;User ID=sa;Password=123456");
            MiConexion.Open();
        }

        public void Deconectar()
        {
            MiConexion.Close();
        }
        public void EjecutarSQL(String Query)
        {
            SqlCommand MiComando = new SqlCommand(Query,this.MiConexion);
            //Ejecuta el query
            int filasAfectadas = MiComando.ExecuteNonQuery();//regresa un valor entero
            if (filasAfectadas> 0)
                MessageBox.Show("Operación realizada exitosamente","La base ha sido modificada",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
                MessageBox.Show("Operación no fue realizada", "Error en el sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ActualizarGrid(DataGridView dg, String Query)
        {

            //Conectamos a bbddd
            this.Conectar();
            //Crear DataSet
            System.Data.DataSet MiDataSet = new System.Data.DataSet();
            //Crear Adaptador 
            SqlDataAdapter MiDataAdapter = new SqlDataAdapter(Query,MiConexion);
            
            //LLenar el Dataset
            MiDataAdapter.Fill(MiDataSet, "alumno");
            //Asignarle el valor apropiado a el Datagrid
            dg.DataSource = MiDataSet;
            dg.DataMember = "alumno";

            //Desconectar de la base de datos
            this.Deconectar();
        }

    }
}
