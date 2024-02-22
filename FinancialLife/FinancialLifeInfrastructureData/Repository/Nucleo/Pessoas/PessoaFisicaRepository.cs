using FinancialLifeDomain.Entities;
using FinancialLifeDomain.Entities.Nucleo.Pessoas;
using FinancialLifeDomain.Interfaces.Repository.Nucleo.Pessoas;
using FinancialLifeInfrastructureData.Context.Nucleo;

namespace FinancialLifeInfrastructureData.Repository.Nucleo.Pessoas
{
    public class PessoaFisicaRepository : RepositoryBase<PessoaFisica>, IRepositoryBase<PessoaFisica>, IPessoaFisicaRepository
    {
        public PessoaFisicaRepository(PessoaDbContext context) : base(context)
        {
        }
    }
}
