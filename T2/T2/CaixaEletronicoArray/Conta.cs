using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronicoArray
{
     public abstract class Conta
    {
        public int Numero;
        public double Saldo;
        public string Titular;
      
        public void Deposito(double valor)
        {
            this.Saldo += valor;
        }

        public virtual void Saca(double valor)
        {
            this.Saldo -= valor;
        }

        public void Transferencia(double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposito(valor);
        }

    }
}
