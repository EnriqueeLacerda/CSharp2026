using System.Runtime.Serialization;

namespace Master
{
    internal class ContaPoupanca : Conta
    {
        //Campo
        private double rendimento;


        //Propriedade
        public double RendimentoConta
        {
            get { return rendimento; }
            set { rendimento = value; }
        }

        public object NumeroConta { get; private set; }

        //Construtor
        public ContaPoupanca(int numeroConta, double saldoConta, Pessoa dadosCliente, double rendimento, int v) : base(numeroConta, saldoConta, dadosCliente)
        {
            RendimentoConta = rendimento;
        }

        //Métodos
        public void Consulta()
        {
            Console.WriteLine($"Dados do cliente: \n" +
                $"\t Nome: {DadosCliente}\n" +
                $"\t Numero: {NumeroConta}\n" +
                $"\t Saldo: {SaldoConta}\n" +
                $"\t Rendimento: {rendimento}%");

        }

    }
}