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
    public partial class frmCalRdb : Form
    {
        public frmCalRdb()
        {
            InitializeComponent();
        }



        private void btnCalculos_Click(object sender, EventArgs e)
        {

            string txt = "";
            try
            {

                txt = gpbOperacoes.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
            }
            catch
            {
                MessageBox.Show("Favor informar apenas números");
            }


            
            switch (txt)
            {
                case "Somar":
                    {
                        
                        try
                        {
                            lblOperacoes.Text = "+";
                            lblResultado.Text = (double.Parse(txtNum1.Text) + double.Parse(txtNum2.Text)).ToString();
                            break;
                        }
                        catch (FormatException)
                        {
                            lblOperacoes.Text = "";
                            MessageBox.Show("Favor informar apenas números");
                            break;
                        }
                    }
                case "Subtrair":
                    {
                        
                        try
                        {
                            lblOperacoes.Text = "-";
                            lblResultado.Text = (double.Parse(txtNum1.Text) - double.Parse(txtNum2.Text)).ToString();
                            break;
                        }
                        catch (FormatException)
                        {
                            lblOperacoes.Text = "";
                            MessageBox.Show("Favor informar apenas números");
                            break;
                        }
                    }
                case "Dividir":
                    {
                        try
                        {
                            lblOperacoes.Text = "/";
                            lblResultado.Text = (double.Parse(txtNum1.Text) / double.Parse(txtNum2.Text)).ToString();
                            break;
                        }
                        catch (FormatException)
                        {
                            lblOperacoes.Text = "";
                            MessageBox.Show("Favor informar apenas números");
                            break;
                        }
                        catch (DivideByZeroException)
                        {
                            lblOperacoes.Text = "";
                            MessageBox.Show("O valor não e divisivel");
                            break;
                        }
                    }
                case "Multiplicação":
                    {
                        try
                        {
                            lblOperacoes.Text = "*";
                            lblResultado.Text = (double.Parse(txtNum1.Text) * double.Parse(txtNum2.Text)).ToString();
                            break;
                        }
                        catch (FormatException)
                        {
                            lblOperacoes.Text = "";
                            MessageBox.Show("Favor informar apenas números");
                            break;
                        }
                    }
                case "Potencia":
                    {
                        try
                        {
                            lblOperacoes.Text = "^";
                            lblResultado.Text = Math.Pow(double.Parse(txtNum1.Text), double.Parse(txtNum2.Text)).ToString();
                            break;
                        }
                        catch (FormatException)
                        {
                            lblOperacoes.Text = "";
                            MessageBox.Show("Favor informar apenas números");
                            break;
                        }
                    }
                default:
                    {
                        break;
                    }
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            lblOperacoes.Text = "";
            lblResultado.Text = "";
            txtNum1.Focus();
        }
    }
}
