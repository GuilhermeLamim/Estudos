using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Conta
    {
        public double Saldo { get; set; }
        public int Numero { get; set; }
        public Cliente Titular;


        public void Deposito(double valor)
        {
            this.Saldo += valor;
        }
    }
}
