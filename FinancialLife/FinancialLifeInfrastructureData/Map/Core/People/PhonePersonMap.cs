using FinancialLifeDomain.Entities.Core.People;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancialLifeInfrastructureData.Map.Core.People
{
    public class PhonePersonMap : IEntityTypeConfiguration<PhonePerson>
    {
        public void Configure(EntityTypeBuilder<PhonePerson> builder)
        {
            //Table
            builder.ToTable("PhonePerson");

            //Primary Key
            builder.HasKey(x => x.Id);

            //Property
            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnType("int")
                .HasColumnName("Id");

            builder.Property(x => x.AreaCode)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(2)
                .HasColumnName("AreaCode");

            builder.Property(x => x.Number)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(9)
                .HasColumnName("Number");

            builder.Property(x => x.IdPerson)
                .IsRequired()
                .HasColumnType("int")
                .HasColumnName("IdPerson");
        }
    }
}
