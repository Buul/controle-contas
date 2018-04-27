
namespace controle_contas.Api.ViewModels
{
    public class TransacaoViewModel
    {
        public string Id { get; set; }
        public string Valor { get; set; }
        public string IdContaOrigem { get; set; }
        public string IdContaDestino { get; set; }
        public string ValorContaOrigem { get; set; }
        public string ValorContaDestino { get; set; }
        public bool Estorno { get; set; }
        public string CodigoTransacaoEstorno { get; set; }
    }
}