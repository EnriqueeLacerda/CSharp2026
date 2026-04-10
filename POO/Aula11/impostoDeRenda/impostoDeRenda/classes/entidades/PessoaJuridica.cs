
namespace impostoDeRenda.classes.entidades
{
    public class PessoaJuridica : Contribuinte
    {
        private const int LimiteFuncionarios = 10;
        private const double AliquotaPadrao = 0.16;
        private const double AliquotaReduzida = 0.14;

        public int NumFuncionarios { get; set; }

        public PessoaJuridica(string nome, double rendaAnual, int numFuncionarios)
            : base(nome, rendaAnual)         
        {
            NumFuncionarios = numFuncionarios;
        }

        

        public override double CalcularImposto()
        {
            double aliquota = NumFuncionarios > LimiteFuncionarios
                              ? AliquotaReduzida
                              : AliquotaPadrao;
            return RendaAnual * aliquota;
        }

        public override string GetDescricaoImposto()
        {
            double aliquota = NumFuncionarios > LimiteFuncionarios
                              ? AliquotaReduzida : AliquotaPadrao;

            return $"PJ {Nome,-30} | Renda: {RendaAnual,10:C}  Func.: {NumFuncionarios,4} " +
                   $" Alíquota: {aliquota,4:P0}  Imposto: {CalcularImposto(),10:C}";
        }
    }




}
