using FinancialLifeApplication.Interfaces.Nucleo.Pessoas;
using FinancialLifeDomain.Entities.Nucleo.Pessoas;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinancialLifeApplication.Controller.Nucleo.Pessoas
{
    [Route("Api/v1/[controller]/[action]")]
    public class PessoaFisicaController : ControllerBase
    {
        private readonly IPessoaFisicaAppService _appService;

        public PessoaFisicaController(IPessoaFisicaAppService appService)
        {
            _appService = appService;
        }

        public async Task<PessoaFisica> CreateAsync(PessoaFisica entity)
        {
            return await _appService.Create(entity);
        }

        public async Task<IEnumerable<PessoaFisica>> GetAllAsync()
        {
            return await _appService.GetAllAsync();
        }
    }
}
