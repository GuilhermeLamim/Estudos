﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class ContaPoupanca : Conta
    {
        public override void Deposita(double valor)
        {
            this.Saldo += valor + 0.1;
        }
    }
}
