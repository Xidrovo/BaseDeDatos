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
    public partial class Title1 : Form
    {
        String palabra;
        SplashImage Splash = new SplashImage();
        public Title1()
        {
            InitializeComponent();
        }

        private void Title1_Load(object sender, EventArgs e)
        {
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Yes; 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            palabra = Username.Text;
            
        }
    }
}
