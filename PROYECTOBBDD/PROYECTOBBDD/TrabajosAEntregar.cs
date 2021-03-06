﻿using System;
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
    public partial class TrabajosAEntregar : Form
    {
        public TrabajosAEntregar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarTrabajos();
            //this.Close();
        }

        private void dFechaFinal_ValueChanged(object sender, EventArgs e)
        {
            if (dFechaFinal.Value <= dFechaInicio.Value)
            {
                MessageBox.Show("La fecha final debe ser mayor a la fecha inicio");

            }
        }
        public void MostrarTrabajos()
        {
            //Colaborador conexion = new Colaborador();
            using (SqlConnection con = new SqlConnection("Data Source=25.22.77.136,49170;Initial Catalog=imp_isabelita;Integrated Security=False;User ID=sa;Password=imprentaisabelita;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                using (SqlCommand cmd = new SqlCommand("spTrabajosAEntregar", con))
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FechaInicio", dFechaInicio.Text);
                    cmd.Parameters.AddWithValue("@FechaFinal", dFechaFinal.Text);
                    cmd.Parameters.AddWithValue("Id", Convert.ToInt32(comboBox1.SelectedValue));
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    celdaResultado.DataSource = dt;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TrabajosAEntregar_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Clientes_Id.ObtenerClientes();
            string texto;
            comboBox1.ValueMember = "Id";
            texto = comboBox1.DisplayMember;
            comboBox1.DisplayMember = "Nombre";
        }
    }
}
