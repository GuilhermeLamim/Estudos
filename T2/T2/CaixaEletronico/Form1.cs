using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            conta.Deposito(250.0);
            conta.Numero = 2;
            Cliente cliente = new Cliente();
            conta.Titular = cliente;
            conta.Titular.nome = "Victor";

            string saldo = Convert.ToString(conta.Saldo);
            string numero = Convert.ToString(conta.Numero);

            textoTitular.Text = conta.Titular.nome;
            textoSaldo.Text = saldo;
            textoNumero.Text = numero;

        }

        
    }
    }
