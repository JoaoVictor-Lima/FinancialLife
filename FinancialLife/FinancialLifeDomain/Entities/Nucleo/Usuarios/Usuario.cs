using FinancialLifeDomain.Core.AggregateRoot;

namespace FinancialLifeDomain.Entities.Nucleo.Usuarios
{
    public class Usuario : IAggregate
    {
        public int Id { get; private set; }
        public string EmailLogin { get; private set; }
        public string Senha { get; private set; }
        public int IdPessoaFisica { get; private set; }

        public void AddEmailLogin(string email)
        {
            EmailLogin = email;
        }

        public void AddSenha(string senha)
        {
            Senha = senha;
        }

        public void AddPessoaFisica(int idPessoa)
        {
            IdPessoaFisica = idPessoa;
        }
    }
}
