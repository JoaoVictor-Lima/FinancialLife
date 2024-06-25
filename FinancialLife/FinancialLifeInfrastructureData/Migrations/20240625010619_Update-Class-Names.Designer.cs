﻿// <auto-generated />
using System;
using FinancialLifeInfrastructureData.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinancialLifeInfrastructureData.Migrations
{
    [DbContext(typeof(FinancialLifeDbContext))]
    [Migration("20240625010619_Update-Class-Names")]
    partial class UpdateClassNames
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FinancialLifeDomain.Entities.Core.Location.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdState")
                        .HasColumnType("int")
                        .HasColumnName("IdState");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.HasIndex("IdState");

                    b.ToTable("City", (string)null);
                });

            modelBuilder.Entity("FinancialLifeDomain.Entities.Core.Location.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Country", (string)null);
                });

            modelBuilder.Entity("FinancialLifeDomain.Entities.Core.Location.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdCountry")
                        .HasColumnType("int")
                        .HasColumnName("IdCountry");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar")
                        .HasColumnName("Name");

                    b.Property<string>("StateAbbreviation")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("varchar")
                        .HasColumnName("StateAbbreviation");

                    b.HasKey("Id");

                    b.HasIndex("IdCountry");

                    b.ToTable("State", (string)null);
                });

            modelBuilder.Entity("FinancialLifeDomain.Entities.Core.People.EmailPerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar")
                        .HasColumnName("Email");

                    b.Property<int>("IdPerson")
                        .HasColumnType("int")
                        .HasColumnName("IdPerson");

                    b.HasKey("Id");

                    b.HasIndex("IdPerson");

                    b.ToTable("EmailPerson", (string)null);
                });

            modelBuilder.Entity("FinancialLifeDomain.Entities.Core.People.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Person");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("FinancialLifeDomain.Entities.Core.People.PersonAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar")
                        .HasColumnName("Address");

                    b.Property<string>("AddressComplement")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar")
                        .HasColumnName("AddressComplement");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar")
                        .HasColumnName("District");

                    b.Property<int>("IdCity")
                        .HasColumnType("int")
                        .HasColumnName("IdCity");

                    b.Property<int>("IdCountry")
                        .HasColumnType("int")
                        .HasColumnName("IdCountry");

                    b.Property<int>("IdPerson")
                        .HasColumnType("int")
                        .HasColumnName("IdPerson");

                    b.Property<int>("IdState")
                        .HasColumnType("int")
                        .HasColumnName("IdState");

                    b.Property<int>("Number")
                        .HasColumnType("int")
                        .HasColumnName("Number");

                    b.HasKey("Id");

                    b.HasIndex("IdCity");

                    b.HasIndex("IdCountry");

                    b.HasIndex("IdPerson");

                    b.HasIndex("IdState");

                    b.ToTable("PersonAddress", (string)null);
                });

            modelBuilder.Entity("FinancialLifeDomain.Entities.Core.People.PhonePerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AreaCode")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("varchar")
                        .HasColumnName("AreaCode");

                    b.Property<int>("IdPerson")
                        .HasColumnType("int")
                        .HasColumnName("IdPerson");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("varchar")
                        .HasColumnName("Number");

                    b.HasKey("Id");

                    b.HasIndex("IdPerson");

                    b.ToTable("PhonePerson", (string)null);
                });

            modelBuilder.Entity("FinancialLifeDomain.Entities.Core.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EmailLogin")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar")
                        .HasColumnName("EmailLogin");

                    b.Property<int>("IdNaturalPerson")
                        .HasColumnType("int")
                        .HasColumnName("IdNaturalPerson");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar")
                        .HasColumnName("Password");

                    b.HasKey("Id");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("FinancialLifeDomain.Entities.Core.People.LegalEntity", b =>
                {
                    b.HasBaseType("FinancialLifeDomain.Entities.Core.People.Person");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar")
                        .HasColumnName("CompanyName");

                    b.ToTable("LegalEntity", (string)null);
                });

            modelBuilder.Entity("FinancialLifeDomain.Entities.Core.People.NaturalPerson", b =>
                {
                    b.HasBaseType("FinancialLifeDomain.Entities.Core.People.Person");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("date")
                        .HasColumnName("BirthDate");

                    b.Property<string>("DocumentNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("varchar")
                        .HasColumnName("DocumentNumber");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar")
                        .HasColumnName("Name");

                    b.Property<int>("PersonGender")
                        .HasColumnType("int")
                        .HasColumnName("PersonGender");

                    b.ToTable("NaturalPerson", (string)null);
                });

            modelBuilder.Entity("FinancialLifeDomain.Entities.Core.Location.City", b =>
                {
                    b.HasOne("FinancialLifeDomain.Entities.Core.Location.State", "State")
                        .WithMany("Cities")
                        .HasForeignKey("IdState")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("FinancialLifeDomain.Entities.Core.Location.State", b =>
                {
                    b.HasOne("FinancialLifeDomain.Entities.Core.Location.Country", "Country")
                        .WithMany("States")
                        .HasForeignKey("IdCountry")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("FinancialLifeDomain.Entities.Core.People.EmailPerson", b =>
                {
                    b.HasOne("FinancialLifeDomain.Entities.Core.People.Person", null)
                        .WithMany("EmailsPerson")
                        .HasForeignKey("IdPerson")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("FinancialLifeDomain.Entities.Core.People.PersonAddress", b =>
                {
                    b.HasOne("FinancialLifeDomain.Entities.Core.Location.City", "City")
                        .WithMany()
                        .HasForeignKey("IdCity")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FinancialLifeDomain.Entities.Core.Location.Country", "Country")
                        .WithMany()
                        .HasForeignKey("IdCountry")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FinancialLifeDomain.Entities.Core.People.Person", null)
                        .WithMany("PersonAdresses")
                        .HasForeignKey("IdPerson")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FinancialLifeDomain.Entities.Core.Location.State", "State")
                        .WithMany()
                        .HasForeignKey("IdState")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Country");

                    b.Navigation("State");
                });

            modelBuilder.Entity("FinancialLifeDomain.Entities.Core.People.PhonePerson", b =>
                {
                    b.HasOne("FinancialLifeDomain.Entities.Core.People.Person", null)
                        .WithMany("PhonesPerson")
                        .HasForeignKey("IdPerson")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("FinancialLifeDomain.Entities.Core.People.LegalEntity", b =>
                {
                    b.HasOne("FinancialLifeDomain.Entities.Core.People.Person", null)
                        .WithOne()
                        .HasForeignKey("FinancialLifeDomain.Entities.Core.People.LegalEntity", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FinancialLifeDomain.Entities.Core.People.NaturalPerson", b =>
                {
                    b.HasOne("FinancialLifeDomain.Entities.Core.People.Person", null)
                        .WithOne()
                        .HasForeignKey("FinancialLifeDomain.Entities.Core.People.NaturalPerson", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FinancialLifeDomain.Entities.Core.Location.Country", b =>
                {
                    b.Navigation("States");
                });

            modelBuilder.Entity("FinancialLifeDomain.Entities.Core.Location.State", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("FinancialLifeDomain.Entities.Core.People.Person", b =>
                {
                    b.Navigation("EmailsPerson");

                    b.Navigation("PersonAdresses");

                    b.Navigation("PhonesPerson");
                });
#pragma warning restore 612, 618
        }
    }
}
