using FinancialLifeDomain.Entities.Nucleo.Pessoas;
using FinancialLifeDomain.Interfaces.Repository;
using FinancialLifeDomain.Interfaces.Repository.Nucleo.Pessoas;
using FinancialLifeInfrastructureData.Context;

namespace FinancialLifeInfrastructureData.Repository.Nucleo.Usuarios
{
    public class EmailPessoaRepository : RepositoryBase<EmailPessoa>, IEmailPessoaRepository
    {
        public EmailPessoaRepository(FinancialLifeDbContext context) : base(context)
        {
        }
    }
}
