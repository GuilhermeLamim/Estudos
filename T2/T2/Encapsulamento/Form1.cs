using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            conta.Deposita(2000.0);

            conta.Saca(500.0);
            conta.Saca(100.0);

     //conta.Saldo = 1000.0; <-- Não funciona { get; private set} proibir escrita e abrir pra leitura.

            MessageBox.Show("O saldo é de:" + conta.Saldo);
        }
    }
}
