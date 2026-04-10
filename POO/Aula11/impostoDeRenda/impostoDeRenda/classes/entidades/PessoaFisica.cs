namespace impostoDeRenda.classes.entidades;


public class PessoaFisica : Contribuinte
{
   

    private const double LimiteRenda = 20_000.00;
    private const double SalarioBaixo = 0.15;
    private const double SalarioAlto = 0.25;
    private const double DescontoSaude = 0.50;

  

    public double GastosComSaude { get; set; }

 

    public PessoaFisica(string nome, double rendaAnual, double gastosComSaude)
        : base(nome, rendaAnual)          
    {
        GastosComSaude = gastosComSaude;
    }



    public override double CalcularImposto()
    {
        double aliquota = RendaAnual < LimiteRenda ? SalarioBaixo : SalarioAlto;
        double imposto = RendaAnual * aliquota;
        double desconto = GastosComSaude * DescontoSaude;
        return imposto;
    }

    public override string GetDescricaoImposto()
    {
        double aliquota = RendaAnual < LimiteRenda ? SalarioBaixo : SalarioAlto;
        return $" PF {Nome,-30} | Renda: {RendaAnual,10:C}  Saúde: {GastosComSaude,8:C} " +
               $" Alíquota: {aliquota,4:P0}  Imposto: {CalcularImposto(),10:C}";
    }
}
