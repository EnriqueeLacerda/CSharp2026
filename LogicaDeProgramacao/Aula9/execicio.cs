/*  fazer um programa que dado o número de visitantes, altura mínima, 
altura máxima e as alturas de todos os visitantes, calcule quantas pessoas 
poderão andar na montanha-russa.*/

using static System.Console;

double alturaMinima, alturaMaxima;
int numeroVisitantes, visitantesAptos = 0;

try
{
    Write("Digite o numero de pessoas ");
    numeroVisitantes = int.Parse(ReadLine());

    Write("Digite a altura mínima: ");
    alturaMinima = double.Parse(ReadLine());

    Write("Digite a altura máxima: ");
    alturaMaxima = double.Parse(ReadLine());

    
    for (int i = 0; i < numeroVisitantes; i++)
    {
        Write($"Digite a altura do visitante {i+1}: ");
        double alturaVisitante = double.Parse(ReadLine());

        if (alturaVisitante >= alturaMinima & alturaVisitante <= alturaMaxima)
        {
            visitantesAptos++;
        }
        else if (alturaVisitante < alturaMinima)
        {
        WriteLine("Visitante reprovado por ser baixo demais");
        }
        else
        {
        WriteLine("Visitante reprovado por ser alto demais");

    }

}
    WriteLine($"O numero de visitantes aptos a andar na montanha-russa é: {visitantesAptos}");
}
catch (Exception ex)
{
    WriteLine($"Digite valores validos, erro: {ex.Message}");
}