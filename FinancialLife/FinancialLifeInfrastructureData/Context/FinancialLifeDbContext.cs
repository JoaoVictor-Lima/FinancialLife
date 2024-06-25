using FinancialLifeDomain.Entities.Core.Location;
using FinancialLifeDomain.Entities.Core.People;
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

        public DbSet<NaturalPerson> PessoasFisicas { get; set; }
        public DbSet<LegalEntity> PessoasJuridicas { get; set; }
        public DbSet<PhonePerson> TelefonesPessoas { get; set; }
        public DbSet<EmailPerson> EmailsPessoas { get; set; }
        public DbSet<PersonAddress> EnderecosPessoas { get; set; }
        public DbSet<City> Cidades { get; set; }
        public DbSet<State> Estados { get; set; }
        public DbSet<Country> Paises { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //Configuração para evitar por padrão deleções em casacata
            modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()).ToList().ForEach(x => x.DeleteBehavior = DeleteBehavior.Restrict);
        }
    }
}