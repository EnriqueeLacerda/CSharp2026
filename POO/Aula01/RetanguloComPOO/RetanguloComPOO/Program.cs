/* elabora um aplicativo de console p/ ler dados de dois retangulo, altura e lagura,
 * em seguida mostra na saida de dados a Area, Perimetro e Diagonal dos dois retangulo */

using RetanguloComPOO;
using static System.Console;

Retangulo1 x = new Retangulo1();
Retangulo1 y = new Retangulo1();

Console.WriteLine("digite as medidas do Retangulo X");
WriteLine();
Console.WriteLine("Digite a Altura do retangulo:");
x.Altura = double.Parse(ReadLine());
Console.WriteLine("digite a altura do retangulo:");
x.Lagura = double.Parse(ReadLine());
x.Processamento();
WriteLine();

Console.WriteLine("digite as medidas do Retangulo Y");
WriteLine();
Console.WriteLine("Digite a base do retangulo:");
y.Altura = double.Parse(ReadLine());
Console.WriteLine("digite a altura do retangulo:");
y.Lagura = double.Parse(ReadLine());
y.Processamento();

