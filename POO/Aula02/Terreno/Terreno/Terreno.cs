using static System.Console;
namespace terreno
{
    internal class Terreno
    {
        // campos

        public double lagura, comprimento, valor;

        // construtor

        public Terreno(double lagura, double comprimento, double valor)
        {
            this.lagura = lagura;
            this.comprimento = comprimento;
            this.valor = valor;

        }




       // metodos

        public double Area()
        {
            return lagura * comprimento;

        }
      
        public double Preco()
        {
            return Area() * valor;
        }
        public void Saida()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Area do terreno = {Area():F2} M²");
            Console.ResetColor();
            WriteLine();
            Console.WriteLine($"Preço do terreno = R$ {Preco():F2}");
        }
    }
}
