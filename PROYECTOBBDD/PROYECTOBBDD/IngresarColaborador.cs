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
    public partial class IngresarColaborador : Form
    {
        Validacion val = new Validacion();
        public IngresarColaborador()
        {
            InitializeComponent();
            button1.Enabled = false;
            InstanciarCombobox();
        }

        private void InstanciarCombobox()
        {
            comboBox1.Items.Add("SECRETARIO");
            comboBox1.Items.Add("DISEÑADOR");
            comboBox1.Items.Add("GERENTE");
            comboBox1.Items.Add("JEFE");
            comboBox1.Text = "...";
            /*
                ...
                SECRETTARIO
                PRENSISTA
                DISEÑADOR
                GERENTE
                JEFE
            */
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void IngresarColaborador_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bloquearBoton();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloLetras(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloLetras(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            bloquearBoton();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            bloquearBoton();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloLetras(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloLetras(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //algoritmo cedula
            if (textBox5.TextLength == 8)
                MessageBox.Show("Debe escribir un telefono valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!Principal.VerificaCedula(textBox3.Text))
                MessageBox.Show("Cedula ingresada no válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            bloquearBoton();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            bloquearBoton();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            bloquearBoton();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            bloquearBoton();
        }

        void bloquearBoton()
        {
            var bl = !string.IsNullOrEmpty(textBox1.Text) &&
                                !string.IsNullOrEmpty(textBox2.Text) &&
                                !string.IsNullOrEmpty(textBox3.Text)&&
                                comboBox1.Text != "..." &&
                                !string.IsNullOrEmpty(textBox5.Text) &&
                                !string.IsNullOrEmpty(textBox6.Text) &&
                                !string.IsNullOrEmpty(tContrasena.Text) &&
                                tContrasena.TextLength >= 6 &&
                                tContrasena.TextLength <= 16 &&
                                textBox5.TextLength >= 7;

            button1.Enabled = bl;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bloquearBoton();
        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {
            bloquearBoton();
        }

        private void tContrasena_TextChanged(object sender, EventArgs e)
        {
            bloquearBoton();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            bloquearBoton();
        }
    }
}