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
            bool janela = false;

            foreach (Form i in Application.OpenForms)
            {
                if (i.Text == "frmCalRadio")
                {
                    janela = true;
                    i.BringToFront();
                    break;
                }
            }

            if (janela == false)
            {
                frmCalRadio objCalRadio = new frmCalRadio();
                objCalRadio.MdiParent = this;
                objCalRadio.Show();
            }
        }

        private void comBotõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool janela = false;

            foreach (Form i in Application.OpenForms)
            {
                if (i.Text == "frmCalBot")
                {
                    janela = true;
                    i.BringToFront();
                    break;
                }
            }

            if (janela == false)
            {
                frmCalBot objCalBot = new frmCalBot();
                objCalBot.MdiParent = this;
                objCalBot.Show();
            }
        }

        private void calculadorSuperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool janela = false;

            foreach (Form i in Application.OpenForms)
            {
                if (i.Text == "Calculadora Super")
                {
                    janela = true;
                    i.BringToFront();
                    break;
                }
            }

            if(janela == false)
            {
                frmSuperCal objSuperCal = new frmSuperCal();
                objSuperCal.MdiParent = this;
                objSuperCal.Show();
            }
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
