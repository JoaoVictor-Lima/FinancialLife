using FinancialLifeAppService.Nucleo.Pessoas.Interfaces;
using FinancialLifeDomain.Entities.Nucleo.Pessoas;
using FinancialLifeDomain.Entities.Nucleo.Pessoas.Interfaces;

namespace FinancialLifeAppService.Nucleo.Pessoas
{
    public class PessoaAppService : IPessoaAppService
    {
        private readonly IPessoaRepository _pessoasRepository;

        public PessoaAppService(
            IPessoaRepository pessoasRepository)
        {
            _pessoasRepository = pessoasRepository;
        }
        public async Task<IEnumerable<Pessoa>> GetAllPessoas()
        {
            var entities = await _pessoasRepository.GetAll();
            return entities;
        }
    }
}
