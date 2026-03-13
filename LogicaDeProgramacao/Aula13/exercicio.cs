/* fazer um aplicativo de console que leia um numero infeiro n, (maximo = 10)
e uma matriz quadrada de ordem n, contendo numeros inteiros. em seguida , 
mostra a diagonal principal e a quantidade de valores negativos da matriz */ 

using static System.Console;

Write("Digite a ordem da matriz (maximo = 10): ");
int n = int.Parse(ReadLine());
int [,] matriz = new int [n,n];

// entrada de dados, inserir valores na matriz
for (int i = 0 ; i < n ; i++)
{
    for (int j = 0; j < n; j++)
    {
        Write($"Digite o valor p/ a posição [{i},{j}]: ");
        matriz [i,j] = int.Parse(ReadLine());
    }
}
WriteLine("Diagonal principal: ");
int contNegativos = 0;
for (int i = 0 ; i < n ; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i == j)
        {
            Write(matriz[i,j] + "\t");
        }
        if (matriz[i,j] < 0)
        {
            contNegativos++;
        }
    
    
    }
}

WriteLine($"\nQuantidade de valores negativos: {contNegativos}");
