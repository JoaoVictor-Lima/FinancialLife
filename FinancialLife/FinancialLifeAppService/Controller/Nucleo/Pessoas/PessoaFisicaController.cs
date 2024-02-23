using FinancialLifeApplication.Intrefaces.Nucleo.Pessoas;
using FinancialLifeDomain.Entities.Nucleo.Pessoas;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinancialLifeApplication.Controller.Nucleo.Pessoas
{
    [Route("Api/v1/[controller]/[action]")]
    public class PessoaFisicaController : ControllerBase
    {
        private readonly IPessoaFisicaAppService _pessoaFisicaAppService;

        public PessoaFisicaController(IPessoaFisicaAppService pessoaFisicaAppService)
        {
            _pessoaFisicaAppService = pessoaFisicaAppService;
        }

        public async Task<IEnumerable<PessoaFisica>> GetAllAsync()
        {
            return await _pessoaFisicaAppService.GetAllAsync();
        }
    }
}
