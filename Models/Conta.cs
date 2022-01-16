namespace DesafioPubFuture.Models
{
    public class Conta
    {
        public int ContaId { get; set; }
        public int? NumeroConta { get; set; }
        public float Saldo { get; set; }
        public string? TipoConta { get; set; }
        public string? InstituicaoFinanceira { get; set; }
        public IList<Despesa>? Despesas { get; }
        public IList<Receita>? Receitas { get; }
    }
}
