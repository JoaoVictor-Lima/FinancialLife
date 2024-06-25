using FinancialLifeDomain.Entities.Core.Users;
using System.Threading.Tasks;

namespace FinancialLifeApplication.Interfaces.Core.Users
{
    public interface IUserAppService
    {
        Task<User> CreateAsync(User entity);
    }
}
