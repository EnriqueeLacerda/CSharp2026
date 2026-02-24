using static System.Console;
//----- Declaraão de variaveis ----
try{

double a, b, c, areaQuadrado, areaTriangulo, areaTrapezzio;


//------ Entrada de dados -----

Write("Digite a medida A:");
a = double.Parse(ReadLine());

Write("Digite a medida B:");
b = double.Parse(ReadLine());

Write("digite a medida C:");
c = double.Parse(ReadLine());

// ----- processamento de dados ----

areaQuadrado = a * a;
areaTriangulo = ( a * b)/2;
areaTrapezzio = ((a + b) * c) / 2;

// --------- saida de dados -------

WriteLine($"Area do quadrado = {areaQuadrado:F4}");
WriteLine($"Area do Triagulo = {areaTriangulo:F4}");
WriteLine($"Area do trapezzio = {areaTrapezzio:F4}");

}
catch (Exception)
{
    WriteLine("Valores invalidos inseridos, programa encerrado!");
}