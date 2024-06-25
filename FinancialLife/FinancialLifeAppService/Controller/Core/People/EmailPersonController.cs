using FinancialLifeApplication.Interfaces.Core.People;
using FinancialLifeDomain.Entities.Core.People;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FinancialLifeApplication.Controller.Core.People
{
    public class EmailPersonController : ControllerBase
    {
        private readonly IEmailPersonAppService _appService;

        public EmailPersonController(IEmailPersonAppService appService)
        {
            _appService = appService;
        }

        [HttpPost]
        public async Task<EmailPerson> CreateAsync(EmailPerson entity)
        {
            return await _appService.CreateAsync(entity);
        }
    }
}
