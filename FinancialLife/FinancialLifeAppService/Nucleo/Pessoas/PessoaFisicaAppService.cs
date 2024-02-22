using FinancialLifeAppService.Nucleo.Pessoas.Interfaces;
using FinancialLifeDomain.Entities.Nucleo.Pessoas;
using FinancialLifeDomain.Entities.Nucleo.Pessoas.Interfaces;

namespace FinancialLifeAppService.Nucleo.Pessoas
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
