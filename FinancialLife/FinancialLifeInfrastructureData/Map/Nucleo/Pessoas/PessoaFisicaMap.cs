using FinancialLifeDomain.Entities.Nucleo.Pessoas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancialLifeInfrastructureData.Map.Nucleo.Pessoas
{
    public class PessoaFisicaMap : IEntityTypeConfiguration<PessoaFisica>
    {
        public void Configure(EntityTypeBuilder<PessoaFisica> builder)
        {
            //Table
            builder.ToTable("PessoaFisica");

            //Property
            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnName("Id");

            builder.Property(x => x.Cpf)
                .IsRequired()
                .HasColumnName("Cpf");

            //Relationship
            builder.HasOne(x => x.Pessoa)
                .WithOne(y => y.PessoaFisica)
                .HasForeignKey<PessoaFisica>(x => x.Id);

        }
    }
}
