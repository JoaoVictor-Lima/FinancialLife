using FinancialLifeDomain.Entities.Nucleo.Pessoas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancialLifeInfrastructureData.Map.Nucleo.Pessoas
{
    public class TelefonePessoaMap : IEntityTypeConfiguration<TelefonePessoa>
    {
        public void Configure(EntityTypeBuilder<TelefonePessoa> builder)
        {
            //Table
            builder.ToTable("TelefonePessoa");

            //Primary Key
            builder.HasKey(x => x.Id);

            //Property
            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnType("int")
                .HasColumnName("Id");

            builder.Property(x => x.Ddd)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(2)
                .HasColumnName("Ddd");

            builder.Property(x => x.Numero)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(9)
                .HasColumnName("Numero");

            builder.Property(x => x.IdPessoa)
                .IsRequired()
                .HasColumnType("int")
                .HasColumnName("IdPessoa");
        }
    }
}
