using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    internal class PessoaJuridica : PessoaFisica
    {
        private double limete;

        public double LimiteEmprestimo
        {
            get { return limete; }
            set { limete = value; }
        }


        public PessoaJuridica(int numeroConta, string titularConta, double limiteConta) : base(numeroConta, titularConta)
        {
            LimiteEmprestimo = limiteConta;
        }

        public PessoaJuridica(int numeroConta, string titularConta, double saldoConta, double limiteConta) : base(numeroConta, titularConta, saldoConta)
        {
            LimiteEmprestimo = limiteConta;
        }

        // metodos

        public void Limite(double quantia)
        {
            SaldoConta += quantia;
        }
    }
}
