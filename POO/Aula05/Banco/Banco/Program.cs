using Banco;
using static System.Console;
using static System.Globalization.CultureInfo;


Title = "Abertura de conta";
ContaBancaria conta;

Console.ForegroundColor = ConsoleColor.Green;
WriteLine("Abertura de conta - Nika Investmento");
Console.ResetColor();

Write("Entre com um numero de conta: ");
int numero = int.Parse(ReadLine());

Write("Entre com o nome do titular: ");
string nome = ReadLine();

Write("Deseja fazer deposito ( S / n ): ");
char resposta = char.Parse(ReadLine().ToLower());

    if (resposta == 's')
{
    Write("Entre com valor de deposito: R$ ");
    double deposito = double.Parse(ReadLine());
   conta = new ContaBancaria(numero, nome, deposito);
}
else
{
     conta = new ContaBancaria(numero, nome);
}
conta.Dados();

Write("Entre com valor de deposito: R$ ");
double quantia = double.Parse(ReadLine());
conta.Deposito(quantia);

Write("Entre com valor para o saque R$ ");
quantia = double.Parse(ReadLine());
conta.Saque(quantia);




ReadKey();

