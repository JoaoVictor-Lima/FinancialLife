using FinancialLifeDomain.Entities.Nucleo.Pessoas;

namespace FinancialLifeApplication.Intrefaces.Nucleo.Pessoas
{
    public interface IPessoaFisicaAppService
    {
        Task<IEnumerable<PessoaFisica>> GetAllPessoasFisicas();
    }
}
