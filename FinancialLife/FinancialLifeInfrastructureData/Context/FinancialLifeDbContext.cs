using FinancialLifeDomain.Entities.Nucleo.Localizacao;
using FinancialLifeDomain.Entities.Nucleo.Pessoas;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace FinancialLifeInfrastructureData.Context
{
    public class FinancialLifeDbContext : DbContext
    {
        public FinancialLifeDbContext(DbContextOptions<FinancialLifeDbContext> options)
            : base(options)
        {
        }
        public DbSet<PessoaFisica> PessoasFisicas { get; set; }
        public DbSet<PessoaJuridica> PessoasJuridicas { get; set; }
        public DbSet<GeneroPessoa> GenersoPessoas { get; set; }
        public DbSet<Pais> Paises { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}