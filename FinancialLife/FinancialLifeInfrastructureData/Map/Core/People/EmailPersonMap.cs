using FinancialLifeDomain.Entities.Core.People;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancialLifeInfrastructureData.Map.Core.People
{
    public class EmailPersonMap : IEntityTypeConfiguration<EmailPerson>
    {
        public void Configure(EntityTypeBuilder<EmailPerson> builder)
        {
            //Table
            builder.ToTable("EmailPerson");

            //Primary Key
            builder.HasKey(e => e.Id);

            //Property
            builder.Property(e => e.Id)
                .IsRequired()
                .HasColumnType("int")
                .HasColumnName("Id");

            builder.Property(e => e.Email)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(500)
                .HasColumnName("Email");

            builder.Property(x => x.IdPerson)
                .IsRequired()
                .HasColumnType("int")
                .HasColumnName("IdPerson");
        }
    }
}
