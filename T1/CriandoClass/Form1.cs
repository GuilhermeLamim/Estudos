using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriandoClass
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
            umaConta.titular = "Mario Bahia";
            umaConta.numero = 33324665;

            MessageBox.Show("O nome do titular é: " + umaConta.titular);

        }
    }
}
