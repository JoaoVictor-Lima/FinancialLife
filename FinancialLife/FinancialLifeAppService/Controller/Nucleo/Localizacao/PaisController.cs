using FinancialLifeApplication.Interfaces.Nucleo.Localizacao;
using FinancialLifeDomain.Entities.Nucleo.Localizacao;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinancialLifeApplication.Controller.Nucleo.Localizacao
{
    [Route("Api/v1/[controller]/[action]")]
    public class PaisController : ControllerBase
    {
        private readonly IPaisAppService _paisAppService;

        public PaisController(
            IPaisAppService paisAppService
            )
        {
            _paisAppService = paisAppService;
        }

        [HttpGet]
        public async Task<IEnumerable<Pais>> GetAllAsync()
        {
            return await _paisAppService.GetAllAsync();
        }
    }
}
