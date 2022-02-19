using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_10_02_22
{
    public partial class frmCalc : Form
    {
        public frmCalc()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            lblResult.Text = (int.Parse(txtNum1.Text) + int.Parse(txtNum2.Text)).ToString();

            lblOperacoes.Text = "+";
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            lblResult.Text = (int.Parse(txtNum1.Text) - int.Parse(txtNum2.Text)).ToString();

            lblOperacoes.Text = "-";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            lblOperacoes.Text = "";
            lblResult.Text = "";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            lblResult.Text = (int.Parse(txtNum1.Text) / int.Parse(txtNum2.Text)).ToString();

            lblOperacoes.Text = "/";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            lblResult.Text = (int.Parse(txtNum1.Text) * int.Parse(txtNum2.Text)).ToString();

            lblOperacoes.Text = "*";
        }

        private void btnParImpar_Click(object sender, EventArgs e)
        {
            int c1, c2;

            lblOperacoes.Text = "PAR\nou\nÍMPAR";
            c1 = int.Parse(txtNum1.Text) % 2;
            c2 = int.Parse(txtNum2.Text) % 2;


            if (c1 == 0)
            {

                if (c2 == 0)
                {
                    lblResult.Text = "O numero digitado " + txtNum1.Text + " e " + txtNum2.Text + " é PAR.";
                }

                else
                {
                    lblResult.Text = "O numero digitado " + txtNum1.Text + " é PAR.\nO numero digitado " + txtNum2.Text + " é ÍMPAR.";
                }
            }

            else if (c2 == 0)
            {
                if (c1 == 0)
                {
                    lblResult.Text = "O numero digitado " + txtNum1.Text + " e " + txtNum2.Text + " é PAR.";
                }

                else
                {
                    lblResult.Text = "O numero digitado " + txtNum2.Text + " é PAR.\nO numero digitado " + txtNum1.Text + " é ÍMPAR.";
                }
            }

            else
            {
                lblResult.Text = "O numero digitado " + txtNum1.Text + " e " + txtNum2.Text + " é ÍMPAR.";
            }

          
        }
    }
}
