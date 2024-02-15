using FinancialLifeDomain.Entities;
using FinancialLifeDomain.Entities.Nucleo.Pessoas;
using FinancialLifeDomain.Entities.Nucleo.Pessoas.Interfaces;
using FinancialLifeInfrastructureData.Context;


namespace FinancialLifeInfrastructureData.Repository.Nucleo.Pessoas
{
    public class PessoaJuridicaRepository : RepositoryBase<PessoaJuridica>, IRepositoryBase<PessoaJuridica>, IPessoaJuridicaRepository
    {
        public PessoaJuridicaRepository(PessoaDbContext context) : base(context)
        {

        }
    }
}
