using BancoMaster;
using static System.Console;

Title = "Cadastro de Conta";
ContaPoupanca conta;

// -------- entrada de dados ------

Write("Entre com o número da conta: ");
int n = int.Parse(ReadLine());
Write("Entre com o nome do Titular da conta: ");
string nome = ReadLine();
Write("Deseja fazer uma conta  ( P/E): ");
char resposta = char.Parse(ReadLine().ToLower());

if (resposta == 'p')
{
    Write("Entre com o valor de deposito inicial: ");
    double dep = double.Parse(ReadLine());
    conta = new ContaPoupanca (n, nome, dep);
}
else
{
    conta = new(n, nome);
}