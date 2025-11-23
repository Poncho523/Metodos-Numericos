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
    public partial class frmBiseccion : Form
    {
        public frmBiseccion()
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
            SolEc1Var SolBisec = new SolEc1Var();

            SolBisec.a = float.Parse(txtValor_a.Text);
            SolBisec.b = float.Parse(txtValor_b.Text);
            SolBisec.ErrorMax = float.Parse(txtErrorMax.Text);
            SolBisec.NumMaxIter= int.Parse(txtNumMaxIter.Text);
            r = SolBisec.MetBiseccion(f, ref dgvBiseccion, ref AproxRaiz);

        }

        private void dgvBiseccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNumMaxIter_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtErrorMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtValor_b_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtValor_a_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
