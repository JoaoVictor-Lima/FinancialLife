namespace FinancialLifeDomain.Entities.Nucleo.Localizacao
{
    public class Cidade
    {
        public int Id { get;private set; }
        public string Nome { get; private set; }
        public virtual Estado Estado { get; set; }
        public int IdEstado { get; set; }

    }
}
