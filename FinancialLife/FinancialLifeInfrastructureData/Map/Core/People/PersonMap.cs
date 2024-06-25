using FinancialLifeDomain.Entities.Core.People;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancialLifeInfrastructureData.Map.Core.People
{
    public class PersonMap : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            //Primary Key
            builder.HasKey(x => x.Id);

            //relationship
            builder.HasMany(x => x.EmailsPerson)
                .WithOne()
                .HasForeignKey(x => x.IdPerson)
                .IsRequired();

            builder.HasMany(x => x.PhonesPerson)
                .WithOne()
                .HasForeignKey(x => x.IdPerson)
                .IsRequired();

            builder.HasMany(x => x.PersonAdresses)
                .WithOne()
                .HasForeignKey(x => x.IdPerson)
                .IsRequired();
        }
    }
}
