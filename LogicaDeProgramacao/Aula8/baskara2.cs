using static System.Console;
//----------- funçoes -------
static double delta(double a, double b, double c  )
{
     return (b*b) - (4*a*c);
}

static void saida(double x1, double x2)
{
     WriteLine($"x1 = {x1}\n x2 {x2}");
}

//------------- declaração de variavel ---------
double a, b, c, delta1, x1, x2;
const string TEXTO = "Digite o valor de ";

Write(TEXTO + "a");
a = double.Parse(ReadLine());
Write(TEXTO + "b");
b = double.Parse(ReadLine());
Write(TEXTO + "c");
c = double.Parse(ReadLine());

delta1 = delta(a, b, c);

// ----- estrutura de controle de decisão  - if -

if (delta1 < 0)
{
    WriteLine("raizes impossiveis");

}

else if (delta1 == 0)
{
    x1 = -b / (2*a);
    x2 = x1;
    saida(x1 ,x2);
}
else
{
    x1 = ( -b - Math.Sqrt(delta1)) / (2*a);
    x2 = ( -b + Math.Sqrt(delta1)) / (2*a);
    saida(x1, x2);
}
