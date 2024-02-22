namespace FinancialLifeDomain.Entities.Nucleo.Localizacao
{
    public class Cidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdEstado { get; set; }
        public Estado Estado { get; set; }
    }
}
