using FinancialLifeDomain.Entities.Nucleo.Localizacao;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinancialLifeApplication.Intrefaces.Nucleo.Localizacao
{
    public interface IPaisAppService
    {
        Task<IEnumerable<Pais>> GetAllAsync();
    }
}
