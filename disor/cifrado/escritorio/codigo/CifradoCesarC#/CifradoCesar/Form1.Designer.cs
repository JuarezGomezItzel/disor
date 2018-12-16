namespace CifradoCesar
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.DesCesar = new System.Windows.Forms.NumericUpDown();
			this.TextoCifrado = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.TextoInverso = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.DesGrupo = new System.Windows.Forms.NumericUpDown();
			this.TextoInvertidoxGrupo = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.TextoPlano = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DesCesar)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DesGrupo)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(52, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Textoplano";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.DesCesar);
			this.panel1.Controls.Add(this.TextoCifrado);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(1, 89);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(196, 231);
			this.panel1.TabIndex = 1;
			// 
			// DesCesar
			// 
			this.DesCesar.Location = new System.Drawing.Point(54, 34);
			this.DesCesar.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.DesCesar.Name = "DesCesar";
			this.DesCesar.Size = new System.Drawing.Size(30, 20);
			this.DesCesar.TabIndex = 4;
			this.DesCesar.ValueChanged += new System.EventHandler(this.DesCesar_ValueChanged);
			// 
			// TextoCifrado
			// 
			this.TextoCifrado.Location = new System.Drawing.Point(11, 98);
			this.TextoCifrado.Multiline = true;
			this.TextoCifrado.Name = "TextoCifrado";
			this.TextoCifrado.ReadOnly = true;
			this.TextoCifrado.Size = new System.Drawing.Size(171, 116);
			this.TextoCifrado.TabIndex = 3;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(44, 73);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(67, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "TextoCifrado";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(11, 36);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "Des.";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(66, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Cesar";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.TextoInverso);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Location = new System.Drawing.Point(204, 89);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(200, 231);
			this.panel2.TabIndex = 2;
			// 
			// TextoInverso
			// 
			this.TextoInverso.Location = new System.Drawing.Point(16, 98);
			this.TextoInverso.Multiline = true;
			this.TextoInverso.Name = "TextoInverso";
			this.TextoInverso.ReadOnly = true;
			this.TextoInverso.Size = new System.Drawing.Size(162, 116);
			this.TextoInverso.TabIndex = 2;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(59, 36);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(49, 13);
			this.label7.TabIndex = 1;
			this.label7.Text = "T.cifrado";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(70, 4);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(20, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "T.I";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.DesGrupo);
			this.panel3.Controls.Add(this.TextoInvertidoxGrupo);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Controls.Add(this.label8);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Location = new System.Drawing.Point(411, 89);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(205, 231);
			this.panel3.TabIndex = 3;
			// 
			// DesGrupo
			// 
			this.DesGrupo.Location = new System.Drawing.Point(81, 28);
			this.DesGrupo.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.DesGrupo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.DesGrupo.Name = "DesGrupo";
			this.DesGrupo.Size = new System.Drawing.Size(46, 20);
			this.DesGrupo.TabIndex = 4;
			this.DesGrupo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.DesGrupo.ValueChanged += new System.EventHandler(this.DesGrupo_ValueChanged);
			// 
			// TextoInvertidoxGrupo
			// 
			this.TextoInvertidoxGrupo.Location = new System.Drawing.Point(22, 98);
			this.TextoInvertidoxGrupo.Multiline = true;
			this.TextoInvertidoxGrupo.Name = "TextoInvertidoxGrupo";
			this.TextoInvertidoxGrupo.ReadOnly = true;
			this.TextoInvertidoxGrupo.Size = new System.Drawing.Size(160, 116);
			this.TextoInvertidoxGrupo.TabIndex = 3;
			this.TextoInvertidoxGrupo.TextChanged += new System.EventHandler(this.TextoInvertidoxGrupo_TextChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(64, 61);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(49, 13);
			this.label9.TabIndex = 2;
			this.label9.Text = "T.cifrado";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(19, 36);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(39, 13);
			this.label8.TabIndex = 1;
			this.label8.Text = "Grupo:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(78, 4);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(30, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "T.I.A";
			// 
			// TextoPlano
			// 
			this.TextoPlano.Location = new System.Drawing.Point(118, 12);
			this.TextoPlano.Multiline = true;
			this.TextoPlano.Name = "TextoPlano";
			this.TextoPlano.Size = new System.Drawing.Size(146, 47);
			this.TextoPlano.TabIndex = 4;
			this.TextoPlano.TextChanged += new System.EventHandler(this.TextoPlano_TextChanged);
			this.TextoPlano.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SoltoTeclaTextoPlano);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(618, 315);
			this.Controls.Add(this.TextoPlano);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DesCesar)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DesGrupo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TextoCifrado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TextoInverso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TextoInvertidoxGrupo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextoPlano;
        private System.Windows.Forms.NumericUpDown DesGrupo;
        private System.Windows.Forms.NumericUpDown DesCesar;
    }
}

