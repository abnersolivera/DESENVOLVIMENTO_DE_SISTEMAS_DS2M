namespace Aula_14_02_22
{
    partial class frmCal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnParImpar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnPotenciacao = new System.Windows.Forms.Button();
            this.btnPorcetagem = new System.Windows.Forms.Button();
            this.btnComparar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(62, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(62, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Digite um numero";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(65, 68);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(65, 144);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 1;
            // 
            // btnSoma
            // 
            this.btnSoma.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnSoma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoma.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSoma.Location = new System.Drawing.Point(65, 183);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSoma.Size = new System.Drawing.Size(86, 23);
            this.btnSoma.TabIndex = 2;
            this.btnSoma.Text = "&Soma";
            this.btnSoma.UseVisualStyleBackColor = false;
            this.btnSoma.Click += new System.EventHandler(this.BtnSoma_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnSubtracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtracao.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSubtracao.Location = new System.Drawing.Point(65, 212);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(86, 23);
            this.btnSubtracao.TabIndex = 2;
            this.btnSubtracao.Text = "Subtração";
            this.btnSubtracao.UseVisualStyleBackColor = false;
            this.btnSubtracao.Click += new System.EventHandler(this.BtnSubtracao_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnMultiplicacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplicacao.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMultiplicacao.Location = new System.Drawing.Point(65, 241);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(86, 23);
            this.btnMultiplicacao.TabIndex = 2;
            this.btnMultiplicacao.Text = "Multiplicação";
            this.btnMultiplicacao.UseVisualStyleBackColor = false;
            this.btnMultiplicacao.Click += new System.EventHandler(this.BtnMultiplicacao_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnDivisao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivisao.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDivisao.Location = new System.Drawing.Point(65, 270);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(86, 23);
            this.btnDivisao.TabIndex = 2;
            this.btnDivisao.Text = "Divisão";
            this.btnDivisao.UseVisualStyleBackColor = false;
            this.btnDivisao.Click += new System.EventHandler(this.BtnDivisao_Click);
            // 
            // btnParImpar
            // 
            this.btnParImpar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnParImpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParImpar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnParImpar.Location = new System.Drawing.Point(65, 299);
            this.btnParImpar.Name = "btnParImpar";
            this.btnParImpar.Size = new System.Drawing.Size(86, 23);
            this.btnParImpar.TabIndex = 2;
            this.btnParImpar.Text = "Par/Impar";
            this.btnParImpar.UseVisualStyleBackColor = false;
            this.btnParImpar.Click += new System.EventHandler(this.BtnParImpar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Location = new System.Drawing.Point(358, 406);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(187, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "=";
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOperacao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacao.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblOperacao.Location = new System.Drawing.Point(242, 102);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(2, 26);
            this.lblOperacao.TabIndex = 0;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResultado.Location = new System.Drawing.Point(311, 104);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(2, 26);
            this.lblResultado.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFechar.Location = new System.Drawing.Point(644, 406);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // btnPotenciacao
            // 
            this.btnPotenciacao.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnPotenciacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPotenciacao.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPotenciacao.Location = new System.Drawing.Point(65, 328);
            this.btnPotenciacao.Name = "btnPotenciacao";
            this.btnPotenciacao.Size = new System.Drawing.Size(86, 23);
            this.btnPotenciacao.TabIndex = 2;
            this.btnPotenciacao.Text = "Potenciação";
            this.btnPotenciacao.UseVisualStyleBackColor = false;
            this.btnPotenciacao.Click += new System.EventHandler(this.BtnPotenciacao_Click);
            // 
            // btnPorcetagem
            // 
            this.btnPorcetagem.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnPorcetagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorcetagem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPorcetagem.Location = new System.Drawing.Point(65, 357);
            this.btnPorcetagem.Name = "btnPorcetagem";
            this.btnPorcetagem.Size = new System.Drawing.Size(86, 23);
            this.btnPorcetagem.TabIndex = 2;
            this.btnPorcetagem.Text = "Porcetagem";
            this.btnPorcetagem.UseVisualStyleBackColor = false;
            this.btnPorcetagem.Click += new System.EventHandler(this.btnPorcetagem_Click);
            // 
            // btnComparar
            // 
            this.btnComparar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnComparar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComparar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnComparar.Location = new System.Drawing.Point(65, 386);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(86, 23);
            this.btnComparar.TabIndex = 2;
            this.btnComparar.Text = "Comparar";
            this.btnComparar.UseVisualStyleBackColor = false;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // frmCal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnParImpar);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.btnPorcetagem);
            this.Controls.Add(this.btnPotenciacao);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCal";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnParImpar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnPotenciacao;
        private System.Windows.Forms.Button btnPorcetagem;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.Button btnSoma;
    }
}

