using FinancialLifeDomain.Core.AggregateRoot;
using FinancialLifeDomain.Interfaces.EntitiesInterface.Nucleo.Pessoas;

namespace FinancialLifeDomain.Entities.Nucleo.Pessoas
{
    public class EmailPessoa : IAggregate
    {
        public int Id { get; set; }
        public string Email { get; private set; }
        public int IdPessoa { get; private set; }

        public void AddEmail(string email)
        {
            Email = email;
        }
    }
}
