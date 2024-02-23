using FinancialLifeDomain.Entities.Nucleo.Localizacao;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancialLifeInfrastructureData.Map.Nucleo.Localizacao
{
    public class PaisMap : IEntityTypeConfiguration<Pais>
    {
        public void Configure(EntityTypeBuilder<Pais> builder)
        {
            //Table
            builder.ToTable("Pais");

            //Primary Key 
            builder.HasKey(x => x.Id);

            //Property
            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int");

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnName("Nome")
                .HasColumnType("varchar")
                .HasMaxLength(300);
        }
    }
}
