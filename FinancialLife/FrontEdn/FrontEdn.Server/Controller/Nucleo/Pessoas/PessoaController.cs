using FinancialLifeApplication.Intrefaces.Nucleo.Pessoas;
using FinancialLifeDomain.Entities.Nucleo.Pessoas;
using Microsoft.AspNetCore.Mvc;

namespace FrontEdn.Server.Controller.Nucleo.Pessoas
{
    [Route("Api/v1/[controller]/[action]")]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaAppService _pessoaAppService;
        public PessoaController(
            IPessoaAppService pessoaAppService
            )
        {
            _pessoaAppService = pessoaAppService;
        }


        [HttpGet]
        public async Task<IEnumerable<Pessoa>> GetAllPessoas()
        {
            return await _pessoaAppService.GetAllPessoas();
        }
    }
}
