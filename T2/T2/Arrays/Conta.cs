using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Conta
    {
        public double Numero;
        public Double Saldo;
        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }
    }
}
