using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOBBDD
{
    public partial class ConsultaClientesXRUC : Form
    {
        Validacion val = new Validacion();
        public ConsultaClientesXRUC()
        {
            InitializeComponent();
            bConsulta.Enabled = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void bConsulta_Click(object sender, EventArgs e)
        {
            if (Principal.VerificaRucEmpresas(textBox1.Text) || Principal.VerificaRucPersonaNatural(textBox1.Text))
            {
                //Consultar Query
            }
            else
            {
                MessageBox.Show("Debe escribir un RUC valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BloquearBoton();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConsultaClientesXRUC_Load(object sender, EventArgs e)
        {

        }
        private void BloquearBoton()
        {
            var bl = !string.IsNullOrEmpty(textBox1.Text) && textBox1.TextLength == 13;

            bConsulta.Enabled = bl;
        }
    }
}