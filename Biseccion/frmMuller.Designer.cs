namespace Biseccion
{
    partial class frmMulle
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtp0_Imaginario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtp0_Real = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtp1_Imaginario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtp1_Real = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtp2_Imaginario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtp2_Real = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNumMaxIter = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtErrorMax = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvMuller = new System.Windows.Forms.DataGridView();
            this.NumIter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.po = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.Na = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuller)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(757, 614);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 27);
            this.btnSalir.TabIndex = 35;
            this.btnSalir.Text = "Salir:)";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(680, 308);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(168, 28);
            this.btnCalcular.TabIndex = 33;
            this.btnCalcular.Text = "Calcular Raiz";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtp0_Imaginario
            // 
            this.txtp0_Imaginario.Location = new System.Drawing.Point(497, 153);
            this.txtp0_Imaginario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtp0_Imaginario.Name = "txtp0_Imaginario";
            this.txtp0_Imaginario.Size = new System.Drawing.Size(75, 22);
            this.txtp0_Imaginario.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = " Real";
            // 
            // txtp0_Real
            // 
            this.txtp0_Real.Location = new System.Drawing.Point(395, 153);
            this.txtp0_Real.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtp0_Real.Name = "txtp0_Real";
            this.txtp0_Real.Size = new System.Drawing.Size(75, 22);
            this.txtp0_Real.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "p0=";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(608, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "Metodo de Muller";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(493, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Imaginario";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(768, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Imaginario";
            // 
            // txtp1_Imaginario
            // 
            this.txtp1_Imaginario.Location = new System.Drawing.Point(772, 153);
            this.txtp1_Imaginario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtp1_Imaginario.Name = "txtp1_Imaginario";
            this.txtp1_Imaginario.Size = new System.Drawing.Size(75, 22);
            this.txtp1_Imaginario.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(685, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = " Real";
            // 
            // txtp1_Real
            // 
            this.txtp1_Real.Location = new System.Drawing.Point(669, 153);
            this.txtp1_Real.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtp1_Real.Name = "txtp1_Real";
            this.txtp1_Real.Size = new System.Drawing.Size(75, 22);
            this.txtp1_Real.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(628, 156);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "p1=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1053, 133);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 46;
            this.label8.Text = "Imaginario";
            // 
            // txtp2_Imaginario
            // 
            this.txtp2_Imaginario.Location = new System.Drawing.Point(1057, 153);
            this.txtp2_Imaginario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtp2_Imaginario.Name = "txtp2_Imaginario";
            this.txtp2_Imaginario.Size = new System.Drawing.Size(75, 22);
            this.txtp2_Imaginario.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(971, 133);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 44;
            this.label9.Text = " Real";
            // 
            // txtp2_Real
            // 
            this.txtp2_Real.Location = new System.Drawing.Point(955, 153);
            this.txtp2_Real.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtp2_Real.Name = "txtp2_Real";
            this.txtp2_Real.Size = new System.Drawing.Size(75, 22);
            this.txtp2_Real.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(913, 156);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 16);
            this.label10.TabIndex = 42;
            this.label10.Text = "p2=";
            // 
            // txtNumMaxIter
            // 
            this.txtNumMaxIter.Location = new System.Drawing.Point(917, 220);
            this.txtNumMaxIter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumMaxIter.Name = "txtNumMaxIter";
            this.txtNumMaxIter.Size = new System.Drawing.Size(132, 22);
            this.txtNumMaxIter.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(753, 224);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 16);
            this.label11.TabIndex = 49;
            this.label11.Text = "No° Max de iteraciones";
            // 
            // txtErrorMax
            // 
            this.txtErrorMax.Location = new System.Drawing.Point(597, 220);
            this.txtErrorMax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtErrorMax.Name = "txtErrorMax";
            this.txtErrorMax.Size = new System.Drawing.Size(132, 22);
            this.txtErrorMax.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(491, 224);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 16);
            this.label12.TabIndex = 47;
            this.label12.Text = "Error Maximo=";
            // 
            // dgvMuller
            // 
            this.dgvMuller.AllowUserToAddRows = false;
            this.dgvMuller.AllowUserToDeleteRows = false;
            this.dgvMuller.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvMuller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuller.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumIter,
            this.po,
            this.p1,
            this.p2,
            this.p3,
            this.ErrorAct});
            this.dgvMuller.GridColor = System.Drawing.Color.Gray;
            this.dgvMuller.Location = new System.Drawing.Point(248, 341);
            this.dgvMuller.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMuller.Name = "dgvMuller";
            this.dgvMuller.ReadOnly = true;
            this.dgvMuller.RowHeadersWidth = 51;
            this.dgvMuller.Size = new System.Drawing.Size(1033, 233);
            this.dgvMuller.TabIndex = 51;
            // 
            // NumIter
            // 
            this.NumIter.HeaderText = "i";
            this.NumIter.MinimumWidth = 6;
            this.NumIter.Name = "NumIter";
            this.NumIter.ReadOnly = true;
            this.NumIter.Width = 50;
            // 
            // po
            // 
            this.po.HeaderText = "p0";
            this.po.MinimumWidth = 6;
            this.po.Name = "po";
            this.po.ReadOnly = true;
            this.po.Width = 150;
            // 
            // p1
            // 
            this.p1.HeaderText = "p1";
            this.p1.MinimumWidth = 6;
            this.p1.Name = "p1";
            this.p1.ReadOnly = true;
            this.p1.Width = 150;
            // 
            // p2
            // 
            this.p2.HeaderText = "p2";
            this.p2.MinimumWidth = 6;
            this.p2.Name = "p2";
            this.p2.ReadOnly = true;
            this.p2.Width = 150;
            // 
            // p3
            // 
            this.p3.HeaderText = "p3";
            this.p3.MinimumWidth = 6;
            this.p3.Name = "p3";
            this.p3.ReadOnly = true;
            this.p3.Width = 150;
            // 
            // ErrorAct
            // 
            this.ErrorAct.HeaderText = "Error";
            this.ErrorAct.MinimumWidth = 6;
            this.ErrorAct.Name = "ErrorAct";
            this.ErrorAct.ReadOnly = true;
            this.ErrorAct.Width = 125;
            // 
            // txtFuncion
            // 
            this.txtFuncion.Location = new System.Drawing.Point(441, 268);
            this.txtFuncion.Margin = new System.Windows.Forms.Padding(4);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(216, 22);
            this.txtFuncion.TabIndex = 53;
            // 
            // Na
            // 
            this.Na.AutoSize = true;
            this.Na.Location = new System.Drawing.Point(364, 271);
            this.Na.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Na.Name = "Na";
            this.Na.Size = new System.Drawing.Size(54, 16);
            this.Na.TabIndex = 52;
            this.Na.Text = "Funcion";
            this.Na.Click += new System.EventHandler(this.label13_Click);
            // 
            // frmMulle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 842);
            this.Controls.Add(this.txtFuncion);
            this.Controls.Add(this.Na);
            this.Controls.Add(this.dgvMuller);
            this.Controls.Add(this.txtNumMaxIter);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtErrorMax);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtp2_Imaginario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtp2_Real);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtp1_Imaginario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtp1_Real);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtp0_Imaginario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtp0_Real);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMulle";
            this.Text = "Muller";
            this.Load += new System.EventHandler(this.frmMulle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtp0_Imaginario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtp0_Real;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtp1_Imaginario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtp1_Real;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtp2_Imaginario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtp2_Real;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNumMaxIter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtErrorMax;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvMuller;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumIter;
        private System.Windows.Forms.DataGridViewTextBoxColumn po;
        private System.Windows.Forms.DataGridViewTextBoxColumn p1;
        private System.Windows.Forms.DataGridViewTextBoxColumn p2;
        private System.Windows.Forms.DataGridViewTextBoxColumn p3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorAct;
        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.Label Na;
    }
}