﻿using FinancialLifeDomain.Entities.Nucleo.Pessoas;
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

            //Primary Key
            builder.HasKey(x => x.Id);

            //Property and table
            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int");

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnName("Nome")
                .HasColumnType("varchar")
                .HasMaxLength(300);

            builder.Property(x => x.DataNascimento)
                .IsRequired()
                .HasColumnName("DataNascimento")
                .HasColumnType("date");

            builder.Property(x => x.Cpf)
                .IsRequired()
                .HasColumnName("Cpf")
                .HasColumnType("varchar")
                .HasMaxLength(11);

            //Relationship
            builder.HasOne(x => x.GeneroPessoa)
                .WithOne()
                .HasForeignKey<PessoaFisica>(x => x.IdGeneroPessoa);

        }
    }
}
