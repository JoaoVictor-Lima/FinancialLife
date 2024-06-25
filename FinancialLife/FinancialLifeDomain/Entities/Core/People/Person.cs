using FinancialLifeDomain.Core.AggregateRoot;
using FinancialLifeDomain.Interfaces.EntitiesInterface.Core.People;

namespace FinancialLifeDomain.Entities.Core.People
{
    public class Person : IPerson, IAggregateRoot
    {
        public int Id { get; set; }
        public List<PhonePerson> PhonesPerson { get; private set; }
        public List<EmailPerson> EmailsPerson { get; private set; }
        public List<PersonAddress> PersonAdresses { get; private set; }

        public Person()
        {
            PhonesPerson = new List<PhonePerson>();
            EmailsPerson = new List<EmailPerson>();
            PersonAdresses = new List<PersonAddress>();
        }

        public void AddEmailPerson(EmailPerson emailPerson)
        {
            EmailsPerson.Add(emailPerson);
        }

        public void AddPhonePerson(PhonePerson phonePerson)
        {
            PhonesPerson.Add(phonePerson);
        }

        public void AddPersonAdress(PersonAddress personAdress)
        {
            PersonAdresses.Add(personAdress);
        }
    }
}
