using FinancialLifeDomain.Entities.Nucleo.Pessoas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancialLifeInfrastructureData.Map.Nucleo.Pessoas
{
    public class EnderecoPessoaMap : IEntityTypeConfiguration<EnderecoPessoa>
    {
        public void Configure(EntityTypeBuilder<EnderecoPessoa> builder)
        {
            //ToTable
            builder.ToTable("EnderecoPessoa");

            //Primary Key
            builder.HasKey(x => x.Id);

            //Property
            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnType("int")
                .HasColumnName("Id");

            builder.Property(x => x.Numero)
                .HasColumnType("int")
                .HasColumnName("Numero");

            builder.Property(x => x.Logradouro)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(300)
                .HasColumnName("Logradouro");

            builder.Property(x => x.Complemento)
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .HasColumnName("Complemento");

            builder.Property(x => x.Bairro)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(300)
                .HasColumnName("Bairro");

            builder.Property(x => x.IdCidade)
                .IsRequired()
                .HasColumnType("int")
                .HasColumnName("IdCidade");

            builder.Property(x => x.IdEstado)
                .IsRequired()
                .HasColumnType("int")
                .HasColumnName("IdEstado");

            builder.Property(x => x.IdPais)
                .IsRequired()
                .HasColumnType("int")
                .HasColumnName("IdPais");

            builder.Property(x => x.IdPessoa)
                .IsRequired()
                .HasColumnType("int")
                .HasColumnName("IdPessoa");

            //Relationship
            builder.HasOne(x => x.Cidade)
                .WithMany()
                .HasForeignKey(x => x.IdCidade);

            builder.HasOne(x => x.Estado)
                .WithMany()
                .HasForeignKey(x => x.IdEstado);


            builder.HasOne(x => x.Pais)
                .WithMany()
                .HasForeignKey(x => x.IdPais);
        }
    }
}
