using FinancialLifeApplication.Interfaces.Core.Location;
using FinancialLifeDomain.Entities.Core.Location;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinancialLifeApplication.Controller.Core.Location
{
    [Route("Api/v1/[controller]/[action]")]
    public class CountryController : ControllerBase
    {
        private readonly ICountryAppService _paisAppService;

        public CountryController(
            ICountryAppService paisAppService
            )
        {
            _paisAppService = paisAppService;
        }

        [HttpGet]
        public async Task<IEnumerable<Country>> GetAllAsync()
        {
            return await _paisAppService.GetAllAsync();
        }
    }
}
