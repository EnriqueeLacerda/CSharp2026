/* Uma lanchonete possui vários produtos. Cada produto possui um código e um preço. 
Você deve fazer um programa para ler o código e a
quantidade comprada de um produto (suponha um código válido), e 
daí informar qual o valor a ser pago, com duas casas decimais, 
conforme tabela de produtos ao lado. */

using static System.Console;
Dictionary<int, double> produtos = new Dictionary<int, double>()
{
    {1, 4.00},
    {2, 4.50},
    {3, 5.00},
    {4, 2.00},
    {5, 1.50}
};

while (true)

    try{
            Console.ForegroundColor = ConsoleColor.White;
            Write("digite o código do produto:");
            Console.ResetColor();
            int codigo = int.Parse(ReadLine());

            WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;

            if (produtos.ContainsKey(codigo))
            {
   
                 Write("digite a quantidade comprada:");
                 Console.ResetColor();
                int quantidade = int.Parse(ReadLine());

                WriteLine();
                double valor = produtos[codigo] * quantidade;
                WriteLine($"Valor a ser pago: R$ {valor:F2}");
            }

            else
            {
                WriteLine("Código do produto inválido.");
            }
        }

catch (Exception ex)
{
    WriteLine("Ocorreu um erro: " + ex.Message);
}



