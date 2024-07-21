using FinacialLifeDtos.Core.People;
using FinancialLifeApplication.Interfaces.Core.People;
using FinancialLifeDomain.Core.AbstractFactory;
using FinancialLifeDomain.Entities.Core.People;
using FinancialLifeDomain.Interfaces.Repository.Core.People;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinancialLifeApplication.Services.Core.Person
{
    public class NaturalPersonAppService : INaturalPersonAppService
    {
        private readonly INaturalPersonRepository _repository;
        private readonly IFactory<NaturalPerson, NaturalPersonDto> _factory;

        public NaturalPersonAppService(
            INaturalPersonRepository repository,
            IFactory<NaturalPerson, NaturalPersonDto> factory
            )
        {
            _repository = repository;
            _factory = factory;
        }
        public async Task<NaturalPerson> Create(NaturalPersonDto dto)
        {
            var entity = _factory.Create(dto);
            return await _repository.Flush(entity);
        }

        public async Task<IEnumerable<NaturalPerson>> GetAllAsync()
        {
            return await _repository.GetAll();
        }
    }
}
