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
            double valorDaNotaFiscal = 2000.0;

            double imposto;

            if (valorDaNotaFiscal < 1000)
            {
                imposto = 0.02 * valorDaNotaFiscal;
            }
            else if (valorDaNotaFiscal < 3000)
            {
                imposto = 0.025 * valorDaNotaFiscal;
            }
            else if (valorDaNotaFiscal < 7000)
            {
                imposto = 0.028 * valorDaNotaFiscal;
            }
            else
            {
                imposto = 0.03 * valorDaNotaFiscal;
            }

            MessageBox.Show("Imposto a ser pago: " + imposto);
        }
    }
}