using FinancialLifeDomain.Core.AggregateRoot;

namespace FinancialLifeDomain.Entities.Core.Users
{
    public class User : IAggregate
    {
        public int Id { get; private set; }
        public string EmailLogin { get; private set; }
        public string Password { get; private set; }
        public int IdNaturalPerson { get; private set; }

        public void AddEmailLogin(string email)
        {
            EmailLogin = email;
        }

        public void AddPassword(string password)
        {
            Password = password;
        }

        public void AddIdNaturalPerson(int idNaturalPerson)
        {
            IdNaturalPerson = idNaturalPerson;
        }
    }
}
