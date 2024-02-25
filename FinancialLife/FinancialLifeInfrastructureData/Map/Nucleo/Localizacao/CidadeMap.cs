using FinancialLifeDomain.Entities.Nucleo.Localizacao;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancialLifeInfrastructureData.Map.Nucleo.Localizacao
{
    public class CidadeMap : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            //Table
            builder.ToTable("Cidade");

            //Primary Key
            builder.HasKey(x => x.Id);

            //Property
            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnType("int")
                .HasColumnName("Id");

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(300)
                .HasColumnName("Nome");

            builder.Property(x => x.IdEstado)
                .IsRequired()
                .HasColumnType("int")
                .HasColumnName("IdEstado");

            //relationship

            builder.HasOne(x => x.Estado)
                .WithMany(x => x.Cidades)
                .HasForeignKey(x => x.IdEstado)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
