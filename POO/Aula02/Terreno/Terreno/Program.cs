using terreno;
using static System.Console;



Write("digite a lagura do terreno: ");
double lagura = double.Parse(Console.ReadLine());
WriteLine();
Write("digite o complimento do terreno: ");
double  comprimento = double.Parse(Console.ReadLine());
WriteLine();
Write("digite o valor do terreno: ");
double  valor = double.Parse(Console.ReadLine());
WriteLine();

Terreno t = new Terreno(lagura,comprimento, valor);
t.Saida();
ReadKey();










