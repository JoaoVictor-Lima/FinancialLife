using FinancialLifeApplication.Interfaces.Nucleo.Pessoas;
using FinancialLifeDomain.Entities.Nucleo.Pessoas;
using FinancialLifeDomain.Interfaces.Repository.Nucleo.Pessoas;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinancialLifeApplication.Services.Nucleo.Pessoas
{
    public class PessoaFisicaAppService : IPessoaFisicaAppService
    {
        private readonly IPessoaFisicaRepository _repository;

        public PessoaFisicaAppService(IPessoaFisicaRepository repository)
        {
            _repository = repository;
        }
        public async Task<PessoaFisica> Create(PessoaFisica entity)
        {
            return await _repository.Create(entity);
        }

        public async Task<IEnumerable<PessoaFisica>> GetAllAsync()
        {
            return await _repository.GetAll();
        }
    }
}
