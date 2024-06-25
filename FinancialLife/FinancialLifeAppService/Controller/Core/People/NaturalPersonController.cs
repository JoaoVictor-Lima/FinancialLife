using FinacialLifeDtos.Core.People;
using FinancialLifeApplication.Interfaces.Core.People;
using FinancialLifeDomain.Entities.Core.People;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinancialLifeApplication.Controller.Core.People
{
    [Route("Api/v1/[controller]/[action]")]
    public class NaturalPersonController : ControllerBase
    {
        private readonly INaturalPersonAppService _appService;

        public NaturalPersonController(INaturalPersonAppService appService)
        {
            _appService = appService;
        }

        [HttpPost]
        public async Task<NaturalPerson> CreateAsync([FromBody] NaturalPersonDto dto)
        {
            return await _appService.Create(dto);
        }

        [HttpGet]
        public async Task<IEnumerable<NaturalPerson>> GetAllAsync()
        {
            return await _appService.GetAllAsync();
        }
    }
}
