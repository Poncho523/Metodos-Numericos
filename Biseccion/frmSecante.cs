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
    public partial class frmSecante : Form
    {
        public frmSecante()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
            SolEc1Var SolSec = new SolEc1Var();

            SolSec.a = float.Parse(txtValor_a.Text);
            SolSec.b = float.Parse(txtValor_b.Text);
            SolSec.ErrorMax = float.Parse(txtErrorMax.Text);
            SolSec.NumMaxIter = int.Parse(txtNumMaxIter.Text);
            r = SolSec.MetSecante(f,ref dgvSecante, ref AproxRaiz);

        }

        private void dgvBiseccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
