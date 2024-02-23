using FinancialLifeDomain.Entities.Nucleo.Pessoas;
using FinancialLifeDomain.Interfaces.Repository;
using FinancialLifeDomain.Interfaces.Repository.Nucleo.Pessoas;
using FinancialLifeInfrastructureData.Context;

namespace FinancialLifeInfrastructureData.Repository.Nucleo.Pessoas
{
    public class PessoaFisicaRepository : RepositoryBase<PessoaFisica>, IRepositoryBase<PessoaFisica>, IPessoaFisicaRepository
    {
        public PessoaFisicaRepository(FinancialLifeDbContext context) : base(context)
        {
        }
    }
}
