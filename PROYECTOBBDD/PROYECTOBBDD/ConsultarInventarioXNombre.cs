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
    public partial class ConsultarInventarioXNombre : Form
    {
        Validacion val = new Validacion();
        public ConsultarInventarioXNombre()
        {
            InitializeComponent();
            button2.Enabled = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloLetras(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BloquearBoton();
        }
        private void BloquearBoton()
        {
            var bl = !string.IsNullOrEmpty(textBox1.Text);
            button2.Enabled = bl;
        }
    }
}