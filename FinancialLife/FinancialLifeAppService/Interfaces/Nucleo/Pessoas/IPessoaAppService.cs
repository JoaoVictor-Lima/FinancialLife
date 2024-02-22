using FinancialLifeDomain.Entities.Nucleo.Pessoas;

namespace FinancialLifeApplication.Interfaces.Nucleo.Pessoas
{
    public interface IPessoaAppService
    {
        Task<IEnumerable<Pessoa>> GetAllPessoas();
    }
}
