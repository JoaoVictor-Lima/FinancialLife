using FinancialLifeDomain.Core.AggregateRoot;
using FinancialLifeDomain.Entities.Nucleo.Localizacao;
using FinancialLifeDomain.Interfaces.EntitiesInterface.Nucleo.Pessoas;

namespace FinancialLifeDomain.Entities.Nucleo.Pessoas
{
    public class EnderecoPessoa : IAggregate
    {
        public int Id { get; set; }
        public int Numero { get; private set; }
        public string Logradouro { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public virtual Cidade Cidade { get; private set; }
        public int IdCidade { get; private set; }
        public virtual Estado Estado { get; private set; }
        public int IdEstado { get; private set; }
        public virtual Pais Pais { get; private set; }
        public int IdPais { get; private set; }
        public int IdPessoa { get; private set; }

        public void AddNumero(int numero)
        {
            Numero = numero;
        }

        public void AddLogradouro(string logradouro)
        {
            Logradouro = logradouro;
        }

        public void AddComplemento(string complemento)
        {
            Complemento = complemento;
        }

        public void AddBairro(string bairro)
        {
            Bairro = bairro;
        }

        public void AddCidade(int cidade)
        {
            IdCidade = cidade;
        }

        public void AddEstado(int estado)
        {
            IdEstado = estado;
        }

        public void AddPais(int pais)
        {
            IdPais = pais;
        }
    }
}
