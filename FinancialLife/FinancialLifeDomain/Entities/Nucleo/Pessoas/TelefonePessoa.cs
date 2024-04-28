using FinancialLifeDomain.Core.AggregateRoot;

namespace FinancialLifeDomain.Entities.Nucleo.Pessoas
{
    public class TelefonePessoa : IAggregate
    {
        public int Id { get; set; }
        public string Ddd { get; private set; }
        public string Numero { get; private set; }
        public int IdPessoa { get; private set; }

        public void AddDdd (string ddd)
        {
            Ddd = ddd;
        }

        public void AddNumero (string numero)
        {
            Numero = numero;
        }
    }
}
