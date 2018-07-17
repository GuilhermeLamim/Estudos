using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoClassCliente
{
    class Conta
    {
        public int numero;
        public double saldo;
        public Cliente titular;
        public int idade;

        public bool maiorDeIdade()
        {
            return this.idade >= 18;
        }
        public bool Saca(double valorASerSacado)
        {
            if (valorASerSacado > this.saldo || valorASerSacado < 0)
            {
                return false;
            }
            else
            {
                if (this.titular.EhMaiorDeIdade())
                {
                    this.saldo -= valorASerSacado;
                    return true;
                }
                else
                {
                    //novo
                    if (valorASerSacado <= 200)
                    {
                        this.saldo -= valorASerSacado;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
                    