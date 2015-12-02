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
    public partial class OrdenDeTrabajo : Form
    {
        private List<TextBox> lista;
        private int Cont;
        public OrdenDeTrabajo()
        {
            lista = new List<TextBox>();
            Cont = 1;

            InitializeComponent();

            /*
            panel1.Controls.Add(Tr1);

            panel1.Controls.Add(Valor); panel1.Controls.Add(Val);
            panel1.Controls.Add(Descripcion); panel1.Controls.Add(Desc);
            panel1.Controls.Add(Cantidad); panel1.Controls.Add(Cant);
            */

            lista.Add(Desc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Se guardan los datos.
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cont++;
            Label LaValor = new Label(), LaDescripcion = new Label(), LaCantidad = new Label(), TrN = new Label();
            TextBox TValor = new TextBox(), TDesc = new TextBox(), TCant = new TextBox();

            TrN.Text = "--Trabajo" + Cont + "--";
            TrN.Location = new Point(Tr1.Location.X, lista.Last<TextBox>().Location.Y + 105);
            TrN.Font = this.Tr1.Font;

            LaValor.Text = this.Valor.Text;
            LaValor.Location = new Point(Valor.Location.X, TrN.Location.Y + 35);
            LaValor.Font = this.Valor.Font;

            TValor.Multiline = true;
            TValor.Size = this.Val.Size;
            TValor.Location = new Point(Valor.Location.X + 54, LaValor.Location.Y);


            LaCantidad.Text = this.Cantidad.Text;
            LaCantidad.Location = new Point(Cantidad.Location.X, TrN.Location.Y + 35);
            LaCantidad.Font = this.Cantidad.Font;

            TCant.Multiline = true;
            TCant.Size = this.Cant.Size;
            TCant.Location = new Point(Cantidad.Location.X + 54, LaCantidad.Location.Y);


            LaDescripcion.Text = this.Desc.Text;
            LaDescripcion.Location = new Point(lista.Last<TextBox>().Location.X - 54, LaValor.Location.Y + 31);
            LaDescripcion.Font = this.Desc.Font;

            TDesc.Multiline = true;
            TDesc.Size = this.Desc.Size;
            TDesc.Location = new Point(LaDescripcion.Location.X + 54, LaDescripcion.Location.Y);

            lista.Add(TDesc);

            TrN.Show();
            LaValor.Show();
            TValor.Show();
            LaCantidad.Show();
            TCant.Show();
            LaDescripcion.Show();
            TDesc.Show();

            panel1.Controls.Add(TrN);
            panel1.Controls.Add(LaValor);
            panel1.Controls.Add(TValor);
            panel1.Controls.Add(LaCantidad);
            panel1.Controls.Add(TCant);
            panel1.Controls.Add(LaDescripcion);
            panel1.Controls.Add(TDesc);
        }
    }
}
