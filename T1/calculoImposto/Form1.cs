using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculoImposto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valorDaNotaFiscal = 3000.0;
            double imposto;
            double conta;
            if (valorDaNotaFiscal < 1000)
            {
                imposto = 0.02;
            }
            else if (valorDaNotaFiscal < 3000)
            {
                imposto = 0.025;
            }
            else if (valorDaNotaFiscal < 7000)
            {
                imposto = 0.028;
            }
            else
            {
                imposto = 0.03;
            }
            conta = valorDaNotaFiscal * imposto;
            MessageBox.Show("A porcentagem de seu imposto de renda é de: " + conta);
        }
    }
}