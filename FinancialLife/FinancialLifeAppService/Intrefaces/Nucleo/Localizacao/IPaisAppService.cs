using FinancialLifeDomain.Entities.Nucleo.Localizacao;

namespace FinancialLifeApplication.Intrefaces.Nucleo.Localizacao
{
    public interface IPaisAppService
    {
        Task<IEnumerable<Pais>> GetAllPaises();
    }
}
