using static System.Console;
// decaração de variavies -------

double nota1, nota2, resultado;

// entrada de dados --------
Write("digite a primeira nota");
nota1 = double.Parse(ReadLine());
Write("digite a segunda nota");
nota2 = double.Parse(ReadLine());


//processamento de dados -------

resultado = nota1 + nota2 ;

if (resultado < 60)
{
    WriteLine($" nota final = {resultado}");
    WriteLine("resprovado");
}

else
{
    WriteLine($" nota final = {resultado}");
    WriteLine("aprovado");
}