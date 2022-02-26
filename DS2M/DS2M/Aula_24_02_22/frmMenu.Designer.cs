
namespace Aula_24_02_22
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
            this.comBotõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comRadionsButtonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadorSuperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.janelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalmenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalmenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calculosToolStripMenuItem
            // 
            this.calculosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comBotõesToolStripMenuItem,
            this.comRadionsButtonsToolStripMenuItem,
            this.calculadorSuperToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.calculosToolStripMenuItem.Name = "calculosToolStripMenuItem";
            this.calculosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.calculosToolStripMenuItem.Text = "Calculos";
            // 
            // comBotõesToolStripMenuItem
            // 
            this.comBotõesToolStripMenuItem.Name = "comBotõesToolStripMenuItem";
            this.comBotõesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.comBotõesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.comBotõesToolStripMenuItem.Text = "Com Botões";
            this.comBotõesToolStripMenuItem.Click += new System.EventHandler(this.comBotõesToolStripMenuItem_Click);
            // 
            // comRadionsButtonsToolStripMenuItem
            // 
            this.comRadionsButtonsToolStripMenuItem.Name = "comRadionsButtonsToolStripMenuItem";
            this.comRadionsButtonsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.comRadionsButtonsToolStripMenuItem.Text = "Com Radion Buttons";
            this.comRadionsButtonsToolStripMenuItem.Click += new System.EventHandler(this.comRadionsButtonsToolStripMenuItem_Click);
            // 
            // calculadorSuperToolStripMenuItem
            // 
            this.calculadorSuperToolStripMenuItem.Name = "calculadorSuperToolStripMenuItem";
            this.calculadorSuperToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.calculadorSuperToolStripMenuItem.Text = "Calculador Super";
            this.calculadorSuperToolStripMenuItem.Click += new System.EventHandler(this.calculadorSuperToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // janelasToolStripMenuItem
            // 
            this.janelasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horizontalmenteToolStripMenuItem,
            this.verticalmenteToolStripMenuItem,
            this.cascataToolStripMenuItem});
            this.janelasToolStripMenuItem.Name = "janelasToolStripMenuItem";
            this.janelasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.janelasToolStripMenuItem.Text = "Janelas";
            // 
            // horizontalmenteToolStripMenuItem
            // 
            this.horizontalmenteToolStripMenuItem.Name = "horizontalmenteToolStripMenuItem";
            this.horizontalmenteToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.horizontalmenteToolStripMenuItem.Text = "Horizontalmente";
            this.horizontalmenteToolStripMenuItem.Click += new System.EventHandler(this.horizontalmenteToolStripMenuItem_Click);
            // 
            // verticalmenteToolStripMenuItem
            // 
            this.verticalmenteToolStripMenuItem.Name = "verticalmenteToolStripMenuItem";
            this.verticalmenteToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.verticalmenteToolStripMenuItem.Text = "Verticalmente";
            this.verticalmenteToolStripMenuItem.Click += new System.EventHandler(this.verticalmenteToolStripMenuItem_Click);
            // 
            // cascataToolStripMenuItem
            // 
            this.cascataToolStripMenuItem.Name = "cascataToolStripMenuItem";
            this.cascataToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.cascataToolStripMenuItem.Text = "Cascata";
            this.cascataToolStripMenuItem.Click += new System.EventHandler(this.cascataToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem janelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comBotõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comRadionsButtonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadorSuperToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalmenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalmenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascataToolStripMenuItem;
    }
}

