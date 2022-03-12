
namespace Aula_24_02_22
{
    partial class frmCalRadio
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbPotenciacao = new System.Windows.Forms.RadioButton();
            this.rdbSubtrair = new System.Windows.Forms.RadioButton();
            this.rdbSomar = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSinal = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lstHistorico = new System.Windows.Forms.ListBox();
            this.btnLimparHistoricos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.rdbPotenciacao);
            this.groupBox1.Controls.Add(this.rdbSubtrair);
            this.groupBox1.Controls.Add(this.rdbSomar);
            this.groupBox1.Location = new System.Drawing.Point(80, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operações";
            // 
            // rdbPotenciacao
            // 
            this.rdbPotenciacao.AutoSize = true;
            this.rdbPotenciacao.Location = new System.Drawing.Point(6, 65);
            this.rdbPotenciacao.Name = "rdbPotenciacao";
            this.rdbPotenciacao.Size = new System.Drawing.Size(85, 17);
            this.rdbPotenciacao.TabIndex = 1;
            this.rdbPotenciacao.TabStop = true;
            this.rdbPotenciacao.Text = "Potenciação";
            this.rdbPotenciacao.UseVisualStyleBackColor = true;
            this.rdbPotenciacao.CheckedChanged += new System.EventHandler(this.rdbPotenciacao_CheckedChanged);
            // 
            // rdbSubtrair
            // 
            this.rdbSubtrair.AutoSize = true;
            this.rdbSubtrair.Location = new System.Drawing.Point(6, 42);
            this.rdbSubtrair.Name = "rdbSubtrair";
            this.rdbSubtrair.Size = new System.Drawing.Size(61, 17);
            this.rdbSubtrair.TabIndex = 1;
            this.rdbSubtrair.TabStop = true;
            this.rdbSubtrair.Text = "Subtrair";
            this.rdbSubtrair.UseVisualStyleBackColor = true;
            this.rdbSubtrair.CheckedChanged += new System.EventHandler(this.rdbSubtrair_CheckedChanged);
            // 
            // rdbSomar
            // 
            this.rdbSomar.AutoSize = true;
            this.rdbSomar.Location = new System.Drawing.Point(6, 19);
            this.rdbSomar.Name = "rdbSomar";
            this.rdbSomar.Size = new System.Drawing.Size(55, 17);
            this.rdbSomar.TabIndex = 1;
            this.rdbSomar.TabStop = true;
            this.rdbSomar.Text = "Somar";
            this.rdbSomar.UseVisualStyleBackColor = true;
            this.rdbSomar.CheckedChanged += new System.EventHandler(this.rdbSomar_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lblResultado);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblSinal);
            this.panel1.Controls.Add(this.txtNum2);
            this.panel1.Controls.Add(this.txtNum1);
            this.panel1.Location = new System.Drawing.Point(334, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 100);
            this.panel1.TabIndex = 1;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(286, 36);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(13, 13);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "?";
            this.lblResultado.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "=";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSinal
            // 
            this.lblSinal.AutoSize = true;
            this.lblSinal.Location = new System.Drawing.Point(122, 36);
            this.lblSinal.Name = "lblSinal";
            this.lblSinal.Size = new System.Drawing.Size(13, 13);
            this.lblSinal.TabIndex = 1;
            this.lblSinal.Text = "?";
            this.lblSinal.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(185, 32);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(76, 20);
            this.txtNum2.TabIndex = 0;
            this.txtNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNum2_KeyPress);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(40, 33);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(76, 20);
            this.txtNum1.TabIndex = 0;
            this.txtNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNum1_KeyPress);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(179, 201);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(334, 201);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(476, 201);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lstHistorico
            // 
            this.lstHistorico.FormattingEnabled = true;
            this.lstHistorico.Location = new System.Drawing.Point(80, 299);
            this.lstHistorico.Name = "lstHistorico";
            this.lstHistorico.Size = new System.Drawing.Size(252, 160);
            this.lstHistorico.TabIndex = 4;
            this.lstHistorico.SelectedIndexChanged += new System.EventHandler(this.lstHistorico_SelectedIndexChanged);
            // 
            // btnLimparHistoricos
            // 
            this.btnLimparHistoricos.Location = new System.Drawing.Point(431, 386);
            this.btnLimparHistoricos.Name = "btnLimparHistoricos";
            this.btnLimparHistoricos.Size = new System.Drawing.Size(120, 30);
            this.btnLimparHistoricos.TabIndex = 5;
            this.btnLimparHistoricos.Text = "Limpar Historico";
            this.btnLimparHistoricos.UseVisualStyleBackColor = true;
            this.btnLimparHistoricos.Click += new System.EventHandler(this.btnLimparHistoricos_Click);
            // 
            // frmCalRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 645);
            this.Controls.Add(this.btnLimparHistoricos);
            this.Controls.Add(this.lstHistorico);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCalRadio";
            this.Text = "frmCalRadio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbPotenciacao;
        private System.Windows.Forms.RadioButton rdbSubtrair;
        private System.Windows.Forms.RadioButton rdbSomar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSinal;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ListBox lstHistorico;
        private System.Windows.Forms.Button btnLimparHistoricos;
    }
}