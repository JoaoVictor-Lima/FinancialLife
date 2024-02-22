using FinancialLifeApplication.Interfaces.Nucleo.Pessoas;
using FinancialLifeDomain.Entities.Nucleo.Pessoas;
using FinancialLifeDomain.Interfaces.Repository.Pessoas;

namespace FinancialLifeApplication.AppService.Nucleo.Pessoas
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
