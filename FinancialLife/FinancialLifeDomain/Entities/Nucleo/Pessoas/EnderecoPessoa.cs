using FinancialLifeDomain.Entities.Nucleo.Localizacao;
using FinancialLifeDomain.Interfaces.EntitiesInterface.Nucleo.Pessoas;

namespace FinancialLifeDomain.Entities.Nucleo.Pessoas
{
    public class EnderecoPessoa
    {
        public int Id { get; private set; }
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
        public virtual Pessoa Pessoa { get; private set; }
        public int IdPessoa { get; private set; }
    }
}
