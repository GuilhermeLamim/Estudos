using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayBanco
{
    class Banco
    {
        private Conta[] contas = new Conta[10];

        private int quantidade;

        public void Adiciona(Conta conta)
        {
            this.contas[this.quantidade] = conta;
            this.quantidade++;
        }
        public void mostra()
        {
            for (int i = 0; i < 10; i++) 
            {
                MessageBox.Show("Arrays: " + contas[i]);
            }
        }
    }
}
