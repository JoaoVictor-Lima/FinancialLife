using FinancialLifeDomain.Entities.Nucleo.Pessoas;
using System.Threading.Tasks;

namespace FinancialLifeApplication.Interfaces.Nucleo.Pessoas
{
    public interface IEmailPessoaAppService
    {
        Task<EmailPessoa> CreateAsync(EmailPessoa entity);
    }
}
