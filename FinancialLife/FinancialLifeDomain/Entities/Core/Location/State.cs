namespace FinancialLifeDomain.Entities.Core.Location
{
    public class State
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string StateAbbreviation { get; private set; }
        public virtual Country Country { get; private set; }
        public int IdCountry { get; private set; }
        public virtual List<City> Cities { get; private set; }
    }
}
