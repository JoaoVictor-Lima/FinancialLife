namespace FinancialLifeDomain.Entities.Core.Location
{
    public class City
    {
        public int Id { get;private set; }
        public string Name { get; private set; }
        public virtual State State { get; set; }
        public int IdState { get; set; }

    }
}
