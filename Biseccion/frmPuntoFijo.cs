using AngouriMath;
using AngouriMath.Core.Compilation.IntoLinq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biseccion
{
    public partial class frmPuntoFijo : Form
    {
        public frmPuntoFijo()
        {
            InitializeComponent();
        }

        private void frmPuntoFijo_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Func<float, float> f;
            try
            {
                Entity.Variable x = "x";
                Entity expr = txtFuncion.Text;

                // Nueva forma de compilar:
                f = expr.Compile<Func<float, float>>(
                    new CompilationProtocol(),
                    typeof(float),
                    new[] { (typeof(float), x) }
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de sintaxis en la función: {ex.Message}");
                return;
            }

            bool r;
            float AproxRaiz = 0;
            SolEc1Var SolBisec = new SolEc1Var();
            SolBisec.x0 = float.Parse(txtx0.Text);
            SolBisec.ErrorMax = float.Parse(txtErrorMax.Text);
            SolBisec.NumMaxIter = int.Parse(txtNumMaxIter.Text);
            r = SolBisec.MetPuntoFijo(f, ref dgvPuntoFijo, ref AproxRaiz);


        }
    }
}
