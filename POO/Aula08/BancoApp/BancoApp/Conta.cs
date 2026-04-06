namespace BancoApp
{
   
    // Taxa de saque: R$ 5,00

    public class Conta
    {
       
        private int numero;
        private string titular;
        private double saldo;

      
        public int Numero { get => numero; set => numero = value; }
        public string Titular { get => titular; set => titular = value; }
        public double Saldo { get => saldo; protected set => saldo = value; }

        // Construtores
        public Conta() { }

        public Conta(int numero, string titular, double saldo)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
        }


        // saque com taxa de R$ 5,00 para conta comum.

        public virtual void Saque(double quantia)
        {
            double taxa = 5.00;
            double totalDebitado = quantia + taxa;

            if (totalDebitado > saldo)
            {
                Console.WriteLine($"\n Saldo insuficiente!");
                Console.WriteLine($"  Saldo atual:      R$ {saldo:F2}");
                Console.WriteLine($"  Valor do saque:   R$ {quantia:F2}");
                Console.WriteLine($"  Taxa:             R$ {taxa:F2}");
                Console.WriteLine($"  Total necessário: R$ {totalDebitado:F2}");
            }
            else
            {
                saldo -= totalDebitado;
                Console.WriteLine($"\n Saque realizado com sucesso!");
                Console.WriteLine($"  Valor sacado:  R$ {quantia:F2}");
                Console.WriteLine($"  Taxa cobrada:  R$ {taxa:F2}");
                Console.WriteLine($"  Saldo atual:   R$ {saldo:F2}");
            }
        }

  
        // depósito na conta.
     
        public virtual void Deposito(double quantia)
        {
            if (quantia <= 0)
            {
                Console.WriteLine("\n O valor do depósito deve ser positivo.");
                return;
            }

            saldo += quantia;
            Console.WriteLine($"\n Depósito realizado com sucesso!");
            Console.WriteLine($"  Valor depositado: R$ {quantia:F2}");
            Console.WriteLine($"  Saldo atual:      R$ {saldo:F2}");
        }

      
        // dados da conta.
      
        public virtual void ExibirDados()
        {
            Console.WriteLine($"  Número:   {numero}");
            Console.WriteLine($"  Titular:  {titular}");
            Console.WriteLine($"  Saldo:    R$ {saldo:F2}");
            Console.WriteLine($"  Tipo:     Conta Comum");
        }
    }
}