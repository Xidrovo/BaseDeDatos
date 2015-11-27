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
    public partial class SplashImage : Form
    {
        public SplashImage()
        {
            InitializeComponent();
        }

        private void SplashImage_Load(object sender, EventArgs e)
        {
            this.AutoSize = false;
            this.Size = new Size(980,444);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 5;
            }
            else
            {
                timer1.Stop();
                timer1.Enabled = false;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
