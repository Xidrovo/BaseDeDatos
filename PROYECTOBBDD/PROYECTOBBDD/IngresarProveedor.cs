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
        private List<Label> labelList = new List<Label>();
        public IngresarProveedor()
        {
            InitializeComponent();
            lista.Add(this.lTelefono);
            labelList.Add(this.lteléfono);
            bGuardar.Enabled = false;
            bQuitar.Enabled = false;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            bool desicion = true;
            foreach (TextBox val in lista)
            {
                if (val.TextLength == 8)
                {
                    desicion = false;
                    val.BackColor = Color.PaleVioletRed;
                }
                else
                {
                    val.BackColor = Color.White;
                }
            }
            if (!desicion)
            {
                MessageBox.Show("Debe escribir un telefono valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!(Principal.VerificaRucEmpresas(textBox3.Text) || 
                        Principal.VerificaRucPersonaNatural(textBox3.Text)))
            {
                textBox3.BackColor = Color.PaleVioletRed;
                MessageBox.Show("RUC ingresado no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                desicion = false;
            }
            else
                textBox3.BackColor = Color.White;

            if (desicion)
            {
                //Comunicarme con el sql
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

            Telefono.Text = this.lteléfono.Text;
            Telefono.Size = this.lteléfono.Size;
            Telefono.Location = new Point(this.lteléfono.Location.X,
                                          this.lista.Last<TextBox>().Location.Y + 50);

            tTelefono.Size = this.lTelefono.Size;
            tTelefono.Location = new Point(this.lTelefono.Location.X,
                                          this.lista.Last<TextBox>().Location.Y + 50);

            Telefono.Show();
            tTelefono.Show();

            lista.Add(tTelefono);
            labelList.Add(Telefono);

            tTelefono.KeyPress += textBox5_KeyPress;
            tTelefono.KeyPress += lTelefono_TextChanged;
            tTelefono.MaxLength = 10;
            panel2.Controls.Add(tTelefono);
            panel2.Controls.Add(Telefono);

            bloquear_Boton();
            bQuitar.Enabled = true;
        }

        private void bloquear_Boton()
        {
            var bl = !string.IsNullOrEmpty(textBox1.Text) &&
                    !string.IsNullOrEmpty(textBox2.Text) &&
                    !string.IsNullOrEmpty(textBox3.Text) &&
                    !string.IsNullOrEmpty(textBox4.Text);

            foreach (TextBox var in lista)
            {
                if (var.TextLength < 7)
                {
                    bl = false;
                    break;
                }

            }
            bGuardar.Enabled = bl;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bloquear_Boton();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            bloquear_Boton();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            bloquear_Boton();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            bloquear_Boton();
        }

        private void lTelefono_TextChanged(object sender, EventArgs e)
        {
            bloquear_Boton();
        }

        private void bQuitar_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(lista[lista.Count - 1]);
            lista[lista.Count - 1].Dispose();
            lista.RemoveAt(lista.Count - 1);

            this.Controls.Remove(labelList[labelList.Count - 1]);
            labelList[labelList.Count - 1].Dispose();
            labelList.RemoveAt(labelList.Count - 1);

            if (lista.Count == 1)
            {
                bQuitar.Enabled = false;
            }
            bloquear_Boton();
        }
    }
}
