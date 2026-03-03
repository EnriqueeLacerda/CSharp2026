
using static System.Console;

// declaração de função -----------

static void Total(int qtd, double valor)
{
    WriteLine($"o valor total é de: {qtd * valor}");
}


//------------- declaração de variavel ---------

int codigo, quantidade;

//------------- entrada de dados ---------
try
{
    Write("digite o codigo do produto");
    codigo = int.Parse(ReadLine());
    Write("digite a quantidade");
    quantidade = int.Parse(ReadLine());



    switch (codigo)
    {
    case 1:
            Total(quantidade, 5.00);
        //WriteLine($"o valor total é de: {quantidade * 5.00}");
        break;

    case 2:
        Total(quantidade, 4.50);
       // WriteLine($"o valor total é de: {quantidade * 4.50}");
        break;

    case 3:
       Total(quantidade, 3.75);
       // WriteLine($"o valor total é de: {quantidade * 3.75}");
        break;

    case 4:
        Total(quantidade, 8.99);
        //WriteLine($"o valor total é de: {quantidade * 8.99}");
        break;

    case 5:
        Total(quantidade, 11.33);
        //WriteLine($"o valor total é de: {quantidade * 11.33}");
        break;

    default: 
        WriteLine("codigo do produto invalido");
        break;          
    }
}

catch (Exception ex)
{
    WriteLine($"Digite valores validos, erro: {ex.Message}");

}