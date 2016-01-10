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
    public partial class RegistrarEgreso : Form
    {
        Validacion val = new Validacion();
        public RegistrarEgreso()
        {
            InitializeComponent();
            button2.Enabled = false;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            BloquearBoton();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            BloquearBoton();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && textBox5.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            BloquearBoton();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            BloquearBoton();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BloquearBoton();
        }
        private void BloquearBoton()
        {
            var bl = !string.IsNullOrEmpty(textBox1.Text) &&
                     !string.IsNullOrEmpty(textBox2.Text) &&
                     !string.IsNullOrEmpty(textBox3.Text) &&
                     !string.IsNullOrEmpty(textBox4.Text) &&
                     !string.IsNullOrEmpty(textBox5.Text);

            button2.Enabled = bl;
        }
    }
}