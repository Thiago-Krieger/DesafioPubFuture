namespace DesafioPubFuture.Models
{
    public class Receita
    {
        public int ReceitaId { get; set; }
        public float Valor { get; set; }
        public DateTime DataRecebimento { get; set; }
        public DateTime DataRecebimentoEsperado { get; set; }
        public string? Descricao { get; set; }
        public string? TipoReceita { get; set; }
        public int? ContaId { get; set; }
    }
}
