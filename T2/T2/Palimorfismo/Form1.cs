using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta c1 = new Conta();
            c1.Deposita(500.0);
            Conta c2 = new Conta();
            c2.Deposita(300.0);

            ContaCorrente cc1 = new ContaCorrente();
            cc1.Deposita(200);
            ContaCorrente cc2 = new ContaCorrente();
            cc2.Deposita(500);

            AtualizadorDeContas atualizador = new AtualizadorDeContas(0.01);
            atualizador.Roda(c1);
            atualizador.Roda(c2);
            atualizador.Roda(cc1);
            atualizador.Roda(cc2);

            TotalizadorDeContas Total = new TotalizadorDeContas();
            Total.Adiciona(c1);
            Total.Adiciona(c2);
            Total.Adiciona(cc1);
            Total.Adiciona(cc2);

            MessageBox.Show("Totalizador: " + Total.SaldoTotal);
        }
    }
}
