using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
   public abstract class Conta
    {
        public double Saldo;

        public virtual void Saca(double valor)
        {
            this.Saldo -= valor;
        }

        public void Deposita (double valor)
        {
            this.Saldo += valor;
        }
       
    }
}
