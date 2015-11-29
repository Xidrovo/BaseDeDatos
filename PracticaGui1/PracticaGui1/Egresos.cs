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
        public Egresos()
        {
            string[] myList = new string[4];

            myList[0] = "One";
            myList[1] = "Two";
            myList[2] = "Three";
            myList[3] = "Four";

            InitializeComponent();
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
            Colaboradores col = new Colaboradores();
            col.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Colaboradores col = new Colaboradores();
            col.Show();
            this.Dispose();
        }
    }
}
