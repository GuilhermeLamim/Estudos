using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palimorfismo
{
    class Conta
    {
        public double Saldo { get; protected set; }
        public int Numero { get; set; }
        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }
        public void Saca(double valor)
        {

            this.Saldo -= valor;
        }
        public virtual void Atualiza(double taxa)
        {
            this.Saldo += this.Saldo * taxa;
        }
    }
}
