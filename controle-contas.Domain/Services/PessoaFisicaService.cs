
using controle_contas.Domain.Entities;
using controle_contas.Domain.Interfaces.Repositories;
using controle_contas.Domain.Interfaces.Services;

namespace controle_contas.Domain.Services
{
    public class PessoaFisicaService : ServiceBase<PessoaFisica>, IPessoaFisicaService
    {
        private readonly IPessoaFisicaRepository _pessoaFisicaRepository;

        public PessoaFisicaService(IPessoaFisicaRepository pessoaFisicaRepository)
            : base(pessoaFisicaRepository)
        {
            _pessoaFisicaRepository = pessoaFisicaRepository;
        }
    }
}
