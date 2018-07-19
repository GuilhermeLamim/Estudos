using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palimorfismo
{
    class ContaCorrente : Conta
    {
        public override void Atualiza(double taxa)
        {
            this.Saldo += this.Saldo * 2 * taxa;
        }
    }
}
