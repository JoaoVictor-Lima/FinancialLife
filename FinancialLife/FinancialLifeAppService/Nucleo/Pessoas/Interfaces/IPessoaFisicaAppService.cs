using FinancialLifeDomain.Entities.Nucleo.Pessoas;

namespace FinancialLifeAppService.Nucleo.Pessoas.Interfaces
{
    public interface IPessoaFisicaAppService
    {
        Task<IEnumerable<PessoaFisica>> GetAllPessoasFisicas();
    }
}
