using FinancialLifeApplication.Interfaces.Nucleo.Pessoas;
using FinancialLifeDomain.Entities.Nucleo.Pessoas;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FinancialLifeApplication.Controller.Nucleo.Pessoas
{
    public class EmailPessoaController : ControllerBase
    {
        private readonly IEmailPessoaAppService _appService;

        public EmailPessoaController(IEmailPessoaAppService appService)
        {
            _appService = appService;
        }

        [HttpPost]
        public async Task<EmailPessoa> CreateAsync(EmailPessoa entity)
        {
            return await _appService.CreateAsync(entity);
        }
    }
}
