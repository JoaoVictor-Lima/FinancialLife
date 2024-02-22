using FinancialLifeDomain.Entities;
using FinancialLifeDomain.Entities.Nucleo.Pessoas;
using FinancialLifeDomain.Entities.Nucleo.Pessoas.Interfaces;
using FinancialLifeInfrastructureData.Context;

namespace FinancialLifeInfrastructureData.Repository.Nucleo.Pessoas
{
    public class PessoaRepository : RepositoryBase<Pessoa>, IRepositoryBase<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(PessoaDbContext context) : base(context)
        {
        }
    }
}
