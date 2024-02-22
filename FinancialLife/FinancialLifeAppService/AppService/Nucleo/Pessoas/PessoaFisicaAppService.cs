using FinancialLifeApplication.Interfaces.Nucleo.Pessoas;
using FinancialLifeDomain.Entities.Nucleo.Pessoas;
using FinancialLifeDomain.Interfaces.Repository.Nucleo.Pessoas;

namespace FinancialLifeApplication.AppService.Nucleo.Pessoas
{
    public class PessoaFisicaAppService : IPessoaFisicaAppService
    {
        private readonly IPessoaFisicaRepository _pessoaFisicaRepository;

        public PessoaFisicaAppService(IPessoaFisicaRepository pessoaFisicaRepository)
        {
            _pessoaFisicaRepository = pessoaFisicaRepository;
        }
        public async Task<IEnumerable<PessoaFisica>> GetAllPessoasFisicas()
        {
            return await _pessoaFisicaRepository.GetAll();
        }
    }
}
