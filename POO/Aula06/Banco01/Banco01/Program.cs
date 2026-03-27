using Banco01;
using static System.Console;

Title = "Cadastro de Conta";
ContaBancaria conta;

// -------- entrada de dados ------

Write("Entre com o número da conta: ");
int n = int.Parse(ReadLine());
Write("Entre com o nome do Titular da conta: ");
string nome = ReadLine();
Write("Deseja fazer deposito inicial ( S/N): ");
char resposta = char.Parse(ReadLine().ToLower());

    if( resposta == 's')
        {
            Write("Entre com o valor de deposito inicial: ");
            double dep = double.Parse(ReadLine());
            conta = new ContaBancaria( n, nome, dep);
        }
    else
    {
        conta = new(n, nome);
    }

conta.Dados();

ReadKey();