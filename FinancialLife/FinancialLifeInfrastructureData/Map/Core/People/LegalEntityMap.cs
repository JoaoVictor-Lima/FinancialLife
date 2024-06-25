using FinancialLifeDomain.Entities.Core.People;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancialLifeInfrastructureData.Map.Core.People
{
    public class LegalEntityMap : IEntityTypeConfiguration<LegalEntity>
    {
        public void Configure(EntityTypeBuilder<LegalEntity> builder)
        {
            //Taable
            builder.ToTable("LegalEntity");

            //Primary Key
            builder.HasBaseType<Person>();

            //Property
            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int");

            builder.Property(x => x.CompanyName)
                .IsRequired()
                .HasColumnName("CompanyName")
                .HasColumnType("varchar")
                .HasMaxLength(300);
           
        }
    }
}
