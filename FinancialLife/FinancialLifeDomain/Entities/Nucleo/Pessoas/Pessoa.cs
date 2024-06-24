using FinancialLifeDomain.Core.AggregateRoot;
using FinancialLifeDomain.Interfaces.EntitiesInterface.Nucleo.Pessoas;

namespace FinancialLifeDomain.Entities.Nucleo.Pessoas
{
    public class Pessoa : IPessoa, IAggregateRoot
    {
        public int Id { get; set; }
        public List<TelefonePessoa> TelefonesPessoa { get; private set; }
        public List<EmailPessoa> EmailsPessoa { get; private set; }
        public List<EnderecoPessoa> EnderecosPessoa { get; private set; }

        public Pessoa()
        {
            TelefonesPessoa = new List<TelefonePessoa>();
            EmailsPessoa = new List<EmailPessoa>();
            EnderecosPessoa = new List<EnderecoPessoa>();
        }

        public void AddEmailPessoa(EmailPessoa emailPessoa)
        {
            EmailsPessoa.Add(emailPessoa);
        }

        public void AddTelefonePessoa(TelefonePessoa telefonePessoa)
        {
            TelefonesPessoa.Add(telefonePessoa);
        }

        public void AddEnderecoPessoa(EnderecoPessoa enderecoPessoa)
        {
            EnderecosPessoa.Add(enderecoPessoa);
        }
    }
}
