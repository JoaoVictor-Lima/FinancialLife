using ContractEntity.Enums.Core.People.NatualPerson;
using FinacialLifeDtos.Core.Users;

namespace FinacialLifeDtos.Core.People
{
    public class NaturalPersonDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string DocumentNumber { get; set; }
        public PersonGenderEnum IdPersonGender { get; set; }
        public PhonePersonDto PhonePerson { get; set; }
        public EmailPersonDto EmailPerson { get; set; }
        public PersonAddressDto PersonAddress { get; set; }
        public UserDto User { get; set; }
    }
}
