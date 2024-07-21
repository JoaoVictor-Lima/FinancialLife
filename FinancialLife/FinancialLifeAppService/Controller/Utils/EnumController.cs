using FinacialLifeDtos.Utils;
using FinancialLifeApplication.Interfaces.Utils;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinancialLifeApplication.Controller.Utils
{
    [Route("Api/v1/[controller]/[action]")]
    public class EnumController : ControllerBase
    {
        private readonly IEnumAppService _appService;

        public EnumController(IEnumAppService appService)
        {
            _appService = appService;
        }

        [HttpGet]
        public async Task<List<EnumValuesDto>> GetEnum([FromQuery] string url)
        {
            return await _appService.GetValuesEnum(url);
        }
    }
}
