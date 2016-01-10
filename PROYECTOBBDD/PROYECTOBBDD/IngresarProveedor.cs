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

    public partial class IngresarProveedor : Form
    {
        Validacion val = new Validacion();
        List<TextBox> lista = new List<TextBox>();
        public IngresarProveedor()
        {
            InitializeComponent();
            lista.Add(this.lTelefono);
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == ""
                    || textBox3.Text == "" || textBox4.Text == "" || !IngresarPersonaNatural.HasSomething(lista))
            {
                //u campo no fue llenado
            }
            else
            {  
                this.Close();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloLetras(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloLetras(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloLetras(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void lagreagar_Click(object sender, EventArgs e)
        {
            Label Telefono = new Label();
            TextBox tTelefono = new TextBox();

            Telefono.Text = this.lTelefono.Text;
            Telefono.Size = this.lTelefono.Size;
            Telefono.Location = new Point(this.lTelefono.Location.X,
                                          this.lista.Last<TextBox>().Location.Y + 50);

            tTelefono.Size = this.lTelefono.Size;
            tTelefono.Location = new Point(this.lTelefono.Location.X,
                                          this.lista.Last<TextBox>().Location.Y + 50);

            tTelefono.Show();
            Telefono.Show();

            lista.Add(tTelefono);

            tTelefono.KeyPress += textBox5_KeyPress;
            tTelefono.MaxLength = 10;
            panel2.Controls.Add(tTelefono);
            panel2.Controls.Add(Telefono);
        }

        private void lagreagar_Click_1(object sender, EventArgs e)
        {
            Label Telefono = new Label();
            TextBox tTelefono = new TextBox();

            Telefono.Text = this.lTelefono.Text;
            Telefono.Size = this.lTelefono.Size;
            Telefono.Location = new Point(this.lTelefono.Location.X,
                                          this.lista.Last<TextBox>().Location.Y + 50);

            tTelefono.Size = this.lTelefono.Size;
            tTelefono.Location = new Point(this.lTelefono.Location.X,
                                          this.lista.Last<TextBox>().Location.Y + 50);

            tTelefono.Show();
            Telefono.Show();

            lista.Add(tTelefono);

            tTelefono.KeyPress += textBox5_KeyPress;
            tTelefono.MaxLength = 10;
            panel2.Controls.Add(tTelefono);
            panel2.Controls.Add(Telefono);
        }
    }
}
