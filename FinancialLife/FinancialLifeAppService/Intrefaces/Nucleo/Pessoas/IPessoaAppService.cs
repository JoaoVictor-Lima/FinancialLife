using FinancialLifeDomain.Entities.Nucleo.Pessoas;

namespace FinancialLifeApplication.Intrefaces.Nucleo.Pessoas
{
    public interface IPessoaAppService
    {
        Task<IEnumerable<Pessoa>> GetAllPessoas();
    }
}
