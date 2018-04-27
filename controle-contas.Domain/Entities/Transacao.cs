
namespace controle_contas.Domain.Entities
{
    public class Transacao
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public int IdContaOrigem { get; set; }
        public int IdContaDestino{ get; set; }
        public decimal ValorContaOrigem { get; set; }
        public decimal ValorContaDestino { get; set; }
        public bool Estorno { get; set; }
        public string CodigoTransacaoEstorno { get; set; }

    }
}
