using FinancialLifeDomain.Entities.Nucleo.Pessoas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancialLifeInfrastructureData.Map.Nucleo.Pessoas
{
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            //Table
            builder.ToTable("Pessoa");

            //Primary Key
            builder.HasKey(x => x.Id);

            //Property
            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnName("Id");

            builder.Property(x => x.NomeRazaoSocial)
                .IsRequired()
                .HasColumnName("NomeRazaoSocial");

            builder.Property(x => x.DataNascimentoAberturaCnpj)
                .IsRequired()
                .HasColumnName("DataNascimentoAberturaCnpj");
        }
    }
}
