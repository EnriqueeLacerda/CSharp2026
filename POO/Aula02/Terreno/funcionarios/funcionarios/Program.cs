using System;
using Funcionarios;
class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("\nFuncionário: " + func);

            Console.Write("\nDigite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine());

            func.AumentarSalario(porcentagem);

            Console.WriteLine("\nDados atualizados: " + func);
        }
    }
}