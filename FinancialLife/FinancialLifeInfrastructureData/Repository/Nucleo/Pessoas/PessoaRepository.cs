using FinancialLifeDomain.Entities.Nucleo.Pessoas;
using FinancialLifeDomain.Interfaces.Repository;
using FinancialLifeDomain.Interfaces.Repository.Nucleo.Pessoas;
using FinancialLifeInfrastructureData.Context.Nucleo;

namespace FinancialLifeInfrastructureData.Repository.Nucleo.Pessoas
{
    public class PessoaRepository : RepositoryBase<Pessoa>, IRepositoryBase<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(PessoaDbContext context) : base(context)
        {
        }
    }
}
