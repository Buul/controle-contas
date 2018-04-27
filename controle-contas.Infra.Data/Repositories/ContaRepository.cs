
using controle_contas.Domain.Entities;
using controle_contas.Domain.Interfaces.Repositories;

namespace controle_contas.Infra.Data.Repositories
{
    public class ContaRepository : RepositoryBase<Conta>, IContaRepository
    {
    }
}
