using controle_contas.Application.Interfaces;
using controle_contas.Domain.Entities;
using controle_contas.Domain.Interfaces.Services;

namespace controle_contas.Application
{
    public class TransacaoAppService : AppServiceBase<Transacao>, ITransacaoAppService
    {
        private readonly ITransacaoService _transacaoService;

        public TransacaoAppService(ITransacaoService transacaoService)
            : base(transacaoService)
        {
            _transacaoService = transacaoService;
        }
    }
}
