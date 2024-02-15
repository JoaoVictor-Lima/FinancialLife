namespace FinancialLifeDomain.Entities.Nucleo.Pessoas
{
    public class PessoaFisica : Pessoa
    {
        public int Id { get; set; }
        public new string Nome => NomeRazaoSocial;
        public new DateTime DataNascimento => DataNascimentoAberturaCnpj;
        public string Cpf { get; set; }
        public Pessoa Pessoa { get; set; }

    }
}
