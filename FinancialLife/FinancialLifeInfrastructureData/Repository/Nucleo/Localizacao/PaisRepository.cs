using FinancialLifeDomain.Entities.Nucleo.Localizacao;
using FinancialLifeDomain.Interfaces.Repository;
using FinancialLifeDomain.Interfaces.Repository.Nucleo.Localizacao;
using FinancialLifeInfrastructureData.Context.Nucleo;

namespace FinancialLifeInfrastructureData.Repository.Nucleo.Localizacao
{
    public class PaisRepository : RepositoryBase<Pais>, IRepositoryBase<Pais>, IPaisRepository
    {
        public PaisRepository(PessoaDbContext context) : base(context)
        {
        }
    }
}
