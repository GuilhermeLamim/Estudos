using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronicoArray
{
    public partial class Form1 : Form
    {
        private Conta BuscaContaSelecionada()
        {
            int indiceSelecionado = comboContas.SelectedIndex;
            return this.contas[indiceSelecionado];

        }
        Conta[] contas;
        private int quantidadeDeContas;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contas = new Conta[3];
            Cliente cliente = new Cliente();
            Conta contaDoVictor = new ContaCorrente();
            contaDoVictor.Titular = "Victor";
            contaDoVictor.Numero = 1;
            contaDoVictor.Saldo = 300.0;
            contas[0] = contaDoVictor;

            Conta contaDoGuilherme = new ContaCorrente();
            contaDoGuilherme.Titular = "Guilherme";
            contaDoGuilherme.Numero = 2;
            contaDoGuilherme.Saldo = 600.0;
            contas[1] = contaDoGuilherme;

            Conta contaDoMauricio = new ContaCorrente();
            contaDoMauricio.Titular = "Mauricio";
            contaDoMauricio.Numero = 3;
            contaDoMauricio.Saldo = 900.0;
            contas[2] = contaDoMauricio;
            
            foreach (Conta Item in contas)
            {
                comboContas.Items.Add(Item.Titular);
                destinoDaTransferencia.Items.Add(Item.Titular);
                quantidadeDeContas++;
            }
        }
        private void MostraConta(Conta conta)
        {
            textoNumero.Text = Convert.ToString(conta.Numero);
            textoSaldo.Text = Convert.ToString(conta.Saldo);
            textoTitular.Text = conta.Titular;

        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conta contaSelecionada = this.BuscaContaSelecionada();
            this.MostraConta(contaSelecionada);

            textoTitular.Text = contaSelecionada.Titular;
            textoNumero.Text = Convert.ToString(contaSelecionada.Numero);
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
        }
        
        public void RemoveConta(Conta conta)
        {
            comboContas.Items.Remove(conta);
            int i;
            for (i = 0; i < this.quantidadeDeContas; i++)
            {
                if (this.contas[i] == conta)
                {
                    break;
                }
            }
            while (i + 1 <= this.quantidadeDeContas)
            {
                this.contas[i] = this.contas[i + 1];
                i++;
            }
        }
            public void AdicionaConta(Conta conta)
        {
            if (this.quantidadeDeContas == this.contas.Length)
            {
                Conta[] novo = new Conta[this.contas.Length * 2];
                for (int i = 0; i < this.quantidadeDeContas; i++)
                {
                    novo[i] = this.contas[i];
                }
                this.contas = novo;
            }
            this.contas[this.quantidadeDeContas] = conta;
            this.quantidadeDeContas++;
            comboContas.Items.Add(conta);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string textoValorSaque = textoValor.Text;
            double valorSaque = Convert.ToDouble(textoValorSaque);
            Conta contaSelecionada = this.BuscaContaSelecionada();
            contaSelecionada.Saca(valorSaque);

            this.MostraConta(contaSelecionada);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoDoValorDoDeposito = textoValor.Text;
            double valorDeposito = Convert.ToDouble(textoDoValorDoDeposito);
            Conta contaSelecionada = this.BuscaContaSelecionada();
            contaSelecionada.Deposito(valorDeposito);

            this.MostraConta(contaSelecionada);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conta contaSelecionada = this.BuscaContaSelecionada();
            int indiceDaContaDestino = destinoDaTransferencia.SelectedIndex;

            Conta contaDestino = this.contas[indiceDaContaDestino];
            string transferenciaValor = textoValor.Text;
            double valorTransferencia = Convert.ToDouble(transferenciaValor);

            contaSelecionada.Transferencia(valorTransferencia, contaDestino);

            textoTitular.Text = contaSelecionada.Titular;
            textoNumero.Text = Convert.ToString(contaSelecionada.Numero);
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
        }

        private void destinoDaTransferencia_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CadastroDeConta cadastro = new CadastroDeConta(this);
            cadastro.ShowDialog();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            int IndiceSelecionado = comboContas.SelectedIndex;
            Conta ContaSelecionada = contas[IndiceSelecionado];
            comboContas.Items.Remove(ContaSelecionada);
            comboContas.Items.Remove(ContaSelecionada);
            RemoveConta(ContaSelecionada);
        }
            
        }
    }
