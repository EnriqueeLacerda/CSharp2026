
using static System.Console;

double Base, altura, area, perimentro, diagonal;
Write("Digite a base do retangulo: ");
Base = double.Parse(ReadLine());
WriteLine();
Write("digite a altura do retangulo: ");
altura = double.Parse(ReadLine());

area = altura * Base;
perimentro = 2 * ( Base + altura);
diagonal = Math.Sqrt((Base*Base) + (altura*altura));


Write($"a area é: {area},  O perimetro é :{perimentro}, Diagonal é: {diagonal}");









