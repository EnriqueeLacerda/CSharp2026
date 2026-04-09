using figuras.classe.Enumeracao;
using System;
using System.Collections.Generic;
using System.Text;

namespace figuras.classe.Entidades
{
    internal class Circulo : Forma
    {

		//Campo
		private double raio;

       

        //Propriedade
        public double Raio
		{
			get { return raio; }
			set { raio = value; }
		}

        // construtor
        public Circulo(Cor corDaForma, double raio) : base(corDaForma)
        {
            Raio = raio;
        }

        //metodos

        public override double Area()
        {
            return Raio * Raio * 3.14;
        }
    }
}
