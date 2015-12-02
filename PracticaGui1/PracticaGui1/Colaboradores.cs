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
    public partial class Colaboradores : Form
    {
        public static bool GoColaborador = false;
        public Colaboradores()
        {
            InitializeComponent();
            this.ImprentaIsabelita.Size = new Size(700,303);
            //Esto centra la imagen ( El logo de Imprenta Isabelita ).
            this.ImprentaIsabelita.Left = (this.Width - this.ImprentaIsabelita.Width) / 2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Colaboradores_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Colaboradores_Load(object sender, EventArgs e)
        {

        }

        private void IngresarProd_Click(object sender, EventArgs e)
        {
            Producto produccion = new Producto();
            produccion.Show();
            this.Dispose();
        }

        private void MostrarProd_Click(object sender, EventArgs e)
        {
            Inventario inv = new Inventario();
            inv.Show();
            this.Dispose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Egresos egr = new Egresos();
            egr.Show();
            this.Dispose();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void IngresarColaborador_Click(object sender, EventArgs e)
        {
            Pass pass = new Pass();
            GoColaborador = true;
            pass.Show();
            this.Dispose();
        }

        private void IngresarNuevo_Click(object sender, EventArgs e)
        {
            Pass pass = new Pass();
            GoColaborador = false;
            pass.Show();
            this.Dispose();
        }

        private void IngresarTransacc_Click(object sender, EventArgs e)
        {
            OrdenDeTrabajo Orden = new OrdenDeTrabajo();
            Orden.Show();
        }
    }
}
