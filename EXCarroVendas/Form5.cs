using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXCarroVendas
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            double i, num, numrsl, result;
            num = Convert.ToDouble(txtNum.Text);
            i = num - 1;
            result = num * i;

            while (i > 0) 
            {
                
                txtResult.Text = string.Concat(txtResult.Text, "\r\n", result.ToString());
                i--;
                num = result;
                result = result * i;
                
            }
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            double i, num, result;
            num = Convert.ToDouble(txtNum.Text);
            i = num - 1;
            result = num * i;

            for (i = num - 2; result > 0; i--)
            {
                num = result;
                result = num * i;
                txtResult.Text = string.Concat(txtResult.Text, "\r\n", result.ToString());
             
            }

        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            double i, num, result;
            num = Convert.ToDouble(txtNum.Text);
            i = num - 1;
            result = num * i;

            do
            {
                
                txtResult.Text = string.Concat(txtResult.Text, "\r\n", result.ToString());
                i--;
                num = result;
                result = result * i;

            } while (i > 0);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            PgMenu tela = new PgMenu();
            tela.Show();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum.Clear();
            txtResult.Clear();
            txtNum.Focus();
        }
    }
}
