// crie um aplicativo de consele no qual o usuario tenha que  digita trÊs valores, a lagura, o complimento e o valor do metro quadrado,
//e em seguida calcule a area do terreno e o preço do terreno, e mostre esses valores na saida de dados

using static System.Console;

double largura, comprimento, valor, area, precoFinal; // declaração de variaveis
WriteLine("digite a largura do terreno");
largura = double.Parse(ReadLine()); // entrada de dados e conversão para double
WriteLine();
WriteLine("digite o comprimento do terreno");
comprimento = double.Parse(ReadLine());
WriteLine();
WriteLine("digite o valor do metro quadrado");
valor = double.Parse(ReadLine());
WriteLine();
area = largura * comprimento; // calculo da area do terreno
precoFinal = area * valor; // calculo do preço do terreno
WriteLine($"a area do terreno é {area} m²  e o valor total é R${precoFinal}"); // saida de dados



