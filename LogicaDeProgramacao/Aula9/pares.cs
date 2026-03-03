using static System.Console;

// declaração de variaveis ---------

int numero, valor;

try
{
    //entrada de dados -------
    Write("quantos numeros você vai digitar?");
    numero = int.Parse(ReadLine());

    //processamento de dados -----
    for ( int i=0; i < numero; i++)
    {
        Write("digite um numero: ");
        valor = int.Parse(ReadLine());
        // teste de valor de positivo , negativo ou nulo


        if (valor < 0)
        {
            Write("negativo ");
        }
        
        else if (valor > 0)
        {
            Write("positivo ");
        }

        else    
        {
            Write("nulo" );
        }
        

        if ((valor % 2) == 0)
        {
            Write("par ");
        }

        else if ((valor % 2) != 0)
        {
            Write(" impar ");
        }
    }
}
catch (Exception ex)
{
    WriteLine("valor invalido, erro =", ex.Message);
}