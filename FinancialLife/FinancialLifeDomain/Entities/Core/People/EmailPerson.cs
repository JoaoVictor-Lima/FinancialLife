using FinancialLifeDomain.Core.AggregateRoot;

namespace FinancialLifeDomain.Entities.Core.People
{
    public class EmailPerson : IAggregate
    {
        public int Id { get; set; }
        public string Email { get; private set; }
        public int IdPerson { get; private set; }

        public void AddEmail(string email)
        {
            Email = email;
        }
    }
}
