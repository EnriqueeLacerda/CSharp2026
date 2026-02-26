using static System.Console;

// probema baskara
//------ Declaração de variaveis ----

double a, b, c, delta, x1, x2;

//------ entrada de dados ---
Write("digite o valor de a:");
a = double.Parse(ReadLine());
Write("digite o valor de b");
b = double.Parse(ReadLine());
Write("digite o valor de c");
c = double.Parse(ReadLine());
// processamento de dados ----

delta = (b*b) - (4*a*c);
// ----- estrutura de controle de decisão  - if -

if (delta < 0)
{
    WriteLine("raizes impossiveis");

}

else if (delta == 0)
{
    x1 = -b / (2*a);
    x2 = x1;
    WriteLine($"x1 = {x1}\n x2 {x2}");
}
else
{
    x1 = ( -b - Math.Sqrt(delta)) / (2*a);
    x2 = ( -b + Math.Sqrt(delta)) / (2*a);
     WriteLine($"x1 = {x1}\n x2 {x2}");
}
