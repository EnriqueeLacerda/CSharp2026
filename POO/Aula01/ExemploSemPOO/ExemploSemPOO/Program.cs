using static System.Console;

// entrada de dados

WriteLine("Digite as medidas do triângulo X : ");
Write("digite o valor de a: ");
double ax= double.Parse(ReadLine());
Write("digite o valor de b: ");
double bx= double.Parse(ReadLine());
Write("digite o valor de c: ");
double cx= double.Parse(ReadLine());

WriteLine("Digite as medidas do triângulo Y : ");
Write("digite o valor de a: ");
double ay= double.Parse(ReadLine());
Write("digite o valor de b: ");
double by= double.Parse(ReadLine());
Write("digite o valor de c: ");
double cy= double.Parse(ReadLine());

// Processamento de dados

double px = (ax + bx + cx) / 2;
double py = (ay + by + cy) / 2;
double areax = Math.Sqrt(px * (px - ax) * (px - bx) * (px - cx));
double areay = Math.Sqrt(px * (py -ay) * (py - by) * (py - cy));

// saida de dados 

WriteLine($"A área do triangulo x é : de {areax: F2}");
WriteLine($"A área do triangulo y é : de {areay: F2}");

if (areax > areay)
{
    WriteLine("maior area é do triangulo x");
}

else if (areay > areax)
{
    WriteLine("maior area é do triangulo y");
}

else
{
    WriteLine("os triangulos tem a mesma area");
}

ReadKey();





