
using controle_contas.Domain.Entities;
using controle_contas.Domain.Interfaces.Repositories;
using controle_contas.Domain.Interfaces.Services;

namespace controle_contas.Domain.Services
{
    public class PessoaJuridicaService : ServiceBase<PessoaJuridica>, IPessoaJuridicaService
    {
        private readonly IPessoaJuridicaRepository _pessoaJuridicaRepository;

        public PessoaJuridicaService(IPessoaJuridicaRepository pessoaJuridicaRepository)
            : base(pessoaJuridicaRepository)
        {
            _pessoaJuridicaRepository = pessoaJuridicaRepository;
        }
    }
}
