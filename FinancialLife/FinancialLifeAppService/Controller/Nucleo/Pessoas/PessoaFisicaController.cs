using FinacialLifeDtos.Nucleo.Pessoas;
using FinancialLifeApplication.Interfaces.Nucleo.Pessoas;
using FinancialLifeDomain.Entities.Nucleo.Pessoas;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.Json;
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

        [HttpPost]
        public async Task<PessoaFisica> CreateAsync([FromBody] PessoaFisicaDto dto)
        {
            return await _appService.Create(dto);
        }

        [HttpGet]
        public async Task<IEnumerable<PessoaFisica>> GetAllAsync()
        {
            return await _appService.GetAllAsync();
        }
    }
}
