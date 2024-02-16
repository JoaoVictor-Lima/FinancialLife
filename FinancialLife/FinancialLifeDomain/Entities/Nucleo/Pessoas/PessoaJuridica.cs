namespace FinancialLifeDomain.Entities.Nucleo.Pessoas
{
    public class PessoaJuridica
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public DateTime DataAberturaCnpj { get; set; }
        public string Cnpj { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}
