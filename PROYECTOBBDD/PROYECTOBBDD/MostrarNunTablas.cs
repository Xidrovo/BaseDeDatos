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
    public partial class MostrarNunTablas : Form
    {
        public MostrarNunTablas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void MostrarNunTablas_Load(object sender, EventArgs e)
        {
            Colaborador objeto = new Colaborador();
            objeto.ActualizarGrid(this.dataGridView1, "SELECT COUNT(*) AS NÚMERO_TABLAS FROM information_schema.tables");
        }
    }
}
