namespace LocadoraCarro.Entidades
{
    public class Fatura
    {
        private double _pagamentoBasico;
        private double _taxa;
        private double _totalPagamento;

        public Fatura(double pagamentoBasico, double taxa)
        {
            _pagamentoBasico = pagamentoBasico;
            _taxa = taxa;
            _totalPagamento = pagamentoBasico + taxa;
        }

        public double PagamentoBasico => _pagamentoBasico;
        public double Taxa => _taxa;
        public double TotalPagamento => _totalPagamento;

        public override string ToString()
        {
            return $"Pagamento basico: {_pagamentoBasico:C2}\n" +
                   $"Taxa: {_taxa:C2}\n" +
                   $"Pagamento total: {_totalPagamento:C2}";
        }
    }
}