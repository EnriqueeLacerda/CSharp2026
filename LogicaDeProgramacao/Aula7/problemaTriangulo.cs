
using static System.Console;

double a, b, c, resultado, p, area;


Write("digite o valor de a:");
a = double.Parse(ReadLine());
WriteLine();
Write("digite o valor de b:");
b = double.Parse(ReadLine());
WriteLine();
Write("digite o valor de c:");
c = double.Parse(ReadLine());

if(a < b + c & b < a + c & c < a + b)
{
    p = (a + b + c) / 2;
    resultado = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    WriteLine($"o valor da area do triangulo é {resultado}");
}
else
{
    WriteLine("os valores não formam um triangulo");
    area = ((a + b)*c / 2);
    
    WriteLine($"a area do trapezio é: {area} m²");
    
}