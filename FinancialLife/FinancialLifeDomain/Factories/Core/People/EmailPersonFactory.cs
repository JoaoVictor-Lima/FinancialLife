using FinacialLifeDtos.Core.People;
using FinancialLifeDomain.Core.AbstractFactory;
using FinancialLifeDomain.Entities.Core.People;

namespace FinancialLifeDomain.Factories.Core.People
{
    public class EmailPersonFactory : AbstractFactory<EmailPerson, EmailPersonDto>
    {
        public override EmailPerson Create(EmailPersonDto dto)
        {
            var entity = new EmailPerson();

            entity.AddEmail(dto.Email);

            return entity;
        }
    }
}
