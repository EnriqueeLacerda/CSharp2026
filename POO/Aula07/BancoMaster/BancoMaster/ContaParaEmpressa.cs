using System;
using System.Collections.Generic;
using System.Text;

namespace BancoMaster
{
    internal class ContaParaEmpressa : Conta
    {
        public ContaParaEmpressa(int numeroConta, string titularConta) : base(numeroConta, titularConta)
        {
        }

        public ContaParaEmpressa(int numeroConta, string titularConta, double saldoConta) : base(numeroConta, titularConta, saldoConta)
        {
        }
    }
}
