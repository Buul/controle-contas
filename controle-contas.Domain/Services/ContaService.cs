
using controle_contas.Domain.Entities;
using controle_contas.Domain.Interfaces.Repositories;
using controle_contas.Domain.Interfaces.Services;

namespace controle_contas.Domain.Services
{
    public class ContaService : ServiceBase<Conta>, IContaService
    {
        private readonly IContaRepository _contaRepository;

        public ContaService(IContaRepository contaRepository)
            : base(contaRepository)
        {
            _contaRepository = contaRepository;
        }
    }
}
