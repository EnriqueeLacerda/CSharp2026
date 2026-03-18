using ExemploComPOO;
using static System.Console;


Triangulo x = new Triangulo();
Triangulo y = new Triangulo();

Console.WriteLine("digite as medidas do triangulo X");
Console.WriteLine("digite a medida A");
x.ladoA = double.Parse(ReadLine());
Console.WriteLine("digite a medida B");
x.ladoB = double.Parse(ReadLine());
Console.WriteLine("digite a medida C");
x.ladoC = double.Parse(ReadLine());

Console.WriteLine("digite as medidas do triangulo y");
Console.WriteLine("digite a medida A");
y.ladoA = double.Parse(ReadLine());
Console.WriteLine("digite a medida B");
y.ladoB = double.Parse(ReadLine());
Console.WriteLine("digite a medida C");
y.ladoC = double.Parse(ReadLine());



WriteLine($"A área do triangulo x é de {x.area()}");
WriteLine($"A área do triangulo y é de {y.area()}");

ReadKey();

