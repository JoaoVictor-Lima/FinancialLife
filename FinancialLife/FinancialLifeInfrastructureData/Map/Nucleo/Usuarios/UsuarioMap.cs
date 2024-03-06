using FinancialLifeDomain.Entities.Nucleo.Usuarios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancialLifeInfrastructureData.Map.Nucleo.Usuarios
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            //Table
            builder.ToTable("Usuario");

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

            builder.Property(x => x.Senha)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .HasColumnName("Senha");

            builder.Property(x => x.IdPessoaFisica)
                .IsRequired()
                .HasColumnType("int")
                .HasColumnName("IdPessoaFisica");

            //Relationship
        }
    }
}
