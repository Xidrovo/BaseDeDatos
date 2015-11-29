using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaGui1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SplashImage Splash = new SplashImage();
            if (Splash.ShowDialog() == DialogResult.OK)
            { 
                Application.Run(new LogIn());
            }
        }
    }
}
