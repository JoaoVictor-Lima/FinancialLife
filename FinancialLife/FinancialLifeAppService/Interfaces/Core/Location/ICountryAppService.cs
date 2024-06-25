using FinancialLifeDomain.Entities.Core.Location;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinancialLifeApplication.Interfaces.Core.Location
{
    public interface ICountryAppService
    {
        Task<IEnumerable<Country>> GetAllAsync();
    }
}
