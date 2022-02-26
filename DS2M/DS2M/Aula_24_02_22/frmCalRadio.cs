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
    public partial class frmCalRadio : Form
    {
        public frmCalRadio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rdbSomar_CheckedChanged(object sender, EventArgs e)
        {
            lblSinal.Text = "+";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double a, b, r;

            a = double.Parse(txtNum1.Text);
            b = double.Parse(txtNum2.Text);
            r = 0;

            switch (lblSinal.Text)
            {
                case "+":
                    {
                        r = a + b;
                        break;
                    }
                case "-":
                    {
                        r = a - b;
                        break;
                    }
                case "elevado a":
                    {
                        r = Math.Pow(a, b);
                        break;
                    }
                default:
                    break;
            }
            lblResultado.Text = r.ToString();
            lstHistorico.Items.Add(a+" "+lblSinal.Text+" "+b+" = "+r);
        }

        private void rdbSubtrair_CheckedChanged(object sender, EventArgs e)
        {
            lblSinal.Text = "-";
        }

        private void rdbPotenciacao_CheckedChanged(object sender, EventArgs e)
        {
            lblSinal.Text = "elevado a";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimparHistoricos_Click(object sender, EventArgs e)
        {
            lstHistorico.Items.Clear();
        }
    }
}
