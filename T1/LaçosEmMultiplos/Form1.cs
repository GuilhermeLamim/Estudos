﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaçosEmMultiplos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soma = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 != 0)
                {
                    soma = soma + i;
                }
            }
            MessageBox.Show("A soma dos números sem os divisores de 3: " + soma);
        }
    }
}
