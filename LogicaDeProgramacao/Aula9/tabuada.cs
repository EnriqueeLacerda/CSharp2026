using static System.Console;

// declaração de variavel -------

int numero;

// entrada de dados ------

numero =  int.Parse(ReadLine());

// proessamento de dados -----

for (int i = 0; i < 10; i++)
{
    WriteLine($"{numero} x {i+1} = {numero * (i+1)}");
}