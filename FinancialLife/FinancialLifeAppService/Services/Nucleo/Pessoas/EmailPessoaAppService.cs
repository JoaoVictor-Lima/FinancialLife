using FinancialLifeApplication.Interfaces.Nucleo.Pessoas;
using FinancialLifeDomain.Entities.Nucleo.Pessoas;
using FinancialLifeDomain.Interfaces.Repository.Nucleo.Pessoas;
using System.Threading.Tasks;

namespace FinancialLifeApplication.Services.Nucleo.Pessoas
{
    public class EmailPessoaAppService : IEmailPessoaAppService
    {
        private readonly IEmailPessoaRepository _repository;

        public EmailPessoaAppService(IEmailPessoaRepository repository)
        {
            _repository = repository;
        }

        public async Task<EmailPessoa> CreateAsync(EmailPessoa entity)
        {
            return await _repository.Flush(entity);
        }
    }
}
