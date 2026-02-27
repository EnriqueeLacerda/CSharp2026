/* o usuario vai digita um valor de 1 a 7 e o programa vai dizer o dia da semana correspondente */
using static System.Console;

int valor;

WriteLine("Digite um valor de 1 a 7");
valor = int.Parse(ReadLine());

if (valor == 1)
{
    WriteLine("Domingo");
}
else if (valor == 2)
{
    WriteLine("Segunda");
}
else if (valor == 3)
{
    WriteLine("Terça");
}
else if (valor == 4)
{
    WriteLine("Quarta");
}
else if (valor == 5)
{
    WriteLine("Quinta");
}
else if (valor == 6)
{
    WriteLine("Sexta");
}
else if (valor == 7)
{
    WriteLine("Sabado");
}
else
{
    WriteLine("numero fora do intevalo");
}