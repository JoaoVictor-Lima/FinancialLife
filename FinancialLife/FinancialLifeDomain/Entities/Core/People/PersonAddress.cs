using FinancialLifeDomain.Core.AggregateRoot;
using FinancialLifeDomain.Entities.Core.Location;

namespace FinancialLifeDomain.Entities.Core.People
{
    public class PersonAddress : IAggregate
    {
        public int Id { get; set; }
        public int Number { get; private set; }
        public string Address { get; private set; }
        public string AddressComplement { get; private set; }
        public string District { get; private set; }
        public virtual City City { get; private set; }
        public int IdCity { get; private set; }
        public virtual State State { get; private set; }
        public int IdState { get; private set; }
        public virtual Country Country { get; private set; }
        public int IdCountry { get; private set; }
        public int IdPerson { get; private set; }

        public void AddNumber(int number)
        {
            Number = number;
        }

        public void AddAddress(string address)
        {
            Address = address;
        }

        public void AddAddressComplement(string addressComplement)
        {
            AddressComplement = addressComplement;
        }

        public void AddDistrict(string district)
        {
            District = district;
        }

        public void AddCity(int city)
        {
            IdCity = city;
        }

        public void AddState(int state)
        {
            IdState = state;
        }

        public void AddCountry(int country)
        {
            IdCountry = country;
        }
    }
}
