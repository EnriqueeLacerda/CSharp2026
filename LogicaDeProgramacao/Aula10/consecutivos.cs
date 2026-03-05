using static System.Console;

int x, resultado; 
while (true)
{
    Write("digite um numero ou zero para sair:");
    x = int.Parse(ReadLine()!);
    if (x == 0)
    {
        WriteLine("Programa encerrado.");
        break;
    }
     if (x % 2 == 0)
    {
       resultado =  x + (x+2)+ (x+4)+ (x+6)+ (x+8);
    }
    else
    {
      x = x + 1;
      resultado =  x + (x+2)+ (x+4)+ (x+6)+ (x+8);
    }
    WriteLine($"Soma = {resultado}");
}

    