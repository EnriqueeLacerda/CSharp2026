namespace BancoApp
{

    // Conta Poupança: herda de Conta.
    // Não cobra taxa no saque.
  
  
    public class ContaPoupanca : Conta
    {
        // Atributo específico da poupança
        private double taxaDeJuros;

        public double TaxaDeJuros { get => taxaDeJuros; set => taxaDeJuros = value; }

        // Construtores
        public ContaPoupanca() { }

        public ContaPoupanca(int numero, string titular, double saldo, double taxaDeJuros)
            : base(numero, titular, saldo)
        {
            this.taxaDeJuros = taxaDeJuros;
        }

      
        /// Atualiza o saldo a taxa de juros.
   
        public void AtualizacaoDeSaldo()
        {
            double rendimento = Saldo * (taxaDeJuros / 100);
            Saldo += rendimento;
            Console.WriteLine($"\n Saldo atualizado com juros!");
            Console.WriteLine($"  Taxa de juros:  {taxaDeJuros:F2}%");
            Console.WriteLine($"  Rendimento:     R$ {rendimento:F2}");
            Console.WriteLine($"  Novo saldo:     R$ {Saldo:F2}");
        }

     
        //Saque sem cobrança de taxa para Conta Poupança.
  
        public override void Saque(double quantia)
        {
            if (quantia > Saldo)
            {
                Console.WriteLine($"\n  [ERRO] Saldo insuficiente!");
                Console.WriteLine($"  Saldo atual:    R$ {Saldo:F2}");
                Console.WriteLine($"  Valor do saque: R$ {quantia:F2}");
            }
            else
            {
                Saldo -= quantia;
                Console.WriteLine($"\n  [OK] Saque realizado com sucesso!");
                Console.WriteLine($"  Valor sacado:  R$ {quantia:F2}");
                Console.WriteLine($"  Sem taxa! (Conta Poupança)");
                Console.WriteLine($"  Saldo atual:   R$ {Saldo:F2}");
            }
        }

      
        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"  Taxa de Juros: {taxaDeJuros:F2}%");
            Console.WriteLine($"  Tipo:          Conta Poupança");
        }
    }
}