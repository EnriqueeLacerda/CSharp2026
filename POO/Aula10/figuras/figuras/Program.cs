using figuras.classe.Entidades;
using figuras.classe.Enumeracao;
using System.Security.Cryptography;
using static System.Console;


List<Forma> formas = new();

Write("Entre com a quantidade de formas: ");
int qtd = int.Parse(ReadLine());

for (int i = 0; i< qtd; i++)

{
    WriteLine("Dados do objeto geometrico N° {i+1}:");
    Write($"Retângulo ou Cinrculo (R/C): ");
    char escolha = char.Parse(ReadLine().ToLower());

        if (escolha == 'r')
    {
        WriteLine("Qual a cor do objeto? " +
            "\n\t1 - Vermelho" +
            "\n\t2  - Rosa" +
             "\n\t3 - Azul" +
              "\n\t4 - Amarelo");

        int cor = int.Parse(ReadLine());
                          
    }
}



Console.ReadKey();