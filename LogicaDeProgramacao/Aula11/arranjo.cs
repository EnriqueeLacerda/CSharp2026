// permite usar Write, WriteLine e ReadLine diretamente
using static System.Console;

// permite usar métodos da classe Enumerable diretamente (como Range)
using static System.Linq.Enumerable;


int n;


Write("quantos números deseja armazenar? ");


n = int.Parse(ReadLine());

// verifica se o número é negativo
if (n < 0 )
{
    // mostra mensagem de erro se for negativo
    WriteLine("valor inválido");
}

// verifica se o número é maior que 10
else if (n > 10)
{
    // limita o máximo a 10 números
    WriteLine("maximo de 10 números");
}

else
{
    // cria um array de inteiros com tamanho definido pelo usuário
    int [] numeros = new int[n];

    // laço para preencher o array
    for(int i = 0; i < numeros.Length; i++)
    {
        // pede ao usuário cada número
        Write($"Digite o {i+1}º número: ");

        // lê o número digitado e armazena na posição i do array
        numeros[i] = int.Parse(ReadLine());
    }

    // título da lista de números negativos
    WriteLine("numeros negativos: ");

    // percorre os índices do array usando Range
    foreach (int item in Range(0, numeros.Length))
    {
        // verifica se o número na posição atual é negativo
        if (numeros[item] < 0)
        {
            // imprime o número negativo encontrado
            WriteLine(numeros[item]);
        }
    }
}