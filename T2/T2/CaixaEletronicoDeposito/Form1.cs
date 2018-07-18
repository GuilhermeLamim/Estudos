using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronicoDeposito
{
    public partial class Form1 : Form
    {
        private Conta conta;
        private Cliente cliente;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.conta = new Conta();
            cliente = new Cliente();
            cliente.Nome = "Victor";
            this.conta.Titular = cliente;
            this.conta.Numero = 1;
            this.conta.Deposito(250.0);

            this.MostraConta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoDoValorDoDeposito = textoValor.Text;
            double valorDeposito = Convert.ToDouble(textoDoValorDoDeposito);
            this.conta.Deposito(valorDeposito);

            this.MostraConta();
        }

        private void MostraConta()
        {
            textoNumero.Text = Convert.ToString(this.conta.Numero);
            textoSaldo.Text = Convert.ToString(this.conta.Saldo);
            textoTitular.Text = this.conta.Titular.Nome;
        }
    }
}