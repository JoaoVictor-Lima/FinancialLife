using FinacialLifeDtos.Nucleo.Pessoas;
using FinancialLifeDomain.Core.AbstractFactory;
using FinancialLifeDomain.Entities.Nucleo.Pessoas;

namespace FinancialLifeDomain.Factories.Nucleo.Pessoas
{
    public class EnderecoPessoaFactory : AbstractFactory<EnderecoPessoa, EnderecoPessoaDto>
    {
        public override EnderecoPessoa Create(EnderecoPessoaDto dto)
        {
            var entity = new EnderecoPessoa();

            entity.AddNumero(dto.Numero);
            entity.AddLogradouro(dto.Logradouro);
            entity.AddBairro(dto.Bairro);
            entity.AddComplemento(dto.Complemento);
            entity.AddCidade(dto.IdCidade);
            entity.AddEstado(dto.IdEstado);
            entity.AddPais(dto.IdPais);


            return entity;
        }
    }
}
