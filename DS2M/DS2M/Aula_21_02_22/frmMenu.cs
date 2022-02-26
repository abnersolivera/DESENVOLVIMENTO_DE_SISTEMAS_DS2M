using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_21_02_22
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void ComBoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ComRadioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool janela = false;
            foreach(Form i in Application.OpenForms)
            {
                if (i.Text == "Calculando com Escolha")
                {
                    janela = true;
                    i.BringToFront();
                    break;
                }
            }

            if (janela == false)
            {
                frmCalRdb objnov = new frmCalRdb();
                objnov.MdiParent = this;
                objnov.Show();
            }

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
