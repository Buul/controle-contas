using controle_contas.Application.Interfaces;
using controle_contas.Domain.Entities;
using controle_contas.Domain.Interfaces.Services;

namespace controle_contas.Application
{
    public class PessoaFisicaAppService : AppServiceBase<PessoaFisica>, IPessoaFisicaAppService
    {
        private readonly IPessoaFisicaService _pessoaFisicaService;

        public PessoaFisicaAppService(IPessoaFisicaService pessoaFisicaService)
            : base(pessoaFisicaService)
        {
            _pessoaFisicaService = pessoaFisicaService;
        }
    }
}
