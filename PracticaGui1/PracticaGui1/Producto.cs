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
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }

        private void Producto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            if (this.NameTextBox.Text != "" && this.TypeTextBox.Text != "" && this.DescriptionTextBox.Text != "" && this.QuantityTextBox.Text != "")
            {
                Inventario inv = new Inventario();
                inv.Show();
                this.Dispose();
            }
        }

        private void DescriptionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)8))
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
            }
        }
    }
}
