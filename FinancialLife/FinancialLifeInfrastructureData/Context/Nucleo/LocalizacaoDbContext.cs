using FinancialLifeDomain.Entities.Nucleo.Localizacao;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace FinancialLifeInfrastructureData.Context.Nucleo
{
    public class LocalizacaoDbContext : DbContext
    {
        public LocalizacaoDbContext(DbContextOptions<LocalizacaoDbContext> options)
            :base(options) { }

        public DbSet<Pais> Paises { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
