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
            {

                Conta conta = null;
                if (tipoDaConta.Text == "Poupanca")
                {
                    conta = new ContaPoupanca();
                }
                else
                {
                    conta = new ContaCorrente();
                }
                
                
                conta.Numero = Convert.ToInt32(numeroConta.Text);
                conta.Titular = titularConta.Text;
                this.aplicacaoPrincipal.AdicionaConta(conta);
            }

            /*{
                ContaCorrente c = new ContaCorrente();
                c.Numero = Convert.ToInt32(numeroConta.Text);
                c.Titular = titularConta.Text;
            }*/
            
            this.Close();
        }

        private void CadastroDeConta_Load(object sender, EventArgs e)
        {

        }

        private void tipoDaConta_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
