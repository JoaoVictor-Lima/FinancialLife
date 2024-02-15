using FinancialLifeAppService.Nucleo.Pessoas.Interfaces;
using FinancialLifeDomain.Entities.Nucleo.Pessoas;
using Microsoft.AspNetCore.Mvc;

namespace FrontEdn.Server.Controller.Nucleo.Pessoas
{
    [Route("Api/v1/[controller]/[action]")]
    public class PessoaFisicaController : ControllerBase
    {
        private readonly IPessoaFisicaAppService _pessoaFisicaAppService;

        public PessoaFisicaController(IPessoaFisicaAppService pessoaFisicaAppService)
        {
            _pessoaFisicaAppService = pessoaFisicaAppService;
        }

        public async Task<IEnumerable<PessoaFisica>> GetAllPessoasFisicas()
        {
            return await _pessoaFisicaAppService.GetAllPessoasFisicas();
        }
    }
}
