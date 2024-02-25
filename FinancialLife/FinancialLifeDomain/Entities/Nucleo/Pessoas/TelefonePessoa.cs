namespace FinancialLifeDomain.Entities.Nucleo.Pessoas
{
    public class TelefonePessoa
    {
        public int Id { get; private set; }
        public string Ddd { get; private set; }
        public string Numero { get; private set; }
        public virtual Pessoa Pessoa { get; private set; }
        public int IdPessoa { get; private set; }
    }
}
