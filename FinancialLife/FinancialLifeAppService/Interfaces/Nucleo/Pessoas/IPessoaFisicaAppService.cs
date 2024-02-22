using FinancialLifeDomain.Entities.Nucleo.Pessoas;

namespace FinancialLifeApplication.Interfaces.Nucleo.Pessoas
{
    public interface IPessoaFisicaAppService
    {
        Task<IEnumerable<PessoaFisica>> GetAllPessoasFisicas();
    }
}
