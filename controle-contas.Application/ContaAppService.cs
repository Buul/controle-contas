using controle_contas.Application.Interfaces;
using controle_contas.Domain.Entities;
using controle_contas.Domain.Interfaces.Services;

namespace controle_contas.Application
{
    public class ContaAppService : AppServiceBase<Conta>, IContaAppService
    {
        private readonly IContaService _contaService;

        public ContaAppService(IContaService contaService)
            : base(contaService)
        {
            _contaService = contaService;
        }
    }
}
