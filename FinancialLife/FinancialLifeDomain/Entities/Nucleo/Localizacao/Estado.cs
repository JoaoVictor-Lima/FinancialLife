namespace FinancialLifeDomain.Entities.Nucleo.Localizacao
{
    public class Estado
    {
        public int Id { get; set; }
        public string Uf { get; set; }
        public string Nome { get; set; }
        public int IdPais { get; set; }
        public Pais Pais { get; set; }
    }
}