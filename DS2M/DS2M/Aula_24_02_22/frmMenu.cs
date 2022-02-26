using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_24_02_22
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void comRadionsButtonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalRadio objCalRadio = new frmCalRadio();
            objCalRadio.MdiParent = this;
            objCalRadio.Show();
        }

        private void comBotõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalBot objCalBot = new frmCalBot();
            objCalBot.MdiParent = this;
            objCalBot.Show();
        }

        private void calculadorSuperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSuperCal objSuperCal = new frmSuperCal();
            objSuperCal.MdiParent = this;
            objSuperCal.Show();
        }

        private void horizontalmenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalmenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
