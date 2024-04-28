using FinacialLifeDtos.Nucleo.Pessoas;
using FinancialLifeDomain.Entities.Nucleo.Pessoas;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinancialLifeApplication.Interfaces.Nucleo.Pessoas
{
    public interface IPessoaFisicaAppService
    {
        Task<PessoaFisica> Create(PessoaFisicaDto entity);
        Task<IEnumerable<PessoaFisica>> GetAllAsync();
    }
}
