using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Master
{
    internal class ContaPJ : Conta
    {
        //Campo
        private double limite;

        //Propriedade
        public double LimiteConta
        {
            get { return limite; }
            set { limite = value; }
        }

        //Construtor
        public ContaPJ(int numeroConta, double saldoConta, Pessoa dadosCliente, double limite) : base(numeroConta, saldoConta, dadosCliente)
        {
            LimiteConta = limite;
        }

        //Método
        public void Emprestimo(double qtd)
        {
            LimiteConta -= qtd;
            SaldoConta += qtd;
        }

        public override string ToString()
        {
            return $"Dados da conta: - {Tipo.ContaPJ}" +
                   $"\n\tNome do titular: {cliente.nome}" +
                   $"\n\tCPF do cliente: {cliente.cpf}" +
                   $"\n\tNúmero da conta: {numero}" +
                   $"\n\tSaldo da conta: {SaldoConta}";
        }





    }
}