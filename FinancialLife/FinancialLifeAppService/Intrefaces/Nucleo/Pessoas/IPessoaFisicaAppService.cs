using FinancialLifeDomain.Entities.Nucleo.Pessoas;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinancialLifeApplication.Intrefaces.Nucleo.Pessoas
{
    public interface IPessoaFisicaAppService
    {
        Task<IEnumerable<PessoaFisica>> GetAllAsync();
    }
}
