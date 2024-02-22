using FinancialLifeDomain.Entities.Nucleo.Pessoas;

namespace FinancialLifeAppService.Nucleo.Pessoas.Interfaces
{
    public interface IPessoaAppService
    {
        Task<IEnumerable<Pessoa>> GetAllPessoas();
    }
}
