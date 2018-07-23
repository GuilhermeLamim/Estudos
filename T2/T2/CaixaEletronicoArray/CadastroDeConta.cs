﻿using System;
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
    public partial class CadastroDeConta : Form
    {

        private Form1 aplicacaoPrincipal;
        public CadastroDeConta(Form1 aplicacaoPrincipal)
        {
            this.aplicacaoPrincipal = aplicacaoPrincipal;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string titular = titularConta.Text;
            int numero = Convert.ToInt32(numeroConta.Text);

            Conta conta = new ContaCorrente()
            {
                Numero = numero,
                Titular = new Cliente { Nome = titular }
            };
        }

        private void CadastroDeConta_Load(object sender, EventArgs e)
        {

        }
    }
}
