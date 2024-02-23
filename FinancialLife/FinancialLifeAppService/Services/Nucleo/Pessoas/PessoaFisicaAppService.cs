using FinancialLifeApplication.Intrefaces.Nucleo.Pessoas;
using FinancialLifeDomain.Entities.Nucleo.Pessoas;
using FinancialLifeDomain.Interfaces.Repository.Nucleo.Pessoas;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinancialLifeApplication.Services.Nucleo.Pessoas
{
    public class PessoaFisicaAppService : IPessoaFisicaAppService
    {
        private readonly IPessoaFisicaRepository _pessoaFisicaRepository;

        public PessoaFisicaAppService(IPessoaFisicaRepository pessoaFisicaRepository)
        {
            _pessoaFisicaRepository = pessoaFisicaRepository;
        }
        public async Task<IEnumerable<PessoaFisica>> GetAllAsync()
        {
            return await _pessoaFisicaRepository.GetAll();
        }
    }
}
