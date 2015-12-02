using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaGui1
{
    public partial class Pass : Form
    {
        public Pass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != "")
            {
                if (Colaboradores.GoColaborador)
                {
                    //Abrir lo de colaborador
                    AgregarColaborador AddCol = new AgregarColaborador();
                    AddCol.Show();
                    this.Dispose();
                }
                else
                {
                    //Abrir ventana de  Proveedor
                    AgregarProveedor AddProvedor = new AgregarProveedor();
                    AddProvedor.Show();
                    this.Dispose();

                }
            }
            else
            {
                MessageBox.Show("what did you do!!", "Oh god!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Pass_FormClosed(object sender, FormClosedEventArgs e)
        {
            Colaboradores Coll = new Colaboradores();
            Coll.Show();
        }
    }
}
