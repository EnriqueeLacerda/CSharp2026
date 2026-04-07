
namespace DepartamentoPessoal.Classes.entidades
{
    internal class Terceiro : Funcionario
    {

		//Campo
		private double despesa;




        //Propriedade
        protected double DespesaAdicional
		{
			get { return despesa; }
			set { despesa = value; }
		}

        //construtor
        public Terceiro(string nomeColaborador, int jornadaTrabalho, double valorHora, double despesa) : base(nomeColaborador, jornadaTrabalho, valorHora)
        {
            DespesaAdicional = despesa;

        }

        //metodo

        public override double Pagamento()
        {
            return base.Pagamento() + (DespesaAdicional * 0.2);
        }

	}
}
