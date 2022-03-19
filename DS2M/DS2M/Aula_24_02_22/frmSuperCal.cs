using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_24_02_22
{
    public partial class frmSuperCal : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public frmSuperCal()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtValorDigitado.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(txtValorDigitado.Text == "0")
            {
                txtValorDigitado.Text = "1";

            }
            else
            {
                txtValorDigitado.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtValorDigitado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtValorDigitado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtValorDigitado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtValorDigitado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtValorDigitado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtValorDigitado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtValorDigitado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtValorDigitado.Text += "9";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (!txtValorDigitado.Text.Contains(","))
            {
                txtValorDigitado.Text += ",";
                
            }
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            try
            {
                valor2 = decimal.Parse(txtValorDigitado.Text, CultureInfo.InvariantCulture);
            }
            catch(FormatException)
            {                
                lblOperacao.Text = "";
                MessageBox.Show("ERRO!\nFavor digitar a operação desejada novamente\nE o número para realizar a operação");
            }
            switch (operacao)
            {
                case "SOMA":
                    {
                        txtValorDigitado.Text = Convert.ToString(valor1 + valor2);
                        break;
                    }

                case "SUBTRACAO":
                    {
                        txtValorDigitado.Text = Convert.ToString(valor1 - valor2);
                        break;
                    }
                case "MULTIPLICACAO":
                    {
                        txtValorDigitado.Text = Convert.ToString(valor1 * valor2);
                        break;
                    }
                case "DIVISAO":
                    {
                        try
                        {
                            txtValorDigitado.Text = Convert.ToString(valor1 / valor2);
                            break;

                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("ERRO!\nFavor digitar a operação desejada\nE o número para realizar a operação");
                            valor1 = decimal.Parse(txtValorDigitado.Text, CultureInfo.InvariantCulture);
                            break;
                        }
                        catch (DivideByZeroException)
                        {
                            lblOperacao.Text = "";
                            MessageBox.Show("O valor não é divisivel");
                            break;
                        }
                    }
                case "PORCENTAGEM":
                    {
                        txtValorDigitado.Text = Convert.ToString(valor1 * valor2 / 100);
                        break;
                    }
            }
            if (lblOperacao.Text != "")
            {
                lstHistorico.Items.Add(valor1 + " " + lblOperacao.Text + " " + valor2 + " = " + txtValorDigitado.Text);
            }
        }

        private void btnsubtracao_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = decimal.Parse(txtValorDigitado.Text, CultureInfo.InvariantCulture);
                txtValorDigitado.Text = "";
                operacao = "SUBTRACAO";
                lblOperacao.Text = "-";
            }
            catch(FormatException)
            {
                MessageBox.Show("ERRO!\nFavor digitar a operação desejada\nE o número para realizar a operação");
                valor1 = decimal.Parse(txtValorDigitado.Text, CultureInfo.InvariantCulture);
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = decimal.Parse(txtValorDigitado.Text, CultureInfo.InvariantCulture);
                txtValorDigitado.Text = "";
                operacao = "MULTIPLICACAO";
                lblOperacao.Text = "X";
            }
            catch(FormatException)
            {
                MessageBox.Show("ERRO!\nFavor digitar a operação desejada\nE o número para realizar a operação");
                valor1 = decimal.Parse(txtValorDigitado.Text, CultureInfo.InvariantCulture);
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = decimal.Parse(txtValorDigitado.Text, CultureInfo.InvariantCulture);
                txtValorDigitado.Text = "";
                operacao = "DIVISAO";
                lblOperacao.Text = "/";
            }
            catch(FormatException)
            {
                MessageBox.Show("ERRO!\nFavor digitar a operação desejada\nE o número para realizar a operação");
                valor1 = decimal.Parse(txtValorDigitado.Text, CultureInfo.InvariantCulture);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("O valor não é divisivel");
                lblOperacao.Text = "";
                valor1 = 0;
                valor2 = 0;
            }
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = decimal.Parse(txtValorDigitado.Text, CultureInfo.InvariantCulture);
                txtValorDigitado.Text = "";
                operacao = "PORCENTAGEM";
                lblOperacao.Text = "%";
            }
            catch (FormatException)
            {
                MessageBox.Show("ERRO!\nFavor digitar a operação desejada\nE o número para realizar a operação");
                valor1 = decimal.Parse(txtValorDigitado.Text, CultureInfo.InvariantCulture);
            }
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = decimal.Parse(txtValorDigitado.Text, CultureInfo.InvariantCulture);
                txtValorDigitado.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }
            catch (FormatException)
            {
                MessageBox.Show("ERRO!\nFavor digitar a operação desejada\nE o número para realizar a operação");
                valor1 = decimal.Parse(txtValorDigitado.Text, CultureInfo.InvariantCulture);
               
            }

            if(valor1 != 0 || valor2 != 0 || operacao != "")
            {
                valor1 = decimal.Parse(txtValorDigitado.Text, CultureInfo.InvariantCulture);
                txtValorDigitado.Text = "";

                if (valor1 != 0 || valor2 != 0 || operacao == "SOMA")
                {
                    txtValorDigitado.Text = Convert.ToString(valor1 + valor2);
                }
            }

        }

        private void btnCe_Click(object sender, EventArgs e)
        {
            txtValorDigitado.Text = "";
        }

        private void btnLimparHistorico_Click(object sender, EventArgs e)
        {
            lstHistorico.Items.Clear();
        }

        private void BtBackspace_Click(object sender, EventArgs e)
        {
            int x = txtValorDigitado.Text.Length - 1;
            if(x >= 0)
            {
                txtValorDigitado.Text = txtValorDigitado.Text.Substring(0, x);
                if(txtValorDigitado.Text == "")
                {
                    txtValorDigitado.Text += "0";
                }
            }
        }

        private void BtnMasMenos_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtValorDigitado.Text, CultureInfo.InvariantCulture);
            valor1 *= -1;
            txtValorDigitado.Text = valor1.ToString();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            valor1 = 0;
            valor2 = 0;
            txtValorDigitado.Text = "";
            operacao = "";
            lblOperacao.Text = "";

        }
    }
}
