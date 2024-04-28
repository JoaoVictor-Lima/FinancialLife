using FinacialLifeDtos.Nucleo.Pessoas;
using FinancialLifeApplication.Interfaces.Nucleo.Pessoas;
using FinancialLifeDomain.Core.AbstractFactory;
using FinancialLifeDomain.Entities.Nucleo.Pessoas;
using FinancialLifeDomain.Interfaces.Repository.Nucleo.Pessoas;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinancialLifeApplication.Services.Nucleo.Pessoas
{
    public class PessoaFisicaAppService : IPessoaFisicaAppService
    {
        private readonly IPessoaFisicaRepository _repository;
        private readonly IFactory<PessoaFisica, PessoaFisicaDto> _factory;

        public PessoaFisicaAppService(
            IPessoaFisicaRepository repository,
            IFactory<PessoaFisica, PessoaFisicaDto> factory
            )
        {
            _repository = repository;
            _factory = factory;
        }
        public async Task<PessoaFisica> Create(PessoaFisicaDto dto)
        {
            var entity = _factory.Create(dto);
            return await _repository.Flush(entity);
        }

        public async Task<IEnumerable<PessoaFisica>> GetAllAsync()
        {
            return await _repository.GetAll();
        }
    }
}
