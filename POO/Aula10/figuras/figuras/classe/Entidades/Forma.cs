using figuras.classe.Contratos;
using figuras.classe.Enumeracao;


namespace figuras.classe.Entidades
{
    abstract internal class Forma : IArea
    {
        /// <summary>
        /// 
        /// Cores disponiveis vermelho, Azul, Amarelo e Rosa
        /// 
        /// </summary>




        //campo

        private Cor cor;


        // construtor

        public Forma(Cor corDaForma)
        {
            CorDaForma = corDaForma;
        }

        // propriedades
        protected Cor CorDaForma
        {
            get { return cor; }
            set { cor = value; }
        }


        // Metodo
        abstract public double Area();

    }
}
