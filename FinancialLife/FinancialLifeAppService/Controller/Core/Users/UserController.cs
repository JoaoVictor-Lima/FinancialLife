using FinancialLifeApplication.Interfaces.Core.Users;
using FinancialLifeDomain.Entities.Core.Users;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FinancialLifeApplication.Controller.Core.Users
{
    [Route("Api/v1/[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private readonly IUserAppService _appService;

        public UserController(IUserAppService appService)
        {
            _appService = appService;
        }

        [HttpPost]
        public async Task<User> CreateAsync(User entity)
        {
            return await _appService.CreateAsync(entity);
        }
    }
}
