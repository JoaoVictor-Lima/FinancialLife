using FinancialLifeDomain.Entities.Nucleo.Localizacao;
using FinancialLifeDomain.Interfaces.Repository;
using FinancialLifeDomain.Interfaces.Repository.Nucleo.Localizacao;
using FinancialLifeInfrastructureData.Context;

namespace FinancialLifeInfrastructureData.Repository.Nucleo.Localizacao
{
    public class PaisRepository : RepositoryBase<Pais>, IRepositoryBase<Pais>, IPaisRepository
    {
        public PaisRepository(FinancialLifeDbContext context) : base(context)
        {
        }
    }
}
