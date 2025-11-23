namespace Biseccion
{
    partial class frmFalsaP
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
            this.dgvFalsaPos = new System.Windows.Forms.DataGridView();
            this.NumIter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colum_a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Func_a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Func_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Func_b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtNumMaxIter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtErrorMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor_b = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor_a = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFalsaPos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(787, 656);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 27);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir:)";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvFalsaPos
            // 
            this.dgvFalsaPos.AllowUserToAddRows = false;
            this.dgvFalsaPos.AllowUserToDeleteRows = false;
            this.dgvFalsaPos.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvFalsaPos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFalsaPos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumIter,
            this.Colum_a,
            this.Column_c,
            this.Column_b,
            this.Func_a,
            this.Func_c,
            this.Func_b,
            this.ErrorAct});
            this.dgvFalsaPos.Location = new System.Drawing.Point(255, 391);
            this.dgvFalsaPos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFalsaPos.Name = "dgvFalsaPos";
            this.dgvFalsaPos.ReadOnly = true;
            this.dgvFalsaPos.RowHeadersWidth = 51;
            this.dgvFalsaPos.Size = new System.Drawing.Size(1041, 241);
            this.dgvFalsaPos.TabIndex = 22;
            // 
            // NumIter
            // 
            this.NumIter.HeaderText = "i";
            this.NumIter.MinimumWidth = 6;
            this.NumIter.Name = "NumIter";
            this.NumIter.ReadOnly = true;
            this.NumIter.Width = 50;
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
            this.btnCalcular.Location = new System.Drawing.Point(880, 324);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(168, 28);
            this.btnCalcular.TabIndex = 21;
            this.btnCalcular.Text = "Calcular Raiz";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtNumMaxIter
            // 
            this.txtNumMaxIter.Location = new System.Drawing.Point(972, 252);
            this.txtNumMaxIter.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumMaxIter.Name = "txtNumMaxIter";
            this.txtNumMaxIter.Size = new System.Drawing.Size(132, 22);
            this.txtNumMaxIter.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(808, 256);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "No° Max de iteraciones";
            // 
            // txtErrorMax
            // 
            this.txtErrorMax.Location = new System.Drawing.Point(916, 208);
            this.txtErrorMax.Margin = new System.Windows.Forms.Padding(4);
            this.txtErrorMax.Name = "txtErrorMax";
            this.txtErrorMax.Size = new System.Drawing.Size(132, 22);
            this.txtErrorMax.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(809, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Error Maximo=";
            // 
            // txtValor_b
            // 
            this.txtValor_b.Location = new System.Drawing.Point(533, 257);
            this.txtValor_b.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor_b.Name = "txtValor_b";
            this.txtValor_b.Size = new System.Drawing.Size(132, 22);
            this.txtValor_b.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 261);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "b=";
            // 
            // txtValor_a
            // 
            this.txtValor_a.Location = new System.Drawing.Point(533, 208);
            this.txtValor_a.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor_a.Name = "txtValor_a";
            this.txtValor_a.Size = new System.Drawing.Size(132, 22);
            this.txtValor_a.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "a=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(611, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Metodo de Falsa Posición";
            // 
            // txtFuncion
            // 
            this.txtFuncion.Location = new System.Drawing.Point(533, 324);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(218, 22);
            this.txtFuncion.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(468, 324);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Funcion";
            // 
            // frmFalsaP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 789);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFuncion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvFalsaPos);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFalsaP";
            this.Text = "frmFalsaP";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFalsaPos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvFalsaPos;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtNumMaxIter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtErrorMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValor_b;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValor_a;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumIter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colum_a;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_b;
        private System.Windows.Forms.DataGridViewTextBoxColumn Func_a;
        private System.Windows.Forms.DataGridViewTextBoxColumn Func_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn Func_b;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorAct;
        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.Label label6;
    }
}