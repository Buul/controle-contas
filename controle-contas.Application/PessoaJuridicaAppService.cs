using controle_contas.Application.Interfaces;
using controle_contas.Domain.Entities;
using controle_contas.Domain.Interfaces.Services;

namespace controle_contas.Application
{
    public class PessoaJuridicaAppService : AppServiceBase<PessoaJuridica>, IPessoaJuridicaAppService
    {
        private readonly IPessoaJuridicaService _pessoaJuridicaService;

        public PessoaJuridicaAppService(IPessoaJuridicaService pessoaJuridicaService)
            : base(pessoaJuridicaService)
        {
            _pessoaJuridicaService = pessoaJuridicaService;
        }
    }
}
