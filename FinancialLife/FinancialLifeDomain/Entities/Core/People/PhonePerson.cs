using FinancialLifeDomain.Core.AggregateRoot;

namespace FinancialLifeDomain.Entities.Core.People
{
    public class PhonePerson : IAggregate
    {
        public int Id { get; set; }
        public string AreaCode { get; private set; }
        public string Number { get; private set; }
        public int IdPerson { get; private set; }

        public void AddAreaCode (string areaCode)
        {
            AreaCode = areaCode;
        }

        public void AddNumber (string number)
        {
            Number = number;
        }
    }
}
