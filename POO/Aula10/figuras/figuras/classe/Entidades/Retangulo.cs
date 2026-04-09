using figuras.classe.Enumeracao;


namespace figuras.classe.Entidades
{
    internal class Retangulo : Forma
    {
		private double largura;
		private double altura;


        protected  double Largura
		{
			get { return largura; }
			set { largura = value; }
		}

        protected double Altura
		{
			get { return altura; }
			set { altura = value; }
		}
        public Retangulo(Cor corDaForma, double largura, double altura) : base(corDaForma)
        {
			Largura = largura;
			Altura = altura;
        }

		/// <summary>
		///		Calcula a área da forma usando as dimensões atuais.
		/// </summary>
		
		/// <returns> o valor da área calculada com base na largura </returns>
        public override double Area()
        {
            return Largura * Altura;
        }
	}
}
