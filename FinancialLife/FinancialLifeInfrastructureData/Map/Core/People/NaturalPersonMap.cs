using FinancialLifeDomain.Entities.Core.People;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancialLifeInfrastructureData.Map.Core.People
{
    public class NaturalPersonMap : IEntityTypeConfiguration<NaturalPerson>
    {
        public void Configure(EntityTypeBuilder<NaturalPerson> builder)
        {
            //Table
            builder.ToTable("NaturalPerson");

            //Primary Key
            builder.HasBaseType<Person>();

            //Property and table
            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int");

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("varchar")
                .HasMaxLength(300);

            builder.Property(x => x.BirthDate)
                .IsRequired()
                .HasColumnName("BirthDate")
                .HasColumnType("date");

            builder.Property(x => x.DocumentNumber)
                .IsRequired()
                .HasColumnName("DocumentNumber")
                .HasColumnType("varchar")
                .HasMaxLength(11);

            builder.Property(x => x.PersonGender)
                .IsRequired()
                .HasColumnName("PersonGender")
                .HasColumnType("int");

        }
    }
}
