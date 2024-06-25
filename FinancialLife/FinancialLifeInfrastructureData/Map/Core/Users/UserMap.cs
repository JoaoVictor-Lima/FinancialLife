using FinancialLifeDomain.Entities.Core.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancialLifeInfrastructureData.Map.Core.Users
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //Table
            builder.ToTable("User");

            //Primary Key
            builder.HasKey(x => x.Id);

            //Property
            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnType("int")
                .HasColumnName("Id");

            builder.Property(x => x.EmailLogin)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(500)
                .HasColumnName("EmailLogin");

            builder.Property(x => x.Password)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .HasColumnName("Password");

            builder.Property(x => x.IdNaturalPerson)
                .IsRequired()
                .HasColumnType("int")
                .HasColumnName("IdNaturalPerson");

            //Relationship
        }
    }
}
