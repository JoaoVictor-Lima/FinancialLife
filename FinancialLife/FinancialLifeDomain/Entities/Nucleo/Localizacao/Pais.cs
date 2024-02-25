namespace FinancialLifeDomain.Entities.Nucleo.Localizacao
{
    public class Pais
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public virtual List<Estado> Estados { get; private set; }
    }
}
