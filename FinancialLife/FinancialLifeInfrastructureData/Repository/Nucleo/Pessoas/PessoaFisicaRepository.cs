using FinancialLifeDomain.Entities;
using FinancialLifeDomain.Entities.Nucleo.Pessoas;
using FinancialLifeDomain.Entities.Nucleo.Pessoas.Interfaces;
using FinancialLifeInfrastructureData.Context;

namespace FinancialLifeInfrastructureData.Repository.Nucleo.Pessoas
{
    public class PessoaFisicaRepository : RepositoryBase<PessoaFisica>, IRepositoryBase<PessoaFisica>, IPessoaFisicaRepository
    {
        public PessoaFisicaRepository(PessoaDbContext context) : base(context)
        {
        }
    }
}
