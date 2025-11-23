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
    public partial class frmNewton : Form
    {
        public frmNewton()
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
            Func<float, float> f_prima;  
            try
            {
                Entity.Variable x = "x";
                Entity expr = txtFuncion.Text; 

                f = expr.Compile<Func<float, float>>(
                    new CompilationProtocol(),
                    typeof(float),
                    new[] { (typeof(float), x) }
                    );

                Entity expr_derivada = expr.Differentiate(x); 

                f_prima = expr_derivada.Compile<Func<float, float>>(
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
            SolEc1Var SolNewton = new SolEc1Var();
            SolNewton.x0 = float.Parse(txtx0.Text);              
            SolNewton.ErrorMax = float.Parse(txtErrorMax.Text);  
            SolNewton.NumMaxIter = int.Parse(txtNumMaxIter.Text);
            r = SolNewton.MetNewton(f,f_prima,ref dgvNewton, ref AproxRaiz);
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

        private void dgvBiseccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
