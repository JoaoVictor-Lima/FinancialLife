using FinancialLifeDomain.Entities.Core.Users;
using FinancialLifeDomain.Interfaces.Repository.Core.Users;
using FinancialLifeInfrastructureData.Context;

namespace FinancialLifeInfrastructureData.Repository.Core.Users
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(FinancialLifeDbContext context) : base(context)
        {
        }
    }
}
