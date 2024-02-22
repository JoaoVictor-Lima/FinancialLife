using FinancialLifeApplication.Intrefaces.Nucleo.Localizacao;
using FinancialLifeDomain.Entities.Nucleo.Localizacao;
using FinancialLifeDomain.Interfaces.Repository.Nucleo.Localizacao;

namespace FinancialLifeApplication.Services.Nucleo.Localizacao
{
    public class PaisAppService : IPaisAppService
    {
        private readonly IPaisRepository _paisRepository;

        public PaisAppService(IPaisRepository paisRepository)
        {
            _paisRepository = paisRepository;
        }

        public async Task<IEnumerable<Pais>> GetAllPaises()
        {
            return await _paisRepository.GetAll();
        }
    }
}
