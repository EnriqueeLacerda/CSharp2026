// entrada de dados
Console.WriteLine("digite seu nome");
string nome = Console.ReadLine();
Console.WriteLine($"o valor digitado é de {nome}");

///////////////////////////////////////////////////

Console.WriteLine("digite o 1º numero");
double x = double.Parse(Console.ReadLine()); // converte o valor digitado para double, caso contrário ele seria string
Console.WriteLine("digite o 2º numero");
double y = double.Parse(Console.ReadLine());// converte o valor digitado para double, caso contrário ele seria string
double soma = x + y;
Console.WriteLine($"a soma dos numeros é {soma}");
