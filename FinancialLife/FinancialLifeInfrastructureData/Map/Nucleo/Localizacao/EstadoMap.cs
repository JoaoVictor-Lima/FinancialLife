using FinancialLifeDomain.Entities.Nucleo.Localizacao;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancialLifeInfrastructureData.Map.Nucleo.Localizacao
{
    public class EstadoMap : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            //Table 
            builder.ToTable("Estado");

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

            builder.Property(x => x.Uf)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(2)
                .HasColumnName("Uf");

            builder.Property(x => x.IdPais)
                .IsRequired()
                .HasColumnType("int")
                .HasColumnName("IdPais");

            builder.HasOne(x => x.Pais)
                .WithMany(x => x.Estados)
                .HasForeignKey(x => x.IdPais)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
