using FinancialLifeDomain.Entities.Nucleo.Pessoas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancialLifeInfrastructureData.Map.Nucleo.Pessoas
{
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            //Primary Key
            builder.HasKey(x => x.Id);

            //relationship
            builder.HasMany(x => x.EmailsPessoa)
                .WithOne()
                .HasForeignKey(x => x.IdPessoa)
                .IsRequired();

            builder.HasMany(x => x.TelefonesPessoa)
                .WithOne()
                .HasForeignKey(x => x.IdPessoa)
                .IsRequired();

            builder.HasMany(x => x.EnderecosPessoa)
                .WithOne()
                .HasForeignKey(x => x.IdPessoa)
                .IsRequired();
        }
    }
}
