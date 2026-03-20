using AlunoNotaFinal;

class Program
{
    static void Main(string[] args)
    {
        Aluno aluno = new Aluno();

        Console.Write("Digite o nome do aluno: ");
        aluno.NomeDoAluno = Console.ReadLine();

        Console.WriteLine("Digite as três notas:");

        Console.Write("Nota 1º  ");
        aluno.Nota1 = double.Parse(Console.ReadLine());

        Console.Write("Nota 2º ");
        aluno.Nota2 = double.Parse(Console.ReadLine());

        Console.Write("Nota 3º  ");
        aluno.Nota3 = double.Parse(Console.ReadLine());

        Console.WriteLine("\nNOTA FINAL = " + aluno.NotaFinal());

        if (aluno.Aprovado())
        {
            Console.WriteLine("APROVADO");
        }
        else
        {
            Console.WriteLine("REPROVADO");
            Console.WriteLine("FALTARAM " + aluno.PontosFaltantes() + " PONTOS");
        }
      
    }
 
}


