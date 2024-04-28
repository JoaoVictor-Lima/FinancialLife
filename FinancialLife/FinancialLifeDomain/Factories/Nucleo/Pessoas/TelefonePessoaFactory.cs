using FinacialLifeDtos.Nucleo.Pessoas;
using FinancialLifeDomain.Core.AbstractFactory;
using FinancialLifeDomain.Entities.Nucleo.Pessoas;

namespace FinancialLifeDomain.Factories.Nucleo.Pessoas
{
    public class TelefonePessoaFactory : AbstractFactory<TelefonePessoa, TelefonePessoaDto>
    {
        public override TelefonePessoa Create(TelefonePessoaDto dto)
        {
            var entity = new TelefonePessoa();

            entity.AddDdd(dto.Ddd);
            entity.AddNumero(dto.Numero);

            return entity;
        }
    }
}
