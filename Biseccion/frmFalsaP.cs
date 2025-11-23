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
using AngouriMath.Core.Compilation.IntoLinq;
using AngouriMath;
namespace Biseccion
{
    public partial class frmFalsaP : Form
    {
        public frmFalsaP()
        {
            InitializeComponent();
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
            SolEc1Var SolFalsaP = new SolEc1Var();

            SolFalsaP.a = float.Parse(txtValor_a.Text);
            SolFalsaP.b = float.Parse(txtValor_b.Text);
            SolFalsaP.ErrorMax = float.Parse(txtErrorMax.Text);
            SolFalsaP.NumMaxIter = int.Parse(txtNumMaxIter.Text);
            r = SolFalsaP.MetFalsaPosicion(f,ref dgvFalsaPos, ref AproxRaiz);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
