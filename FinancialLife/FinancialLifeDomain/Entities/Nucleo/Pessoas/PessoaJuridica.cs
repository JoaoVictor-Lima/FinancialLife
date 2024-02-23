namespace FinancialLifeDomain.Entities.Nucleo.Pessoas
{
    public class PessoaJuridica : Pessoa
    {
        public string Cnpj { get; private set; }
        public string RazaoSocial { get; private set; }
        public DateTime DataAberturaCnpj { get; private set; }
    }
}
