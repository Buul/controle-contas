
using controle_contas.Domain.Entities;
using controle_contas.Domain.Interfaces.Repositories;
using controle_contas.Domain.Interfaces.Services;

namespace controle_contas.Domain.Services
{
    public class TransacaoService : ServiceBase<Transacao>, ITransacaoService
    {
        private readonly ITransacaoRepository _transacaoRepository;

        public TransacaoService(ITransacaoRepository transacaoRepository)
            : base(transacaoRepository)
        {
            _transacaoRepository = transacaoRepository;
        }
    }
}
