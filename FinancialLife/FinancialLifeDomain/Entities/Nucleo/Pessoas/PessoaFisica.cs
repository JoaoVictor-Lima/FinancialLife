using FinancialLifeDomain.Interfaces.EntitiesInterface.Nucleo.Pessoas;

namespace FinancialLifeDomain.Entities.Nucleo.Pessoas
{
    public class PessoaFisica : Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string Cpf { get; private set; }
        public int IdGeneroPessoa { get; private set; }
        public GeneroPessoa GeneroPessoa { get; private set; }
    }
}
