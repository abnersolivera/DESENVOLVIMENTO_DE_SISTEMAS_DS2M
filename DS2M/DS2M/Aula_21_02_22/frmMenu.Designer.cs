namespace Aula_21_02_22
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comBoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comRadioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadorSuperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.janelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculosToolStripMenuItem,
            this.janelasToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calculosToolStripMenuItem
            // 
            this.calculosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comBoToolStripMenuItem,
            this.comRadioToolStripMenuItem,
            this.calculadorSuperToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.calculosToolStripMenuItem.Name = "calculosToolStripMenuItem";
            this.calculosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.calculosToolStripMenuItem.Text = "Calculos";
            // 
            // comBoToolStripMenuItem
            // 
            this.comBoToolStripMenuItem.Name = "comBoToolStripMenuItem";
            this.comBoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comBoToolStripMenuItem.Text = "Com Botões";
            this.comBoToolStripMenuItem.Click += new System.EventHandler(this.ComBoToolStripMenuItem_Click);
            // 
            // comRadioToolStripMenuItem
            // 
            this.comRadioToolStripMenuItem.Name = "comRadioToolStripMenuItem";
            this.comRadioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comRadioToolStripMenuItem.Text = "Com RadioButtons";
            this.comRadioToolStripMenuItem.Click += new System.EventHandler(this.ComRadioToolStripMenuItem_Click);
            // 
            // calculadorSuperToolStripMenuItem
            // 
            this.calculadorSuperToolStripMenuItem.Name = "calculadorSuperToolStripMenuItem";
            this.calculadorSuperToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calculadorSuperToolStripMenuItem.Text = "Calculador Super";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // janelasToolStripMenuItem
            // 
            this.janelasToolStripMenuItem.Name = "janelasToolStripMenuItem";
            this.janelasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.janelasToolStripMenuItem.Text = "Janelas";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comBoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem janelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comRadioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadorSuperToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

