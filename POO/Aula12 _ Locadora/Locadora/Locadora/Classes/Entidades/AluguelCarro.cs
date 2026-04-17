namespace LocadoraCarro.Entidades
{
    public class AluguelCarro
    {
        private DateTime _inicio;
        private DateTime _fim;
        private Veiculo _veiculo;

        public AluguelCarro(DateTime inicio, DateTime fim, Veiculo veiculo)
        {
            _inicio = inicio;
            _fim = fim;
            _veiculo = veiculo;
        }

        public DateTime Inicio => _inicio;
        public DateTime Fim => _fim;
        public Veiculo Veiculo => _veiculo;
        public Fatura? Fatura { get; set; }
    }
}