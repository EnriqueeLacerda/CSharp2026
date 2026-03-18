using static System.Console;
namespace RetanguloComPOO
{
    internal class Retangulo1
    {
        public double Altura;
        public double Lagura;



        public void Processamento()
        {
            double area = Altura * Lagura;
            double Perimetro = 2 * (Lagura + Altura);
            double diagonal = Math.Sqrt((Lagura * Lagura) + (Altura * Altura));
            WriteLine();
            Write($"a area é: {area},  O perimetro é :{Perimetro}, Diagonal é: {diagonal}");
            WriteLine();
        }



    }
}
