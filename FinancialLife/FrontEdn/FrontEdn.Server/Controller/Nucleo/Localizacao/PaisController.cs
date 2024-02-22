using FinancialLifeApplication.Intrefaces.Nucleo.Localizacao;
using FinancialLifeDomain.Entities.Nucleo.Localizacao;
using Microsoft.AspNetCore.Mvc;

namespace FrontEdn.Server.Controller.Nucleo.Localizacao
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
        public async Task<IEnumerable<Pais>> GetAllPaises()
        {
            return await _paisAppService.GetAllPaises();
        }
    }
}
