using ContractEntity.Enums.Core.People.NatualPerson;
using FinancialLifeDomain.Core.AggregateRoot;

namespace FinancialLifeDomain.Entities.Core.People
{
    public class NaturalPerson : Person, IAggregateRoot
    {
        public int Id { get; set; }
        public string Name { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string DocumentNumber { get; private set; }
        public PersonGenderEnum PersonGender { get; private set; }

        public void AddName(string name)
        {
            Name = name;
        }

        public void AddBirthDate(DateTime birthDate)
        {
            BirthDate = birthDate;
        }

        public void AddDocumentNumber(string documentNumber)
        {
            DocumentNumber = documentNumber;
        }

        public void AddPersonGender(PersonGenderEnum personGender)
        {
            PersonGender = personGender;
        }
    }
}
