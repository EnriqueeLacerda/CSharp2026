using DepartamentoPessoal.Classes.entidades;
using static System.Console;


List<Funcionario> Colaboradores = new();

Write("Quantos Funcionarios irá cadastrar: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i< n; i++)
{
    WriteLine("Colaborador nº { i+1}");
        Write("o funcionario é tercerizado ( S/N ): ");
    char e = char.Parse(ReadLine().ToLower());

    if( e == 'n')
    {
        Write("nome: ");
        string nome = ReadLine();
        Write("Horas trabalhadas: ");
        int h = int.Parse(ReadLine());
        Write("Valor da hora: ");
        double v = double.Parse(ReadLine());
        Colaboradores.Add(new Funcionario(nome, h, v));
    }
    else
    {
        Write("nome: ");
        string nome = ReadLine();
        Write("Horas trabalhadas: ");
        int h = int.Parse(ReadLine());
        Write("Valor da hora: ");
        double v = double.Parse(ReadLine());
        Write("Despesa adicional: R$ ");
        double d = double.Parse(ReadLine());
        Colaboradores.Add(new Terceiro(nome, h, v, d));
    }

    WriteLine(" -Pagamentos-");
    foreach (var colab in Colaboradores)
    {
        Colaboradores[colab].ToString;
    }

}