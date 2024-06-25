using FinacialLifeDtos.Core.Location;

namespace FinacialLifeDtos.Core.People
{
    public class PersonAddressDto
    {
        public int Number { get; set; }
        public string Address { get; set; }
        public string AddressComplement { get; set; }
        public string District { get; set; }
        public virtual CityDto City { get; set; }
        public int IdCity { get; set; }
        public virtual StateDto State { get; set; }
        public int IdState { get; set; }
        public virtual CountryDto Country { get; set; }
        public int IdCountry { get; set; }
    }
}
