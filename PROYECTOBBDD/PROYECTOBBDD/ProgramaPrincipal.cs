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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (PracticaGui1.LogIn.Cargo != "JEFE")
            {
                reportesToolStripMenuItem.Enabled = false;
                reportesToolStripMenuItem.Visible = false;
            }

            if (!(PracticaGui1.LogIn.Cargo == "JEFE" || PracticaGui1.LogIn.Cargo == "SECRETARIO"))
            {
                reportesToolStripMenuItem.Enabled = false;
                reportesToolStripMenuItem.Visible = false;

                colaboradoresToolStripMenuItem.Enabled = false;
                colaboradoresToolStripMenuItem.Visible = false;
            }
        }

        private void clientesPorRUcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaClientesXRUC conClieRUC = new ConsultaClientesXRUC();
            conClieRUC.MdiParent = this; //PAra que se ejecute ingresarTrabajo dentro de la pantalla de principal 
            conClieRUC.Show();
        }

        private void ingresosDiariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteIngresos repIng = new ReporteIngresos();
            repIng.MdiParent = this;
            repIng.Show();
        }

        private void consultarPorNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void desconectarseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void ingresarTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresarTrabajo inTrabajo = new IngresarTrabajo();
            inTrabajo.MdiParent = this; //PAra que se ejecute ingresarTrabajo dentro de la pantalla de principal 
            inTrabajo.Show();    
        }


        private void colaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ingresarColaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresarColaborador inColaborador = new IngresarColaborador();
            inColaborador.MdiParent = this; //PAra que se ejecute ingresarTrabajo dentro de la pantalla de principal 
            inColaborador.Show();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresarEmpresa ingEm = new IngresarEmpresa();
            ingEm.MdiParent = this; //PAra que se ejecute ingresarTrabajo dentro de la pantalla de principal 
            ingEm.Show();

        }

        private void ingresarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresarProveedor ingPr = new IngresarProveedor();
            ingPr.MdiParent = this;
            ingPr.Show();
        }

        private void personaNaturalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresarPersonaNatural ingPe = new IngresarPersonaNatural();
            ingPe.MdiParent = this; //PAra que se ejecute ingresarTrabajo dentro de la pantalla de principal 
            ingPe.Show();
        }

        private void ingresarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresarProducto ingProducto = new IngresarProducto();
            ingProducto.MdiParent = this;
            ingProducto.Show();
        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturar fac = new Facturar();
            fac.MdiParent = this;
            fac.Show();
        }

        private void trabajosAEntregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrabajosAEntregar traEnt = new TrabajosAEntregar();
            traEnt.MdiParent = this;
            traEnt.Show();
        }

        private void porNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarProveedorPorNombre conProveNombre = new ConsultarProveedorPorNombre();
            conProveNombre.MdiParent = this;
            conProveNombre.Show();
        }

        private void porNombreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarInventarioXNombre conInvNombre = new ConsultarInventarioXNombre();
            conInvNombre.MdiParent = this;
            conInvNombre.Show();
        }

        private void egresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteEgresos repEgre = new ReporteEgresos();
            repEgre.MdiParent = this;
            repEgre.Show();
        }

        private void registrarEgresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarEgreso regEgre = new RegistrarEgreso();
            regEgre.MdiParent = this;
            regEgre.Show();
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public static bool VerificaCedula(string ced)
        {
            int isNumeric;
            var total = 0;
            const int tamanoLongitudCedula = 10;
            int[] coeficientes = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
            const int numeroProvincias = 24;
            const int tercerDigito = 6;

            if (int.TryParse(ced, out isNumeric) && ced.Length == tamanoLongitudCedula)
            {
                var provincias = Convert.ToInt32(string.Concat(ced[0], ced[1], string.Empty));
                var digitoTres = Convert.ToInt32(ced[2] + string.Empty);
                if ((provincias > 0 && provincias <= numeroProvincias) && digitoTres < tercerDigito)
                {
                    var digitoVerificadorRecibido = Convert.ToInt32(ced[9] + string.Empty);
                    for (var k = 0; k < coeficientes.Length; k++)
                    {
                        var valor = Convert.ToInt32(coeficientes[k] + string.Empty) *
                                    Convert.ToInt32(ced[k] + string.Empty);
                        total = valor >= 10 ? total + (valor - 9) : total + valor;
                    }
                    var digitoVerificadorObtenido = total >= 10 ? (total % 10) != 0 ?
                                                                    10 - (total % 10) : (total % 10) : total;
                    return digitoVerificadorObtenido == digitoVerificadorRecibido;
                }
            }
            return false;
        }

        public static bool VerificaRucEmpresas(string ruc)
        {
            long isNumeric;
            const int tamanoLongitudRuc = 13;
            const int modulo = 11;
            const int tercerDigito = 6;
            var total = 0;
            const string establecimiento = "0001";
            int[] coeficientes = { 3, 2, 7, 6, 5, 4, 3, 2 };
            if (long.TryParse(ruc, out isNumeric) && ruc.Length.Equals(tamanoLongitudRuc))
            {
                var numeroProvincia = Convert.ToInt32(string.Concat(ruc[0] + string.Empty, ruc[1] + string.Empty));
                var sociedadPublica = Convert.ToInt32(ruc[2] + string.Empty);
                if ((numeroProvincia >= 1 && numeroProvincia <= 24) &&
                    sociedadPublica == tercerDigito && ruc.Substring(9, 4) == establecimiento)
                {
                    var digitoVerificadorRecibido = Convert.ToInt32(ruc[8] + string.Empty);
                    for (var i = 0; i < coeficientes.Length; i++)
                    {
                        total = total + (coeficientes[i] * Convert.ToInt32(ruc[i] + string.Empty));
                    }
                    var digitoVerificadorobtenido = modulo - (total % modulo);
                    return digitoVerificadorRecibido == digitoVerificadorobtenido;
                }
                return false;
            }
            return false;
        }

        public static bool VerificaRucPersonaNatural(string ruc)
        {
            long isNumeric;
            const int tamanoLongitudRuc = 13;
            const string establecimiento = "001";
            if (long.TryParse(ruc, out isNumeric) && ruc.Length.Equals(tamanoLongitudRuc))
            {
                var numeroProvincia = Convert.ToInt32(string.Concat(ruc[0] + string.Empty, ruc[1] + string.Empty));
                var personaNatural = Convert.ToInt32(ruc[2] + string.Empty);
                if ((numeroProvincia >= 1 && numeroProvincia <= 24) && (personaNatural >= 0 && personaNatural < 6))
                {
                    return ruc.Substring(10, 3) == establecimiento && VerificaCedula(ruc.Substring(0, 10));
                }
                return false;
            }
            return false;
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarProducto actProd = new ActualizarProducto();
            actProd.MdiParent = this;
            actProd.Show();
        }

        private void clientesPorCédulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaCLientesCedula cons = new ConsultaCLientesCedula();
            cons.MdiParent = this;
            cons.Show();
        }

        private void porCedulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarColaborador consultarColaborador = new ConsultarColaborador();
            consultarColaborador.MdiParent = this; //PAra que se ejecute ingresarTrabajo dentro de la pantalla de principal 
            consultarColaborador.Show();
        }

        private void sustentarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sustentacion sust = new Sustentacion();
            sust.MdiParent = this;
            sust.Show();
        }
    }
}
