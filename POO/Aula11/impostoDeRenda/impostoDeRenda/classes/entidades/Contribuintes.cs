using impostoDeRenda.classes.Contratos.Iimposto;


namespace impostoDeRenda.classes.entidades;

public abstract class Contribuinte : Iimposto
{
  

    public string Nome { get; set; }
    public double RendaAnual { get; set; }

    // ── Construtor ────────

    protected Contribuinte(string nome, double rendaAnual)
    {
        Nome = nome;
        RendaAnual = rendaAnual;
    }
   
    public abstract double CalcularImposto();

      public virtual string DescricaoImposto()
    {
        return $"{"Contribuinte",-5} {Nome,-30}  Renda: {RendaAnual,12:C} Imposto: {CalcularImposto(),10:C}";
    }

    public abstract string GetDescricaoImposto();
}