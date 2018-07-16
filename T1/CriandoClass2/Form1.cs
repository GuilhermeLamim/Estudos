using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriandoClass2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta umaConta = new Conta();
            umaConta.saldo = 2000.0;
            umaConta.titular = "Caitano Pereira";
            umaConta.numero = 1;
            umaConta.cpf = "321.654.898 - 89";
            umaConta.agencia = 685989;

            Conta outraConta = new Conta();
            outraConta.saldo = 4000.0;
            outraConta.titular = "Oracio da Silva";
            outraConta.numero = 2;
            outraConta.cpf = "456.478.741 - 56";
            outraConta.agencia = 6897891;

            MessageBox.Show("Titular: " +umaConta.titular + "\n CPF: " + umaConta.cpf + "\n Agência: " + umaConta.agencia);
            MessageBox.Show("Titular: " +outraConta.titular + "\n CPF: " + outraConta.cpf + "\n Agência: " + outraConta.agencia);
        }
    }
}
