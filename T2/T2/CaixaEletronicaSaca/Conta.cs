using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronicaSaca
{
    class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public Cliente Titular;

        public void Deposito( double valor)
        {
            this.Saldo += valor;
        }

        public void Saca(double valor)
        {
            this.Saldo -= valor;
        }
    }
}
