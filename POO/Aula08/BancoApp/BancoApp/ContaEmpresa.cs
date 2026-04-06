namespace BancoApp
{

    // Empresa: herda de Conta.
    // Possui limite de empréstimo e método Emprestimo.
    // Taxa de saque: R$ 5,00 (herda comportamento da Conta base).

    public class ContaParaEmpresa : Conta
    {
       
        private double limiteDeEmprestimo;

        public double LimiteDeEmprestimo { get => limiteDeEmprestimo; set => limiteDeEmprestimo = value; }

        // Construtores
        public ContaParaEmpresa() { }

        public ContaParaEmpresa(int numero, string titular, double saldo, double limiteDeEmprestimo)
            : base(numero, titular, saldo)
        {
            this.limiteDeEmprestimo = limiteDeEmprestimo;
        }

      
        /*empréstimo creditando o valor na conta,
         desde que não ultrapasse o limite de empréstimo disponível.*/
     
        public void Emprestimo(double quantia)
        {
            if (quantia <= 0)
            {
                Console.WriteLine("\n O valor do empréstimo deve ser positivo.");
                return;
            }

            if (quantia > limiteDeEmprestimo)
            {
                Console.WriteLine($"\n Valor excede o limite de empréstimo disponível!");
                Console.WriteLine($"  Valor solicitado:        R$ {quantia:F2}");
                Console.WriteLine($"  Limite de empréstimo:    R$ {limiteDeEmprestimo:F2}");
            }
            else
            {
                Saldo += quantia;
                limiteDeEmprestimo -= quantia;
                Console.WriteLine($"\n Empréstimo realizado com sucesso!");
                Console.WriteLine($"  Valor emprestado:        R$ {quantia:F2}");
                Console.WriteLine($"  Saldo atual:             R$ {Saldo:F2}");
                Console.WriteLine($"  Limite restante:         R$ {limiteDeEmprestimo:F2}");
            }
        }

    
        //  dados Conta Para Empresa.
    
        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"  Limite de Empréstimo: R$ {limiteDeEmprestimo:F2}");
            Console.WriteLine($"  Tipo:                 Conta Para Empresa");
        }
    }
}