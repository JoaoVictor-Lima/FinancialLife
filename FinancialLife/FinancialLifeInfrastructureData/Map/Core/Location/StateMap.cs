using FinancialLifeDomain.Entities.Core.Location;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancialLifeInfrastructureData.Map.Core.Location
{
    public class StateMap : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
            //Table 
            builder.ToTable("State");

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

            builder.Property(x => x.StateAbbreviation)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(2)
                .HasColumnName("StateAbbreviation");

            builder.Property(x => x.IdCountry)
                .IsRequired()
                .HasColumnType("int")
                .HasColumnName("IdCountry");

            builder.HasOne(x => x.Country)
                .WithMany(x => x.States)
                .HasForeignKey(x => x.IdCountry)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
