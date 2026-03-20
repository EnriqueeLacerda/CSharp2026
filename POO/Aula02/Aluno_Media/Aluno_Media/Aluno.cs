using System;
using System.Collections.Generic;
using System.Text;

namespace Aluno_Media
{
    internal class Aluno
    {
        public string NomeDoAluno;
        public double Nota1, Nota2, Nota3;

        //construtor

        public Aluno(string NomeDoAluno, double Nota1, double Nota2, Double Nota3)
        {
            this.NomeDoAluno = NomeDoAluno;
            this.Nota1 = Nota1;
            this.Nota2 = Nota2;
            this.Nota3 = Nota3;

        }

        // metodos

        public double NotaFinal()
        {

            return Nota1 + Nota2 + Nota3;

        }
    }
}
