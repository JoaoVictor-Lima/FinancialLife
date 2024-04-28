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
        public DbSet<TelefonePessoa> TelefonesPessoas { get; set; }
        public DbSet<EmailPessoa> EmailsPessoas { get; set; }
        public DbSet<EnderecoPessoa> EnderecosPessoas { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Pais> Paises { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //Configuração para evitar por padrão deleções em casacata
            modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()).ToList().ForEach(x => x.DeleteBehavior = DeleteBehavior.Restrict);
        }
    }
}