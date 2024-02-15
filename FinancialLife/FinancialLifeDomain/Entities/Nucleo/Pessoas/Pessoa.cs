namespace FinancialLifeDomain.Entities.Nucleo.Pessoas
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string NomeRazaoSocial { get; set; }
        public DateTime DataNascimentoAberturaCnpj { get; set; }
        public PessoaFisica PessoaFisica { get; set; }
        public PessoaJuridica PessoaJuridica { get; set; }
    }
}
