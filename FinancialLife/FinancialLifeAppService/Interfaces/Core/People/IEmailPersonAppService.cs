using FinancialLifeDomain.Entities.Core.People;
using System.Threading.Tasks;

namespace FinancialLifeApplication.Interfaces.Core.People
{
    public interface IEmailPersonAppService
    {
        Task<EmailPerson> CreateAsync(EmailPerson entity);
    }
}
