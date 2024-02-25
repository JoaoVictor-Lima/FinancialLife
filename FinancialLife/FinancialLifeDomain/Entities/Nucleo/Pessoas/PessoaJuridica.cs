using FinancialLifeDomain.Interfaces.EntitiesInterface.Nucleo.Pessoas;

namespace FinancialLifeDomain.Entities.Nucleo.Pessoas
{
    public class PessoaJuridica : Pessoa
    {
        public int Id { get; set; }
        public string RazaoSocial { get; private set; }
    }
}
