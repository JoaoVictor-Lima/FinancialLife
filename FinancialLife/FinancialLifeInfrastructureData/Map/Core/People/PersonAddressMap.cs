using FinancialLifeDomain.Entities.Core.People;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancialLifeInfrastructureData.Map.Core.People
{
    public class PersonAddressMap : IEntityTypeConfiguration<PersonAddress>
    {
        public void Configure(EntityTypeBuilder<PersonAddress> builder)
        {
            //ToTable
            builder.ToTable("PersonAddress");

            //Primary Key
            builder.HasKey(x => x.Id);

            //Property
            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnType("int")
                .HasColumnName("Id");

            builder.Property(x => x.Number)
                .HasColumnType("int")
                .HasColumnName("Number");

            builder.Property(x => x.Address)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(300)
                .HasColumnName("Address");

            builder.Property(x => x.AddressComplement)
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .HasColumnName("AddressComplement");

            builder.Property(x => x.District)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(300)
                .HasColumnName("District");

            builder.Property(x => x.IdCity)
                .IsRequired()
                .HasColumnType("int")
                .HasColumnName("IdCity");

            builder.Property(x => x.IdState)
                .IsRequired()
                .HasColumnType("int")
                .HasColumnName("IdState");

            builder.Property(x => x.IdCountry)
                .IsRequired()
                .HasColumnType("int")
                .HasColumnName("IdCountry");

            builder.Property(x => x.IdPerson)
                .IsRequired()
                .HasColumnType("int")
                .HasColumnName("IdPerson");

            //Relationship
            builder.HasOne(x => x.City)
                .WithMany()
                .HasForeignKey(x => x.IdCity);

            builder.HasOne(x => x.State)
                .WithMany()
                .HasForeignKey(x => x.IdState);


            builder.HasOne(x => x.Country)
                .WithMany()
                .HasForeignKey(x => x.IdCountry);
        }
    }
}
