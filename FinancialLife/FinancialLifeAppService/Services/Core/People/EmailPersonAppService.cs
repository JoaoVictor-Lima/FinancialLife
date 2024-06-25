using FinancialLifeApplication.Interfaces.Core.People;
using FinancialLifeDomain.Entities.Core.People;
using FinancialLifeDomain.Interfaces.Repository.Core.People;
using System.Threading.Tasks;

namespace FinancialLifeApplication.Services.Core.People
{
    public class EmailPersonAppService : IEmailPersonAppService
    {
        private readonly IEmailPersonRepository _repository;

        public EmailPersonAppService(IEmailPersonRepository repository)
        {
            _repository = repository;
        }

        public async Task<EmailPerson> CreateAsync(EmailPerson entity)
        {
            return await _repository.Flush(entity);
        }
    }
}
