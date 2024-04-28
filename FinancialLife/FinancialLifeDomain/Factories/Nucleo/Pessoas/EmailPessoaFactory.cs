using FinacialLifeDtos.Nucleo.Pessoas;
using FinancialLifeDomain.Core.AbstractFactory;
using FinancialLifeDomain.Entities.Nucleo.Pessoas;

namespace FinancialLifeDomain.Factories.Nucleo.Pessoas
{
    public class EmailPessoaFactory : AbstractFactory<EmailPessoa, EmailPessoaDto>
    {
        public override EmailPessoa Create(EmailPessoaDto dto)
        {
            var entity = new EmailPessoa();

            entity.AddEmail(dto.Email);

            return entity;
        }
    }
}
