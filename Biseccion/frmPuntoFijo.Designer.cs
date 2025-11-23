namespace Biseccion
{
    partial class frmPuntoFijo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvPuntoFijo = new System.Windows.Forms.DataGridView();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtNumMaxIter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtErrorMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtx0 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumIter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntoFijo)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(565, 237);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Funcion";
            // 
            // txtFuncion
            // 
            this.txtFuncion.Location = new System.Drawing.Point(640, 237);
            this.txtFuncion.Margin = new System.Windows.Forms.Padding(4);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(204, 22);
            this.txtFuncion.TabIndex = 37;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(805, 600);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 27);
            this.btnSalir.TabIndex = 36;
            this.btnSalir.Text = "Salir:)";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // dgvPuntoFijo
            // 
            this.dgvPuntoFijo.AllowUserToAddRows = false;
            this.dgvPuntoFijo.AllowUserToDeleteRows = false;
            this.dgvPuntoFijo.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvPuntoFijo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuntoFijo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumIter,
            this.x0,
            this.xi,
            this.ErrorAct});
            this.dgvPuntoFijo.Location = new System.Drawing.Point(524, 311);
            this.dgvPuntoFijo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPuntoFijo.Name = "dgvPuntoFijo";
            this.dgvPuntoFijo.ReadOnly = true;
            this.dgvPuntoFijo.RowHeadersWidth = 51;
            this.dgvPuntoFijo.Size = new System.Drawing.Size(591, 266);
            this.dgvPuntoFijo.TabIndex = 35;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(947, 237);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(168, 28);
            this.btnCalcular.TabIndex = 34;
            this.btnCalcular.Text = "Calcular Raiz";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtNumMaxIter
            // 
            this.txtNumMaxIter.Location = new System.Drawing.Point(840, 177);
            this.txtNumMaxIter.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumMaxIter.Name = "txtNumMaxIter";
            this.txtNumMaxIter.Size = new System.Drawing.Size(132, 22);
            this.txtNumMaxIter.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(664, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "No° Max de iteraciones";
            // 
            // txtErrorMax
            // 
            this.txtErrorMax.Location = new System.Drawing.Point(981, 136);
            this.txtErrorMax.Margin = new System.Windows.Forms.Padding(4);
            this.txtErrorMax.Name = "txtErrorMax";
            this.txtErrorMax.Size = new System.Drawing.Size(132, 22);
            this.txtErrorMax.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(874, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Error Maximo=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(565, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 29;
            // 
            // txtx0
            // 
            this.txtx0.Location = new System.Drawing.Point(598, 136);
            this.txtx0.Margin = new System.Windows.Forms.Padding(4);
            this.txtx0.Name = "txtx0";
            this.txtx0.Size = new System.Drawing.Size(132, 22);
            this.txtx0.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(565, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "x0=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(676, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 31);
            this.label1.TabIndex = 26;
            this.label1.Text = "Metodo de Punto Fijo";
            // 
            // NumIter
            // 
            this.NumIter.HeaderText = "i";
            this.NumIter.MinimumWidth = 6;
            this.NumIter.Name = "NumIter";
            this.NumIter.ReadOnly = true;
            this.NumIter.Width = 125;
            // 
            // x0
            // 
            this.x0.HeaderText = "xi";
            this.x0.MinimumWidth = 6;
            this.x0.Name = "x0";
            this.x0.ReadOnly = true;
            this.x0.Width = 125;
            // 
            // xi
            // 
            this.xi.HeaderText = "g(xi)";
            this.xi.MinimumWidth = 6;
            this.xi.Name = "xi";
            this.xi.ReadOnly = true;
            this.xi.Width = 125;
            // 
            // ErrorAct
            // 
            this.ErrorAct.HeaderText = "Error";
            this.ErrorAct.MinimumWidth = 6;
            this.ErrorAct.Name = "ErrorAct";
            this.ErrorAct.ReadOnly = true;
            this.ErrorAct.Width = 125;
            // 
            // frmPuntoFijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 686);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFuncion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvPuntoFijo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNumMaxIter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtErrorMax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtx0);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPuntoFijo";
            this.Text = "frmPuntoFijo";
            this.Load += new System.EventHandler(this.frmPuntoFijo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntoFijo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvPuntoFijo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtNumMaxIter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtErrorMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtx0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumIter;
        private System.Windows.Forms.DataGridViewTextBoxColumn x0;
        private System.Windows.Forms.DataGridViewTextBoxColumn xi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorAct;
    }
}