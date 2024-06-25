using FinacialLifeDtos.Core.People;
using FinancialLifeDomain.Entities.Core.People;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinancialLifeApplication.Interfaces.Core.People
{
    public interface INaturalPersonAppService
    {
        Task<NaturalPerson> Create(NaturalPersonDto entity);
        Task<IEnumerable<NaturalPerson>> GetAllAsync();
    }
}
