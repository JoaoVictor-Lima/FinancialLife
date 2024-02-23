using FinancialLifeDomain.Entities.Nucleo.Pessoas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancialLifeInfrastructureData.Map.Nucleo.Pessoas
{
    public class GeneroPessoaMap : IEntityTypeConfiguration<GeneroPessoa>
    {
        public void Configure(EntityTypeBuilder<GeneroPessoa> builder)
        {
            //Table
            builder.ToTable("GeneroPessoa");

            //Primary Key
            builder.HasKey(x => x.Id);

            //Propety
            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int");

            builder.Property(x => x.Descricao)
                .IsRequired()
                .HasColumnName("Descricao")
                .HasColumnType("varchar")
                .HasMaxLength(100);
        }
    }
}
