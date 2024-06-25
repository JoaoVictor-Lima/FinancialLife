using FinancialLifeDomain.Entities.Core.People;
using FinancialLifeDomain.Interfaces.Repository;
using FinancialLifeDomain.Interfaces.Repository.Core.People;
using FinancialLifeInfrastructureData.Context;


namespace FinancialLifeInfrastructureData.Repository.Core.People
{
    public class LegalEntityRepository : RepositoryBase<LegalEntity>, IRepositoryBase<LegalEntity>, ILegalEntityRepository
    {
        public LegalEntityRepository(FinancialLifeDbContext context) : base(context)
        {

        }
    }
}
