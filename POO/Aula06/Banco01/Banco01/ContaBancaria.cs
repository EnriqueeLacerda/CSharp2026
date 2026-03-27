using System;


namespace Banco01
{
    internal class ContaBancaria
    {

		// -----------campo   propfull  aperta tab, tab ----------

		private int numero;
		private string titular;
		private double saldo;



        // ------------ propriedade ------------------------
        public int Numero
		{
			get { return numero; }
			set { numero = value; }
		}

		public string Titular
		{
			get { return titular; }
			set { titular = value; }
		}
		public double Saldo
		{
			get { return saldo; }
			set {
				if (value > 0)
				{
					saldo = value;
				}

				else
				{
					saldo = 0;
				}

					}	


			
					
		}

        // --------------- construtor -------------------------

        public ContaBancaria(int numero, string titular)
		{
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }


		public ContaBancaria(int numero, string titular, double saldo) : this (numero, titular)
		{
			
			
            Saldo = saldo;

        }
		
		// --------------- metodos ------------------------------------------------------

		public void Deposito (double quantia)
		{
			Saldo += quantia;
		}

        public void Saque(double quantia)
        {
            Saldo -= quantia;
        }

		public void Dados()
		{
            Console.WriteLine($"Dados da Conta: \n + " +
				$"\t Conta: {Numero}\n +" +
				$"\t Titular: {Titular}\n +" +
				$"\t Saldo: {Saldo:C}");
		}

    }
}
