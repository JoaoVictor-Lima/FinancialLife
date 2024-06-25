using FinacialLifeDtos.Core.People;
using FinancialLifeDomain.Core.AbstractFactory;
using FinancialLifeDomain.Entities.Core.People;

namespace FinancialLifeDomain.Factories.Core.People
{
    public class PhonePersonFactory : AbstractFactory<PhonePerson, PhonePersonDto>
    {
        public override PhonePerson Create(PhonePersonDto dto)
        {
            var entity = new PhonePerson();

            entity.AddAreaCode(dto.AreaCode);
            entity.AddNumber(dto.Number);

            return entity;
        }
    }
}
