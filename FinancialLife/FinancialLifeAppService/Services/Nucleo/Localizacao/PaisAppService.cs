using FinancialLifeApplication.Interfaces.Nucleo.Localizacao;
using FinancialLifeDomain.Entities.Nucleo.Localizacao;
using FinancialLifeDomain.Interfaces.Repository.Nucleo.Localizacao;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinancialLifeApplication.Services.Nucleo.Localizacao
{
    public class PaisAppService : IPaisAppService
    {
        private readonly IPaisRepository _paisRepository;

        public PaisAppService(IPaisRepository paisRepository)
        {
            _paisRepository = paisRepository;
        }

        public async Task<IEnumerable<Pais>> GetAllAsync()
        {
            return await _paisRepository.GetAll();
        }
    }
}
