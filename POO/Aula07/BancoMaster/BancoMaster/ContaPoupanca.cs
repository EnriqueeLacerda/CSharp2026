using System;
using System.Collections.Generic;
using System.Text;

namespace BancoMaster
{
    internal class ContaPoupanca : Conta
    {
      
        public ContaPoupanca(int numeroConta, string titularConta) : base(numeroConta, titularConta)
        {
        }

        public ContaPoupanca(int numeroConta, string titularConta, double saldoConta) : base(numeroConta, titularConta, saldoConta)
        {
        }

      
    }
}
