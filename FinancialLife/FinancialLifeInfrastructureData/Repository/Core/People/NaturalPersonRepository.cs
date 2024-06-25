using FinancialLifeDomain.Entities.Core.People;
using FinancialLifeDomain.Interfaces.Repository;
using FinancialLifeDomain.Interfaces.Repository.Core.People;
using FinancialLifeInfrastructureData.Context;

namespace FinancialLifeInfrastructureData.Repository.Core.People
{
    public class NaturalPersonRepository : RepositoryBase<NaturalPerson>, IRepositoryBase<NaturalPerson>, INaturalPersonRepository
    {
        public NaturalPersonRepository(FinancialLifeDbContext context) : base(context)
        {
        }
    }
}
