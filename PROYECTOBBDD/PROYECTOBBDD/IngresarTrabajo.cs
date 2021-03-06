﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace PROYECTOBBDD
{
    public partial class IngresarTrabajo : Form

    {

        Validacion val = new Validacion();
        List<TextBox> listaDesc = new List<TextBox>();
        List<TextBox> listaCant = new List<TextBox>();
        List<TextBox> listaVal = new List<TextBox>();

        List<Label> listaLabelDesc = new List<Label>();
        List<Label> listaLabelCant = new List<Label>();
        List<Label> listaLabelVal = new List<Label>();
        public IngresarTrabajo()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            listaDesc.Add(tDescripcion);
            listaCant.Add(tcantidad);
            listaVal.Add(tvalor);

            bQuitar.Enabled = false;

        }

        private void contIngTra_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lFecPed_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lFecha_entrega_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dfechaPedido.Value.CompareTo(this.dfechaEntrega.Value) == 1)
            {
                MessageBox.Show("Las fechas de Entrega debe ser mayor a la fecha de Pedido");

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabono_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;


            if (ch == 46 && tabono.Text.IndexOf('.') != -1) //Un solo punto decimal
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46) //Permite retroceso y punto decimal
            {
                e.Handled = true;
            }
            if (Regex.IsMatch(tabono.Text, @"\.\d\d") && !Char.IsControl(ch)) // Controla que solo exista dos digitos desupués del punto decimal
            {
                e.Handled = true;
            }




        }

        private void tidcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {


            char ch = e.KeyChar;


            if (ch == 46 && tvalor.Text.IndexOf('.') != -1) //Un solo punto decimal
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46) //Permite retroceso y punto decimal
            {
                e.Handled = true;
            }
            if (Regex.IsMatch(tvalor.Text, @"\.\d\d") && !Char.IsControl(ch)) // Controla que solo exista dos digitos desupués del punto decimal
            {
                e.Handled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            val.soloLetras(e);
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            bool desicion = true;
            float abono = 0, total;


            try
            {
                abono = float.Parse(tabono.Text);
            }
            catch
            {
            }

            total = sumaValores(listaVal);
            if (!(abono >= (total * 0.5) && abono < total))
            {
                desicion = false;
                tabono.BackColor = Color.PaleVioletRed;
                MessageBox.Show("Abono no supera el 50% ó supera el total", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tabono.BackColor = Color.White;
            }

            if (desicion)
            {
                //Comunicarme con sql
                AddTrabajo(Convert.ToString(comboBox1.SelectedValue), dfechaPedido.Text, dfechaEntrega.Text, float.Parse(tabono.Text));
                this.Close();
            }
        }

        private float sumaValores(List<TextBox> lista)
        {
            float resultado = 0;
            float contenedor;
            foreach (TextBox val in lista)
            {
                try
                {
                    contenedor = float.Parse(val.Text);
                    resultado = resultado + contenedor;
                }
                catch { }
            }

            return resultado;
        }

        private bool HasDetails()
        {
            int Cont = 0;
            foreach (TextBox texto in listaDesc)
            {
                if (texto.Text != "")
                {
                    if (listaCant[Cont].Text != "" &&
                            listaVal[Cont].Text != "")
                    {
                        return true;
                    }
                }

                Cont++;
            }
            return false;
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            Label cantidad, valor, descripcion;
            TextBox textCantidad, textValor, textDescripcion;

            cantidad = new Label();
            valor = new Label();
            descripcion = new Label();

            textCantidad = new TextBox();
            textValor = new TextBox();
            textDescripcion = new TextBox();


            cantidad.Text = this.lcantidad.Text;
            valor.Text = this.lvalor.Text;
            descripcion.Text = this.lDescripcion.Text;

            textCantidad.Size = this.tcantidad.Size;
            textCantidad.TabIndex = 2;
            textValor.Size = this.tvalor.Size;
            textValor.TabIndex = 2;
            textDescripcion.Multiline = true;
            textDescripcion.Size = this.tDescripcion.Size;


            cantidad.Location = new Point(this.lcantidad.Location.X, listaDesc.Last<TextBox>().Location.Y + 100);
            textCantidad.Location = new Point(this.tcantidad.Location.X, cantidad.Location.Y);

            valor.Location = new Point(this.lvalor.Location.X, cantidad.Location.Y);
            textValor.Location = new Point(this.tvalor.Location.X, valor.Location.Y);

            descripcion.Location = new Point(this.lDescripcion.Location.X, cantidad.Location.Y + 58);
            textDescripcion.Location = new Point(this.tDescripcion.Location.X, descripcion.Location.Y);

            // textBox1_KeyPress

            //textValor.KeyPress += tvalor_KeyPress;
            textValor.KeyPress += tvalor_KeyPress;
            textValor.MaxLength = 7;

            textCantidad.KeyPress += tcantidad_KeyPress;
            textCantidad.MaxLength = 7;

            textDescripcion.KeyPress += tDescripcion_KeyPress;
            textCantidad.MaxLength = 150;

            cantidad.Show();
            textCantidad.Show();
            valor.Show();
            textValor.Show();
            descripcion.Show();
            textDescripcion.Show();

            panel2.Controls.Add(textCantidad);
            panel2.Controls.Add(cantidad);
            panel2.Controls.Add(textValor);
            panel2.Controls.Add(valor);
            panel2.Controls.Add(descripcion);
            panel2.Controls.Add(textDescripcion);

            listaDesc.Add(textDescripcion);
            listaLabelDesc.Add(descripcion);
            listaCant.Add(textCantidad);
            listaLabelCant.Add(cantidad);
            listaVal.Add(textValor);
            listaLabelVal.Add(valor);

            bQuitar.Enabled = true;

        }

        private void tabono_TextChanged(object sender, EventArgs e)
        {

        }

        private void tvalor_TextChanged(object sender, EventArgs e)
        {

        }

        private void tvalor_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            var algo = sender as TextBox;
            string temporal = algo.Text;

            temporal = algo.Text + ch.ToString();

            if (ch == 46 && algo.Text.IndexOf('.') != -1) //Un solo punto decimal
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46) //Permite retroceso y punto decimal
            {
                e.Handled = true;
                return;
            }

            if (Regex.IsMatch(algo.Text, @"\.\d\d") && !Char.IsControl(ch)) // Controla que solo exista dos digitos desupués del punto decimal
            {
                e.Handled = true;
                return;
            }
        }

        private void tcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }



        private void tDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloLetras(e);
        }

        private void dfechaEntrega_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void lIdcliente_Click(object sender, EventArgs e)
        {

        }

        private void tvalor_KeyUp(object sender, KeyEventArgs e)
        {

        }

        //Dada una RUC, retorna el Id del mismo.
        //Retorna '0' si el RUC no está en la base de datos.
        private int GetIdFromRuc(string RUC)
        {
            int Numero = -1;
            using (SqlConnection con = new SqlConnection("Data Source=25.22.77.136,49170;Database=imp_isabelita;Integrated Security=False;User ID=sa;Password=imprentaisabelita;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                using (SqlCommand cmd = new SqlCommand("spGetIdFromRUC", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@RUC", SqlDbType.VarChar).Value = RUC;
                    con.Open();
                    try
                    {
                        Numero = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    catch { }
                    con.Close();
                }
            }
            return Numero;
        }

        private void AddTrabajo(string RUC, string FechaPedido, string FechaEntrega, float Abono)
        {
            int ingresado = 0;
            using (SqlConnection con = new SqlConnection("Data Source=25.22.77.136,49170;Database=imp_isabelita;Integrated Security=False;User ID=sa;Password=imprentaisabelita;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                using (SqlCommand cmd = new SqlCommand("spCrearTrabajo", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Fecha_pedido", FechaPedido);
                    cmd.Parameters.AddWithValue("@Fecha_entrega", FechaEntrega);
                    cmd.Parameters.AddWithValue("Abono", Abono);
                    cmd.Parameters.AddWithValue("Id_Cliente", Convert.ToInt32(comboBox1.SelectedValue));
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            using (SqlConnection con2 = new SqlConnection("Data Source=25.22.77.136,49170;Database=imp_isabelita;Integrated Security=False;User ID=sa;Password=imprentaisabelita;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {

                SqlConnection sqlConnection1 = new SqlConnection("Data Source=25.22.77.136,49170;Database=imp_isabelita;Integrated Security=False;User ID=sa;Password=imprentaisabelita;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlCommand cmd3 = new SqlCommand();
                SqlDataReader reader;
                cmd3.CommandText = "SELECT MAX(Trabajo.Id_Trabajo) FROM Trabajo";
                cmd3.CommandType = CommandType.Text;
                cmd3.Connection = sqlConnection1;
                sqlConnection1.Open();
                reader = cmd3.ExecuteReader();
                reader.Read();
                int id_trabajo = reader.GetInt32(0);
                for (int i = 0; i < listaDesc.Count(); i++)
                {
                    using (SqlCommand cmd2 = new SqlCommand("spCrearDescripcion_Trabajo", con2))
                    {
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@Descripcion", listaDesc.ElementAt(i).Text);
                        cmd2.Parameters.AddWithValue("@Cantidad", Convert.ToInt32(listaCant.ElementAt(i).Text));
                        cmd2.Parameters.AddWithValue("@Valor", float.Parse(listaVal.ElementAt(i).Text));
                        cmd2.Parameters.AddWithValue("@Id_Trabajo", id_trabajo);
                        con2.Open();
                        ingresado=cmd2.ExecuteNonQuery();
                        con2.Close();
                    }
                }
                sqlConnection1.Close();
            }
            if (ingresado > 0)
            {
                MessageBox.Show("Trabajo Ingresado Satisfactoriamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void bQuitar_Click(object sender, EventArgs e)
        {
            //Lista de cantidad
            this.Controls.Remove(listaCant[listaCant.Count - 1]);
            listaCant[listaCant.Count - 1].Dispose();
            listaCant.RemoveAt(listaCant.Count - 1);

            this.Controls.Remove(listaLabelCant[listaLabelCant.Count - 1]);
            listaLabelCant[listaLabelCant.Count - 1].Dispose();
            listaLabelCant.RemoveAt(listaLabelCant.Count - 1);

            //Lista de descripción
            this.Controls.Remove(listaDesc[listaDesc.Count - 1]);
            listaDesc[listaDesc.Count - 1].Dispose();
            listaDesc.RemoveAt(listaDesc.Count - 1);

            this.Controls.Remove(listaLabelDesc[listaLabelDesc.Count - 1]);
            listaLabelDesc[listaLabelDesc.Count - 1].Dispose();
            listaLabelDesc.RemoveAt(listaLabelDesc.Count - 1);

            //Lista de Valor
            this.Controls.Remove(listaVal[listaVal.Count - 1]);
            listaVal[listaVal.Count - 1].Dispose();
            listaVal.RemoveAt(listaVal.Count - 1);

            this.Controls.Remove(listaLabelVal[listaLabelVal.Count - 1]);
            listaLabelVal[listaLabelVal.Count - 1].Dispose();
            listaLabelVal.RemoveAt(listaLabelVal.Count - 1);

            if (listaCant.Count == 1)
            {
                bQuitar.Enabled = false;
            }
        }

        private void IngresarTrabajo_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Clientes_Id.ObtenerClientes();
            string texto;
            comboBox1.ValueMember = "Id";
            texto = comboBox1.DisplayMember;
            comboBox1.DisplayMember = "Nombre";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
