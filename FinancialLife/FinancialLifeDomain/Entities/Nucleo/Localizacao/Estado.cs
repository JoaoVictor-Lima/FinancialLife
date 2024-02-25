namespace FinancialLifeDomain.Entities.Nucleo.Localizacao
{
    public class Estado
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Uf { get; private set; }
        public virtual Pais Pais { get; private set; }
        public int IdPais { get; private set; }
        public virtual List<Cidade> Cidades { get; private set; }
    }
}
