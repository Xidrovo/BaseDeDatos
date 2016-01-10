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
    public partial class ReporteEgresos : Form
    {
        Validacion val = new Validacion();

        public ReporteEgresos()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dFechaFinal_ValueChanged(object sender, EventArgs e)
        {
            if (dFechaFinal.Value <= dFechaInicio.Value)
            {
                MessageBox.Show("La fecha final debe ser mayor a la fecha inicio");

            }
        }
    }
}
