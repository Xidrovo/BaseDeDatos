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
    public partial class Descripciones : Form
    {
        private List<TextBox> lista;
        public Descripciones()
        {
            lista = new List<TextBox>();
            InitializeComponent();

            panel1.Controls.Add(Desc1);
            panel1.Controls.Add(Valor);
            panel1.Controls.Add(Cantidad);
            panel1.Controls.Add(LaValor);
            panel1.Controls.Add(LaCantidad);
            panel1.Controls.Add(LaDescripcion);


            lista.Add(Desc1);
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            Label NValor = new Label();
            Label NCantidad = new Label();
            Label NDescripcion = new Label();

            NValor.Text = this.LaValor.Text;
            NValor.Font = this.LaValor.Font;

            NCantidad.Text = this.LaCantidad.Text;
            NCantidad.Font = this.LaCantidad.Font;

            NDescripcion.Text = this.LaDescripcion.Text;
            NDescripcion.Font = this.LaDescripcion.Font;
            
            TextBox valor = new TextBox();
            valor.Multiline = true;
            valor.Size = this.Valor.Size;

            TextBox cantidad = new TextBox();
            cantidad.Multiline = true;
            cantidad.Size = this.Cantidad.Size;

            TextBox descripcion = new TextBox();
            descripcion.Multiline = true;
            descripcion.Size = this.Desc1.Size;
            descripcion.ScrollBars = ScrollBars.Vertical;


            valor.Location = new Point(lista.Last<TextBox>().Location.X, lista.Last<TextBox>().Location.Y + 135);
            cantidad.Location = new Point(valor.Location.X, valor.Location.Y + 40);
            descripcion.Location = new Point(cantidad.Location.X, cantidad.Location.Y + 69);
            


            NValor.Location = new Point(LaValor.Location.X, lista.Last<TextBox>().Location.Y + 135);
            NCantidad.Location = new Point(LaValor.Location.X, valor.Location.Y + 40);
            NDescripcion.Location = new Point(LaValor.Location.X, cantidad.Location.Y + 69);

            lista.Add(descripcion);
            NValor.Show();
            NCantidad.Show();
            NDescripcion.Show();

            valor.Show();
            cantidad.Show();
            descripcion.Show();


            panel1.Controls.Add(NValor);
            panel1.Controls.Add(NCantidad);
            panel1.Controls.Add(NDescripcion);
            panel1.Controls.Add(valor);
            panel1.Controls.Add(cantidad);
            panel1.Controls.Add(descripcion);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((this.Cantidad.Text != "") && (this.Valor.Text != "") && (this.Desc1.Text != ""))
            {
                Egresos.Descrito = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Agrega al menos una descripción!", "Oh god!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)8))
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void Valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)8))
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
            }
        }
    }
}
