using FinacialLifeDtos.Core.People;
using FinancialLifeDomain.Core.AbstractFactory;
using FinancialLifeDomain.Entities.Core.People;

namespace FinancialLifeDomain.Factories.Core.People
{
    public class PersonAddressFactory : AbstractFactory<PersonAddress, PersonAddressDto>
    {
        public override PersonAddress Create(PersonAddressDto dto)
        {
            var entity = new PersonAddress();

            entity.AddNumber(dto.Number);
            entity.AddAddress(dto.Address);
            entity.AddDistrict(dto.District);
            entity.AddAddressComplement(dto.AddressComplement);
            entity.AddCity(dto.IdCity);
            entity.AddState(dto.IdState);
            entity.AddCountry(dto.IdCountry);


            return entity;
        }
    }
}
