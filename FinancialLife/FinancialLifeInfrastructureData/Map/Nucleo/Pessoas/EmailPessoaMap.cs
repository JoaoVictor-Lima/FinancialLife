using FinancialLifeDomain.Entities.Nucleo.Pessoas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancialLifeInfrastructureData.Map.Nucleo.Pessoas
{
    public class EmailPessoaMap : IEntityTypeConfiguration<EmailPessoa>
    {
        public void Configure(EntityTypeBuilder<EmailPessoa> builder)
        {
            //Table
            builder.ToTable("EmailPessoa");

            //Primary Key
            builder.HasKey(e => e.Id);

            //Property
            builder.Property(e => e.Id)
                .IsRequired()
                .HasColumnType("int")
                .HasColumnName("Id");

            builder.Property(e => e.Email)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(500)
                .HasColumnName("Email");

            builder.Property(x => x.IdPessoa)
                .IsRequired()
                .HasColumnType("int")
                .HasColumnName("IdPessoa");
        }
    }
}
