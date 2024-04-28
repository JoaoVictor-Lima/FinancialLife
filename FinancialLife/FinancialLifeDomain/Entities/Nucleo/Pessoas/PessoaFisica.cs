using ContractEntity.Enums.Nucleo.Pessoas.PessoaFisica;
using FinancialLifeDomain.Core.AggregateRoot;
using FinancialLifeDomain.Interfaces.EntitiesInterface.Nucleo.Pessoas;

namespace FinancialLifeDomain.Entities.Nucleo.Pessoas
{
    public class PessoaFisica : Pessoa, IAggregateRoot
    {
        public int Id { get; set; }
        public string Nome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string Cpf { get; private set; }
        public GeneroPessoaEnum IdGeneroPessoa { get; private set; }

        public void AddNome(string nome)
        {
            Nome = nome;
        }

        public void AddDataNascimento(DateTime dataNascimento)
        {
            DataNascimento = dataNascimento;
        }

        public void AddCpf(string cpf)
        {
            Cpf = cpf;
        }

        public void AddGeneroPessoa(GeneroPessoaEnum idGeneroPessoa)
        {
            IdGeneroPessoa = idGeneroPessoa;
        }
    }
}
