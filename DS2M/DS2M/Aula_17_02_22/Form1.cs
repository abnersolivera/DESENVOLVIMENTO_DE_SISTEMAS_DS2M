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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            lblSinal.Text = "?";
            lblresultado.Text = "?";

        }

        private void BtnSomar_Click(object sender, EventArgs e)
        {
            double a, b, r; //declaração de variável
            lblSinal.Text = "+";
            try
            {
                a = double.Parse(txtNum1.Text);
                b = double.Parse(txtNum2.Text);
                r = a + b;
                lblresultado.Text = r.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Favor informar apenas números");
            }

        }

        private void LblSinal_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
