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
    public partial class Egresos : Form
    {
        public static bool Descrito = false;
        public List<TextBox> Descripciones;
        private Descripciones desc = new Descripciones();

        public Egresos()
        {
            InitializeComponent();
            Descripciones = new List<TextBox>();
            Descripciones.Add(this.Desc1);

        }

        private void Egresos_Load(object sender, EventArgs e)
        {

        }

        private void Egresos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Descrito)
            {
                Colaboradores col = new Colaboradores();
                col.Show();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Describa más el proceso", "Don't be lazy~",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Colaboradores col = new Colaboradores();
            col.Show();
            this.Dispose();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (! ( char.IsNumber(e.KeyChar) || e.KeyChar == (char)8) )
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)8))
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)8))
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)8))
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void NumFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)8))
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            desc.Show();
        }
    }
}

/*
//Agregará más descripciones para poder escribir en ellas. Estas descripciones son guardadas en una lista de descripciones
            TextBox Desc = new TextBox();
            Desc.Location = new Point(Desc1.Location.X, Descripciones.Last<TextBox>().Location.Y + 100);
            Desc.Multiline = true;
            Desc.Size = new Size(Desc1.Width, Desc1.Height);
            Desc.Show();
            Desc.ScrollBars = ScrollBars.Vertical;

            Descripciones.Add(Desc);
            DescPanel.Controls.Add(Desc);   
*/
