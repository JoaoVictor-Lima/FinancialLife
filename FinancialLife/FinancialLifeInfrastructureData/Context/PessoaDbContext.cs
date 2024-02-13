using FinancialLifeDomain.Entities.Nucleo.Pessoas;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace FinancialLifeInfrastructureData.Context
{
    public class PessoaDbContext : DbContext
    {
        public PessoaDbContext(DbContextOptions<PessoaDbContext> options)
            : base(options)
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
