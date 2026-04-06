namespace BancoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            ExibirCabecalho();

            // ─── Escolha do tipo de conta ───────────────────────────────────
            int tipoConta = EscolherTipoConta();

            Conta conta;

            if (tipoConta == 1)
                conta = CadastrarContaPoupanca();
            else
                conta = CadastrarContaEmpresa();

            // ─── Menu de operações ──────────────────────────────────────────
            bool continuar = true;

            while (continuar)
            {
                ExibirMenuOperacoes(conta);
                int opcao = LerOpcao();

                switch (opcao)
                {
                    case 1: // Saque
                        Console.Write("\n  Informe o valor do saque: R$ ");
                        double valorSaque = LerValorPositivo();
                        conta.Saque(valorSaque);
                        break;

                    case 2: // Depósito
                        Console.Write("\n  Informe o valor do depósito: R$ ");
                        double valorDeposito = LerValorPositivo();
                        conta.Deposito(valorDeposito);
                        break;

                    case 3: // Operação específica do tipo de conta
                        if (conta is ContaPoupanca poupanca)
                        {
                            Console.WriteLine("\n  Aplicando atualização de saldo com juros...");
                            poupanca.AtualizacaoDeSaldo();
                        }
                        else if (conta is ContaParaEmpresa empresa)
                        {
                            Console.Write("\n  Informe o valor do empréstimo: R$ ");
                            double valorEmprestimo = LerValorPositivo();
                            empresa.Emprestimo(valorEmprestimo);
                        }
                        break;

                    case 4: // Exibir dados
                       
                        Console.WriteLine("        DADOS DA CONTA");
                        break;

                    case 0: // Sair
                        continuar = false;
                        Console.WriteLine("\n  Obrigado por usar o BancoApp! Até logo.\n");
                        break;

                    default:
                        Console.WriteLine("\n  Opção inválida. Tente novamente.");
                        break;
                }

                if (continuar)
                {
                    Console.WriteLine("\n  Pressione ENTER para continuar...");
                    Console.ReadLine();
                }
            }
        }



        static void ExibirCabecalho()
        {
            Console.Clear();
         
            Console.WriteLine("      B A N C O   A P P          ");
            Console.WriteLine("    Sistema de Contas Bancárias     ");
           
        }

        static int EscolherTipoConta()
        {
            while (true)
            {
                Console.WriteLine("  Qual tipo de conta deseja criar?\n");
                Console.WriteLine("  [1] Conta Poupança");
                Console.WriteLine("  [2] Conta Para Empresa\n");
                Console.Write("  Opção: ");

                if (int.TryParse(Console.ReadLine(), out int opcao) && (opcao == 1 || opcao == 2))
                    return opcao;

                Console.WriteLine("\n Opção inválida. Digite 1 ou 2.\n");
            }
        }

        static ContaPoupanca CadastrarContaPoupanca()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("       CADASTRO — CONTA POUPANÇA");
            Console.ResetColor();

            Console.Write("  Número da conta:    ");
            int numero = LerInteiro();

            Console.Write("  Nome do titular:    ");
            string titular = Console.ReadLine() ?? "Sem nome";

            Console.Write("  Saldo inicial: R$   ");
            double saldo = LerValorPositivo();

            Console.Write("  Taxa de juros (%):  ");
            double taxa = LerValorPositivo();

            var conta = new ContaPoupanca(numero, titular, saldo, taxa);

            Console.WriteLine("\n Conta Poupança cadastrada com sucesso!");
            return conta;
        }

        static ContaParaEmpresa CadastrarContaEmpresa()
        {
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("      CADASTRO — CONTA PARA EMPRESA");
           Console.ResetColor();

            Console.Write("  Número da conta:          ");
            int numero = LerInteiro();

            Console.Write("  Nome do titular/empresa:  ");
            string titular = Console.ReadLine() ?? "Sem nome";

            Console.Write("  Saldo inicial: R$         ");
            double saldo = LerValorPositivo();

            Console.Write("  Limite de empréstimo: R$  ");
            double limite = LerValorPositivo();

            var conta = new ContaParaEmpresa(numero, titular, saldo, limite);

            Console.WriteLine("\n Conta Para Empresa cadastrada com sucesso!");
            return conta;
        }

        static void ExibirMenuOperacoes(Conta conta)
        {
            Console.Clear();

            string tipoConta = conta is ContaPoupanca ? "CONTA POUPANÇA" : "CONTA PARA EMPRESA";
            string operacaoEspecifica = conta is ContaPoupanca
                ? "[3] Atualizar Saldo (Juros)"
                : "[3] Solicitar Empréstimo";

           
            Console.WriteLine($"     MENU DE OPERAÇÕES — {tipoConta}");
         
            Console.WriteLine($"  Titular: {conta.Titular}");
            Console.WriteLine($"  Saldo:   R$ {conta.Saldo:F2}\n");
            Console.WriteLine($"  [1] Saque");
            Console.WriteLine($"  [2] Depósito");
            Console.WriteLine($"  {operacaoEspecifica}");
            Console.WriteLine($"  [4] Exibir Dados da Conta");
            Console.WriteLine($"  [0] Sair\n");
            Console.Write("  Opção: ");
        }

        static int LerOpcao()
        {
            if (int.TryParse(Console.ReadLine(), out int opcao))
                return opcao;
            return -1;
        }

        static int LerInteiro()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int valor))
                    return valor;
                Console.Write(" Digite um número inteiro válido: ");
            }
        }

        static double LerValorPositivo()
        {
            while (true)
            {
                string? entrada = Console.ReadLine()?.Replace(",", ".");
                if (double.TryParse(entrada,
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture,
                    out double valor) && valor > 0)
                    return valor;

                Console.Write(" Digite um valor numérico positivo: ");
            }
        }
    }
}