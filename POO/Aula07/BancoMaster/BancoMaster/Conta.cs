

namespace BancoMaster
{
    internal class Conta
    {
        //campo

        private int numero;
        private string titular;
        private double saldo;

        public Conta(int numeroConta, string titularConta, double saldoConta)
        {
            NumeroConta = numeroConta;
            TitularConta = titularConta;
            SaldoConta = saldoConta;
        }

        public Conta(int numeroConta, string titularConta) : this(numeroConta, titularConta, 0)
        {
            SaldoConta = 0;
        }

        public int NumeroConta
        {
            get { return numero; }
            set { numero = value; }
        }


        public string TitularConta
        {
            get { return titular; }
            set { titular = value; }
        }


        public double SaldoConta
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public void Saque(double quantia)
        {
            SaldoConta -= quantia;
        }
        public void Deposito(double quantia)
        {
            SaldoConta += quantia;
        }

    }
}
