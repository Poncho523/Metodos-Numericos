using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace Biseccion
{
    internal class SolEc1Var
    {
        public float a, b,x0;
        public int NumMaxIter;
        public float ErrorMax;
        public Complex p0, p1, p2; 

        public SolEc1Var(float a, float b, int numMaxIter, float errorMax)
        {
            this.a = a;
            this.b = b;
            NumMaxIter = numMaxIter;
            ErrorMax = errorMax;
        }

        public SolEc1Var()
        {
            a = 0;
            b = 0;
            NumMaxIter = 0;
            ErrorMax = 0;
        }


        //public Func<float, float> miFuncionDerivada;
        //public Func<Complex, Complex> miFuncionMuller;

        //public float f(float x)
        //{


          //  return (float)(Math.Pow(x, 3) - 2);
        //}
     

        public bool MetBiseccion(ref float AproxRaiz, Func<float, float> f)
        {
            int i = 0;
            float ErrorAct;
            float c;

            if (f(this.a) * f(this.b) > 0)
            {
                MessageBox.Show("No hay cambio de signo en el intervalo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (f(this.a) == 0 || f(this.b) == 0)
            {
                AproxRaiz = (f(this.a) == 0) ? this.a : this.b;
                return true;
            }
            while (i <= this.NumMaxIter)
            {
                c = (this.a + this.b) / 2;
                if (f(a) * f(c) < 0)
                {
                    this.b = c;
                }
                else
                {
                    this.a = c;
                }
                ErrorAct = (this.b - this.a);
                if (ErrorAct <= this.ErrorMax)
                {
                    AproxRaiz = c;
                    return true;
                }
                i++;
            }
            MessageBox.Show("No hay cambio de signo en el intervalo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;

        }


        public bool MetBiseccion(Func<float, float> f, ref DataGridView dgvBiseccion, ref float AproxRaiz)
        {
            
            int i = 0;
            int IndiceRenglon;
            float ErrorAct;
            float c;

            if (f(this.a) * f(this.b) > 0)
            {
                MessageBox.Show("No hay cambio de signo en el intervalo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (f(this.a) == 0 || f(this.b) == 0)
            {
                AproxRaiz = (f(this.a) == 0) ? this.a : this.b;
                return true;
            }
            while (i <= this.NumMaxIter)
            {
                c = (this.a + this.b) / 2;
                dgvBiseccion.Rows.Add();
                IndiceRenglon = dgvBiseccion.Rows.Count - 1;
                dgvBiseccion.Rows[IndiceRenglon].Cells[0].Value = i.ToString();
                dgvBiseccion.Rows[IndiceRenglon].Cells[1].Value = this.a.ToString();
                dgvBiseccion.Rows[IndiceRenglon].Cells[2].Value = c.ToString();
                dgvBiseccion.Rows[IndiceRenglon].Cells[3].Value = this.b.ToString();
                dgvBiseccion.Rows[IndiceRenglon].Cells[4].Value = f(a) > 0 ? "+" : "-";
                dgvBiseccion.Rows[IndiceRenglon].Cells[5].Value = f(c) > 0 ? "+" : "-";
                dgvBiseccion.Rows[IndiceRenglon].Cells[6].Value = f(b) > 0 ? "+" : "-";


                if (f(a) * f(c) < 0)
                {
                    this.b = c;
                }
                else
                {
                    this.a = c;
                }
                ErrorAct = (this.b - this.a);
                dgvBiseccion.Rows[IndiceRenglon].Cells[7].Value = ErrorAct.ToString();
                if (ErrorAct <= this.ErrorMax)
                {
                    AproxRaiz = c;
                    return true;
                }
                i++;
            }
            MessageBox.Show("No hay cambio de signo en el intervalo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;

        }

        public bool MetSecante(Func<float, float> f, ref float AproxRaiz)
        {
            int i = 0;
            float ErrorAct;
            float a = this.a;  
            float b = this.b;  
            float c;           

            while (i <= this.NumMaxIter)
            {
                if (f(b) - f(a) == 0)
                {
                    MessageBox.Show("División entre cero en la Secante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                c = b - f(b) * (b - a) / (f(b) - f(a));
                ErrorAct = Math.Abs(c - b);

                if (ErrorAct <= this.ErrorMax)
                {
                    AproxRaiz = c;
                    return true;
                }
                a = b;
                b = c;
                i++;
            }

            MessageBox.Show("No se encontró raíz con el método de la Secante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        public bool MetSecante(Func<float, float> f,ref DataGridView dgvSecante, ref float AproxRaiz)
        {
            int i = 0;
            int IndiceRenglon;
            float ErrorAct;
            float a = this.a;
            float b = this.b;
            float c;

            while (i <= this.NumMaxIter)
            {
                if (f(b) - f(a) == 0)
                {
                    MessageBox.Show("División entre cero en la Secante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                c = b - f(b) * (b - a) / (f(b) - f(a));
                ErrorAct = Math.Abs(c - b);

                dgvSecante.Rows.Add();
                IndiceRenglon = dgvSecante.Rows.Count - 1;
                dgvSecante.Rows[IndiceRenglon].Cells[0].Value = i.ToString();
                dgvSecante.Rows[IndiceRenglon].Cells[1].Value = a.ToString();
                dgvSecante.Rows[IndiceRenglon].Cells[2].Value = b.ToString();
                dgvSecante.Rows[IndiceRenglon].Cells[3].Value = c.ToString();
                dgvSecante.Rows[IndiceRenglon].Cells[4].Value = f(a).ToString();
                dgvSecante.Rows[IndiceRenglon].Cells[5].Value = f(b).ToString();
                dgvSecante.Rows[IndiceRenglon].Cells[6].Value = ErrorAct.ToString();

                if (ErrorAct <= this.ErrorMax)
                {
                    AproxRaiz = c;
                    return true;
                }

                
                a = b;
                b = c;
                i++;
            }

            MessageBox.Show("No se encontró raíz con el método de la Secante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        public bool Muller(Func<Complex, Complex> f_muller, ref Complex AproxRaiz, ref DataGridView dgvMuller)
        {
            int IterAct = 0;
            Complex v1, v2,p3;
            Complex a = new Complex(), b = new Complex(), c = new Complex();
            float ErrorAct;

            while (IterAct <= this.NumMaxIter)
            {
                dgvMuller.Rows.Add();

                c = f_muller(p2);
                b = Complex.Pow((p0 - p2), 2) * (f_muller(p1) - f_muller(p2)) -
                    Complex.Pow((p1 - p2), 2) * (f_muller(p0) - f_muller(p2));
                b = b / ((p0 - p2) * (p1 - p2) * (p0 - p1));
                a = (p1 - p2) * (f_muller(p0) - f_muller(p2)) - (p0 - p2) *
                    (f_muller(p1) - f_muller(p2));
                a = a / ((p0 - p2) * (p1 - p2) * (p0 - p1));

                v1 = b + Complex.Pow(Complex.Pow(b, 2) - 4 * a * c, 0.5);
                v2 = b - Complex.Pow(Complex.Pow(b, 2) - 4 * a * c, 0.5);

                if (Complex.Abs(v1) > Complex.Abs(v2))//modulo del num complejo
                    p3 = p2 - 2 * c / v1;
                else
                    p3 = p2 - 2 * c / v2;
                ErrorAct = (float)Complex.Abs(p3 - p2);
                dgvMuller.Rows[IterAct].Cells[0].Value = IterAct.ToString();
                dgvMuller.Rows[IterAct].Cells[1].Value = p0.ToString();
                dgvMuller.Rows[IterAct].Cells[2].Value = p1.ToString();
                dgvMuller.Rows[IterAct].Cells[3].Value = p2.ToString();
                dgvMuller.Rows[IterAct].Cells[4].Value = p3.ToString();
                dgvMuller.Rows[IterAct].Cells[5].Value = ErrorAct.ToString();

                if (ErrorAct<=this.ErrorMax)
                {
                    AproxRaiz = p3;
                    return true;
                }
                p0=p1; 
                p1= p2; 
                p2= p3;
                IterAct++;
            }
            MessageBox.Show("No se encontró raíz ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;

        }

        public bool MetNewton(Func<float, float> f,Func<float, float> f_derivada, ref float AproxRaiz, float x0)
        {
            int i = 0;
            float ErrorAct;
            float x1;

            while (i <= this.NumMaxIter)
            {
                if (f_derivada(x0) == 0)
                {
                    MessageBox.Show("Derivada nula. Newton no puede continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                x1 = x0 - f(x0) / f_derivada(x0);
                ErrorAct = Math.Abs(x1 - x0);

                if (ErrorAct <= this.ErrorMax)
                {
                    AproxRaiz = x1;
                    return true;
                }

                x0 = x1;
                i++;
            }
            MessageBox.Show("No se encontró raíz con Newton-Raphson", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public bool MetNewton(Func<float, float> f, Func<float, float> f_derivada, ref DataGridView dgvNewton, ref float AproxRaiz)
        {
            int i = 0;
            int IndiceRenglon;
            float ErrorAct;
            float x1;

            while (i <= this.NumMaxIter)
            {
                if (f_derivada(x0) == 0)
                {
                    MessageBox.Show("Derivada nula. Newton no puede continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                x1 = x0 - f(x0) / f_derivada(x0);
                ErrorAct = Math.Abs(x1 - x0);

                dgvNewton.Rows.Add();
                IndiceRenglon = dgvNewton.Rows.Count - 1;
                dgvNewton.Rows[IndiceRenglon].Cells[0].Value = i.ToString();
                dgvNewton.Rows[IndiceRenglon].Cells[1].Value = x0.ToString();
                dgvNewton.Rows[IndiceRenglon].Cells[2].Value = x1.ToString();
                dgvNewton.Rows[IndiceRenglon].Cells[3].Value = ErrorAct.ToString();

                if (ErrorAct <= this.ErrorMax)
                {
                    AproxRaiz = x1;
                    return true;
                }

                x0 = x1;
                i++;
            }
            MessageBox.Show("No se encontró raíz con Newton-Raphson", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        public bool MetFalsaPosicion(Func<float, float> f,ref float AproxRaiz)
        {
            int i = 0;
            float ErrorAct;
            float c;
            float a = this.a;
            float b = this.b;

            if (f(a) * f(b) > 0)
            {
                MessageBox.Show("No hay cambio de signo en el intervalo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            while (i <= this.NumMaxIter)
            {
                c = (a * f(b) - b * f(a)) / (f(b) - f(a)); 
                ErrorAct = Math.Abs(f(c));

                if (ErrorAct <= this.ErrorMax)
                {
                    AproxRaiz = c;
                    return true;
                }

                if (f(a) * f(c) < 0)
                {
                    b = c;
                }
                else
                {
                    a = c;
                }
                i++;
            }

            MessageBox.Show("No se encontró raíz con Falsa Posición", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public bool MetFalsaPosicion(Func<float, float> f, ref DataGridView dgvFalsaPos, ref float AproxRaiz)
        {
            int i = 0;
            int IndiceRenglon;
            float ErrorAct;
            float c;
            float a = this.a;
            float b = this.b;

            if (f(a) * f(b) > 0)
            {
                MessageBox.Show("No hay cambio de signo en el intervalo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            while (i <= this.NumMaxIter)
            {
                c = (a * f(b) - b * f(a)) / (f(b) - f(a));
                ErrorAct = Math.Abs(f(c));

                dgvFalsaPos.Rows.Add();
                IndiceRenglon = dgvFalsaPos.Rows.Count - 1;
                dgvFalsaPos.Rows[IndiceRenglon].Cells[0].Value = i.ToString();
                dgvFalsaPos.Rows[IndiceRenglon].Cells[1].Value = a.ToString();
                dgvFalsaPos.Rows[IndiceRenglon].Cells[2].Value = c.ToString();
                dgvFalsaPos.Rows[IndiceRenglon].Cells[3].Value = b.ToString();
                dgvFalsaPos.Rows[IndiceRenglon].Cells[4].Value = f(a) > 0 ? "+" : "-";
                dgvFalsaPos.Rows[IndiceRenglon].Cells[5].Value = f(c) > 0 ? "+" : "-";
                dgvFalsaPos.Rows[IndiceRenglon].Cells[6].Value = f(b) > 0 ? "+" : "-";
                dgvFalsaPos.Rows[IndiceRenglon].Cells[7].Value = ErrorAct.ToString();

                if (ErrorAct <= this.ErrorMax)
                {
                    AproxRaiz = c;
                    return true;
                }

                if (f(a) * f(c) < 0)
                {
                    b = c;
                }
                else
                {
                    a = c;
                }
                i++;
            }

            MessageBox.Show("No se encontró raíz con Falsa Posición", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        public bool MetPuntoFijo(Func<float, float> f, ref DataGridView dgvPuntoFijo, ref float AproxRaiz)
        {
            int i = 0;
            int IndiceRenglon;
            float ErrorAct;
            float x1;

            while (i <= this.NumMaxIter)
            {

                x1 = f(x0);
                ErrorAct = Math.Abs(x1 - x0);

                dgvPuntoFijo.Rows.Add();
                IndiceRenglon = dgvPuntoFijo.Rows.Count - 1;
                dgvPuntoFijo.Rows[IndiceRenglon].Cells[0].Value = i.ToString();
                dgvPuntoFijo.Rows[IndiceRenglon].Cells[1].Value = x0.ToString();
                dgvPuntoFijo.Rows[IndiceRenglon].Cells[2].Value = x1.ToString();
                dgvPuntoFijo.Rows[IndiceRenglon].Cells[3].Value = ErrorAct.ToString();

                if (ErrorAct <= this.ErrorMax)
                {
                    AproxRaiz = x1;
                    return true;
                }

                x0 = x1;
                i++;
            }
            MessageBox.Show("No se encontró raíz con Punto fjo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}
