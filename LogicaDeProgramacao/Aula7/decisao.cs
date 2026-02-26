double resultado = 1;
//--------------- Entrada de dados --------------
System.Console.WriteLine("digite um numero:");
double entrada = double.Console.Parse(Console.ReadLine());

//-------------- Processamento de dados ----------

if (entrada > 0) // condição Se
{
    double resultado = 2 / entrada;
}
else if (entrada < 0) // Se Não Se
{
    resultado = 2 - entrada;
}
else // condição Se Não
{
    resultado = 2 + entrada;
}

//--------------- saida de dados -------------

Console.WriteLine($"o resultado é:{resultado}");