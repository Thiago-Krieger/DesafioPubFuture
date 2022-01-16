namespace DesafioPubFuture.Models
{
    public class Despesa
    {
        public int DespesaId { get; set; }
        public float Valor { get; set; }
        public DateTime DataPagamento { get; set; }
        public DateTime DataPagamentoEsperado { get; set; }
        public string? TipoDespesa { get; set; }
        public int? ContaId { get; set; }
    }
}
