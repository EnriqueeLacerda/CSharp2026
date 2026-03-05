/*O programa deve receber sucessivos pares de entrada. Cada par de entradas deve indicar o movimento do Fiat Uno e a quantidade de turistas que ele transporta. A primeira entrada de cada par é uma string que indica a direção:
"entrando": O Fiat Uno está saindo da cidade e entrando no parque.
"voltando": O Fiat Uno está retornando do passeio.
A segunda entrada é um número inteiro T (onde 0 <= T <= 4), que indica a quantidade de turistas sendo transportados.
A string "sair" deve ser o indicador de que o expediente acabou e o processamento deve ser finalizado.*/


using static System.Console;
string direcao;
int turistas, totalTuristas = 0;


while (true)
{
    Console.BackgroundColor = ConsoleColor.Yellow;
    WriteLine("Aplicativo de controle de fluxo de carro");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Green;
    WriteLine("Parque nacional dos Lençóis Maranhenses");
    Console.ResetColor();

    WriteLine();

    Write("Digite a direção (entrando, voltando ou sair): ");
    direcao = ReadLine()!;
    
     

    if (direcao == "sair")
    {
        WriteLine("Expediente encerrado.");
        break;
    }
    

    Write("Digite a quantidade de turistas (0 a 4): ");
    turistas = int.Parse(ReadLine()!);

    if (turistas < 0 | turistas > 4)
    {
        WriteLine("Quantidade de turistas inválida. Tente novamente.");
        continue;
    }

    if (direcao == "entrando")
      
    {
         totalTuristas += turistas;
      
     }

    else if (direcao == "voltando")
    {
        totalTuristas -= turistas;
        if (totalTuristas < 0)
        {
            totalTuristas = 0; 
        }
    }
    else
    {
        WriteLine("Direção inválida. Tente novamente.");
        continue;
    }

    WriteLine($"Total de turistas no parque: {totalTuristas}");
   
}

