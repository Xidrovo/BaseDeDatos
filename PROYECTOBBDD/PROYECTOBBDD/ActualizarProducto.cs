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
    public partial class ActualizarProducto : Form
    {
        Validacion Val = new Validacion();
        public ActualizarProducto()
        {
            InitializeComponent();
            rAgregar.Checked = true;
            groupBox1.Controls.Add(rAgregar);
            groupBox1.Controls.Add(rQuitar);
            bActualizar.Enabled = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void Ingresar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.soloNumeros(e);
        }

        private void Ingresar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int Value = Int32.Parse(Ingresar.Text);

                if (Value > 0)
                {
                    bActualizar.Enabled = true;
                }
                else
                    bActualizar.Enabled = false;
            }
            catch (Exception exc)
            {
                bActualizar.Enabled = false;
            }
        }

        private void ActualizarProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
