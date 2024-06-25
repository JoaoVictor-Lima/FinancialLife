using FinancialLifeDomain.Entities.Core.People;
using FinancialLifeDomain.Interfaces.Repository.Core.People;
using FinancialLifeInfrastructureData.Context;

namespace FinancialLifeInfrastructureData.Repository.Core.People
{
    public class EmailPersonRepository : RepositoryBase<EmailPerson>, IEmailPersonRepository
    {
        public EmailPersonRepository(FinancialLifeDbContext context) : base(context)
        {
        }
    }
}
