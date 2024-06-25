namespace FinancialLifeDomain.Entities.Core.Location
{
    public class Country
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public virtual List<State> States { get; private set; }
    }
}
