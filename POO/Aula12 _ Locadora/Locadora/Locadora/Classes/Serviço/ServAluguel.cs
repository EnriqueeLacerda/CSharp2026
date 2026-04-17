using LocadoraCarro.Entidades;
using LocadoraCarro.Services;

namespace LocadoraCarro.Services
{
    public class ServAluguel
    {
        private double _precoPorDia;
        private double _precoPorHora;
        private TaxaServBrasil _taxaServBrasil;

        public ServAluguel(double precoPorDia, double precoPorHora)
        {
            _precoPorDia = precoPorDia;
            _precoPorHora = precoPorHora;
            _taxaServBrasil = new TaxaServBrasil();
        }

        public double PrecoDia => _precoPorDia;
        public double PrecoHora => _precoPorHora;

        public void CalcularFatura(AluguelCarro aluguel)
        {
            TimeSpan duracao = aluguel.Fim - aluguel.Inicio;
            double totalHoras = duracao.TotalHours;

            double pagamentoBasico;

            if (totalHoras <= 12.0)
            {
                
                pagamentoBasico = Math.Ceiling(totalHoras) * _precoPorHora;
            }
            else
            {
                
                double totalDias = duracao.TotalHours / 24.0;
                pagamentoBasico = Math.Ceiling(totalDias) * _precoPorDia;
            }

            double percentualTaxa = _taxaServBrasil.Taxa(pagamentoBasico);
            double valorTaxa = pagamentoBasico * percentualTaxa;

            aluguel.Fatura = new Fatura(pagamentoBasico, valorTaxa);
        }
    }
}