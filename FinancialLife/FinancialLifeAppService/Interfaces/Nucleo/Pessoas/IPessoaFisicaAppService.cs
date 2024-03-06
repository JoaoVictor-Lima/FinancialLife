using FinancialLifeDomain.Entities.Nucleo.Pessoas;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinancialLifeApplication.Interfaces.Nucleo.Pessoas
{
    public interface IPessoaFisicaAppService
    {
        Task<PessoaFisica> Create(PessoaFisica entity);
        Task<IEnumerable<PessoaFisica>> GetAllAsync();
    }
}
