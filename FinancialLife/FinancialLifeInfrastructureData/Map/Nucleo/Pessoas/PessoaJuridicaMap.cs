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

            //Primary Key
            builder.HasKey(x => x.Id);

            //Property
            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int");

            builder.Property(x => x.RazaoSocial)
                .IsRequired()
                .HasColumnName("RazaoSocial")
                .HasColumnType("varchar")
                .HasMaxLength(300);

            builder.Property(x => x.Cnpj)
                .IsRequired()
                .HasColumnName("Cnpj")
                .HasColumnType("varchar")
                .HasMaxLength(14);

            builder.Property(x => x.DataAberturaCnpj)
                .IsRequired()
                .HasColumnName("DataAberturaCnpj")
                .HasColumnType("date");
           
        }
    }
}
