using FinancialLifeApplication.Interfaces.Core.Users;
using FinancialLifeDomain.Entities.Core.Users;
using FinancialLifeDomain.Interfaces.Repository.Core.Users;
using System.Threading.Tasks;

namespace FinancialLifeApplication.Services.Core.Users
{
    public class UserAppService : IUserAppService
    {
        private readonly IUserRepository _repository;

        public UserAppService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<User> CreateAsync(User entity)
        {
            return await _repository.Flush(entity);
        }
    }
}
