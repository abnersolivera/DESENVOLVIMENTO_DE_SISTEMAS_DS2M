namespace Aula_21_02_22
{
    partial class frmCalRdb
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
            this.gpbOperacoes = new System.Windows.Forms.GroupBox();
            this.rdbMultiplicacao = new System.Windows.Forms.RadioButton();
            this.rdbDivisao = new System.Windows.Forms.RadioButton();
            this.rdbSubtrair = new System.Windows.Forms.RadioButton();
            this.rdbSomar = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.btnCalculos = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblOperacoes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.gpbOperacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbOperacoes
            // 
            this.gpbOperacoes.Controls.Add(this.rdbMultiplicacao);
            this.gpbOperacoes.Controls.Add(this.rdbDivisao);
            this.gpbOperacoes.Controls.Add(this.rdbSubtrair);
            this.gpbOperacoes.Controls.Add(this.rdbSomar);
            this.gpbOperacoes.Controls.Add(this.radioButton3);
            this.gpbOperacoes.Location = new System.Drawing.Point(12, 12);
            this.gpbOperacoes.Name = "gpbOperacoes";
            this.gpbOperacoes.Size = new System.Drawing.Size(200, 161);
            this.gpbOperacoes.TabIndex = 0;
            this.gpbOperacoes.TabStop = false;
            this.gpbOperacoes.Text = "Operações";
            // 
            // rdbMultiplicacao
            // 
            this.rdbMultiplicacao.AutoSize = true;
            this.rdbMultiplicacao.Location = new System.Drawing.Point(6, 89);
            this.rdbMultiplicacao.Name = "rdbMultiplicacao";
            this.rdbMultiplicacao.Size = new System.Drawing.Size(87, 17);
            this.rdbMultiplicacao.TabIndex = 3;
            this.rdbMultiplicacao.TabStop = true;
            this.rdbMultiplicacao.Text = "Multiplicação";
            this.rdbMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // rdbDivisao
            // 
            this.rdbDivisao.AutoSize = true;
            this.rdbDivisao.Location = new System.Drawing.Point(6, 66);
            this.rdbDivisao.Name = "rdbDivisao";
            this.rdbDivisao.Size = new System.Drawing.Size(54, 17);
            this.rdbDivisao.TabIndex = 2;
            this.rdbDivisao.TabStop = true;
            this.rdbDivisao.Text = "Dividir";
            this.rdbDivisao.UseVisualStyleBackColor = true;
            // 
            // rdbSubtrair
            // 
            this.rdbSubtrair.AutoSize = true;
            this.rdbSubtrair.Location = new System.Drawing.Point(7, 43);
            this.rdbSubtrair.Name = "rdbSubtrair";
            this.rdbSubtrair.Size = new System.Drawing.Size(61, 17);
            this.rdbSubtrair.TabIndex = 1;
            this.rdbSubtrair.TabStop = true;
            this.rdbSubtrair.Text = "Subtrair";
            this.rdbSubtrair.UseVisualStyleBackColor = true;
            // 
            // rdbSomar
            // 
            this.rdbSomar.AutoSize = true;
            this.rdbSomar.Location = new System.Drawing.Point(7, 20);
            this.rdbSomar.Name = "rdbSomar";
            this.rdbSomar.Size = new System.Drawing.Size(55, 17);
            this.rdbSomar.TabIndex = 0;
            this.rdbSomar.TabStop = true;
            this.rdbSomar.Text = "Somar";
            this.rdbSomar.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 115);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(67, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Potencia";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // btnCalculos
            // 
            this.btnCalculos.Location = new System.Drawing.Point(102, 234);
            this.btnCalculos.Name = "btnCalculos";
            this.btnCalculos.Size = new System.Drawing.Size(75, 23);
            this.btnCalculos.TabIndex = 1;
            this.btnCalculos.Text = "Calculos";
            this.btnCalculos.UseVisualStyleBackColor = true;
            this.btnCalculos.Click += new System.EventHandler(this.btnCalculos_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(260, 234);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(292, 55);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(443, 55);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 1;
            // 
            // lblOperacoes
            // 
            this.lblOperacoes.AutoSize = true;
            this.lblOperacoes.Location = new System.Drawing.Point(409, 62);
            this.lblOperacoes.Name = "lblOperacoes";
            this.lblOperacoes.Size = new System.Drawing.Size(13, 13);
            this.lblOperacoes.TabIndex = 3;
            this.lblOperacoes.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(571, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "=";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(590, 57);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 3;
            // 
            // frmCalRdb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOperacoes);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalculos);
            this.Controls.Add(this.gpbOperacoes);
            this.Name = "frmCalRdb";
            this.Text = "Calculando com Escolha";
            this.gpbOperacoes.ResumeLayout(false);
            this.gpbOperacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbOperacoes;
        private System.Windows.Forms.RadioButton rdbDivisao;
        private System.Windows.Forms.RadioButton rdbSubtrair;
        private System.Windows.Forms.RadioButton rdbSomar;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button btnCalculos;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblOperacoes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbMultiplicacao;
        private System.Windows.Forms.Label lblResultado;
    }
}