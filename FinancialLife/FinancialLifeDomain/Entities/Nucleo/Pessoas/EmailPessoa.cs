using FinancialLifeDomain.Interfaces.EntitiesInterface.Nucleo.Pessoas;

namespace FinancialLifeDomain.Entities.Nucleo.Pessoas
{
    public class EmailPessoa
    {
        public int Id { get; private set; }
        public string Email { get; private set; }
        public virtual Pessoa Pessoa { get; private set; }
        public int IdPessoa { get; private set; }
    }
}
