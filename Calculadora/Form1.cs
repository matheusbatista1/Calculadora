using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        decimal valor1 = 0;
        decimal valor2 = 0;
        string operacao = "";
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResult.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResult.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResult.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResult.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResult.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResult.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResult.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResult.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResult.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResult.Text += "9";
        }

        private void btnVirg_Click(object sender, EventArgs e)
        {
            txtResult.Text += ",";
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "")
            {
                MessageBox.Show("Digite um número!");
            } 
            else
            {
                valor1 = Convert.ToDecimal(txtResult.Text);
                operacao = "SOMA";
                txtResult.Text = "";
                lboperacao.Text = "+";
            }            
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "")
            {
                MessageBox.Show("Digite um número!");
            }
            else
            {
                valor1 = Convert.ToDecimal(txtResult.Text);
                operacao = "SUBTRAIR";
                txtResult.Text = "";
                lboperacao.Text = "-";
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "")
            {
                MessageBox.Show("Digite um número!");
            }
            else
            {
                valor1 = Convert.ToDecimal(txtResult.Text);
                operacao = "MULTIPLICAR";
                txtResult.Text = "";
                lboperacao.Text = "x";
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "")
            {
                MessageBox.Show("Digite um número!");
            }
            else
            {
                valor1 = Convert.ToDecimal(txtResult.Text);
                operacao = "DIVIDIR";
                txtResult.Text = "";
                lboperacao.Text = "/";
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "")
            {
                MessageBox.Show("Digite um número!");
            }
            else
            {
                lboperacao.Text = "=";
                valor2 = Convert.ToDecimal(txtResult.Text);
            }
            
            switch (operacao)
            {
                case "SOMA":
                    txtResult.Text = Convert.ToString(valor1 + valor2);
                    break;

                case "SUBTRAIR":
                    txtResult.Text = Convert.ToString(valor1 - valor2);
                    break;

                case "MULTIPLICAR":
                    txtResult.Text = Convert.ToString(valor1 * valor2);
                    break;

                case "DIVIDIR":
                    txtResult.Text = Convert.ToString(valor1 / valor2);
                    break;
            }
        }

        private void btnLimpatudo_Click(object sender, EventArgs e)
        {
            valor1 = 0;
            valor2 = 0;
            txtResult.Text = "";
            lboperacao.Text = "";
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
