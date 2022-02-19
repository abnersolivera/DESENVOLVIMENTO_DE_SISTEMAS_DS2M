using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_14_02_22
{
    public partial class frmCal : Form
    {
        public frmCal()
        {
            InitializeComponent();
            
        }



        private void BtnSoma_Click(object sender, EventArgs e)
        {
            lblOperacao.Text = "+";
            try
            {
                lblResultado.Text = (decimal.Parse(txtNum1.Text) + decimal.Parse(txtNum2.Text)).ToString();
            }
            catch(FormatException)
            {
                lblOperacao.Text = "";
                MessageBox.Show("Favor informar apenas números");
            }
            
            
            
        }

        private void BtnSubtracao_Click(object sender, EventArgs e)
        {
            lblOperacao.Text = "-";
            try
            {
                lblResultado.Text = (int.Parse(txtNum1.Text) - int.Parse(txtNum2.Text)).ToString();
            }
            catch (FormatException)
            {
                lblOperacao.Text = "";
                MessageBox.Show("Favor informar apenas números");
            }
            
        }

        private void BtnMultiplicacao_Click(object sender, EventArgs e)
        {
            
            try
            {
                lblOperacao.Text = "*";
                lblResultado.Text = (int.Parse(txtNum1.Text) * int.Parse(txtNum2.Text)).ToString();
            }
            catch (FormatException)
            {
                lblOperacao.Text = "";
                MessageBox.Show("Favor informar apenas números");
            }
            
        }

        private void BtnDivisao_Click(object sender, EventArgs e)
        {
            
            try
            {
                lblOperacao.Text = "/";
                lblResultado.Text = (double.Parse(txtNum1.Text) / double.Parse(txtNum2.Text)).ToString();
            }
            catch (FormatException)
            {
                lblOperacao.Text = "";
                MessageBox.Show("Favor informar apenas números");
            }
            catch(DivideByZeroException)
            {
                lblOperacao.Text = "";
                MessageBox.Show("O valor não e divisivel");
            }

        }

        private void BtnParImpar_Click(object sender, EventArgs e)
        {
            int c1, c2;
            try { 
                lblOperacao.Text = "PAR\nou\nÍMPAR";
                c1 = int.Parse(txtNum1.Text) % 2;
                c2 = int.Parse(txtNum2.Text) % 2;


                if (c1 == 0)
                {

                    if (c2 == 0)
                    {
                        lblResultado.Text = "O numero digitado " + txtNum1.Text + " e " + txtNum2.Text + " é PAR.";
                    }

                    else
                    {
                        lblResultado.Text = "O numero digitado " + txtNum1.Text + " é PAR.\nO numero digitado " + txtNum2.Text + " é ÍMPAR.";
                    }
                }

                else if (c2 == 0)
                {
                    if (c1 == 0)
                    {
                        lblResultado.Text = "O numero digitado " + txtNum1.Text + " e " + txtNum2.Text + " é PAR.";
                    }

                    else
                    {
                        lblResultado.Text = "O numero digitado " + txtNum2.Text + " é PAR.\nO numero digitado " + txtNum1.Text + " é ÍMPAR.";
                    }
                }

                else
                {
                    lblResultado.Text = "O numero digitado " + txtNum1.Text + " e " + txtNum2.Text + " é ÍMPAR.";
                }

            }
            catch
            {
                lblOperacao.Text = "";
                MessageBox.Show("Favor informar apenas números");
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            lblOperacao.Text = "";
            lblResultado.Text = "";
            txtNum1.Focus();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void BtnPotenciacao_Click(object sender, EventArgs e)
        {
           
            
            try
            {
                lblOperacao.Text = "^";
                lblResultado.Text = Math.Pow(double.Parse(txtNum1.Text), double.Parse(txtNum2.Text)).ToString();
            }
            catch (FormatException)
            {
                lblOperacao.Text = "";
                MessageBox.Show("Favor informar apenas números");
            }

        }

        private void btnPorcetagem_Click(object sender, EventArgs e)
        {
            try
            {
                lblOperacao.Text = "%";
                lblResultado.Text = (float.Parse(txtNum1.Text) * (float.Parse(txtNum2.Text)/100)).ToString();
            }
            catch (FormatException)
            {
                lblOperacao.Text = "";
                MessageBox.Show("Favor informar apenas números");
            }
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            int num1, num2;



            try
            {
                num1 = int.Parse(txtNum1.Text);
                num2 = int.Parse(txtNum2.Text);

                if (num1 > num2)
                {
                    if (num2 < num1)
                    {
                        lblResultado.Text = "numero digitado: "+txtNum1.Text+" é maior que o numero "+txtNum2.Text+"\nnumero digitado: " + txtNum2.Text + " é menor que o numero " + txtNum1.Text;
                    }
                }

                else if (num2 > num1)
                {
                    if (num1 < num2)
                    {
                        lblResultado.Text = "numero digitado: " + txtNum2.Text + " é maior que o numero " + txtNum1.Text + "\nnumero digitado: " + txtNum1.Text + " é menor que o numero " + txtNum2.Text;
                    }
                }

                else
                {
                    lblResultado.Text = "Os numeros digitados são iguais";
                }

            }
            catch (FormatException)
            {
                lblOperacao.Text = "";
                MessageBox.Show("Favor informar apenas números");
            }
        }


    }
}
