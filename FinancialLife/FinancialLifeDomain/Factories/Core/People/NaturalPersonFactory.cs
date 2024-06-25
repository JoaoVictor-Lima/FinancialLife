using FinacialLifeDtos.Core.People;
using FinancialLifeDomain.Core.AbstractFactory;
using FinancialLifeDomain.Entities.Core.People;

namespace FinancialLifeDomain.Factories.Core.People
{
    public class NaturalPersonFactory : AbstractFactory<NaturalPerson, NaturalPersonDto>
    {
        private readonly IFactory<PhonePerson, PhonePersonDto> _phoneFactory;
        private readonly IFactory<EmailPerson, EmailPersonDto> _emailPersonFactory;
        private readonly IFactory<PersonAddress, PersonAddressDto> _personAddressFactory;

        public NaturalPersonFactory(
            IFactory<PhonePerson, PhonePersonDto> phoneFactory,
            IFactory<EmailPerson, EmailPersonDto> emailPersonFactory,
            IFactory<PersonAddress, PersonAddressDto> personAddressFactory
            )
        {
            _phoneFactory = phoneFactory;
            _emailPersonFactory = emailPersonFactory;
            _personAddressFactory = personAddressFactory;
        }

        public override NaturalPerson Create(NaturalPersonDto dto)
        {
            var entity = new NaturalPerson();
            entity.AddName(dto.Name);
            entity.AddDocumentNumber(dto.DocumentNumber);
            entity.AddBirthDate(dto.BirthDate);
            entity.AddPersonGender(dto.IdPersonGender);

            entity.AddEmailPerson(_emailPersonFactory.Create(dto.EmailPerson));
            entity.AddPhonePerson(_phoneFactory.Create(dto.PhonePerson));
            entity.AddPersonAdress(_personAddressFactory.Create(dto.PersonAddress));

            return entity;
        }
    }
}
