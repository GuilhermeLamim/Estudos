﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        Conta[] contas;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contas = new Conta[2];
            contas[0] = new Conta();
            contas[0].numero = 1;
            contas[0].Titular = "Victor";
            contas[0].Saldo = 500.0;

            contas[1] = new Conta();
            contas[1].numero = 2;
            contas[1].Titular = "Mario";
            contas[1].Saldo = 550.0;
            foreach (Conta conta in contas)
            {
                comboContas.Items.Add(conta.Titular);
            }
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelecionado = comboContas.SelectedIndex;
            Conta contaSelecionada = contas[indiceSelecionado];

            textoTitular.Text = contaSelecionada.Titular;
            textoNumero.Text = Convert.ToString(contaSelecionada.numero);
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);

        }
    }
}
