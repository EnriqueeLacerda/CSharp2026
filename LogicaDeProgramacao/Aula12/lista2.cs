using static System.Console;

// exercicio de lista com a estrutura de repetição for

int n;
List <double> numeros = new List<double>();

Write("Quantos numeros você vai digitar?");
n= int.Parse(ReadLine());

for (int i=0; i < n; i++)
{
    Write("digite um numero: ");
    numeros.Add(double.Parse(ReadLine()));

}
 WriteLine("Valores=");

for (int i=0; i < n; i++)
{
        WriteLine($"{numeros [i]}");
}

WriteLine($"\nSoma={numeros.Sum()}");
WriteLine($"\nMedia={numeros.Average()}");