using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_17_02_22
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void ComBotõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 objComBotoes = new Form1();
            objComBotoes.MdiParent = this;
            objComBotoes.Show();
        }
    }
}
