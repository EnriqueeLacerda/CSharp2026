namespace LocadoraCarro.Services
{
    public class TaxaServBrasil
    {
        // Taxa de 20% para valores até R$ 100,00
        // Taxa de 15% para valores acima de R$ 100,00
        public double Taxa(double pagamentoBasico)
        {
            if (pagamentoBasico <= 100.0)
                return 0.20;
            else
                return 0.15;
        }
    }
}