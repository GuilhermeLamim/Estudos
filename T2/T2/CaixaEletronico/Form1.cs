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

        private void textoTitular_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            conta.titular = "Vitor";
            conta.numero = 1;
            conta.saldo = 250.0;

            string texto = Convert.ToString(conta.numero);

            textoTitular.Text = conta.numero;
        }
    }
}
