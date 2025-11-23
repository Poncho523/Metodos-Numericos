using System;
using System.Drawing;
using System.Windows.Forms;

namespace Biseccion
{
    public partial class Form1 : Form
    {
        private Panel contenido; // Panel contenedor global para los formularios hijos

        public Form1()
        {
     
            InitializeComponent();
            
            DiseñarInterfaz();
        }

        public void DiseñarInterfaz()
        {
            
            this.Text = "Métodos Numéricos";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;
            this.ClientSize = new Size(1000, 650); // Tamaño total del formulario

            Panel header = new Panel();
            header.Dock = DockStyle.Top;
            header.Height = 60;
            header.BackColor = Color.FromArgb(35, 90, 160);
            this.Controls.Add(header);

            Label lblTitulo = new Label();
            lblTitulo.Text = "Métodos Numéricos";
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(25, 15);
            header.Controls.Add(lblTitulo);

            
            Panel menuPanel = new Panel();
            menuPanel.Dock = DockStyle.Left;
            menuPanel.Width = 220;
            menuPanel.BackColor = Color.FromArgb(240, 244, 248);
            this.Controls.Add(menuPanel);

            Label lblMenu = new Label();
            lblMenu.Text = "Solución de ecuaciones\n1 variable";
            lblMenu.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);
            lblMenu.ForeColor = Color.FromArgb(45, 45, 45);
            lblMenu.AutoSize = true;
            lblMenu.Location = new Point(20, 20);
            menuPanel.Controls.Add(lblMenu);

            
            contenido = new Panel();
            contenido.Dock = DockStyle.Fill;
            contenido.BackColor = Color.White;
         
            contenido.AutoScroll = true;
            this.Controls.Add(contenido);

            Label lblInfo = new Label();
            lblInfo.Text = "Seleccione un método en el menú izquierdo.";
            lblInfo.Font = new Font("Segoe UI", 12, FontStyle.Italic);
            lblInfo.ForeColor = Color.Gray;
            lblInfo.AutoSize = true;

            
            lblInfo.Location = new Point(
                (this.ClientSize.Width - menuPanel.Width - lblInfo.Width) / 2,
                (this.ClientSize.Height - header.Height - lblInfo.Height) / 2
            );
            contenido.Controls.Add(lblInfo);

            
            string[] metodos = { "Bisección", "Secante", "Falsa Posición", "Newton-Raphson", "Muller", "Punto Fijo" };
            int y = 80;

            foreach (string metodo in metodos)
            {
                Button btn = new Button();
                btn.Text = metodo;
                btn.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                btn.Size = new Size(180, 40);
                btn.Location = new Point(20, y);
                btn.BackColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.FromArgb(180, 180, 180);
                btn.ForeColor = Color.FromArgb(40, 40, 40);
                btn.Cursor = Cursors.Hand;

                btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(220, 230, 250);
                btn.MouseLeave += (s, e) => btn.BackColor = Color.White;

                
                btn.Click += (s, e) => AbrirFormulario(metodo);

                menuPanel.Controls.Add(btn);
                y += 55;
            }
        }

        
        private void AbrirFormulario(string metodo)
        {
            // Limpia el contenido anterior
            contenido.Controls.Clear();

            Form formHijo = null;

            switch (metodo)
            {
                case "Bisección":
                    formHijo = new frmBiseccion();
                    break;
                case "Secante":
                    formHijo = new frmSecante();
                    break;
                case "Falsa Posición":
                    formHijo = new frmFalsaP();
                    break;
                case "Newton-Raphson":
                    formHijo = new frmNewton();
                    break;
                case "Muller":
                    formHijo = new frmMulle();
                    break;
                case "Punto Fijo":
                    formHijo= new frmPuntoFijo();
                    break;
            }

            if (formHijo != null)
            {
                
                formHijo.TopLevel = false;
                formHijo.FormBorderStyle = FormBorderStyle.None; 
                formHijo.StartPosition = FormStartPosition.Manual;

                
                formHijo.Location = new Point(0, 0);

                

                contenido.Controls.Add(formHijo);
                formHijo.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}