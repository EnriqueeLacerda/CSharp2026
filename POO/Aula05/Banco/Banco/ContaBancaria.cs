using System;


namespace Banco
{
    internal class ContaBancaria
    {
        //Campo ou atributos

        private int  numero;
        private string titular;
        private double saldo;


        //construtor

        public ContaBancaria(int numero, string titular)
        {
            this.numero = numero;
            this.titular = titular;
            saldo = 0;
        }   
                                                                         // reaproventamento de construtor            
        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular) // <^
        {
            this.saldo = saldo;
        }

        // metodos

        public void Deposito(double quantia)
        {
            saldo += quantia;
        }

        public void Saque ( double quantia)
        {
            saldo -= quantia;
        }

        public void Dados()
        {
            Console.WriteLine("Dados da conta Cadastrada: ");
            Console.WriteLine($" \t Titular: {titular}\n" + $" \t Numero da conta: {numero}\n " + $" \t Saldo da Conta: R$ {saldo}");
        }
    }
}
