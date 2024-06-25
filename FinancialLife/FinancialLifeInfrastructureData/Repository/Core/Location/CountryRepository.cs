using FinancialLifeDomain.Entities.Core.Location;
using FinancialLifeDomain.Interfaces.Repository;
using FinancialLifeDomain.Interfaces.Repository.Core.Location;
using FinancialLifeInfrastructureData.Context;

namespace FinancialLifeInfrastructureData.Repository.Core.Location
{
    public class CountryRepository : RepositoryBase<Country>, IRepositoryBase<Country>, ICountryRepository
    {
        public CountryRepository(FinancialLifeDbContext context) : base(context)
        {
        }
    }
}
