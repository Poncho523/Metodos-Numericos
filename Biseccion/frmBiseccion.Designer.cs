namespace Biseccion
{
    partial class frmBiseccion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor_a = new System.Windows.Forms.TextBox();
            this.txtValor_b = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtErrorMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumMaxIter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.dgvBiseccion = new System.Windows.Forms.DataGridView();
            this.NumIter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colum_a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Func_a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Func_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Func_b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorAprox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBiseccion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(529, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Metodo de Bisección";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "a=";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtValor_a
            // 
            this.txtValor_a.Location = new System.Drawing.Point(452, 182);
            this.txtValor_a.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValor_a.Name = "txtValor_a";
            this.txtValor_a.Size = new System.Drawing.Size(132, 22);
            this.txtValor_a.TabIndex = 2;
            this.txtValor_a.TextChanged += new System.EventHandler(this.txtValor_a_TextChanged);
            // 
            // txtValor_b
            // 
            this.txtValor_b.Location = new System.Drawing.Point(452, 231);
            this.txtValor_b.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValor_b.Name = "txtValor_b";
            this.txtValor_b.Size = new System.Drawing.Size(132, 22);
            this.txtValor_b.TabIndex = 4;
            this.txtValor_b.TextChanged += new System.EventHandler(this.txtValor_b_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "b=";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtErrorMax
            // 
            this.txtErrorMax.Location = new System.Drawing.Point(835, 182);
            this.txtErrorMax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtErrorMax.Name = "txtErrorMax";
            this.txtErrorMax.Size = new System.Drawing.Size(132, 22);
            this.txtErrorMax.TabIndex = 6;
            this.txtErrorMax.TextChanged += new System.EventHandler(this.txtErrorMax_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(728, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Error Maximo=";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNumMaxIter
            // 
            this.txtNumMaxIter.Location = new System.Drawing.Point(891, 226);
            this.txtNumMaxIter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumMaxIter.Name = "txtNumMaxIter";
            this.txtNumMaxIter.Size = new System.Drawing.Size(132, 22);
            this.txtNumMaxIter.TabIndex = 8;
            this.txtNumMaxIter.TextChanged += new System.EventHandler(this.txtNumMaxIter_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(727, 230);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "No° Max de iteraciones";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(799, 285);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(168, 28);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular Raiz";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // dgvBiseccion
            // 
            this.dgvBiseccion.AllowUserToAddRows = false;
            this.dgvBiseccion.AllowUserToDeleteRows = false;
            this.dgvBiseccion.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvBiseccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBiseccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumIter,
            this.Colum_a,
            this.Column_c,
            this.Column_b,
            this.Func_a,
            this.Func_c,
            this.Func_b,
            this.ErrorAprox});
            this.dgvBiseccion.Location = new System.Drawing.Point(303, 347);
            this.dgvBiseccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBiseccion.Name = "dgvBiseccion";
            this.dgvBiseccion.ReadOnly = true;
            this.dgvBiseccion.RowHeadersWidth = 51;
            this.dgvBiseccion.Size = new System.Drawing.Size(804, 188);
            this.dgvBiseccion.TabIndex = 10;
            this.dgvBiseccion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBiseccion_CellContentClick);
            // 
            // NumIter
            // 
            this.NumIter.HeaderText = "i";
            this.NumIter.MinimumWidth = 6;
            this.NumIter.Name = "NumIter";
            this.NumIter.ReadOnly = true;
            this.NumIter.Width = 20;
            // 
            // Colum_a
            // 
            this.Colum_a.HeaderText = "a";
            this.Colum_a.MinimumWidth = 6;
            this.Colum_a.Name = "Colum_a";
            this.Colum_a.ReadOnly = true;
            this.Colum_a.Width = 125;
            // 
            // Column_c
            // 
            this.Column_c.HeaderText = "c";
            this.Column_c.MinimumWidth = 6;
            this.Column_c.Name = "Column_c";
            this.Column_c.ReadOnly = true;
            this.Column_c.Width = 125;
            // 
            // Column_b
            // 
            this.Column_b.HeaderText = "b";
            this.Column_b.MinimumWidth = 6;
            this.Column_b.Name = "Column_b";
            this.Column_b.ReadOnly = true;
            this.Column_b.Width = 125;
            // 
            // Func_a
            // 
            this.Func_a.HeaderText = "f(a)";
            this.Func_a.MinimumWidth = 6;
            this.Func_a.Name = "Func_a";
            this.Func_a.ReadOnly = true;
            this.Func_a.Width = 125;
            // 
            // Func_c
            // 
            this.Func_c.HeaderText = "f(c)";
            this.Func_c.MinimumWidth = 6;
            this.Func_c.Name = "Func_c";
            this.Func_c.ReadOnly = true;
            this.Func_c.Width = 125;
            // 
            // Func_b
            // 
            this.Func_b.HeaderText = "f(b)";
            this.Func_b.MinimumWidth = 6;
            this.Func_b.Name = "Func_b";
            this.Func_b.ReadOnly = true;
            this.Func_b.Width = 125;
            // 
            // ErrorAprox
            // 
            this.ErrorAprox.HeaderText = "Error";
            this.ErrorAprox.MinimumWidth = 6;
            this.ErrorAprox.Name = "ErrorAprox";
            this.ErrorAprox.ReadOnly = true;
            this.ErrorAprox.Width = 125;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(663, 560);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 27);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir:)";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtFuncion
            // 
            this.txtFuncion.Location = new System.Drawing.Point(422, 294);
            this.txtFuncion.Margin = new System.Windows.Forms.Padding(4);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(222, 22);
            this.txtFuncion.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 300);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Funcion";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // frmBiseccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 843);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFuncion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvBiseccion);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNumMaxIter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtErrorMax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValor_b);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValor_a);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBiseccion";
            this.Text = "frmBiseccion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBiseccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValor_a;
        private System.Windows.Forms.TextBox txtValor_b;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtErrorMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumMaxIter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridView dgvBiseccion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumIter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colum_a;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_b;
        private System.Windows.Forms.DataGridViewTextBoxColumn Func_a;
        private System.Windows.Forms.DataGridViewTextBoxColumn Func_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn Func_b;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorAprox;
        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.Label label6;
    }
}