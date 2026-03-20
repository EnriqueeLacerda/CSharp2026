using static System.Console;
using System;

namespace AlunoNotaFinal
{
    internal class Aluno
    {
        public string NomeDoAluno;
        public double Nota1, Nota2, Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {
            return NotaFinal() >= 60.0;
        }

        public double PontosFaltantes()
        {
            if (Aprovado())
                return 0;
            else
                return 60 - NotaFinal();
        }
    }

}