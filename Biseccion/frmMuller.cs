using AngouriMath;
using AngouriMath.Core.Compilation.IntoLinq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Biseccion
{
    public partial class frmMulle : Form
    {
        public frmMulle()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Func<Complex, Complex> f_compleja;
            try
            {
                Entity.Variable x = "x";

                Entity expr = txtFuncion.Text;

                f_compleja = expr.Compile<Func<Complex, Complex>>(
                    new CompilationProtocol(),
                    typeof(Complex),
                    new[] { (typeof(Complex), x) }
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de sintaxis en la función: {ex.Message}");
                return;
            }
            bool result;
            SolEc1Var SolMuller = new SolEc1Var();
            Complex Aprox = new Complex();
            SolMuller.p0 = new Complex(double.Parse(txtp0_Real.Text), double.Parse(txtp0_Imaginario.Text));
            SolMuller.p1 = new Complex(double.Parse(txtp1_Real.Text), double.Parse(txtp1_Imaginario.Text));
            SolMuller.p2 = new Complex(double.Parse(txtp2_Real.Text), double.Parse(txtp2_Imaginario.Text));
            SolMuller.ErrorMax = float.Parse(txtErrorMax.Text);
            SolMuller.NumMaxIter = int.Parse(txtNumMaxIter.Text);

            result = SolMuller.Muller(f_compleja,ref Aprox, ref dgvMuller);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmMulle_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
