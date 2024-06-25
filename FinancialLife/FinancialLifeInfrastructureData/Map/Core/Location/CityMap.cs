using FinancialLifeDomain.Entities.Core.Location;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancialLifeInfrastructureData.Map.Core.Location
{
    public class CityMap : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            //Table
            builder.ToTable("City");

            //Primary Key
            builder.HasKey(x => x.Id);

            //Property
            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnType("int")
                .HasColumnName("Id");

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(300)
                .HasColumnName("Name");

            builder.Property(x => x.IdState)
                .IsRequired()
                .HasColumnType("int")
                .HasColumnName("IdState");

            //relationship

            builder.HasOne(x => x.State)
                .WithMany(x => x.Cities)
                .HasForeignKey(x => x.IdState)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
