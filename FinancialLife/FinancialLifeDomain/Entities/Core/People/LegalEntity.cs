namespace FinancialLifeDomain.Entities.Core.People
{
    public class LegalEntity : Person
    {
        public int Id { get; set; }
        public string CompanyName { get; private set; }
    }
}
