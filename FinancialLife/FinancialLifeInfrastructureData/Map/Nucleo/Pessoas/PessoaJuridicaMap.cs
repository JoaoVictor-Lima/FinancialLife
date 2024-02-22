using FinancialLifeDomain.Entities.Nucleo.Pessoas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancialLifeInfrastructureData.Map.Nucleo.Pessoas
{
    public class PessoaJuridicaMap : IEntityTypeConfiguration<PessoaJuridica>
    {
        public void Configure(EntityTypeBuilder<PessoaJuridica> builder)
        {
            //Taable
            builder.ToTable("PessoaJuridica");

            //Property
            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnName("Id");

            builder.Property(x => x.Cnpj)
                .IsRequired()
                .HasColumnName("Cnpj");

            //Relationship
            builder.HasOne(x => x.Pessoa)
                .WithOne(x => x.PessoaJuridica)
                .HasForeignKey<PessoaJuridica>(x => x.Id);
        }
    }
}
