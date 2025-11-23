namespace Biseccion
{
    partial class frmNewton
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvNewton = new System.Windows.Forms.DataGridView();
            this.NumIter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtNumMaxIter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtErrorMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtx0 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewton)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(780, 624);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 27);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir:)";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvNewton
            // 
            this.dgvNewton.AllowUserToAddRows = false;
            this.dgvNewton.AllowUserToDeleteRows = false;
            this.dgvNewton.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvNewton.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewton.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumIter,
            this.x0,
            this.x1,
            this.ErrorAct});
            this.dgvNewton.Location = new System.Drawing.Point(499, 335);
            this.dgvNewton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvNewton.Name = "dgvNewton";
            this.dgvNewton.ReadOnly = true;
            this.dgvNewton.RowHeadersWidth = 51;
            this.dgvNewton.Size = new System.Drawing.Size(591, 266);
            this.dgvNewton.TabIndex = 22;
            this.dgvNewton.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBiseccion_CellContentClick);
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
            this.x0.HeaderText = "x0";
            this.x0.MinimumWidth = 6;
            this.x0.Name = "x0";
            this.x0.ReadOnly = true;
            this.x0.Width = 125;
            // 
            // x1
            // 
            this.x1.HeaderText = "x1";
            this.x1.MinimumWidth = 6;
            this.x1.Name = "x1";
            this.x1.ReadOnly = true;
            this.x1.Width = 125;
            // 
            // ErrorAct
            // 
            this.ErrorAct.HeaderText = "Error";
            this.ErrorAct.MinimumWidth = 6;
            this.ErrorAct.Name = "ErrorAct";
            this.ErrorAct.ReadOnly = true;
            this.ErrorAct.Width = 125;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(922, 261);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(168, 28);
            this.btnCalcular.TabIndex = 21;
            this.btnCalcular.Text = "Calcular Raiz";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtNumMaxIter
            // 
            this.txtNumMaxIter.Location = new System.Drawing.Point(815, 201);
            this.txtNumMaxIter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumMaxIter.Name = "txtNumMaxIter";
            this.txtNumMaxIter.Size = new System.Drawing.Size(132, 22);
            this.txtNumMaxIter.TabIndex = 20;
            this.txtNumMaxIter.TextChanged += new System.EventHandler(this.txtNumMaxIter_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(639, 204);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "No° Max de iteraciones";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtErrorMax
            // 
            this.txtErrorMax.Location = new System.Drawing.Point(956, 160);
            this.txtErrorMax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtErrorMax.Name = "txtErrorMax";
            this.txtErrorMax.Size = new System.Drawing.Size(132, 22);
            this.txtErrorMax.TabIndex = 18;
            this.txtErrorMax.TextChanged += new System.EventHandler(this.txtErrorMax_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(849, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Error Maximo=";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 15;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtx0
            // 
            this.txtx0.Location = new System.Drawing.Point(573, 160);
            this.txtx0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtx0.Name = "txtx0";
            this.txtx0.Size = new System.Drawing.Size(132, 22);
            this.txtx0.TabIndex = 14;
            this.txtx0.TextChanged += new System.EventHandler(this.txtValor_a_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(540, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "x0=";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(651, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Metodo de Newton";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFuncion
            // 
            this.txtFuncion.Location = new System.Drawing.Point(615, 261);
            this.txtFuncion.Margin = new System.Windows.Forms.Padding(4);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(204, 22);
            this.txtFuncion.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(540, 261);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Funcion";
            // 
            // frmNewton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 746);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFuncion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvNewton);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNumMaxIter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtErrorMax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtx0);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmNewton";
            this.Text = "frmNewton";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvNewton;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn x1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorAct;
        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.Label label6;
    }
}