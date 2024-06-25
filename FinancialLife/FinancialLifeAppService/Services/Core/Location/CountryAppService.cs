using FinancialLifeApplication.Interfaces.Core.Location;
using FinancialLifeDomain.Entities.Core.Location;
using FinancialLifeDomain.Interfaces.Repository.Core.Location;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinancialLifeApplication.Services.Core.Location
{
    public class CountryAppService : ICountryAppService
    {
        private readonly ICountryRepository _paisRepository;

        public CountryAppService(ICountryRepository paisRepository)
        {
            _paisRepository = paisRepository;
        }

        public async Task<IEnumerable<Country>> GetAllAsync()
        {
            return await _paisRepository.GetAll();
        }
    }
}
