namespace FinancialLifeDomain.Entities.Nucleo.Pessoas
{
    public class PessoaFisica : Pessoa
    {
        public string Nome { get; private set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; private set; }
        public int IdGeneroPessoa { get; set; }
        public GeneroPessoa GeneroPessoa { get; set; }
    }
}
